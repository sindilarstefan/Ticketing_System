using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ATM_Tiketing
{
    internal class BazaDate
    {
        private static BazaDate instance = null;
        private SqlConnection con;

        private BazaDate()
        {
            con = new SqlConnection();
        }

        public static BazaDate GetInstance()
        {
            if (instance == null)
            {
                instance = new BazaDate();
            }
            return instance;
        }

        public SqlConnection getCon()
        {
            con.ConnectionString = "Server=.;Database=test_ts;Trusted_Connection=true";
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            else if (con.State == System.Data.ConnectionState.Broken)
            {
                con.Close();
                con.Open();
            }
            return con;
        }

        public void closeCon()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
                con.Dispose();
            }
        }
    }
}
