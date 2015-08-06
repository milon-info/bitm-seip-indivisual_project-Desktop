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
    public class ZoneEntryGateway
    {
        public string databaseConString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        public int Save(Zone zones)
        {
            SqlConnection connection = new SqlConnection(databaseConString);
            string query = "INSERT INTO tbl_zone VALUES ('" + zones.ZoneCode + "','" + zones.ZoneName + "')";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowAffected;
        }

        public List<Zone> GetAllZones()
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
                zones.ZoneCode = reader["zone_code"].ToString();
                zones.ZoneName = reader["zone_name"].ToString();

                zoneList.Add(zones);
            }
            reader.Close();
            connection.Close();

            return zoneList;
        }

        public List<Zone> GetAllZonesCheckedListView()
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
                zones.ZoneCode = reader["zone_code"].ToString();
                zones.ZoneName = reader["zone_name"].ToString();

                zoneList.Add(zones);
            }
            reader.Close();
            connection.Close();

            return zoneList;
        }

        public Zone GetZoneCodeAndName(string zoneCode, string zoneName)
        {
            SqlConnection connection = new SqlConnection(databaseConString);
            string query = "SELECT * FROM tbl_zone WHERE zone_code = '" + zoneCode + "' OR zone_name = '" + zoneName +
                           "'";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            Zone zones = null;

            while (reader.Read())
            {
                if (zones == null)
                {
                    zones = new Zone();
                }
                zones.ZoneCode = reader["zone_code"].ToString();
                zones.ZoneName = reader["zone_name"].ToString();
            }
            reader.Close();
            connection.Close();

            return zones;
        }
    }
}
