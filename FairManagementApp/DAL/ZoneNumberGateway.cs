using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementApp.MODEL;

namespace FairManagementApp.DAL
{
    public class ZoneNumberGateway
    {
        public string databaseConString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        public List<Zone> GetAllZoneVisitorNumberListBox()
        {
            SqlConnection connection = new SqlConnection(databaseConString);
            string query = "SELECT * FROM tbl_zone";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<Zone> zoneList = new List<Zone>();

            while (reader.Read())
            {
                Zone zones = new Zone();
                zones.ZoneId = int.Parse(reader["zone_id"].ToString());
                zones.ZoneName = reader["zone_name"].ToString();

                //Visitor visitors = new Visitor();
                //visitors.VisitorId = int.Parse(reader["visitor_id"].ToString());
                //visitors.VisitorName = reader["visitor_name"].ToString();
                //visitors.VisitorEmail = reader["visitor_email"].ToString();
                //visitors.ContactNumber = reader["visitor_contactNo"].ToString();
                //visitors.VisitorZoneId = reader["visitor_zoneId"].ToString();
                //visitors.visitorZoneName = reader["zone_name"].ToString();

                zoneList.Add(zones);
            }
            reader.Close();
            connection.Close();

            return zoneList;
        }
    }
}
