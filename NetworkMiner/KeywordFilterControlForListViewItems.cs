using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace NetworkMiner {

    
    class KeywordFilterControlForListViewItems : KeywordFilterControl<ListViewItem>
    {
        public KeywordFilterControlForListViewItems()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeywordFilterControlForListViewItems));
            this.SuspendLayout();
            // 
            // KeywordFilterControlForListViewItems
            // 
            resources.ApplyResources(this, "$this");
            this.Name = "KeywordFilterControlForListViewItems";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        //I need to create this wrapper class because of some bug in Visual Studio that prevents the Designer view from showing generic GUI objects
        //http://stackoverflow.com/questions/9314/could-not-find-type-error-loading-a-form-in-the-windows-forms-designer
    }
}
