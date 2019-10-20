using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtClave.Text == "admin")
                Page.Response.Write("Ingreso OK");
            else
                Page.Response.Write("Usuario o contraseña incorrectos");
            
            if (txtUsuario.Text == "borrar")
                Page.Response.Clear();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/Default.aspx");
        }
    }
}