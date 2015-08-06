using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementApp.DAL;
using FairManagementApp.MODEL;

namespace FairManagementApp.BLL
{
    public class ZoneEntryManager
    {
        ZoneEntryGateway zoneEntryGateway = new ZoneEntryGateway();
        public string Save(Zone zones)
        {
            bool checkZoneCodeAndName = IsZoneCodeAndNameExists(zones.ZoneCode,zones.ZoneName);
            if (checkZoneCodeAndName)
            {
                return "Zone Allready Exists!";
            }

            if (zoneEntryGateway.Save(zones) > 0)
            {
                return "Added Successfully!";
            }
            else
            {
                return "Could Not Added!";
            }
        }

        private bool IsZoneCodeAndNameExists(string zoneCode, string zoneName)
        {
            Zone IsZoneCodeAndName = zoneEntryGateway.GetZoneCodeAndName(zoneCode, zoneName);
            if (IsZoneCodeAndName != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Zone> GetAllZones()
        {
            return zoneEntryGateway.GetAllZones();
        }

        public List<Zone> GetAllZonesCheckedListView()
        {
            return zoneEntryGateway.GetAllZonesCheckedListView();
        }
    }
}
