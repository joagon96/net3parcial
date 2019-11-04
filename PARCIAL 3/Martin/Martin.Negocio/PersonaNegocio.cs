using Martin.Datos;
using Martin.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Negocio
{
    public static class PersonaNegocio
    {
        public static List<Persona> RecuperarTodos()
        {
            PersonaData per = new PersonaData();
            return per.RecuperarTodos();
        }
        public static void Agregar(Persona persona)
        {
            PersonaData per = new PersonaData();
            per.Agregar(persona);
        }
        public static List<Persona> RecuperarPorTipoPersona(int id)
        {
            PersonaData tp = new PersonaData();
            return tp.RecuperarPorTipoPersona(id);
        }

    }
}
