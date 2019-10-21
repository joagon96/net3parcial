using Martin.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Datos
{
    public class AlumnoAdapter : Conexion
    {
        public List<Alumno> RecuerarTodos()
        {
            List<Alumno> alumnos = new List<Alumno>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdAlumnos = new SqlCommand("SELECT * FROM Alumnos", SqlConn);
                SqlDataReader drAlumnos = cmdAlumnos.ExecuteReader();
                while (drAlumnos.Read())
                {
                    Alumno alu = new Alumno();
                    alu.Id = Convert.ToInt32(drAlumnos["id_alumno"]);
                    alu.ApellidoNombre = Convert.ToString(drAlumnos["apellido_nombre"]);
                    alu.Dni = Convert.ToString(drAlumnos["dni"]);
                    alu.Email = Convert.ToString(drAlumnos["email"]);
                    alu.FechaNacimiento = Convert.ToDateTime(drAlumnos["fecha_nacimiento"]);
                    alu.NotaPromedio = Convert.ToDecimal(drAlumnos["nota_promedio"]);
                    alumnos.Add(alu);
                }
                drAlumnos.Close();

            }
            catch (Exception ex)
            {
                Exception exception = new Exception("Error al recuperar alumnos",ex );
                throw exception;
            }
            finally
            {
                this.CloseConnection();
            }
            return alumnos;
        }
        public Alumno RecuperarUno(string name)
        {
            Alumno alu = new Alumno();
            try
            {
                this.OpenConnection();
                SqlCommand cmdAlumnos = new SqlCommand("SELECT * FROM Alumnos WHERE apellido_nombre=@apellido_nombre",SqlConn);
                cmdAlumnos.Parameters.Add("@apellido_nombre", SqlDbType.VarChar, 50).Value = name;
                SqlDataReader drAlumnos = cmdAlumnos.ExecuteReader();
                while(drAlumnos.Read())
                {
                    alu.Id = Convert.ToInt32(drAlumnos["id_alumno"]);
                    alu.ApellidoNombre = Convert.ToString(drAlumnos["apellido_nombre"]);
                    alu.Dni = Convert.ToString(drAlumnos["dni"]);
                    alu.Email = Convert.ToString(drAlumnos["email"]);
                    alu.FechaNacimiento = Convert.ToDateTime(drAlumnos["fecha_nacimiento"]);
                    alu.NotaPromedio = Convert.ToDecimal(drAlumnos["nota_promedio"]);
                }
                drAlumnos.Close();
            }
            catch(Exception ex)
            {
                Exception exception = new Exception("Error", ex);
                throw exception;
            }
            finally
            {
                this.CloseConnection();
            }
            return alu;
        }

    }
}
