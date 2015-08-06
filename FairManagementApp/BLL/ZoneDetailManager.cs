using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementApp.DAL;
using FairManagementApp.MODEL;

namespace FairManagementApp.BLL
{
    public class ZoneDetailManager
    {
        ZoneDetailGateway zoneDetailGateway = new ZoneDetailGateway();
        public List<Zone> GetAllZoneByComboBox()
        {
            return zoneDetailGateway.GetAllZoneByComboBox();
        }

        public List<Visitor> LoadAllZoneDetailListView(int visitorZoneId)
        {
            return zoneDetailGateway.LoadAllZoneDetailListView(visitorZoneId);
        }

        public List<Visitor> GetAllZoneVisitorNumber(int zoneVisitorNumberId)
        {
            return zoneDetailGateway.GetAllZoneVisitorNumber(zoneVisitorNumberId);
        }
    }
}
