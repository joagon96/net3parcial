using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Entidades
{
    public class Persona
    {
        public string Apellido;
        public string EMail;
        public DateTime FechaNacimiento;
        public string Nombre;
        public int TipoPersona;
        public Persona(string apellido, string email, DateTime fechanacimiento, string nombre, int tipopersona)
        {
            this.Apellido = apellido;
            this.EMail = email;
            this.FechaNacimiento = fechanacimiento;
            this.Nombre = nombre;
            this.TipoPersona = tipopersona;
        }
        public Persona()
        {

        }
    }
}
