using System;

namespace Basso.Entidades
{
    public class Alumno
    {
        private string _ApellidoNombre;
        private string _Dni;
        private int _Edad;
        private string _Email;
        private DateTime _FechaNacimiento;
        private int _Id;
        private decimal _NotaPromedio;

        public Alumno()
        {
                       //Sin parametros
        }
        public Alumno(string AN, string dni, string email, int id,DateTime fechanac, decimal prome)
        {
            this._ApellidoNombre = AN;
            this._Dni = dni;
            this._Email = email;
            this._Id = id;
            this._FechaNacimiento = fechanac;
            this._NotaPromedio = prome;
        }

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
                DateTime hoy = DateTime.Today;
                int edad = hoy.Year - FechaNacimiento.Year;
                if (hoy < FechaNacimiento.AddYears(edad)) edad--;
                return edad;
            }
        }
        public string Email
        {
            set { _Email = value; }
            get { return _Email; }
        }
        public DateTime FechaNacimiento
        {
            set { _FechaNacimiento = value; }
            get { return _FechaNacimiento; }
        }
        public int Id
        {
            set { _Id = value; }
            get { return _Id; }
        }
        public decimal NotaPromedio
        {
            set { _NotaPromedio = value; }
            get { return _NotaPromedio; }
        }


    }
}
