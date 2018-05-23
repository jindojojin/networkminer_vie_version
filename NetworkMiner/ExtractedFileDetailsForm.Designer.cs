namespace NetworkMiner {
    partial class ExtractedFileDetailsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtractedFileDetailsForm));
            this.fileDetailsPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // fileDetailsPropertyGrid
            // 
            resources.ApplyResources(this.fileDetailsPropertyGrid, "fileDetailsPropertyGrid");
            this.fileDetailsPropertyGrid.CommandsVisibleIfAvailable = false;
            this.fileDetailsPropertyGrid.Name = "fileDetailsPropertyGrid";
            this.fileDetailsPropertyGrid.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.fileDetailsPropertyGrid.ToolbarVisible = false;
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Name = "statusStrip1";
            // 
            // ExtractedFileDetailsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fileDetailsPropertyGrid);
            this.Controls.Add(this.statusStrip1);
            this.Name = "ExtractedFileDetailsForm";
            this.VisibleChanged += new System.EventHandler(this.FileDetailsForm_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PropertyGrid fileDetailsPropertyGrid;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}