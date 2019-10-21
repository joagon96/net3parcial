using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Datos
{
    public class Base
    {
        private SqlConnection _sqlConn { get; set; }
        public SqlConnection sqlConn { get {return _sqlConn; } set { _sqlConn = value; } }

        protected void OpenConnection()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings[conKey].ConnectionString;
            sqlConn = new SqlConnection(ConnectionString);
            sqlConn.Open();
        }
        protected void CloseConnection()
        {
            sqlConn.Close();
            sqlConn = null;
        }
        const string conKey = "ConnStringExpress";

    }
}
