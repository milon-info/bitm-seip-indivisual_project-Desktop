using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairManagementApp.BLL;
using FairManagementApp.MODEL;

namespace FairManagementApp.UI
{
    public partial class ZoneEntryUI : Form
    {
        public ZoneEntryUI()
        {
            InitializeComponent();
        }

        ZoneEntryManager zoneEntryManager = new ZoneEntryManager();

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (zoneCodeTextBox.Text == "" || zoneNameTextBox.Text == "")
            {
                MessageBox.Show("All fields are required!");
            }
            else
            {
                Zone zones = new Zone();
                zones.ZoneCode = zoneCodeTextBox.Text;
                zones.ZoneName = zoneNameTextBox.Text;

                MessageBox.Show(zoneEntryManager.Save(zones));
                ClearAllTextBoxes();
                LoadAllZonesListView();
            }
        }

        public void ClearAllTextBoxes()
        {
            zoneCodeTextBox.Text = string.Empty;
            zoneNameTextBox.Text = string.Empty;
        }

        public void LoadAllZonesListView()
        {
            List<Zone> zoneList = zoneEntryManager.GetAllZones();

            zoneDisplayListView.Items.Clear();
            foreach (var zone in zoneList)
            {
                ListViewItem listViewItem = new ListViewItem(zone.ZoneCode);
                listViewItem.SubItems.Add(zone.ZoneName);

                listViewItem.Tag = zone;

                zoneDisplayListView.Items.Add(listViewItem);
            }
        }
        private void ZoneEntryUI_Load(object sender, EventArgs e)
        {
            LoadAllZonesListView();
        }
    }
}
