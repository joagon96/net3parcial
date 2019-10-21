using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Specialized;

namespace Basso.Datos
{
    public class Base
    {

        private SqlConnection _sqlCon;
       

        public SqlConnection sqlCon { get { return _sqlCon; } set { _sqlCon = value; } }


        protected void OpenConnection()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings[conKey].ConnectionString;
            sqlCon = new SqlConnection(ConnectionString);
            sqlCon.Open();

        }
        protected void CloseConnection()
        {
            sqlCon.Close();
            sqlCon = null;
        }
        const string conKey = "NetGenerica";
    }
}
