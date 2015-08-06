using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementApp.DAL;
using FairManagementApp.MODEL;

namespace FairManagementApp.BLL
{
    public class VisitorEntryManager
    {
        VisitorEntryGateway visitorEntryGateway = new VisitorEntryGateway();
        public string Save(Visitor visitors)
        {
            bool checkVisitorEmail = IsCheckVisitorEmail(visitors.VisitorEmail);
            if (checkVisitorEmail)
            {
                return "Email Allready Exists!";
            }
            if (visitorEntryGateway.Insert(visitors) > 0)
            {
                return "Added Successfully!";
            }
            else
            {
                return "Could Not Added";
            }
        }

        private bool IsCheckVisitorEmail(string visitorEmail)
        {
            Visitor isVisitorEmail = visitorEntryGateway.GetVisitorEmail(visitorEmail);
            if (isVisitorEmail != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
