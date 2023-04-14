using FCM.Clubs;
using FCM.Players;
using System;
using System.Windows.Forms;

namespace FCM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void clubsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var clubsForm = new Clubs.Clubs())
            {
                clubsForm.ShowDialog();
            }
        }

        private void playersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var playersForm = new PlayersForm())
            {
                playersForm.ShowDialog();
            }
        }
    }
}
