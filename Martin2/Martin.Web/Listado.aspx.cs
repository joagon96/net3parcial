using Martin.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Martin.Entidades;

namespace Martin.Web
{
    public partial class Listado : System.Web.UI.Page
    {
        private AlumnoLogic logic
        {
            get {return _logic; }
            set {_logic=value; }
        }
        public AlumnoLogic _logic { get; set; }
        public Listado()
        {
            logic = new AlumnoLogic();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.LoadGrid();
                
            }
        }

        private void LoadGrid()
        {
            gridView.DataSource = logic.RecuperarTodos();
            gridView.DataBind();   
        }
    }
}