using System;
using System.Windows.Forms;
using FairManagementApp.UI;

namespace FairManagementApp
{
    public partial class MainMenuUI : Form
    {
        public MainMenuUI()
        {
            InitializeComponent();
        }

        private void visitorEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VisitorEntryUI visitorEntryUi = new VisitorEntryUI();
            visitorEntryUi.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void zoneEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneEntryUI zoneEntryUi = new ZoneEntryUI();
            zoneEntryUi.Show();
        }

        private void zoneSpecificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneVisitorDetailUI zoneVisitorDetailUi = new ZoneVisitorDetailUI();
            zoneVisitorDetailUi.Show();
        }

        private void zoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneVisitorNumberUI zoneVisitorNumberUi = new ZoneVisitorNumberUI();
            zoneVisitorNumberUi.Show();
        }
    }
}
