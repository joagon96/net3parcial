using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Datos
{
    public class Conexion
    {
        public SqlConnection SqlConn
        {
            get
            {
                return _SqlConn;
            }
            set
            {
                _SqlConn = value;
            }
        }
        private SqlConnection _SqlConn { get; set; }

        protected void OpenConnection()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings[conKey].ConnectionString;
            SqlConn = new SqlConnection(ConnectionString);
            SqlConn.Open();

        }
        protected void CloseConnection()
        {
            SqlConn.Close();
            SqlConn = null;
        }
        const string conKey = "ConnStringExpress";
    }
}
