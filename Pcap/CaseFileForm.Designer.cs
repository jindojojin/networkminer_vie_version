namespace NetworkMiner {
    partial class CaseFileForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaseFileForm));
            this.metadataGridView = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.metadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // metadataGridView
            // 
            resources.ApplyResources(this.metadataGridView, "metadataGridView");
            this.metadataGridView.AllowUserToAddRows = false;
            this.metadataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.metadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metadataGridView.Name = "metadataGridView";
            this.metadataGridView.ReadOnly = true;
            this.metadataGridView.RowHeadersVisible = false;
            this.metadataGridView.ShowCellErrors = false;
            this.metadataGridView.ShowCellToolTips = false;
            this.metadataGridView.ShowEditingIcon = false;
            this.metadataGridView.ShowRowErrors = false;
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Name = "statusStrip1";
            // 
            // CaseFileForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metadataGridView);
            this.Controls.Add(this.statusStrip1);
            this.Name = "CaseFileForm";
            ((System.ComponentModel.ISupportInitialize)(this.metadataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView metadataGridView;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}