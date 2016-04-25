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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string user = username.Value.ToString();
            string pass = password.Value.ToString();
            string name = fullname.Value.ToString();
            string phone = phonenumber.Value.ToString();
            string gender = Gender.SelectedValue.ToString();
            string emai = email.Value.ToString();
            string addresss = address.Value.ToString();
            string roll = "user";

            tblUserBus Ub = new tblUserBus();
            TblUser u = new TblUser(user, pass, name, phone, gender, emai, addresss, roll);
            Ub.InsertUser(u);
            Response.Redirect("LoginPage.aspx");
        }
    }
}