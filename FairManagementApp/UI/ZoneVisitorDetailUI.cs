using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FairManagementApp.BLL;
using FairManagementApp.MODEL;
using Microsoft.Office.Interop.Excel;

namespace FairManagementApp.UI
{
    public partial class ZoneVisitorDetailUI : Form
    {
        public ZoneVisitorDetailUI()
        {
            InitializeComponent(); 
        }
        ZoneDetailManager zoneDetailManager = new ZoneDetailManager();
        Zone zones = new Zone();
        public int visitorZoneId = 0;
        private void showButton_Click(object sender, EventArgs e)
        {
            zones.ZoneId = int.Parse(selectZoneComboBox.SelectedValue.ToString());
            visitorZoneId = zones.ZoneId;

            List<Visitor> visitorList = zoneDetailManager.LoadAllZoneDetailListView(visitorZoneId);

            zoneDetailDisplayListView.Items.Clear();
            int totalZoneVisitor = 0;
            foreach (var visitor in visitorList)
            {
                ListViewItem listViewItem = new ListViewItem(visitor.VisitorName);
                listViewItem.SubItems.Add(visitor.VisitorEmail);
                listViewItem.SubItems.Add(visitor.ContactNumber);

                listViewItem.Tag = visitor;

                zoneDetailDisplayListView.Items.Add(listViewItem);
                totalZoneVisitor++;
            }

            totalZoneVisitorTextBox.Text = totalZoneVisitor.ToString();
        }
        public void LoadAllZoneByComboBox()
        {
            List<Zone> zoneList = zoneDetailManager.GetAllZoneByComboBox();

            selectZoneComboBox.DisplayMember = "ZoneName";
            selectZoneComboBox.ValueMember = "ZoneId";
            selectZoneComboBox.DataSource = null;
            selectZoneComboBox.DataSource = zoneList;
        }

        private void ZoneVisitorDetailUI_Load(object sender, EventArgs e)
        {
            LoadAllZoneByComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(1);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];
            int i = 1;
            int i2 = 1;
            foreach (ListViewItem lvi in zoneDetailDisplayListView.Items)
            {
                i = 1;
                foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
                {
                    ws.Cells[i2, i] = lvs.Text;
                    i++;
                }
                i2++;

            }
        }
    }
}

