using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Basso.Entidades;

namespace Basso.Datos
{
    public class AlumnoDatos:Base
    {
        public List<Alumno> RecuperarTodos()
        {
            List<Alumno> alumnos = new List<Alumno>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdAlumno = new SqlCommand("Select * from Alumno", sqlCon);
                SqlDataReader drAlumnos = cmdAlumno.ExecuteReader();
                while (drAlumnos.Read())
                {
                    Alumno alum = new Alumno();
                    alum.Id = Convert.ToInt32(drAlumnos["Id"]);
                    alum.Dni = Convert.ToString(drAlumnos["dni"]);
                    alum.Email = Convert.ToString(drAlumnos["email"]);
                    alum.ApellidoNombre = Convert.ToString(drAlumnos["apenom"]);
                    alum.FechaNacimiento = Convert.ToDateTime(drAlumnos["fechaNac"]);
                    alum.NotaPromedio = Convert.ToDecimal(drAlumnos["notaProm"]);
                    alumnos.Add(alum);

                }
                drAlumnos.Close();
            }   
             catch(Exception ex)
            {
                Exception excepcion = new Exception("No se pudieron obtener los alumnos", ex);
                throw excepcion;
            }
            finally
            {
                this.CloseConnection();
            }
            return alumnos;
        }
        public void Add(Alumno alu)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdAlumno = new SqlCommand("Insert into" + "Alumno(Id,dni,email,apenom,fechaNac,notaProm" +
                    "VALUES (@Id,@dni,@email,@apenom,@fechaNac,@notaProm" + "SELECT @@identity@", sqlCon);
                cmdAlumno.Parameters.Add("@Id", SqlDbType.Int).Value = alu.Id;
                cmdAlumno.Parameters.Add("@dni", SqlDbType.VarChar,8).Value = alu.Dni;
                cmdAlumno.Parameters.Add("@email", SqlDbType.VarChar,50).Value = alu.Email;
                cmdAlumno.Parameters.Add("@apenom", SqlDbType.VarChar, 50).Value = alu.ApellidoNombre;
                cmdAlumno.Parameters.Add("@fechaNac", SqlDbType.DateTime).Value = alu.FechaNacimiento;
                cmdAlumno.Parameters.Add("@notaProm", SqlDbType.Decimal).Value = alu.NotaPromedio;
                alu.Id = (Int32)cmdAlumno.ExecuteScalar();
            }
            catch(Exception ex)
            {
                Exception excepcion = new Exception("no se pudo guardar el usuario", ex);
                throw excepcion;

            }
            finally
            {
                this.CloseConnection();
            }
        }
        /*public void Eliminar(string dni)
         {
             try
             {
                 this.OpenConnection();
                 SqlCommand cmdValida = new SqlCommand("SELECT dni FROM Alumno WHERE dni=@dni", sqlCon);
                 cmdValida.Parameters.Add("@dni", SqlDbType.VarChar, 50).Value = dni;
                 SqlDataReader drAlumnos = cmdValida.ExecuteReader();


                 drAlumnos.Close();


             }
             catch (Exception ex)
             {
                 Exception excepcion = new Exception("Error al eliminar el usuario", ex);
                 throw excepcion;
             }
             finally
             {
                 this.CloseConnection();
             }
         }*/
        public Alumno RecuperarUno(string dni)
        {
            Alumno alu = new Alumno();
            try
            {
                this.OpenConnection();
                SqlCommand cmdAlumnos = new SqlCommand("SELECT * FROM Alumnos WHERE dni=@dni", SqlCon);
                cmdAlumnos.Parameters.Add("@dni", SqlDbType.VarChar, 50).Value = dni;
                SqlDataReader drAlumnos = cmdAlumnos.ExecuteReader();
                while (drAlumnos.Read())
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
            catch (Exception ex)
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
