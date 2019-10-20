using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class LogicaUsuario
    {
        public static List<Usuario> TraerTodos()
        {
            AdaptadorUsuario datos = new AdaptadorUsuario();
            return datos.TraerTodos();
        }

        public static bool Ingresar(string usuario, string clave)
        {
            AdaptadorUsuario datos = new AdaptadorUsuario();
            return datos.Ingresar(usuario, clave);
        }

        public static void Agregar(Usuario usuario)
        {
            AdaptadorUsuario datos = new AdaptadorUsuario();
            datos.Agregar(usuario);
        }
    }
}
