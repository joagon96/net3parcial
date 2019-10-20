using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private DateTime _UltimoIngreso;
        private string _Clave, _Email, _NombreUsuario;
        private int _TipoUsuario;

        #region CONSTRUCTORES
        public Usuario()
        {
            //Constructor sin parámetros
        }

        public Usuario(string nombreUsuario, string email, string clave, int tipoUsuario, DateTime ultimoIng)
        {
            this.NombreUsuario = nombreUsuario;
            this.Clave = clave;
            this.Email = email;
            this.TipoUsuario = tipoUsuario;
            this.UltimoIngreso = ultimoIng;
        }
        #endregion

        #region PROPIEDADES
        public int DiasUltimoIngreso
        {
            get
            {
                int difDias = DateTime.Today.Day - UltimoIngreso.Day;
                return difDias;
            }
        }

        public DateTime UltimoIngreso
        {
            get
            {
                return _UltimoIngreso;
            }

            set
            {
                _UltimoIngreso = value;
            }
        }

        public string Clave
        {
            get
            {
                return _Clave;
            }

            set
            {
                _Clave = value;
            }
        }

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

        public string NombreUsuario
        {
            get
            {
                return _NombreUsuario;
            }

            set
            {
                _NombreUsuario = value;
            }
        }

        public int TipoUsuario
        {
            get
            {
                return _TipoUsuario;
            }

            set
            {
                _TipoUsuario = value;
            }
        } 
        #endregion

        public enum TiposUsuarios
        {
            SuperAdmin,
            ConPocosPrivilegios,
            Invitado
        }
    }
}
