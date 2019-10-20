using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;
using Utiles;

namespace Escritorio
{
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text.Length == 0 || txtContraseña.Text.Length == 0)
            {
                MessageBox.Show("Complete ambos campos");
            }
            else
            {
                if (LogicaUsuario.Ingresar(txtUsuario.Text.Trim(), txtContraseña.Text.Trim()))
                {
                    MessageBox.Show("Ingreso correcto");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecto/s");
                }
            }
        }
    }
}
