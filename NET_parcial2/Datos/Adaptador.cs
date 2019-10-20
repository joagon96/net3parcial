using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace Datos
{
    public class Adaptador
    {
        private SqlConnection sqlCon;
        const string conPorDef = "ConexionLocal";

        public SqlConnection SqlCon
        {
            get
            {
                return sqlCon;
            }

            set
            {
                sqlCon = value;
            }
        }

        protected void AbrirConexion()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings[conPorDef].ConnectionString;
            SqlCon = new SqlConnection(cadenaConexion);
            SqlCon.Open();
        }

        protected void CerrarConexion()
        {
            SqlCon.Close();
            SqlCon = null;
        }
    }
}
