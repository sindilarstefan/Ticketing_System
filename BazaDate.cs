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
        private SqlConnection _con;

        private BazaDate()
        {
            _con = new SqlConnection();
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
            _con.ConnectionString = "Server=.;Database=test_ts;Trusted_Connection=true";
            if (_con.State == System.Data.ConnectionState.Closed)
            {
                _con.Open();
            }
            else if (_con.State == System.Data.ConnectionState.Broken)
            {
                _con.Close();
                _con.Open();
            }
            return _con;
        }

        public void closeCon()
        {
            if (_con.State == System.Data.ConnectionState.Open)
            {
                _con.Close();
                _con.Dispose();
            }
        }
    }
}
