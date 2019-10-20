using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utiles;
using Entidades;
using Negocio;

namespace Escritorio
{
    public partial class frmAlta : Form
    {
        public frmAlta()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Usuario usuario = mapearAUsuario();
                LogicaUsuario.Agregar(usuario);
                MessageBox.Show("Se agregó bien");
                this.Dispose();
            }
        }

        public bool Validar()
        {
            string mensaje = "";

            if(txtUsuario.Text.Length == 0 || txtClave.Text.Length == 0)
            {
                mensaje += ("Complete todos los campos." + "\n");
            }

            if (!Validaciones.EsMailValido(txtEmail.Text))
            {
                mensaje += ("El email no es valido" + "\n");
            }

            if (String.IsNullOrEmpty(mensaje))
            {
                return true;
            }
            else
            {
                MessageBox.Show(mensaje);
                return false;
            }
        }

        public Usuario mapearAUsuario()
        {
            Usuario usuario = new Usuario();

            usuario.NombreUsuario = txtUsuario.Text;
            usuario.Clave = txtClave.Text;
            usuario.Email = txtEmail.Text;
            usuario.TipoUsuario = Convert.ToInt32(txtTipoUsuario.Text);
            usuario.UltimoIngreso = dtpUltimoIngreso.Value.Date;

            return usuario;
        }
    }
}
