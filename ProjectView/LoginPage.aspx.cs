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

namespace ProjectView
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string u = username.Value.ToString();
            string p = password.Value.ToString();
            CheckLogin(u, p);
        }

        private void CheckLogin(string v1, string v2)
        {
            tblUserBus Ub = new tblUserBus();
            DataTable dt = Ub.Login2(v1, v2);
            int count = dt.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    string roll = dt.Rows[i]["Roll"].ToString();
                    int U_ID = Convert.ToInt16(dt.Rows[i]["ID"].ToString());
                    if (roll.Equals("user"))
                    {
                        Session["userLogin"] = v1;
                        Session["U_ID"] = U_ID;


                        string URLOLD = Session["strPath"].ToString();
                        Response.Redirect("~" + URLOLD);
                    }
                    else
                    {
                        Response.Redirect("~/AdminPage/LoginAdmin.aspx");
                    }
                }
            }
            else
            {
                Response.Redirect("Error.aspx");
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}