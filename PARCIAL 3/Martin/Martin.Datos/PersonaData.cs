using Martin.Datos;
using Martin.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Martin.Datos
{
    public class PersonaData : Base
    {
        public List<Persona> RecuperarTodos()
        {
            this.OpenConnection();
            List<Persona> personas = new List<Persona>();
            SqlCommand cmdPersona = new SqlCommand("select * from personas", sqlConn);
            SqlDataReader drPersona = cmdPersona.ExecuteReader();
            while (drPersona.Read())
            {
                Persona per = new Persona();
                per.Apellido = Convert.ToString(drPersona["apellido"]);
                per.EMail = Convert.ToString(drPersona["email"]);
                per.FechaNacimiento = Convert.ToDateTime(drPersona["fecha_nacimiento"]);
                per.Nombre = Convert.ToString(drPersona["nombre"]);
                per.TipoPersona = Convert.ToInt32(drPersona["tipo_persona"]);
                personas.Add(per);
            }
            drPersona.Close();
            this.CloseConnection();
            return personas;
        }
        public void Agregar(Persona per)
        {
            this.OpenConnection();
            SqlCommand cmdPersona = new SqlCommand("insert into personas " +
                "(apellido,email,fecha_nacimiento,nombre,tipo_persona) " +
                "values(@apellido,@email,@fecha_nacimiento,@nombre,@tipo_persona) " +
                "select @@identity", sqlConn);
            cmdPersona.Parameters.Add("@apellido", System.Data.SqlDbType.VarChar, 50).Value = per.Apellido;
            cmdPersona.Parameters.Add("@email", System.Data.SqlDbType.VarChar, 50).Value = per.EMail;
            cmdPersona.Parameters.Add("@fecha_nacimiento", System.Data.SqlDbType.DateTime).Value = per.FechaNacimiento;
            cmdPersona.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar, 50).Value = per.Nombre;
            cmdPersona.Parameters.Add("@tipo_persona", System.Data.SqlDbType.Int).Value = per.TipoPersona;
            cmdPersona.ExecuteNonQuery();
            this.CloseConnection();
        }
        public List<Persona> RecuperarPorTipoPersona(int id)
        {
            this.OpenConnection();
            List<Persona> personas = new List<Persona>();
            SqlCommand cmdPersona = new SqlCommand("select * from personas where tipo_persona=@id_persona", sqlConn);
            cmdPersona.Parameters.Add("@id_persona", System.Data.SqlDbType.Int).Value = id;
            SqlDataReader drPersona = cmdPersona.ExecuteReader();
            while(drPersona.Read())
            {
                Persona per = new Persona();
                per.Apellido = Convert.ToString(drPersona["apellido"]);
                per.EMail = Convert.ToString(drPersona["email"]);
                per.FechaNacimiento = Convert.ToDateTime(drPersona["fecha_nacimiento"]);
                per.Nombre = Convert.ToString(drPersona["nombre"]);
                per.TipoPersona = Convert.ToInt32(drPersona["tipo_persona"]);
                personas.Add(per);
            }
            drPersona.Close();
            this.CloseConnection();
            return personas;
            
        }
    }
}
