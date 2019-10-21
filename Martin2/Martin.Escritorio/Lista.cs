using Martin.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Martin.Escritorio
{
    public partial class Lista : Form
    {
        public Lista()
        {
            InitializeComponent();
            AlumnoLogic logic = new AlumnoLogic();
            var alumnos = logic.RecuperarTodos();
            foreach(var alu in alumnos)
            {
                this.CbAlumnos.Items.Add(alu.ApellidoNombre);
            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (this.CbAlumnos.SelectedIndex > -1)
            {
                AlumnoLogic logic = new AlumnoLogic();
                var alumno = logic.RecuperarUno(Convert.ToString(this.CbAlumnos.SelectedItem));
                this.textBox1.Text =  "Apellido y nombre:" +alumno.ApellidoNombre+
                    "\n Dni:" + alumno.Dni+
                    "\n Edad:" + alumno.Edad+
                    "\n Email:" + alumno.Email+
                    "\n Fecha Nacimiento:" + alumno.FechaNacimiento+
                    "\n Id:" + alumno.Id+
                    "\n Nota Promedio:" + alumno.NotaPromedio;
            }
        }
    }
}
