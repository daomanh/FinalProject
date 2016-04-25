using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectView
{
    public partial class HomeUser_Masterpage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userLogin"] != null)
            {
                //lblLogin.Text = "logout";
                a.Visible = true;
                loginLI.Visible = false;
                logoutli.Visible = true;
                Label1.Text = "welcome : " + Session["userLogin"];
            }
            else
            {
                loginLI.Visible = true;
                logoutli.Visible = false;
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["userLogin"] = null;
            Session["U_ID"] = null;
            Response.Redirect("index.aspx");
        }
    }
}