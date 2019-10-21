using Martin.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Datos
{
    public class UsuarioData : Base
    {
        public List<Usuario> RecuperarTodos()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdUsuario = new SqlCommand("SELECT * FROM Usuario", sqlConn);
                SqlDataReader drUsuarios = cmdUsuario.ExecuteReader();
                while (drUsuarios.Read())
                {
                    Usuario usr = new Usuario();
                    usr.ID = Convert.ToInt32(drUsuarios["Id_usuario"]);
                    usr.Clave = Convert.ToString(drUsuarios["clave"]);
                    usr.Email = Convert.ToString(drUsuarios["email"]);
                    usr.NombreUsuario = Convert.ToString(drUsuarios["nombre_usuario"]);
                    usr.TipoUsuario = Convert.ToInt32(drUsuarios["tipo_usuario"]);
                    usr.UltimoIngreso = Convert.ToDateTime(drUsuarios["ultimo_ingreso"]);
                    usuarios.Add(usr);
                }
                drUsuarios.Close(); 
            }
            catch(Exception ex)
            {
                Exception excepcion = new Exception("No se pudieron obtener los usuarios", ex);
                throw excepcion;
            }
            finally
            {
                this.CloseConnection();
            }
            return usuarios;
        }
        public void Agregar(Usuario usu)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUsuario = new SqlCommand("INSERT INTO " +
                    "Usuario (clave,email,nombre_usuario,tipo_usuario,ultimo_ingreso)" +
                    "VALUES (@clave,@email,@nombre_usuario,@tipo_usuario,@ultimo_ingreso) " +
                    "SELECT @@identity ", sqlConn);
                cmdUsuario.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = usu.Clave;
                cmdUsuario.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = usu.Email;
                cmdUsuario.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usu.NombreUsuario;
                cmdUsuario.Parameters.Add("@tipo_usuario", SqlDbType.Int).Value = usu.TipoUsuario;
                cmdUsuario.Parameters.Add("@ultimo_ingreso", SqlDbType.DateTime).Value = usu.UltimoIngreso;
                usu.ID = Decimal.ToInt32((decimal)cmdUsuario.ExecuteScalar());
            }
            catch(Exception ex) 
            {
                Exception excepcion = new Exception("No se pudo guardar el usuario", ex);
                throw excepcion;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public void Eliminar(string nombre)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdValida = new SqlCommand("SELECT tipo_usuario FROM Usuario WHERE nombre_usuario=@nombre_usuario", sqlConn);
                cmdValida.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = nombre;
                SqlDataReader drUsuarios = cmdValida.ExecuteReader();
                int tipo = 0;
                while(drUsuarios.Read())
                {
                    tipo = Convert.ToInt32(drUsuarios["tipo_usuario"]);

                }drUsuarios.Close();
                
                if (tipo == 1)
                {
                    Exception exception = new Exception("Tipo 1");
                    throw exception;
                }
                else
                {
                    SqlCommand cmdUsuario = new SqlCommand("DELETE Usuario WHERE nombre_usuario=@nombre_usuario", sqlConn);
                    cmdUsuario.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = nombre;
                    cmdUsuario.ExecuteNonQuery();
                }

            }
            catch(Exception ex)
            {
                Exception excepcion = new Exception("Error al eliminar el usuario", ex);
                throw excepcion;
            }
            finally
            {
                this.CloseConnection();
            }
        }
    }
}
