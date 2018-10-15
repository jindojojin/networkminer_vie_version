namespace Player
{
    partial class VoIPPlayer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nextTrack = new System.Windows.Forms.PictureBox();
            this.skip = new System.Windows.Forms.PictureBox();
            this.stop = new System.Windows.Forms.PictureBox();
            this.pause = new System.Windows.Forms.PictureBox();
            this.play = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.PictureBox();
            this.prevTrack = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevTrack)).BeginInit();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.progressBar);
            this.groupBox1.Controls.Add(this.nextTrack);
            this.groupBox1.Controls.Add(this.skip);
            this.groupBox1.Controls.Add(this.stop);
            this.groupBox1.Controls.Add(this.pause);
            this.groupBox1.Controls.Add(this.play);
            this.groupBox1.Controls.Add(this.back);
            this.groupBox1.Controls.Add(this.prevTrack);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(844, 58);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(309, 41);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(517, 10);
            this.progressBar.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Player.Properties.Resources.Very_Basic_Folder_icon;
            this.pictureBox1.Location = new System.Drawing.Point(8, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // nextTrack
            // 
            this.nextTrack.Image = global::Player.Properties.Resources.Media_Controls_End_icon;
            this.nextTrack.Location = new System.Drawing.Point(260, 22);
            this.nextTrack.Name = "nextTrack";
            this.nextTrack.Size = new System.Drawing.Size(30, 30);
            this.nextTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nextTrack.TabIndex = 8;
            this.nextTrack.TabStop = false;
            // 
            // skip
            // 
            this.skip.Image = global::Player.Properties.Resources.Media_Controls_Fast_Forward_icon;
            this.skip.Location = new System.Drawing.Point(224, 22);
            this.skip.Name = "skip";
            this.skip.Size = new System.Drawing.Size(30, 30);
            this.skip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.skip.TabIndex = 7;
            this.skip.TabStop = false;
            // 
            // stop
            // 
            this.stop.Image = global::Player.Properties.Resources.Media_Controls_Stop_icon;
            this.stop.Location = new System.Drawing.Point(188, 21);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(30, 30);
            this.stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stop.TabIndex = 6;
            this.stop.TabStop = false;
            // 
            // pause
            // 
            this.pause.Image = global::Player.Properties.Resources.Media_Controls_Pause_icon;
            this.pause.Location = new System.Drawing.Point(152, 22);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(30, 30);
            this.pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pause.TabIndex = 5;
            this.pause.TabStop = false;
            // 
            // play
            // 
            this.play.Image = global::Player.Properties.Resources.Media_Controls_Play_icon;
            this.play.Location = new System.Drawing.Point(116, 21);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(30, 30);
            this.play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.play.TabIndex = 4;
            this.play.TabStop = false;
            // 
            // back
            // 
            this.back.Image = global::Player.Properties.Resources.Media_Controls_Rewind_icon;
            this.back.Location = new System.Drawing.Point(80, 21);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(30, 30);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back.TabIndex = 3;
            this.back.TabStop = false;
            // 
            // prevTrack
            // 
            this.prevTrack.Image = global::Player.Properties.Resources.Media_Controls_Skip_To_Start_icon;
            this.prevTrack.Location = new System.Drawing.Point(44, 21);
            this.prevTrack.Name = "prevTrack";
            this.prevTrack.Size = new System.Drawing.Size(30, 30);
            this.prevTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.prevTrack.TabIndex = 2;
            this.prevTrack.TabStop = false;
            this.prevTrack.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(309, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(517, 22);
            this.textBox1.TabIndex = 11;
            // 
            // VoIPPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Name = "VoIPPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Network Miner - VoIP Player";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox prevTrack;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.PictureBox nextTrack;
        private System.Windows.Forms.PictureBox skip;
        private System.Windows.Forms.PictureBox stop;
        private System.Windows.Forms.PictureBox pause;
        private System.Windows.Forms.PictureBox play;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

