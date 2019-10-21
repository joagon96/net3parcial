using Martin.Datos;
using Martin.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Negocio
{
    public class UsuarioLogic
    {
        private UsuarioData _usuData;
        public UsuarioData usuData { get {return _usuData; } set {_usuData = value; } }
        public UsuarioLogic()
        {
            usuData = new UsuarioData();
        }
        public List<Usuario> RecuperarTodos()
        {
            try
            {
                return usuData.RecuperarTodos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Agregar(Usuario usu)
        {
            try
            {
                usuData.Agregar(usu);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void Eliminar(string nombre)
        {
            try
            {
                usuData.Eliminar(nombre);
            }
            catch(Exception ex)
            {
                throw ex;
            }


        }
            
    }
}
