using Martin.Datos;
using Martin.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Negocio
{
    public class AlumnoLogic
    {
        public AlumnoAdapter alumnoAdapter
        {
            get
            {
                return _alumnoAdapter;
            }
            set
            {
                _alumnoAdapter=value;
            }
        }
        private AlumnoAdapter _alumnoAdapter { get; set; }
        public AlumnoLogic()
        {
            alumnoAdapter = new AlumnoAdapter();
        }
        public List<Alumno> RecuperarTodos()
        {
            try
            {
                return alumnoAdapter.RecuerarTodos();
            }
            catch(Exception ex)
            {
                Exception exception = new Exception("Error", ex);
                throw exception;
            }
        }
        public Alumno RecuperarUno(string name)
        {
            try
            {
                return alumnoAdapter.RecuperarUno(name);
            }
            catch(Exception ex)
            {
                Exception exception = new Exception("Error", ex);
                throw exception;
            }
        }
    }
}
