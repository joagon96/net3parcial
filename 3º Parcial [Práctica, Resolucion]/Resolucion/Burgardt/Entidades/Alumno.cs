using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        private string apellido = "";
        private string nombre = "";
        private int legajo = 0;
        private double promedio = 0;

        public string Apellido 
        {
            get { return apellido; }
            set { apellido = value;  }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre= value; }
        }

        public int Edad
        {
            get { return legajo; }
            set { legajo = value; }
        }
        
        public double Promedio
        {
            get { return promedio; }
            set { promedio = value; }
        }

        // Constructor
        public Alumno(int legajo, string apellido, string nombre, double promedio) 
        {
            Apellido = apellido; // Es lo mismo this.apellido = apellido
            this.nombre = nombre;
            this.legajo = legajo;
            this.promedio = promedio;
        }

    }
}
