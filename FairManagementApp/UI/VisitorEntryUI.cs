using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using FairManagementApp.BLL;
using FairManagementApp.MODEL;

namespace FairManagementApp
{
    public partial class VisitorEntryUI : Form
    {
        public VisitorEntryUI()
        {
            InitializeComponent();
        }
        VisitorEntryManager visitorEntryManager = new VisitorEntryManager();
        ZoneEntryManager zoneEntryManager = new ZoneEntryManager();
        Zone zones = new Zone();
        private string visitorEmail = "";
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (visitorNameTextBox.Text == "" || visitorEmailTextBox.Text == "" || contactNumberTextBox.Text == "")
            {
                MessageBox.Show("All fields are required!");
            }

            else
            {
                Visitor visitors = new Visitor();

                visitors.VisitorName = visitorNameTextBox.Text;
                visitors.VisitorEmail = visitorEmailTextBox.Text;
                visitors.ContactNumber = contactNumberTextBox.Text;

                string selectZoneId = "";
                foreach (Zone item in zoneCheckedListBox.CheckedItems)
                {
                    selectZoneId += item.ZoneId.ToString() + ",";
                }

                visitors.VisitorZoneId = selectZoneId;

                MessageBox.Show(visitorEntryManager.Save(visitors));
            }
        }

        public void ClearAllTextBoxes()
        {
            visitorNameTextBox.Text = string.Empty;
            visitorEmailTextBox.Text = string.Empty;
            contactNumberTextBox.Text = string.Empty;
        }

        public void LoadAllZonesCheckedListView()
        {
            List<Zone> zoneList = zoneEntryManager.GetAllZonesCheckedListView();

            zoneCheckedListBox.DataSource = null;
            zoneCheckedListBox.DataSource = zoneList;

            zoneCheckedListBox.DisplayMember = "ZoneName";
            zoneCheckedListBox.ValueMember = "ZoneId";

        }

        private void VisitorEntryUI_Load(object sender, EventArgs e)
        {
            LoadAllZonesCheckedListView();
        }
        
    }
}
