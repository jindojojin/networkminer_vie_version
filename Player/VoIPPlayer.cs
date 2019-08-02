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
            this.CurrentFileList = new List<string>();
            this.processor = processor;
            this.core = core;
            this.CurrentFileList = pcapFiles;
            this.CurrentFolderList = pcapFolders;
            this.audioList = audioList;
            this.WMPlayer = new WindowsMediaPlayer();
            InitializeComponent();
            this.voiptable = new DataTable();
            this.voipDataGridView.DataSource = this.voiptable;
            this.initdatagrid();
            this.currentDuration.Text = "";
            
            this.progressBar.Minimum = 0;
            this.progressBar.Maximum = 0;
            
            if (pcapFiles.Count > 0)
                foreach ( string file in pcapFiles ) this.currentListView.Items.Add(file);
            if(pcapFolders.Count > 0)
                foreach( string folder in pcapFolders ) this.currentListView.Items.Add(folder);

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (this.WMPlayer.playState == WMPPlayState.wmppsPlaying) this.WMPlayer.controls.stop();
            base.OnFormClosing(e);
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
            string cmd = "/C .\\Handletool\\" + s;
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
            this.core.SetFolder(ref this.processor, ref this.err, ref this.audioList); //giaodien.analyse.open
            if (this.processor.folder_selected_textbox.Text.Length > 0 && !this.CurrentFolderList.Contains(this.processor.folder_selected_textbox.Text))
            {
                //Interaction.MsgBox("Opened " + this.processor.folder_selected_textbox.Text, MsgBoxStyle.OkOnly, "Openfolder_click");
                this.addToListView(this.processor.folder_selected_textbox.Text);
                this.findPcapFile();
                this.addToLists();
            }
            
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
            List<string> streamdata = new List<string>();
            bool hasFile = this.CurrentFileList.Count > 0;
            bool hasFolder = this.CurrentFolderList.Count > 0;
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
                    foreach (string file in this.CurrentFileList)
                    {
                        StreamWriter sw = new StreamWriter("F:\\test.txt");
                        sw.WriteLine(file);
                        string pcap_name = Path.GetFileName(file);
                        sw.WriteLine(pcap_name);
                        string pcap_edit = "F:\\edit_" + pcap_name;
                        sw.WriteLine(pcap_edit);
                        runHandle("editcap \"" + file + "\" \"" + pcap_edit+"\"");
                        string dir = "rtp.txt";
                        runHandle("tshark -r  \"" + pcap_edit + " \" -o \"rtp.heuristic_rtp: TRUE\" -q -z rtp,streams > " + dir);
                        int count = 0;
                        ArrayList rtpList = new ArrayList();
                        using (var reader = new System.IO.StreamReader(dir))
                        {
                            reader.ReadLine(); // skip first
                            reader.ReadLine();
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
                        foreach (Rtp rtp in rtpList)
                        {
                            string name = rtp.src_ip+'_'+rtp.dst_ip+'_'+rtp.payload_type+'_'+rtp.src_port+'_'+rtp.dst_port;
                            string cmd = "tshark -r \"" + pcap_edit + "\" -o \"rtp.heuristic_rtp: TRUE\" -Y \"udp.srcport=="+rtp.src_port+" && udp.dstport=="+rtp.dst_port
                            +" && rtp.ssrc==" + rtp.ssrc + "\"" + " -T fields -e rtp.payload > " + name + ".raw";
                            runHandle(cmd);
                            runHandle("str2bin " + name + ".raw");
                            if (rtp.payload_type == "g729" || rtp.payload_type == "G729")
                            {
                                string decode_cmd = "cp_g729_decoder.exe payload.raw " + name + ".bin";         //Decode
                                Console.WriteLine(decode_cmd);
                                runHandle(decode_cmd);
                                string conv_cmd = "bin2wav.exe \"" + name + ".bin\" \"" + name + ".wav\"";      //Convert to wav
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
                                string conv_cmd = "bin2wav.exe \"" + name + ".bin\" \""+ name +".wav\"";        //Convert to wav
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
                                string conv_cmd = "bin2wav.exe \"" + name + ".bin\" \"" + name + ".wav\"";      //Convert to wav
                                runHandle(conv_cmd);
                                runCommand("del payload.raw");
                                runCommand("del " + name + ".raw");
                                runCommand("del " + name + ".bin");
                            }
                            runCommand("del tmpabcdef.raw");
                            Console.WriteLine(name);
                            streamdata.Add(name);
                            audioList.Add(name+".wav");
                        }
                        foreach (string s in streamdata)
                        {
                            Console.WriteLine(s);
                        }
                        
                       sw.Close();
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
                    foreach (string data in streamdata)
                    {
                        //insert bao datagrid
                        rowObject dataOfAudioFromName = new rowObject(data);
                        this.addtodatagrid(dataOfAudioFromName);
                    }
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
                        row.Cells[4].Value.ToString().Equals(data.codec)
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
                this.voiptable.Rows.Add(this.voiptable.Rows.Count + 1, data.durationString, data.from, data.to, data.codec);
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

        private void CurrentListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VoipDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void CurrentListView_MouseClick(object sender, MouseEventArgs e)
        {
            bool selected = false;
            if (e.Button == MouseButtons.Right)
            {
                for (int i = currentListView.Items.Count - 1; i >= 0; i--)
                {
                    if (currentListView.Items[i].Selected)
                    {
                        selected = true;
                        break;
                    }
                }
                if (selected==true)
                {
                    //currentListView.ContextMenu.Show(currentListView, new Point(e.X, e.Y));
                }
            }
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


        public rowObject(string filename){
            //string filenamewithoutext = Path.GetFileNameWithoutExtension(filename);
            string filenamewithoutext = filename;
            Console.WriteLine(filenamewithoutext);
            string path = filename + ".wav";
            IWMPMedia mediainfo = new WindowsMediaPlayer().newMedia(path);//.newMedia(path);
            //mediainfo.sourceURL = path;
            //Console.WriteLine(mediainfo.get);
            this.initRowObject
            (
                mediainfo.duration,                                                         //duration
                mediainfo.durationString,
                filenamewithoutext.Split('_')[0] + ":" + filenamewithoutext.Split('_')[3],  //from
                filenamewithoutext.Split('_')[1] + ":" + filenamewithoutext.Split('_')[4],  //to
                filenamewithoutext.Split('_')[2]                                           //code, so 2 chua ro y nghi
            );
            Console.WriteLine("add Done!");
            // vd 10-1-3-143_10-1-6-18_222-224-238-143_5000_2006.wav

            // 1:ip1 2:ip2 3:so 4:port1 5:port2

        }

        private void initRowObject(double duration, string durationString, string from, string to, string codec) { 
            //this.id = id;
            this.from = from;
            this.to = to;
            this.codec = codec;
            this.durationString = durationString;
            this.duration = duration;
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
 