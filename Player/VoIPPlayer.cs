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

using pcapdatacopy;
using Microsoft.VisualBasic;

namespace Player
{
    public partial class VoipPlayer : Form
    {
        private List<string> CurrentFileList;
        private List<string> CurrentFolderList;
        private List<string> audioList;
        private Form1 processor;
        private EventArgs err;
        private Analyse core;
        
        public VoipPlayer(ref Form1 processor, ref EventArgs err, ref Analyse core, ref List<string> pcapFiles, ref List<string> pcapFolders, ref List<string> audioList)
        {
            this.CurrentFileList = new List<string>();
            this.processor = processor;
            this.core = core;
            this.CurrentFileList = pcapFiles;
            this.CurrentFolderList = pcapFolders;
            this.audioList = audioList;
            InitializeComponent();
            
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
       

        public void OpenFolder_Click(object sender, EventArgs e)
        {
            this.core.OpenFolder(ref this.processor, ref this.err, ref this.audioList); //giaodien.analyse.open
            this.addToLists();
            Console.WriteLine(this.CurrentFileList.Count + " / " + this.CurrentFolderList.Count);
        }

        public void OpenFile_Click(object sender, EventArgs e)
        {
            this.core.OpenFile(ref this.processor, ref this.err, ref this.audioList); //giaodien.analyse.open
            this.addToLists();
            Console.WriteLine(this.CurrentFileList.Count + " / " + this.CurrentFolderList.Count);
        }

        private void Refresh_Click(object sender, EventArgs e)//update current file list to Form1 processor
        {
            //this.CurrentFileList = pcapFiles;
            //this.CurrentFolderList = pcapFolders;
            Addcount result = this.addToLists();
            Console.WriteLine(this.CurrentFileList.Count + " / " + this.CurrentFolderList.Count + " vs " + result.numberOfFile() + " / " + result.numberOfFolder());
            //dang co exception
        }

        private void scan_Click(object sender, EventArgs e)
        {
            bool hasFile = this.CurrentFileList.Count > 0;
            bool hasFolder = this.CurrentFolderList.Count > 0;
            if (hasFile || hasFolder)
            {
                int sum_result = 0;
                if (hasFolder)
                {
                    foreach (string folder in this.CurrentFolderList)
                    {
                        sum_result += this.core.ScanFolder(ref processor, ref err, folder, ref this.audioList);
                    }
                }
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
                if (sum_result > 0) Interaction.MsgBox("Scan completed\n" + 
                    "Found " + sum_result + " streams in folders:" +
                    listFolderScanned + "\nAnd files:" +
                    listFileScanned
                    ,MsgBoxStyle.OkOnly, "Scan result");
                string audio = "";
                foreach (string audiofile in this.audioList) audio += audiofile+ "\n";
                ///string str = fileInfo.Name.Replace(".bin", ".wav");
                audio += this.audioList.Count.ToString();
                Interaction.MsgBox(audio, MsgBoxStyle.OkOnly, "Audio list from scan_click");
                if(sum_result == 0) Interaction.MsgBox("No stream detected", MsgBoxStyle.OkCancel, "Scan result");
            }

            else
            {
                string message1 = "Nothing to scan";
                string message2 = "Do you want to open a pcap file ?";
                chooseFileOrFolderToScan msgbox = new chooseFileOrFolderToScan(message1, message2, this);
                msgbox.ShowDialog();
            }
        }
        private void prevTrack_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {

        }

        private void play_Click(object sender, EventArgs e)
        {
            SoundPlayer selectedCallWAV = new SoundPlayer(@"");
            selectedCallWAV.Play();
        }

        private void pause_Click(object sender, EventArgs e)
        {

        }

        private void stop_Click(object sender, EventArgs e)
        {

        }

        private void skip_Click(object sender, EventArgs e)
        {

        }

        private void nextTrack_Click(object sender, EventArgs e)
        {

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
}
 