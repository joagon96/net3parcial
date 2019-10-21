using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Basso.Web
{
    public partial class MasterBase : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
               
        
        private Alta alt = new Alta();
        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {

            Response.Redirect("Alta.aspx");
        }
    }
}