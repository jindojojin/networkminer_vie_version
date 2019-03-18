namespace Player
{
    partial class chooseFileOrFolderToScan
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
            this.OpenFile = new System.Windows.Forms.Button();
            this.OpenFolder = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Message1 = new System.Windows.Forms.TextBox();
            this.Message2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(26, 87);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(97, 30);
            this.OpenFile.TabIndex = 0;
            this.OpenFile.Text = "Open File";
            this.OpenFile.UseCompatibleTextRendering = true;
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // OpenFolder
            // 
            this.OpenFolder.Location = new System.Drawing.Point(147, 86);
            this.OpenFolder.Name = "OpenFolder";
            this.OpenFolder.Size = new System.Drawing.Size(104, 31);
            this.OpenFolder.TabIndex = 1;
            this.OpenFolder.Text = "Open Folder";
            this.OpenFolder.UseCompatibleTextRendering = true;
            this.OpenFolder.UseVisualStyleBackColor = true;
            this.OpenFolder.Click += new System.EventHandler(this.OpenFolder_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(272, 86);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(87, 31);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseCompatibleTextRendering = true;
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Message1
            // 
            this.Message1.BackColor = System.Drawing.SystemColors.Control;
            this.Message1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Message1.Location = new System.Drawing.Point(26, 12);
            this.Message1.Name = "Message1";
            this.Message1.Size = new System.Drawing.Size(333, 15);
            this.Message1.TabIndex = 3;
            // 
            // Message2
            // 
            this.Message2.BackColor = System.Drawing.SystemColors.Control;
            this.Message2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Message2.Location = new System.Drawing.Point(26, 33);
            this.Message2.Name = "Message2";
            this.Message2.Size = new System.Drawing.Size(333, 15);
            this.Message2.TabIndex = 4;
            // 
            // chooseFileOrFolderToScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 146);
            this.Controls.Add(this.Message2);
            this.Controls.Add(this.Message1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OpenFolder);
            this.Controls.Add(this.OpenFile);
            this.Name = "chooseFileOrFolderToScan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "chooseFileOrFolderToScan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button OpenFolder;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox Message1;
        private System.Windows.Forms.TextBox Message2;
    }
}