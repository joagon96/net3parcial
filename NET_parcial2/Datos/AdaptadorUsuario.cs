using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class AdaptadorUsuario : Adaptador
    {
        public List<Usuario> TraerTodos()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                AbrirConexion();
                SqlCommand cmdUsuarios = new SqlCommand("select * from usuarios", SqlCon);
                SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();
                while (drUsuarios.Read())
                {
                    Usuario usuarioact = new Usuario();
                    usuarioact.NombreUsuario = (string)drUsuarios["nombre"];
                    usuarioact.Clave = (string)drUsuarios["clave"];
                    usuarioact.Email = (string)drUsuarios["email"];
                    usuarioact.TipoUsuario = (int)drUsuarios["tipo_usuario"];
                    usuarioact.UltimoIngreso = (DateTime)drUsuarios["ultimo_ingreso"];
                    usuarios.Add(usuarioact);
                }
                drUsuarios.Close();
                return usuarios;
            }
            //catch (Exception ex)
            //{
            //    Exception ExcepcionManejada = new Exception("No se pudieron traer los usuarios", ex);
            //    throw ExcepcionManejada;
            //}
            finally
            {
                CerrarConexion();
            }
        }

        public bool Ingresar(string usuario, string clave)
        {
            try
            {
                AbrirConexion();
                SqlCommand cmdIngreso = new SqlCommand("select * from usuarios where nombre=@nombre and clave=@clave", SqlCon);
                cmdIngreso.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = usuario;
                cmdIngreso.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = clave;
                SqlDataReader drUsuario = cmdIngreso.ExecuteReader();
                if (drUsuario.Read())
                {
                    drUsuario.Close();
                    return true;
                }
                else
                {
                    drUsuario.Close();
                    return false;
                }
            }
            //catch (Exception ex)
            //{
            //    Exception ExcepcionManejada = new Exception("No existe el usuario", ex);
            //    throw ExcepcionManejada;
            //}
            finally
            {
                CerrarConexion();
            }
        }

        public void Agregar(Usuario usuario)
        {
            try
            {
                Usuario usuarito = new Usuario();
                AbrirConexion();
                SqlCommand cmdUsuarios = new SqlCommand("insert into usuarios" +
                    "(nombre, clave, email, tipo_usuario, ultimo_ingreso) " +
                    "values(@nombre, @clave, @email, @tipo_usuario, @ultimo_ingreso) " +
                    "select @@identity", SqlCon);

                cmdUsuarios.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
                cmdUsuarios.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = usuario.Clave;
                cmdUsuarios.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = usuario.Email;
                cmdUsuarios.Parameters.Add("@tipo_usuario", SqlDbType.Int).Value = usuario.TipoUsuario;
                cmdUsuarios.Parameters.Add("@ultimo_ingreso", SqlDbType.Date).Value = usuario.UltimoIngreso;
                cmdUsuarios.ExecuteReader();
            }
            //catch (Exception ex)
            //{
            //    Exception ExcepcionManejada = new Exception("No se pudieron traer los usuarios", ex);
            //    throw ExcepcionManejada;
            //}
            finally
            {
                CerrarConexion();
            }
        }
    }
}
