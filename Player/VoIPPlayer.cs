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
            this.initdatagrid();
            this.currentDuration.Text = "";
            if(pcapFiles.Count > 0)
                foreach ( string file in pcapFiles ) this.currentListView.Items.Add(file);
            if(pcapFolders.Count > 0)
                foreach( string folder in pcapFolders ) this.currentListView.Items.Add(folder);

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (this.WMPlayer.playState == WMPPlayState.wmppsPlaying) this.WMPlayer.controls.stop();
            base.OnFormClosing(e);
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
                Interaction.MsgBox("Opened " + this.processor.folder_selected_textbox.Text, MsgBoxStyle.OkOnly, "Openfolder_click");
                this.addToListView(this.processor.folder_selected_textbox.Text);
                this.findPcapFile();
                this.addToLists();
            }
            
        }

        public void addToListView(string path)
        {
            ListViewItem newitem = new ListViewItem();
            newitem.Text = path;
            bool is_duplicate = false;
            foreach(ListViewItem item in currentListView.Items)
            if (item.Text == path)
                {
                    is_duplicate = true;
                    break;
                }
            if(!is_duplicate) this.currentListView.Items.Add(path);
        }

        public void OpenFile_Click(object sender, EventArgs e)
        {
            this.core.OpenFile(ref this.processor, ref this.err, ref this.audioList); //giaodien.analyse.open
            Interaction.MsgBox("Opened " + this.processor.file_selected_textbox.Text, MsgBoxStyle.OkOnly, "Openfile_click");
            this.addToListView(this.processor.file_selected_textbox.Text);
            this.addToLists();
           
        }

        

        public void scan_Click(object sender, EventArgs e) { scan_Click(sender, e, MODE.NORMAL); }
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
                    
                    if(_MODE == MODE.NORMAL) Interaction.MsgBox("start scanning files list", MsgBoxStyle.OkOnly, "scan clicked");
                    foreach (string file in this.CurrentFileList)
                    {
                        streamdata.AddRange(this.core.UseFile(ref processor,  file, ref err, ref this.audioList));
                        //Interaction.MsgBox("tra ve "+ this.core.UseFile(ref processor, file, ref err, ref this.audioList).Count , MsgBoxStyle.OkOnly, " test return 2 cap");
                    }
                }
                sum_result += streamdata.Count;
                string listFileScanned = "";
                string listFolderScanned = "";
                int i = 0;
                int noFile = this.CurrentFileList.Count;
                int noFolder = this.CurrentFolderList.Count;
                for ( ; i < noFile && i < 5; i++)
                {
                    listFileScanned += "\n"+ CurrentFileList[i] ;
                }
                if (noFile > 5) listFileScanned += "\n...";
                for (i = 0; i < noFolder && i < 5; i++)
                {
                    listFolderScanned += "\n"+ CurrentFolderList[i]  ;
                }
                if (noFolder > 5) listFolderScanned += "\n...";
                if (sum_result > 0) if (_MODE == MODE.NORMAL) Interaction.MsgBox("Scan completed\n" + 
                    "Found " + sum_result + " streams in folders:" +
                    listFolderScanned + "\nAnd files:" +
                    listFileScanned
                    ,MsgBoxStyle.OkOnly, "Scan sum_result (after word found)");
                string audio = "";
                foreach (string audiofile in this.audioList) audio += audiofile+ "\n";
                audio += this.audioList.Count.ToString();
                if (_MODE == MODE.NORMAL) Interaction.MsgBox(audio, MsgBoxStyle.OkOnly, "Audio list from scan_click");
                if(sum_result == 0) if (_MODE == MODE.NORMAL) Interaction.MsgBox("No stream detected", MsgBoxStyle.OkCancel, "Scan result fail");
              
                
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
            }
        }
        private void prevTrack_Click(object sender, EventArgs e)
        {
            this.WMPlayer.controls.previous();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.WMPlayer.controls.fastReverse();
        }

        private void play_Click(object sender, EventArgs e)
        {
            this.updateposission();
            this.WMPlayer.controls.play();
        }

        private void pause_Click(object sender, EventArgs e)
        {
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
            this.WMPlayer.controls.next();
        }
        private DataTable voiptable;
        private void initdatagrid()
        {
            this.voiptable = new DataTable();
            this.voiptable.Columns.Add("#");
            this.voiptable.Columns.Add("Duration");
            this.voiptable.Columns.Add("From");
            this.voiptable.Columns.Add("To");
            this.voiptable.Columns.Add("Code");
            this.voiptable.Columns.Add("Location");
            this.voipDataGridView.DataSource = this.voiptable;
        }

        private void updateposission()
        {
            this.progressBar.Value = (int)((((double)this.WMPlayer.controls.currentPosition / (double)this.progressBar.Maximum))*100);
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
                    if (row.Cells[1].Value.ToString().Equals(data.from) &&
                        row.Cells[2].Value.ToString().Equals(data.to) &&
                        row.Cells[3].Value.ToString().Equals(data.duration) &&
                        row.Cells[4].Value.ToString().Equals(data.location)
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
                this.voiptable.Rows.Add(this.voiptable.Rows.Count + 1, data.duration, data.from, data.to, data.code, data.location);
                this.voipDataGridView.DataSource = this.voiptable;
            }
        }

        private void updateAudioNameTextboxandDuration(string path)
        {
            this.fileNameTextbox.Text = path;
            
            this.updateDuration();
            
            
            
        }
        //private void voipDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int thisRow = this.voipDataGridView.CurrentCell.RowIndex;
        //    if (this.WMPlayer.playState != WMPPlayState.wmppsPlaying)
        //    {
        //        this.updateAudioNameTextbox(voipDataGridView.Rows[thisRow].Cells[4].Value.ToString());
        //        if (this.WMPlayer.playState != WMPPlayState.wmppsPaused)
        //        {
        //            this.WMPlayer.URL = this.voipDataGridView.CurrentCell.OwningRow.Cells[4].Value.ToString();
                 
        //        }
        //    }
            
        //}

        private void updateDuration()
        {
            
            IWMPMedia mediainfo = WMPlayer.newMedia(this.WMPlayer.URL);
            this.currentDuration.Text = mediainfo.durationString;
            this.progressBar.Maximum = (int)mediainfo.duration;

        }
        


        private void voipDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int thisRow = this.voipDataGridView.CurrentCell.RowIndex;
            string file = voipDataGridView.Rows[thisRow].Cells[5].Value.ToString();
            Interaction.MsgBox("Opening audio " + file, MsgBoxStyle.OkOnly, "double_click cell");
            this.updateAudioNameTextboxandDuration(file);
            this.WMPlayer.controls.stop();
            this.WMPlayer.URL = file;
            
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
        public string duration;
        public string from;
        public string to;
        public string code;
        public string location;


        public rowObject(string filename){
            string filenamewithoutext = Path.GetFileNameWithoutExtension(filename);
            string path = filename + ".wav";
            IWMPMedia mediainfo = new WindowsMediaPlayer().newMedia(path);
            this.initRowObject
            (
                mediainfo.durationString,                                                         //duration
                filenamewithoutext.Split('_')[0] + ":" + filenamewithoutext.Split('_')[3],  //from
                filenamewithoutext.Split('_')[1] + ":" + filenamewithoutext.Split('_')[4],  //to
                filenamewithoutext.Split('_')[2],                                           //code, so 2 chua ro y nghia
                path
            );
            // vd 10-1-3-143_10-1-6-18_222-224-238-143_5000_2006.wav

            // 1:ip1 2:ip2 3:so 4:port1 5:port2

        }

        private void initRowObject(string duration , string from, string to, string code, string location)
        {
            //this.id = id;
            this.from = from;
            this.to = to;
            this.code = code;
            this.duration = duration;
            this.location = location;
        }
    }
}
 