using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
        private Form1 processor;
        private EventArgs err;
        private Analyse core;
        
        public VoipPlayer(ref Form1 processor, ref EventArgs err, ref Analyse core, ref List<string> pcapFiles, ref List<string> pcapFolders)
        {
            this.CurrentFileList = new List<string>();
            this.processor = processor;
            this.core = core;
            this.CurrentFileList = pcapFiles;
            this.CurrentFolderList = pcapFolders;
            InitializeComponent();
            
        }
        
        private void Refresh_Click(object sender, EventArgs e)//update current file list to Form1 processor
        {
            //this.CurrentFileList = pcapFiles;
            //this.CurrentFolderList = pcapFolders;
            this.addToLists();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            this.core.OpenFile(ref this.processor, ref this.err); //giaodien.analyse.open
            this.addToLists();
        }

        private void addToLists()
        {
            string file = this.processor.file_selected_textbox.Text;
            string folder1 = this.processor.folder_selected_textbox.Text;
            string folder2 = Path.GetDirectoryName(this.processor.file_selected_textbox.Text);
            if (!this.CurrentFileList.Contains(file))
            {
                this.CurrentFileList.Add(file);
            }
            if (!this.CurrentFolderList.Contains(folder1))
            {
                this.CurrentFolderList.Add(folder1);
            }
            if (!this.CurrentFolderList.Contains(folder2))
            {
                this.CurrentFolderList.Add(folder2);
            }
        }
       

        private void OpenFolder_Click(object sender, EventArgs e)
        {
            this.core.OpenFolder(ref this.processor, ref this.err); //giaodien.analyse.open
        }

        private void prevTrack_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {

        }

        private void play_Click(object sender, EventArgs e)
        {

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

        private void scan_Click(object sender, EventArgs e)
        {
            if (this.CurrentFileList.Count > 0) this.core.Scan(processor, err);
            else Interaction.MsgBox("Nothing to scan\n" +
                "Do you want to open a pcap file ?", MsgBoxStyle.OkCancel, "Scan VoIP stream failed");
        }
    }
}
