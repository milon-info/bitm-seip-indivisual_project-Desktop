using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementApp.MODEL;

namespace FairManagementApp.DAL
{
    public class VisitorEntryGateway
    {
        public string databaseConString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        public int Insert(Visitor visitors)
        {
            SqlConnection connection = new SqlConnection(databaseConString);
            string query = "INSERT INTO tbl_visitor VALUES ('" + visitors.VisitorName + "','" + visitors.VisitorEmail +
                           "','" + visitors.ContactNumber + "','" + visitors.VisitorZoneId + "')";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowAffected;
        }

        public Visitor GetVisitorEmail(string visitorEmail)
        {
            SqlConnection connection = new SqlConnection(databaseConString);
            string query = "SELECT * FROM tbl_visitor WHERE visitor_email = '" + visitorEmail + "'";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            Visitor visitors = null;

            while (reader.Read())
            {
                if (visitors == null)
                {
                    visitors = new Visitor();
                }
                visitors.VisitorId = int.Parse(reader["visitor_id"].ToString());
                visitors.VisitorEmail = reader["visitor_email"].ToString();
            }
            reader.Close();
            connection.Close();

            return visitors;
        }
    }
}
