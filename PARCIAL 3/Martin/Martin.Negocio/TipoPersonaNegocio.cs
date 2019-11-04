using Martin.Datos;
using Martin.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Negocio
{
    public static class TipoPersonaNegocio
    {
        public static List<TipoPersona> RecuperarTodos()
        {
            TipoPersonaData tp = new TipoPersonaData();
            return tp.RecuperarTodos();
        }

    }
}
