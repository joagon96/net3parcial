using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Entidades
{
    public class Usuario
    {
        private int _ID { get; set; }
        private DateTime _UltimoIngreso { get; set; }
        private string _Clave { get; set; }
        private string _Email { get; set; }
        private string _NombreUsuario { get; set; }
        private int _TipoUsuario { get; set; }
        public int ID { get {return _ID; } set {_ID= value; } }
        public string Clave { get { return _Clave; } set { _Clave = value; } }
        public int DiasUltimoIngreso { get
            {
                DateTime Today = DateTime.Now;
                TimeSpan ts = Today - _UltimoIngreso;
                int dif = ts.Days;
                return dif;
            }
        }
        public string Email { get { return _Email; } set {_Email=value; } }
        public string NombreUsuario { get {return _NombreUsuario; } set {_NombreUsuario = value; } }
        public int TipoUsuario { get {return _TipoUsuario; } set {_TipoUsuario=value; } }
        public DateTime UltimoIngreso { get { return _UltimoIngreso; } set {_UltimoIngreso = value; } }
        public Usuario()
        {

        }
    }

}
