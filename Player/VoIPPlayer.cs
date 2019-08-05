using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using pcapdatacopy;
using Microsoft.VisualBasic;
using System.Collections;
using System.Globalization;
using pcapdatacopy.My;

namespace Player
{
    public enum MODE
    {
        QUIET = 0,
        NORMAL = 1

    }
    
    public partial class VoipPlayer : Form 
    {
        private List<string> CurrentFileList;
        private List<string> CurrentFolderList;
        private List<string> audioList;
        private Form1 processor;
        private EventArgs err;
        private Analyse core;
        public System.Windows.Forms.ListView currentListView;
        private WindowsMediaPlayer WMPlayer;
        private string outputPath;

        public VoipPlayer(ref Form1 processor, ref EventArgs err, ref Analyse core, ref List<string> pcapFiles, ref List<string> pcapFolders, ref List<string> audioList)
        {
            this.processor = processor;
            this.core = core;
            this.CurrentFileList = new List<string>();
            this.CurrentFolderList =new List<string>();
            this.audioList = new List<string>();
            this.WMPlayer = new WindowsMediaPlayer();
            InitializeComponent();
            this.voiptable = new DataTable();
            this.voipDataGridView.DataSource = this.voiptable;
            this.initdatagrid();
            this.currentDuration.Text = "";
            voipDatagridInit();
            currentListviewInit();
            this.progressBar.Minimum = 0;
            this.progressBar.Maximum = 0;
            textBox1.Text = "";
            if (pcapFiles.Count > 0)
                foreach ( string file in pcapFiles ) this.currentListView.Items.Add(file);
            if(pcapFolders.Count > 0)
                foreach( string folder in pcapFolders ) this.currentListView.Items.Add(folder);

        }
       
        private void voipDatagridInit()
        {
            voipDataGridView.ContextMenu = new ContextMenu();
            voipDataGridView.ContextMenu.MenuItems.Add("Sửa tên", new EventHandler(Rename_Click));
        }
        private void currentListviewInit()
        {
            currentListView.ContextMenu = new ContextMenu();
            currentListView.ContextMenu.MenuItems.Add("Xóa", new EventHandler(Delete_Click));
        }

        private void Rename_Click(object sender, EventArgs e)
        {
            //RenameForm rnf = new RenameForm();
            //rnf.Show();
            using (var form = new RenameForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string audioFolder = @"Audio\";
                    string newPath = audioFolder+form.newName+".wav";            //values preserved after close
                    int index = voipDataGridView.CurrentCell.RowIndex;
                    string oldPath = audioList[index];
                    int count = 1;
                    bool ok = false;
                    while (1==1)
                    {
                        try
                        {
                            System.IO.File.Move(oldPath, newPath);
                            ok = true;
                        }
                        catch (IOException ex)
                        {
                            newPath=Path.GetFileNameWithoutExtension(newPath) + "("+count+")"+".wav";
                            count++;
                            ok = false;
                        }
                        if (ok == true) break;
                    }
                    audioList[index] = newPath;
                    //voipDataGridView.CurrentCell.Value = newPath;
                    voipDataGridView.Rows[index].Cells[6].Value = newPath;
                    voipDataGridView.NotifyCurrentCellDirty(true);
                }
            }
        }

        public string[] splitString(string s)
        {
            string[] arr = new string[20];
            int i = 0;
            int count = 0;
            while (s[i] == ' ') i++;
            int first = i;
            int prev = i;
            for (int j = first; j < s.Length; j++)
            {
                if (s[j] == ' ' && s[j - 1] == ' ') continue;
                else if (s[j] != ' ' && s[j - 1] == ' ')
                {
                    prev = j;
                }
                else if (s[j] == ' ')
                {
                    arr[count] = s.Substring(prev, j - prev);
                    count++;
                }
            }
            if (s[s.Length - 1] != ' ')
            {
                arr[count] = s.Substring(prev, s.Length - prev);
            }
            return arr;
        }
        public void runHandle(string s)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            string cmd = "/C .\\RtpHandleTool\\" + s;
            Console.WriteLine(cmd);
            startInfo.Arguments = cmd;
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
        }
        public void runCommand(string s)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            string cmd = "/C " + s;
            startInfo.Arguments = cmd;
            Console.WriteLine(cmd);
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
        }
        private Addcount addToLists()
        {
            int nofile = 0;
            int nofolder = 0;
            string folder1 = "";
            string folder2 = "";
            string file = "";
            if (this.processor.file_selected_textbox.Text.Length > 0)
            {
                file = this.processor.file_selected_textbox.Text;
                folder2 = Path.GetDirectoryName(this.processor.file_selected_textbox.Text);
                if (!this.CurrentFileList.Contains(file))
                {
                    this.CurrentFileList.Add(file);
                    nofile++;
                }
                
                if (!this.CurrentFolderList.Contains(folder2))
                {
                    this.CurrentFolderList.Add(folder2);
                    nofolder++;
                }
            }
            if (this.processor.folder_selected_textbox.Text.Length > 0)
            {
                folder1 = this.processor.folder_selected_textbox.Text;
                if (!this.CurrentFolderList.Contains(folder1))
                {
                    this.CurrentFolderList.Add(folder1);
                    nofolder++;
                }
            }
            Addcount result = new Addcount(nofile,nofolder);
            return result;
        }
        private void findPcapFile()
        {
            
            string[] files = Directory.GetFiles(this.processor.folder_selected_textbox.Text, "*.pcap", SearchOption.TopDirectoryOnly);
            this.CurrentFileList.AddRange(files);
        }

        public void OpenFolder_Click(object sender, EventArgs e)
        {
            /*this.core.SetFolder(ref this.processor, ref this.err, ref this.audioList); //giaodien.analyse.open
            if (this.processor.folder_selected_textbox.Text.Length > 0 && !this.CurrentFolderList.Contains(this.processor.folder_selected_textbox.Text))
            {
                //Interaction.MsgBox("Opened " + this.processor.folder_selected_textbox.Text, MsgBoxStyle.OkOnly, "Openfolder_click");
                this.addToListView(this.processor.folder_selected_textbox.Text);
                this.findPcapFile();
                this.addToLists();
            }*/
            MessageBox.Show("Tính năng này vẫn đang trong quá trình phát triển","Thông báo");
            
        }
        public void addToListView(string path)
        {
            if (path.Length >= 3) //min is C:/
            {
                ListViewItem newitem = new ListViewItem();
                newitem.Text = path;
                bool is_duplicate = false;
                foreach (ListViewItem item in currentListView.Items)
                    if (item.Text == path)
                    {
                        is_duplicate = true;
                        break;
                    }
                if (!is_duplicate) this.currentListView.Items.Add(path);
            }
        }

        public void OpenFile_Click(object sender, EventArgs e)
        {
            this.core.OpenFile(ref this.processor, ref this.err, ref this.audioList); //giaodien.analyse.open
            //Interaction.MsgBox("Opened " + this.processor.file_selected_textbox.Text, MsgBoxStyle.OkOnly, "Openfile_click");
            this.addToListView(this.processor.file_selected_textbox.Text);
            this.addToLists();
           
        }

        public void scan_Click(object sender, EventArgs e) { this.scan_Click(sender, e, MODE.NORMAL); }
        public void scan_Click(object sender, EventArgs e, MODE _MODE)
        {
            for (int i = voipDataGridView.Rows.Count - 1; i >= 0; i--)
            {
                voipDataGridView.Rows.RemoveAt(i);
            }
            if (this.audioList.Count>0) this.audioList.Clear();
            List<string> streamdata = new List<string>();
            bool hasFile = this.CurrentFileList.Count > 0;
            bool hasFolder = this.CurrentFolderList.Count > 0;
            string audioFolder =@"Audio";
            if (!Directory.Exists(audioFolder))
            {
                Directory.CreateDirectory(audioFolder);
            }
            string tmpFolder =@"Tmp";
            if (!Directory.Exists(tmpFolder))
            {
                Directory.CreateDirectory(tmpFolder);
            }
            if (hasFile || hasFolder)
            {
                int sum_result = 0;
                //if (hasFolder)
                //{
                //    Interaction.MsgBox("start scanning folder list", MsgBoxStyle.OkOnly, "scan clicked");
                //    foreach (string folder in this.CurrentFolderList)
                //    {
                //        streamdata.AddRange(this.core.ScanFolder(ref processor, ref err, folder, ref this.audioList));
                //    }
                //}
                if (hasFile)
                {

                    //if(_MODE == MODE.NORMAL) Interaction.MsgBox("start scanning files list", MsgBoxStyle.OkOnly, "scan clicked");
                    int currentFile=0;
                    foreach (string file in this.CurrentFileList) {
                        currentFile++;
                        textBox1.Text = "Đang xử lý " + currentFile; 
                        string pcap_name = Path.GetFileName(file);
                        string pcap_edit = tmpFolder+"\\edit_" + pcap_name;
                        runHandle("editcap -d \"" + file + "\" \"" + pcap_edit+"\"");
                        string dir = "rtp.txt";
                        runHandle("tshark -r  \"" + pcap_edit + " \" -o \"rtp.heuristic_rtp: TRUE\" -q -z rtp,streams > " + dir);
                        int count = 0;
                        ArrayList rtpList = new ArrayList();
                        using (var reader = new System.IO.StreamReader(dir))
                        {
                            reader.ReadLine(); // skip first row
                            reader.ReadLine(); // skip second row
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                if (line[0] == '=') break;
                                count++;
                                string[] paras = splitString(line);
                                Rtp rtp = new Rtp();
                                rtp.start_time = float.Parse(paras[0], CultureInfo.InvariantCulture.NumberFormat);
                                rtp.end_time = float.Parse(paras[1], CultureInfo.InvariantCulture.NumberFormat);
                                rtp.src_ip = paras[2];
                                rtp.src_port = int.Parse(paras[3], CultureInfo.InvariantCulture.NumberFormat);
                                rtp.dst_ip = paras[4];
                                rtp.dst_port = int.Parse(paras[5], CultureInfo.InvariantCulture.NumberFormat);
                                rtp.ssrc = paras[6];
                                rtp.payload_type = paras[7];
                                if (rtp.payload_type[rtp.payload_type.Length - 1] == ',')
                                {
                                    rtp.payload_type = rtp.payload_type.Substring(0, rtp.payload_type.Length - 1);
                                }
                                rtpList.Add(rtp);
                            }
                        }
                        int total = rtpList.Count;
                        int curr = 0;
                        foreach (Rtp rtp in rtpList)
                        {
                            curr++;
                            textBox1.Text = "Đang xử lý tệp tin "+ currentFile+ ", "+ + curr + " / " + total + " rtp stream"; 
                            string name = rtp.src_ip+'_'+rtp.dst_ip+'_'+rtp.payload_type+'_'+rtp.src_port+'_'+rtp.dst_port+'_'+rtp.ssrc;
                            string cmd = "tshark -r \"" + pcap_edit + "\" -o \"rtp.heuristic_rtp: TRUE\" -Y \"udp.srcport=="+rtp.src_port+" && udp.dstport=="+rtp.dst_port
                            +" && rtp.ssrc==" + rtp.ssrc + "\"" + " -T fields -e rtp.payload > " + name + ".raw";
                            runHandle(cmd);
                            runHandle("str2bin " + name + ".raw");
                            if (rtp.payload_type == "g729" || rtp.payload_type == "G729")
                            {
                                string decode_cmd = "cp_g729_decoder.exe payload.raw " + name + ".bin";         //Decode
                                Console.WriteLine(decode_cmd);
                                runHandle(decode_cmd);
                                string conv_cmd = "bin2wav.exe \"" + name + ".bin\" \"" + audioFolder+"\\"+name + ".wav\"";      //Convert to wav
                                runHandle(conv_cmd);
                                runCommand("del payload.raw");
                                runCommand("del " + name + ".bin");
                                runCommand("del " + name + ".raw");
                            }
                            else if (rtp.payload_type == "g711A" || rtp.payload_type == "G711A")
                            {
                                string decode_cmd = "g711_decoder.exe payload.raw alaw_pcm " + name + ".bin";   //Decode
                                Console.WriteLine(decode_cmd);
                                runHandle(decode_cmd);
                                string conv_cmd = "bin2wav.exe \"" + name + ".bin\" \"" + audioFolder + "\\" + name + ".wav\"";      //Convert to wav
                                runHandle(conv_cmd);
                                runCommand("del payload.raw");
                                runCommand("del " + name + ".bin");
                                runCommand("del " + name + ".raw");
                            }
                            else if (rtp.payload_type == "g711U" || rtp.payload_type == "G711U")
                            {
                                string decode_cmd = "g711_decoder.exe payload.raw ulaw_pcm " + name + ".bin";   //Decode
                                Console.WriteLine(decode_cmd);
                                runHandle(decode_cmd);
                                string conv_cmd = "bin2wav.exe \"" + name + ".bin\" \"" + audioFolder + "\\" + name + ".wav\"";      //Convert to wav
                                runHandle(conv_cmd);
                                runCommand("del payload.raw");
                                runCommand("del " + name + ".raw");
                                runCommand("del " + name + ".bin");
                            }
                            runCommand("del tmpabcdef.raw");
                            Console.WriteLine(name);
                            streamdata.Add(audioFolder + "\\"+name);
                            audioList.Add(audioFolder+"\\"+name+".wav");
                        }
                        runCommand("del " + pcap_edit);
                        foreach (string s in streamdata)
                        {
                            Console.WriteLine(s);
                        }
                        
                        /*if (_MODE == MODE.QUIET)
                        {
                            //streamdata.AddRange(rtpdata);
                            streamdata.AddRange(this.core.UseFile(ref processor, file, ref err, ref this.audioList, MODE.QUIET));
                        }
                        if (_MODE == MODE.NORMAL)
                        {
                            streamdata.AddRange(this.core.UseFile(ref processor, file, ref err, ref this.audioList, MODE.NORMAL));
                        }
                        foreach (string s in streamdata)
                        {
                            Console.WriteLine(s);
                        }*/
                    }
                    //Interaction.MsgBox("tra ve "+ this.core.UseFile(ref processor, file, ref err, ref this.audioList).Count , MsgBoxStyle.OkOnly, " test return 2 cap");
                    //}
                    sum_result += streamdata.Count;
                    string listFileScanned = "";
                    string listFolderScanned = "";
                    int i = 0;
                    int noFile = this.CurrentFileList.Count;
                    int noFolder = this.CurrentFolderList.Count;
                    for (; i < noFile && i < 5; i++)
                    {
                        listFileScanned += "\n" + CurrentFileList[i];
                    }
                    if (noFile > 5) listFileScanned += "\n...";
                    for (i = 0; i < noFolder && i < 5; i++)
                    {
                        listFolderScanned += "\n" + CurrentFolderList[i];
                    }
                    if (noFolder > 5) listFolderScanned += "\n...";
                    foreach (string data in audioList)
                    {
                        //insert bao datagrid
                        rowObject dataOfAudioFromName = new rowObject(data);
                        this.addtodatagrid(dataOfAudioFromName);
                    }
                    textBox1.Text = "Đã xử lý xong!";
                }

                else if (_MODE == MODE.NORMAL)
                {
                    string message1 = "Nothing to scan";
                    string message2 = "Do you want to open a pcap file ?";
                    chooseFileOrFolderToScan msgbox = new chooseFileOrFolderToScan(message1, message2, this);
                    msgbox.ShowDialog();
                    //this.scan_Click(sender, err, MODE.NORMAL);
                }


            }
        }
        private void prevTrack_Click(object sender, EventArgs e)
        {
            int curRow = this.voipDataGridView.CurrentCell.RowIndex;
            int lastRowIndex = this.voipDataGridView.Rows.Count-1;
            int curCol = this.voipDataGridView.CurrentCell.ColumnIndex;
            int jumpto = 0;
            if (curRow == 0) jumpto = lastRowIndex;
            else jumpto = curRow - 1;
            this.voipDataGridView.CurrentCell = this.voipDataGridView.Rows[jumpto].Cells[curCol];
            this.voipDataGridView_CellContentDoubleClick(new object(), new DataGridViewCellEventArgs(curCol,jumpto), CELLMODE.NAVIGATE, jumpto);
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.WMPlayer.controls.fastReverse();
        }

        private void play_Click(object sender, EventArgs e)
        {
            //this.updatepossision();
            this.WMPlayer.controls.play();
            this.baseclock.Start();
        }

        private void pause_Click(object sender, EventArgs e)
        {
            this.baseclock.Stop();
            this.WMPlayer.controls.pause();
            
        }

        private void stop_Click(object sender, EventArgs e)
        {
            this.WMPlayer.controls.stop();
        }

        private void skip_Click(object sender, EventArgs e)
        {
            this.WMPlayer.controls.fastForward();
        }

        private void nextTrack_Click(object sender, EventArgs e)
        {
            this.WMPlayer.controls.stop();
            int curRow = this.voipDataGridView.CurrentCell.RowIndex;
            bool is_overlength = ((curRow+1) == this.voipDataGridView.Rows.Count);
            int curCol = this.voipDataGridView.CurrentCell.ColumnIndex;
            int jumpto = 0;
            if (is_overlength) jumpto = 0;
            else jumpto = curRow + 1;
            this.voipDataGridView.CurrentCell = this.voipDataGridView.Rows[jumpto].Cells[curCol];
            this.voipDataGridView_CellContentDoubleClick(new object(), new DataGridViewCellEventArgs(curCol, jumpto), CELLMODE.NAVIGATE, jumpto);
        }
        public DataTable voiptable;
        private void initdatagrid()
        {
            this.voiptable = new DataTable();
            this.voiptable.Columns.Add("#");
            this.voiptable.Columns.Add("Duration");
            this.voiptable.Columns.Add("Src");
            this.voiptable.Columns.Add("Dst");
            this.voiptable.Columns.Add("Codec");
            this.voiptable.Columns.Add("SSRC");
            this.voiptable.Columns.Add("Audio Path");
            this.voipDataGridView.DataSource = this.voiptable;

        }

        private void voipDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = this.voipDataGridView.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow>=0)
                {
                    this.voipDataGridView.ContextMenu.Show(voipDataGridView, new Point(e.X, e.Y));
                }
                

            }
        }
        private void EditName_Click(object sender, EventArgs e)
        {
            
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            for (int i = currentListView.Items.Count - 1; i >= 0; i--)
            {
                if (currentListView.Items[i].Selected)
                {
                    currentListView.Items[i].Remove();
                    CurrentFileList.RemoveAt(i);
                }
            }
        }
        public void addtodatagrid(rowObject data)
        {
            bool can_i_add = false;
            if (this.voipDataGridView.Rows.Count == 0)
            {
                can_i_add = true;
            }
            else
            {
                bool is_duplicate = false;
                foreach (DataGridViewRow row in this.voipDataGridView.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(data.durationString) &&
                        row.Cells[2].Value.ToString().Equals(data.from) &&
                        row.Cells[3].Value.ToString().Equals(data.to) &&
                        row.Cells[4].Value.ToString().Equals(data.codec) &&
                        row.Cells[5].Value.ToString().Equals(data.ssrc)
                        )
                    {
                        is_duplicate = true;
                        break;
                    }
                }
                if (!is_duplicate)
                {
                    can_i_add = true;
                }

            }
            if (can_i_add)
            {
                this.voiptable.Rows.Add(this.voiptable.Rows.Count + 1, data.durationString, data.from, data.to, data.codec, data.ssrc, data.audioPath);
                this.voipDataGridView.DataSource = this.voiptable;
            }
        }

        private void updateDuration(string durationStr, double durationDou)
        {
            /*
            IWMPMedia mediainfo = WMPlayer.newMedia(this.WMPlayer.URL);
            this.currentDuration.Text = mediainfo.durationString;
            
            */
            this.currentDuration.Text = durationStr;
            this.progressBar.Maximum = (int)(Math.Round(durationDou, 3)*1000);
        }
        
        private void updatepossision()
        {
            int possision = (int)(Math.Floor((this.WMPlayer.controls.currentPosition * 1000)));
            if(possision >= 0 && possision <= this.progressBar.Maximum) this.progressBar.Value = possision;
            //Interaction.MsgBox(this.WMPlayer.controls.currentPosition + " / " + this.progressBar.Maximum, MsgBoxStyle.OkOnly, "Player");
            this.curr.Text = this.WMPlayer.controls.currentPositionString;
            //this.max.Text = this.progressBar.Maximum.ToString();
        }
        
        public enum CELLMODE
        {
           CURRENT = 0,
           NAVIGATE = 1
        }
        private void voipDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.voipDataGridView_CellContentDoubleClick(sender, e, CELLMODE.CURRENT, 0);
        }

        private void voipDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e, CELLMODE _MODE, int rowindex )
        {
            int thisRow = 0;
            if (_MODE == CELLMODE.CURRENT) thisRow = this.voipDataGridView.CurrentCell.RowIndex;
            else thisRow = rowindex;
            string file = this.audioList[thisRow];//voipDataGridView.Rows[thisRow].Cells[5].Value.ToString();
            //Interaction.MsgBox("Opening audio " + file, MsgBoxStyle.OkOnly, "double_click cell");
            //this.updateAudioNameTextboxandDuration(file);
            this.WMPlayer.controls.stop();
            this.WMPlayer.URL = file;
            this.fileNameTextbox.Text = file;
            IWMPMedia mediainfo = new WindowsMediaPlayer().newMedia(file);
            this.updateDuration(this.voipDataGridView.CurrentCell.OwningRow.Cells[1].Value.ToString(), mediainfo.duration);
            this.baseclock.Start();
            this.WMPlayer.controls.play();
        }
        
        private void baseclock_Tick(object sender, EventArgs e)
        {
            //if(this.WMPlayer.playState == WMPPlayState.wmppsPlaying)
                this.updatepossision();
            
        }

        private void progressBar_MouseDown(object sender, MouseEventArgs e)
        {
            this.WMPlayer.controls.pause();
            float percent = (float)e.X / (float)this.progressBar.Width;
            this.progressBar.Value = (int)(percent * (float)this.progressBar.Maximum);
            this.WMPlayer.controls.currentPosition = (double)this.progressBar.Value / 1000;
            if (this.WMPlayer.URL.Length > 7) this.WMPlayer.controls.play();  //URL > D:/.wav
            Interaction.MsgBox(this.progressBar.Maximum.ToString()+ ":"+e.X+"/"+ this.progressBar.Width+"="+ ((float)e.X / (float)this.progressBar.Width * (float)this.progressBar.Maximum).ToString(), MsgBoxStyle.OkOnly, "");
            
        }

        private void VoipPlayer_Load(object sender, EventArgs e)
        {

        }

        private void VoipDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.WMPlayer.controls.stop();
        }

    }

    class Addcount {
        private int filesadded;
        private int folderadded;
        public Addcount(int nofile, int nofolder)
        {
            filesadded = nofile;
            folderadded = nofolder;
        }
        public int numberOfFile()
        {
            return this.filesadded;
        }
        public int numberOfFolder()
        {
            return this.folderadded;
        }
    }
    public class rowObject
    {
        //public string id;
        public double duration;
        public string durationString;
        public string from;
        public string to;
        public string codec;
        public string ssrc;
        public string audioPath;
        public rowObject(string filePath){
            //string filenamewithoutext = Path.GetFileNameWithoutExtension(filename);
            string filenamewithoutext = Path.GetFileNameWithoutExtension(filePath);     
            IWMPMedia mediainfo = new WindowsMediaPlayer().newMedia(filePath);//.newMedia(path);
            //mediainfo.sourceURL = path;
            //Console.WriteLine(mediainfo.get);
            this.initRowObject
            (
                mediainfo.duration,                                                         //duration
                mediainfo.durationString,
                filenamewithoutext.Split('_')[0] + ":" + filenamewithoutext.Split('_')[3],  //from
                filenamewithoutext.Split('_')[1] + ":" + filenamewithoutext.Split('_')[4],  //to
                filenamewithoutext.Split('_')[2],
                filenamewithoutext.Split('_')[5],
                filePath
            );
            Console.WriteLine("add Done!");

        }

        private void initRowObject(double duration, string durationString, string from, string to, string codec,string SSRC, string audioPath ) { 
            //this.id = id;
            this.from = from;
            this.to = to;
            this.codec = codec;
            this.durationString = durationString;
            this.duration = duration;
            this.ssrc = SSRC;
            this.audioPath = audioPath;
        }
    }
    class Rtp
    {
        public float start_time;
        public float end_time;
        public string src_ip;
        public int src_port;
        public string dst_ip;
        public int dst_port;
        public string ssrc;
        public string payload_type;
    }
}
 