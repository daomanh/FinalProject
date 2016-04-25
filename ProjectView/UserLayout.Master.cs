using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectView
{
    public partial class UserLayout : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void logout_Click(object sender, EventArgs e)
        {
            Session["userLogin"] = null;
            Session["U_ID"] = null;
            Response.Redirect("index.aspx");            
        }
    }
}