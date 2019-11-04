using Martin.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Datos
{
    public class TipoPersonaData
    {
        public List<TipoPersona> RecuperarTodos()
        {
            List<TipoPersona> tiposPersona = new List<TipoPersona>();
            TipoPersona persona1 = new TipoPersona(1, "Alumno");
            TipoPersona persona2 = new TipoPersona(2, "Profesor");
            tiposPersona.Add(persona1);
            tiposPersona.Add(persona2);
            return tiposPersona;
        }

    }
}
