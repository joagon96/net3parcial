using Martin.Entidades;
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

namespace Martin.Desktop
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
            List<TipoPersona> tipos  = TipoPersonaNegocio.RecuperarTodos();
            foreach(var t in tipos)
            {
                this.tbTipoPersona.Items.Add(t.Id);
                
            }
            
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            if ( this.tbApellido.Text != null)
            {
                persona.Apellido = this.tbApellido.Text;
            }
            else
            {
                throw new Exception("Apellido invalido");
            }
            if (this.tbEmail.Text != null)
            {
                persona.EMail = this.tbEmail.Text;
            }
            else
            {
                throw new Exception("Email invalido");
            }
            if (this.tbNombre.Text != null)
            {
                persona.Nombre = this.tbNombre.Text;
            }
            else
            {
                throw new Exception("Nombre invalido");
            }
            if (this.tbFecha.Value != null)
            {
                bool bandera = Validaciones.EsFechaNacimientoValida(this.tbFecha.Value);
                if (bandera == true)
                {
                    persona.FechaNacimiento = this.tbFecha.Value;
                }
            }
            else
            {
                throw new Exception("Fecha invalida");
            }
            if (this.tbTipoPersona.SelectedItem != null)
            {
                persona.TipoPersona = Convert.ToInt32(this.tbTipoPersona.SelectedItem);
            }
            else
            {
                throw new Exception("Tipo persona invalido");
            }


            PersonaNegocio.Agregar(persona);
        }
    }
}
