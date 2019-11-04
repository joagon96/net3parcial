using Martin.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Martin.Web
{
    public partial class Listado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            this.DropDownList1.Items.Add("1");
            this.DropDownList1.Items.Add("2");
            this.load_grid();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = PersonaNegocio.RecuperarPorTipoPersona(Convert.ToInt32(this.DropDownList1.SelectedValue));
            GridView1.DataBind();
        }
        private void load_grid()
        {
            GridView1.DataSource = PersonaNegocio.RecuperarTodos();
            GridView1.DataBind();
        }
    }
}