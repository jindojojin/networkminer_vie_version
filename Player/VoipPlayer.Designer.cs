namespace Player
{
    partial class VoipPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.PlayerGroup = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.nextTrack = new System.Windows.Forms.PictureBox();
            this.skip = new System.Windows.Forms.PictureBox();
            this.stop = new System.Windows.Forms.PictureBox();
            this.pause = new System.Windows.Forms.PictureBox();
            this.play = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.PictureBox();
            this.prevTrack = new System.Windows.Forms.PictureBox();
            this.AnalyseGroup = new System.Windows.Forms.GroupBox();
            this.OpenFolder = new System.Windows.Forms.PictureBox();
            this.OpenFile = new System.Windows.Forms.PictureBox();
            this.scan = new System.Windows.Forms.PictureBox();
            this.Refresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.PlayerGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevTrack)).BeginInit();
            this.AnalyseGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpenFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 79);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(844, 359);
            this.dataGridView.TabIndex = 0;
            // 
            // PlayerGroup
            // 
            this.PlayerGroup.Controls.Add(this.textBox1);
            this.PlayerGroup.Controls.Add(this.progressBar);
            this.PlayerGroup.Controls.Add(this.nextTrack);
            this.PlayerGroup.Controls.Add(this.skip);
            this.PlayerGroup.Controls.Add(this.stop);
            this.PlayerGroup.Controls.Add(this.pause);
            this.PlayerGroup.Controls.Add(this.play);
            this.PlayerGroup.Controls.Add(this.back);
            this.PlayerGroup.Controls.Add(this.prevTrack);
            this.PlayerGroup.Location = new System.Drawing.Point(169, 12);
            this.PlayerGroup.Name = "PlayerGroup";
            this.PlayerGroup.Size = new System.Drawing.Size(687, 58);
            this.PlayerGroup.TabIndex = 1;
            this.PlayerGroup.TabStop = false;
            this.PlayerGroup.Text = "Player";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(276, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(405, 22);
            this.textBox1.TabIndex = 11;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(276, 41);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(334, 10);
            this.progressBar.TabIndex = 9;
            // 
            // nextTrack
            // 
            this.nextTrack.Image = global::Player.Properties.Resources.Media_Controls_End_icon;
            this.nextTrack.Location = new System.Drawing.Point(228, 21);
            this.nextTrack.Name = "nextTrack";
            this.nextTrack.Size = new System.Drawing.Size(30, 30);
            this.nextTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nextTrack.TabIndex = 8;
            this.nextTrack.TabStop = false;
            this.nextTrack.Click += new System.EventHandler(this.nextTrack_Click);
            // 
            // skip
            // 
            this.skip.Image = global::Player.Properties.Resources.Media_Controls_Fast_Forward_icon;
            this.skip.Location = new System.Drawing.Point(192, 21);
            this.skip.Name = "skip";
            this.skip.Size = new System.Drawing.Size(30, 30);
            this.skip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.skip.TabIndex = 7;
            this.skip.TabStop = false;
            this.skip.Click += new System.EventHandler(this.skip_Click);
            // 
            // stop
            // 
            this.stop.Image = global::Player.Properties.Resources.Media_Controls_Stop_icon;
            this.stop.Location = new System.Drawing.Point(156, 20);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(30, 30);
            this.stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stop.TabIndex = 6;
            this.stop.TabStop = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // pause
            // 
            this.pause.Image = global::Player.Properties.Resources.Media_Controls_Pause_icon;
            this.pause.Location = new System.Drawing.Point(120, 21);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(30, 30);
            this.pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pause.TabIndex = 5;
            this.pause.TabStop = false;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // play
            // 
            this.play.Image = global::Player.Properties.Resources.Media_Controls_Play_icon;
            this.play.Location = new System.Drawing.Point(84, 20);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(30, 30);
            this.play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.play.TabIndex = 4;
            this.play.TabStop = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // back
            // 
            this.back.Image = global::Player.Properties.Resources.Media_Controls_Rewind_icon;
            this.back.Location = new System.Drawing.Point(48, 20);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(30, 30);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back.TabIndex = 3;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // prevTrack
            // 
            this.prevTrack.Image = global::Player.Properties.Resources.Media_Controls_Skip_To_Start_icon;
            this.prevTrack.Location = new System.Drawing.Point(12, 20);
            this.prevTrack.Name = "prevTrack";
            this.prevTrack.Size = new System.Drawing.Size(30, 30);
            this.prevTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.prevTrack.TabIndex = 2;
            this.prevTrack.TabStop = false;
            this.prevTrack.Click += new System.EventHandler(this.prevTrack_Click);
            // 
            // AnalyseGroup
            // 
            this.AnalyseGroup.Controls.Add(this.OpenFolder);
            this.AnalyseGroup.Controls.Add(this.OpenFile);
            this.AnalyseGroup.Controls.Add(this.scan);
            this.AnalyseGroup.Controls.Add(this.Refresh);
            this.AnalyseGroup.Location = new System.Drawing.Point(12, 12);
            this.AnalyseGroup.Name = "AnalyseGroup";
            this.AnalyseGroup.Size = new System.Drawing.Size(151, 58);
            this.AnalyseGroup.TabIndex = 14;
            this.AnalyseGroup.TabStop = false;
            this.AnalyseGroup.Text = "Analyse";
            // 
            // OpenFolder
            // 
            this.OpenFolder.Image = global::Player.Properties.Resources.Very_Basic_Folder_icon;
            this.OpenFolder.Location = new System.Drawing.Point(6, 20);
            this.OpenFolder.Name = "OpenFolder";
            this.OpenFolder.Size = new System.Drawing.Size(30, 30);
            this.OpenFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OpenFolder.TabIndex = 14;
            this.OpenFolder.TabStop = false;
            this.OpenFolder.Click += new System.EventHandler(this.OpenFolder_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.Image = global::Player.Properties.Resources.File_icon;
            this.OpenFile.Location = new System.Drawing.Point(42, 20);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(30, 30);
            this.OpenFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OpenFile.TabIndex = 10;
            this.OpenFile.TabStop = false;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // scan
            // 
            this.scan.Image = global::Player.Properties.Resources.User_Interface_Fingerprint_Scan_icon;
            this.scan.Location = new System.Drawing.Point(114, 20);
            this.scan.Name = "scan";
            this.scan.Size = new System.Drawing.Size(30, 30);
            this.scan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.scan.TabIndex = 13;
            this.scan.TabStop = false;
            this.scan.Click += new System.EventHandler(this.scan_Click);
            // 
            // Refresh
            // 
            this.Refresh.Image = global::Player.Properties.Resources.Very_Basic_Update_icon;
            this.Refresh.Location = new System.Drawing.Point(78, 20);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(30, 30);
            this.Refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Refresh.TabIndex = 12;
            this.Refresh.TabStop = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // VoipPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Controls.Add(this.AnalyseGroup);
            this.Controls.Add(this.PlayerGroup);
            this.Controls.Add(this.dataGridView);
            this.Name = "VoipPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Network Miner - VoIP Player";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.PlayerGroup.ResumeLayout(false);
            this.PlayerGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevTrack)).EndInit();
            this.AnalyseGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OpenFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox PlayerGroup;
        private System.Windows.Forms.PictureBox prevTrack;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.PictureBox nextTrack;
        private System.Windows.Forms.PictureBox skip;
        private System.Windows.Forms.PictureBox stop;
        private System.Windows.Forms.PictureBox pause;
        private System.Windows.Forms.PictureBox play;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.PictureBox OpenFile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox Refresh;
        private System.Windows.Forms.PictureBox scan;
        private System.Windows.Forms.GroupBox AnalyseGroup;
        private System.Windows.Forms.PictureBox OpenFolder;
    }
}

