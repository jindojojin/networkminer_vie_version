using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Player
{
    public partial class chooseFileOrFolderToScan : Form 
    {
        private VoipPlayer player;
        public chooseFileOrFolderToScan(string message1, string message2, VoipPlayer player)
        {
            InitializeComponent();
            this.Message1.Text = message1;
            this.Message2.Text = message2;
            this.player = player;
        }
        private void OpenFolder_Click(object sender, EventArgs e)
        {
            this.player.OpenFolder_Click(sender, e);
            this.Close();
        }
        
        private void OpenFile_Click(object sender, EventArgs e)
        {
            this.player.OpenFile_Click(sender, e);
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
