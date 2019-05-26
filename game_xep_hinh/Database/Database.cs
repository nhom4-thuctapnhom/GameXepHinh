using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_xep_hinh.Database
{
    public class Database
    {
        private string _connectionString;

        public string ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }

        private SqlConnection _sqlCon;

        public SqlConnection SqlConnection
        {
            get { return _sqlCon; }
            set { _sqlCon = value; }
        }

        public Database()
        {
            string ConnectionString = System.Configuration.ConfigurationManager.AppSettings["chuoiketnoi"];
            SqlConnection = new SqlConnection(ConnectionString);
        }

        public void OpenConnection()
        {
            _sqlCon.Open();
        }

        public void CloseConnection()
        {
            _sqlCon.Close();
        }
    }
}
