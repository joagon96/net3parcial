using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Basso.Negocio;
using Basso.Entidades;
using Basso.Datos;

namespace Basso.Escritorio
{
    public partial class frmListado : Form
    {
        public frmListado()
        {
            InitializeComponent();
            AlumnoLogic logic = new AlumnoLogic();
            var alumnos = logic.RecuperarTodos();
            foreach(var alu in alumnos)
            {
                this.comboBox1.Items.Add(alu.Dni);
               // this.comboBox1.Items.Add(alu.ApellidoNombre); 
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AlumnoLogic logic = new AlumnoLogic();
            var alumno = logic.RecuperarUno(Convert.ToString(this.comboBox1.SelectedItem));
            this.textBox1.Text = "Apellido y nombre:" + alumno.ApellidoNombre +
                "\n Dni:" + alumno.Dni +
                "\n Edad:" + alumno.Edad +
                "\n Email:" + alumno.Email +
                "\n Fecha Nacimiento:" + alumno.FechaNacimiento +
                "\n Id:" + alumno.Id +
                "\n Nota Promedio:" + alumno.NotaPromedio;
        }
    }
}
