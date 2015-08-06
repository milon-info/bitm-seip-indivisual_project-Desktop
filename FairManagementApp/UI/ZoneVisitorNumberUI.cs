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
    public partial class ZoneVisitorNumberUI : Form
    {
        public ZoneVisitorNumberUI()
        {
            InitializeComponent();
        }
        ZoneNumberManager zoneNumberManager = new ZoneNumberManager();
        ZoneDetailManager zoneDetailManager = new ZoneDetailManager();
        private int zoneVisitorNumberId = 0;
        public void LoadAllZoneVisitorNumberListBox()
        {
            List<Zone> zoneList = zoneNumberManager.GetAllZoneVisitorNumberListBox();
            zoneVisitorNumberListView.Items.Clear();
            int totalVisitor = 0;
            foreach (var zones in zoneList)
            {
                zoneVisitorNumberId = zones.ZoneId;
                List<Visitor> visitorList = zoneDetailManager.GetAllZoneVisitorNumber(zoneVisitorNumberId);
                int zoneVisitor = 0;
                foreach (var visitor in visitorList)
                {
                    zoneVisitor++;
                }

                int totalZoneVisitor = zoneVisitor;
 
                ListViewItem listViewItem = new ListViewItem(zones.ZoneName);
                listViewItem.SubItems.Add(totalZoneVisitor.ToString());

                listViewItem.Tag = zones;

                zoneVisitorNumberListView.Items.Add(listViewItem);
                totalVisitor += totalZoneVisitor;
            }

            totalVisitorTextBox.Text = totalVisitor.ToString();
        }

        private void ZoneVisitorNumberUI_Load(object sender, EventArgs e)
        {
            LoadAllZoneVisitorNumberListBox();
        }
    }
}
