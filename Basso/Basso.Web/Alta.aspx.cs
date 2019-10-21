using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Basso.Entidades;
using Basso.Utiles;
using Basso.Negocio;
namespace Basso.Web
{
    public partial class Alta : MasterBase
    {
        public AlumnoLogic _logic { get; set; }
        private AlumnoLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new AlumnoLogic();
                }
                return _logic;
            }
        }
        private Alumno Entity { get; set; } 
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Cancelar_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }

        
        private void LoadEntity(Alumno alumno)
        {


            alumno.Id = Convert.ToInt32(IDtb.Text);
            alumno.Dni = dnitb.Text;
            alumno.ApellidoNombre = antb.Text;
            alumno.Email = emailtb.Text;
            alumno.FechaNacimiento = Convert.ToDateTime(fechnactb.Text);
            if (Utiles.Validaciones.EsFechaDeNacimientoValida(alumno.FechaNacimiento))
            {}
            else { /* Mensaje de alerta al usuario*/ }
            alumno.NotaPromedio = Convert.ToDecimal(notatb.Text);
           
        }


        private void SaveEntity(Alumno alumno)
        {
            this.Logic.Agregar(alumno);
            this.Dispose();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.Entity = new Alumno();
            this.LoadEntity(this.Entity);
            this.SaveEntity(this.Entity);
        }
    }
}