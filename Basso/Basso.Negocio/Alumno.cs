using System;
using Basso.Datos;
using Basso.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basso.Negocio

{
    public class AlumnoLogic
    {
        private AlumnoDatos _aluData;
        public AlumnoDatos aluData { get { return _aluData; } set { _aluData = value; } }
        public AlumnoLogic()
        {
            aluData = new AlumnoDatos();
        }
        public  List<Alumno> RecuperarTodos()//estaticos?
        {
            try
            {
                return aluData.RecuperarTodos();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void Agregar(Alumno alu) {//estaticos???
            try{
                aluData.Add(alu);
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
        /*public void Eliminar(string dni)
        {
            try
            {
                aluData.Eliminar(dni);
            }
            catch(Exception ex)
            {
                throw ex;
            }


        }*/
        public Alumno RecuperarUno(string dni)
        {
            try
            {
                return aluData.RecuperarUno(dni);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}
