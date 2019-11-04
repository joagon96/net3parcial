using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Datos
{
    public class Base
    {
        public SqlConnection sqlConn;
        public Base()
        {
            
        }

        public void OpenConnection()
        {
            sqlConn = new SqlConnection();
            sqlConn.ConnectionString = "Data Source=DESKTOP-QPP4BNK\\SQLEXPRESS;Database=NetGenerica;Integrated Security=True";
            sqlConn.Open();
        }
        public void CloseConnection()
        {
            sqlConn.Close();
        }
    }
}
