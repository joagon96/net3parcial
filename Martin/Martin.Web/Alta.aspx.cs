using Martin.Entidades;
using Martin.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Martin.Web
{
    public partial class Alta : System.Web.UI.Page
    {
        public UsuarioLogic _logic { get; set; }
        private UsuarioLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new UsuarioLogic();
                }
                return _logic;
            }
        }
        private Usuario Entity { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            this.usuarioDD.Items.Add("Administrador");
            this.usuarioDD.Items.Add("Supervisor");
            this.usuarioDD.Items.Add("Invitado");
        }
        private void LoadEntity(Usuario usuario)
        {
            usuario.NombreUsuario = this.NombreUsuarioTB.Text;
            usuario.UltimoIngreso = Convert.ToDateTime(this.UltimoIngresoTB.Text);
            usuario.Email = this.EmailTB.Text;
            usuario.Clave = this.ClaveTB.Text;
            switch(this.usuarioDD.SelectedValue)
            {
                case "Administrador":
                    usuario.TipoUsuario = 1;
                    break;
                case "Supervisor":
                    usuario.TipoUsuario = 2;
                    break;
                case "Invitado":
                    usuario.TipoUsuario = 3;
                    break;
            }

        }
        private void SaveEntity(Usuario usuario)
        {
            this.Logic.Agregar(usuario);
            this.agregado.Visible = true;
            this.NombreUsuarioTB.Text = string.Empty;
            this.UltimoIngresoTB.Text = string.Empty;
            this.EmailTB.Text = string.Empty;
            this.ClaveTB.Text = string.Empty;
        }

        protected void aceptarBtn_Click(object sender, EventArgs e)
        {
            this.Entity = new Usuario();
            this.LoadEntity(this.Entity);
            this.SaveEntity(this.Entity);
        }

        protected void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.NombreUsuarioTB.Text = string.Empty;
            this.UltimoIngresoTB.Text = string.Empty;
            this.EmailTB.Text = string.Empty;
            this.ClaveTB.Text = string.Empty;
        }
    }
}