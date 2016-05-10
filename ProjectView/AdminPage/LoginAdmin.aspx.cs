using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Public;
using Business;
using DataAccess;
using System.Data;

namespace ProjectView.AdminPage
{
    public partial class LoginAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["sadasdS"] != null || Session["MatKhau"] != null)
            {
                if (!IsPostBack)
                {
                    Response.Redirect("Login.aspx");
                }                
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string u = username.Value.ToString();
            string p = password.Value.ToString();
            CheckLogin(u, p);
        }

        private void CheckLogin(string u, string p)
        {
            tblUserBus Ub = new tblUserBus();
            bool dt = Ub.Login(u, p);

            if (dt == true)
            {
                Session["userLogin"] = u;
                Response.Redirect("index.aspx");
            }
            else
            {
                Response.Redirect("Error.aspx");
            }
        }
    }
}