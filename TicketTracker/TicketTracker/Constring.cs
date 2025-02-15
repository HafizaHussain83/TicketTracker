using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace TicketTracker
{
    internal class Constring
    {
        public SqlConnection getCon()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TicketTrackerConStr"].ConnectionString);
            con.Open();
            return con;
        }

    }
}
