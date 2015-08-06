using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementApp.DAL;
using FairManagementApp.MODEL;

namespace FairManagementApp.BLL
{
    public class ZoneNumberManager
    {
        ZoneNumberGateway zoneNumberGateway = new ZoneNumberGateway();
        public List<Zone> GetAllZoneVisitorNumberListBox()
        {
            return zoneNumberGateway.GetAllZoneVisitorNumberListBox();
        }
    }
}
