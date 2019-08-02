using System;
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
            this.components = new System.ComponentModel.Container();
            this.PlayerGroup = new System.Windows.Forms.GroupBox();
            this.curr = new System.Windows.Forms.TextBox();
            this.currentDuration = new System.Windows.Forms.TextBox();
            this.fileNameTextbox = new System.Windows.Forms.TextBox();
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
            this.currentListView = new System.Windows.Forms.ListView();
            this.baseclock = new System.Windows.Forms.Timer(this.components);
            this.voipDataGridView = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.voipDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerGroup
            // 
            this.PlayerGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerGroup.Controls.Add(this.curr);
            this.PlayerGroup.Controls.Add(this.currentDuration);
            this.PlayerGroup.Controls.Add(this.fileNameTextbox);
            this.PlayerGroup.Controls.Add(this.progressBar);
            this.PlayerGroup.Controls.Add(this.nextTrack);
            this.PlayerGroup.Controls.Add(this.skip);
            this.PlayerGroup.Controls.Add(this.stop);
            this.PlayerGroup.Controls.Add(this.pause);
            this.PlayerGroup.Controls.Add(this.play);
            this.PlayerGroup.Controls.Add(this.back);
            this.PlayerGroup.Controls.Add(this.prevTrack);
            this.PlayerGroup.Location = new System.Drawing.Point(100, 10);
            this.PlayerGroup.Margin = new System.Windows.Forms.Padding(2);
            this.PlayerGroup.Name = "PlayerGroup";
            this.PlayerGroup.Padding = new System.Windows.Forms.Padding(2);
            this.PlayerGroup.Size = new System.Drawing.Size(532, 47);
            this.PlayerGroup.TabIndex = 1;
            this.PlayerGroup.TabStop = false;
            this.PlayerGroup.Text = "Trình phát";
            // 
            // curr
            // 
            this.curr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.curr.BackColor = System.Drawing.SystemColors.Control;
            this.curr.Location = new System.Drawing.Point(380, 29);
            this.curr.Margin = new System.Windows.Forms.Padding(2);
            this.curr.Name = "curr";
            this.curr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.curr.Size = new System.Drawing.Size(77, 20);
            this.curr.TabIndex = 16;
            // 
            // currentDuration
            // 
            this.currentDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentDuration.BackColor = System.Drawing.SystemColors.Control;
            this.currentDuration.Location = new System.Drawing.Point(454, 29);
            this.currentDuration.Margin = new System.Windows.Forms.Padding(2);
            this.currentDuration.Name = "currentDuration";
            this.currentDuration.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.currentDuration.Size = new System.Drawing.Size(74, 20);
            this.currentDuration.TabIndex = 16;
            // 
            // fileNameTextbox
            // 
            this.fileNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameTextbox.BackColor = System.Drawing.SystemColors.Control;
            this.fileNameTextbox.Location = new System.Drawing.Point(207, 11);
            this.fileNameTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.fileNameTextbox.Name = "fileNameTextbox";
            this.fileNameTextbox.Size = new System.Drawing.Size(322, 20);
            this.fileNameTextbox.TabIndex = 11;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(207, 33);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(168, 8);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 9;
            this.progressBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.progressBar_MouseDown);
            // 
            // nextTrack
            // 
            this.nextTrack.Image = global::Player.Properties.Resources.Media_Controls_End_icon;
            this.nextTrack.Location = new System.Drawing.Point(171, 17);
            this.nextTrack.Margin = new System.Windows.Forms.Padding(2);
            this.nextTrack.Name = "nextTrack";
            this.nextTrack.Size = new System.Drawing.Size(22, 24);
            this.nextTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nextTrack.TabIndex = 8;
            this.nextTrack.TabStop = false;
            this.nextTrack.Click += new System.EventHandler(this.nextTrack_Click);
            // 
            // skip
            // 
            this.skip.Image = global::Player.Properties.Resources.Media_Controls_Fast_Forward_icon;
            this.skip.Location = new System.Drawing.Point(144, 17);
            this.skip.Margin = new System.Windows.Forms.Padding(2);
            this.skip.Name = "skip";
            this.skip.Size = new System.Drawing.Size(22, 24);
            this.skip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.skip.TabIndex = 7;
            this.skip.TabStop = false;
            this.skip.Click += new System.EventHandler(this.skip_Click);
            // 
            // stop
            // 
            this.stop.Image = global::Player.Properties.Resources.Media_Controls_Stop_icon;
            this.stop.Location = new System.Drawing.Point(117, 16);
            this.stop.Margin = new System.Windows.Forms.Padding(2);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(22, 24);
            this.stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stop.TabIndex = 6;
            this.stop.TabStop = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // pause
            // 
            this.pause.Image = global::Player.Properties.Resources.Media_Controls_Pause_icon;
            this.pause.Location = new System.Drawing.Point(90, 17);
            this.pause.Margin = new System.Windows.Forms.Padding(2);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(22, 24);
            this.pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pause.TabIndex = 5;
            this.pause.TabStop = false;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // play
            // 
            this.play.Image = global::Player.Properties.Resources.Media_Controls_Play_icon;
            this.play.Location = new System.Drawing.Point(63, 16);
            this.play.Margin = new System.Windows.Forms.Padding(2);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(22, 24);
            this.play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.play.TabIndex = 4;
            this.play.TabStop = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // back
            // 
            this.back.Image = global::Player.Properties.Resources.Media_Controls_Rewind_icon;
            this.back.Location = new System.Drawing.Point(36, 16);
            this.back.Margin = new System.Windows.Forms.Padding(2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(22, 24);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back.TabIndex = 3;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // prevTrack
            // 
            this.prevTrack.Image = global::Player.Properties.Resources.Media_Controls_Skip_To_Start_icon;
            this.prevTrack.Location = new System.Drawing.Point(9, 16);
            this.prevTrack.Margin = new System.Windows.Forms.Padding(2);
            this.prevTrack.Name = "prevTrack";
            this.prevTrack.Size = new System.Drawing.Size(22, 24);
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
            this.AnalyseGroup.Location = new System.Drawing.Point(9, 10);
            this.AnalyseGroup.Margin = new System.Windows.Forms.Padding(2);
            this.AnalyseGroup.Name = "AnalyseGroup";
            this.AnalyseGroup.Padding = new System.Windows.Forms.Padding(2);
            this.AnalyseGroup.Size = new System.Drawing.Size(87, 47);
            this.AnalyseGroup.TabIndex = 14;
            this.AnalyseGroup.TabStop = false;
            this.AnalyseGroup.Text = "Phân tích";
            // 
            // OpenFolder
            // 
            this.OpenFolder.Image = global::Player.Properties.Resources.Very_Basic_Folder_icon;
            this.OpenFolder.Location = new System.Drawing.Point(4, 16);
            this.OpenFolder.Margin = new System.Windows.Forms.Padding(2);
            this.OpenFolder.Name = "OpenFolder";
            this.OpenFolder.Size = new System.Drawing.Size(22, 24);
            this.OpenFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OpenFolder.TabIndex = 14;
            this.OpenFolder.TabStop = false;
            this.OpenFolder.Click += new System.EventHandler(this.OpenFolder_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.Image = global::Player.Properties.Resources.File_icon;
            this.OpenFile.Location = new System.Drawing.Point(32, 16);
            this.OpenFile.Margin = new System.Windows.Forms.Padding(2);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(22, 24);
            this.OpenFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OpenFile.TabIndex = 10;
            this.OpenFile.TabStop = false;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // scan
            // 
            this.scan.Image = global::Player.Properties.Resources.User_Interface_Fingerprint_Scan_icon;
            this.scan.Location = new System.Drawing.Point(58, 16);
            this.scan.Margin = new System.Windows.Forms.Padding(2);
            this.scan.Name = "scan";
            this.scan.Size = new System.Drawing.Size(22, 24);
            this.scan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.scan.TabIndex = 13;
            this.scan.TabStop = false;
            this.scan.Click += new System.EventHandler(this.scan_Click);
            // 
            // currentListView
            // 
            this.currentListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.currentListView.HideSelection = false;
            this.currentListView.Location = new System.Drawing.Point(9, 64);
            this.currentListView.Margin = new System.Windows.Forms.Padding(2);
            this.currentListView.Name = "currentListView";
            this.currentListView.Size = new System.Drawing.Size(124, 313);
            this.currentListView.TabIndex = 15;
            this.currentListView.UseCompatibleStateImageBehavior = false;
            this.currentListView.View = System.Windows.Forms.View.List;
            this.currentListView.SelectedIndexChanged += new System.EventHandler(this.CurrentListView_SelectedIndexChanged);
            this.currentListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CurrentListView_MouseClick);
            this.currentListView.ContextMenu = new System.Windows.Forms.ContextMenu();
            this.currentListView.ContextMenu.MenuItems.Add(new System.Windows.Forms.MenuItem("Xóa", Delete_Click));

            // 
            // baseclock
            // 
            this.baseclock.Interval = 1;
            this.baseclock.Tick += new System.EventHandler(this.baseclock_Tick);
            // 
            // voipDataGridView
            // 
            this.voipDataGridView.AllowUserToAddRows = false;
            this.voipDataGridView.AllowUserToDeleteRows = false;
            this.voipDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.voipDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.voipDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.voipDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.voipDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.voipDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.voipDataGridView.Location = new System.Drawing.Point(136, 64);
            this.voipDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.voipDataGridView.Name = "voipDataGridView";
            this.voipDataGridView.RowTemplate.Height = 24;
            this.voipDataGridView.Size = new System.Drawing.Size(496, 312);
            this.voipDataGridView.TabIndex = 0;
            this.voipDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.voipDataGridView_CellContentDoubleClick);
            this.voipDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.VoipDataGridView_CellMouseClick);
            this.voipDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.voipDataGridView_MouseClick);
            this.voipDataGridView.ContextMenu = new System.Windows.Forms.ContextMenu();
            this.voipDataGridView.ContextMenu.MenuItems.Add(new System.Windows.Forms.MenuItem("Đổi tên file", EditName_Click));
            // 
            // VoipPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 382);
            this.Controls.Add(this.currentListView);
            this.Controls.Add(this.AnalyseGroup);
            this.Controls.Add(this.PlayerGroup);
            this.Controls.Add(this.voipDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VoipPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Trình phát VoIP";
            this.Load += new System.EventHandler(this.VoipPlayer_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.voipDataGridView)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion
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
        private System.Windows.Forms.TextBox fileNameTextbox;
        private System.Windows.Forms.PictureBox scan;
        private System.Windows.Forms.GroupBox AnalyseGroup;
        private System.Windows.Forms.PictureBox OpenFolder;
        private System.Windows.Forms.TextBox currentDuration;
        private System.Windows.Forms.Timer baseclock;
        private System.Windows.Forms.TextBox curr;
        private System.Windows.Forms.DataGridView voipDataGridView;
    }
}

