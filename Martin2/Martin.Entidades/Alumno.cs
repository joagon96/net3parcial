using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Entidades
{
    public class Alumno
    {
        private string _ApellidoNombre { get; set; }
        public string ApellidoNombre
        {
            get
            {
                return _ApellidoNombre;
            }
            set
            {
                _ApellidoNombre = value;
            }
        }
        private string _Dni { get; set; }
        public string Dni
        {
            get
            {
                return _Dni;
            }
            set
            {
                _Dni = value;
            }
        }
        public int Edad
        {
            get
            {
                DateTime zeroTime = new DateTime(1, 1, 1);
                DateTime dt = DateTime.Now;
                TimeSpan ts = dt - FechaNacimiento;
                int years = (zeroTime + ts).Year - 1;
                return years;
            }
        }
        private string _Email { get; set; }
        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
            }
        }
        private DateTime _FechaNacimiento { get; set; }
        public DateTime FechaNacimiento
        {
            get
            {
                return _FechaNacimiento;
            }
            set
            {
                _FechaNacimiento = value;
            }
        }
        private int _Id { get; set; }
        public int Id
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
            }

        }
        private decimal _NotaPromedio { get; set; }
        public decimal NotaPromedio
        {
            get
            {
                return _NotaPromedio;
            }
            set
            {
                _NotaPromedio = value;
            }
        }
        public Alumno()
        {

        }
    }
}
