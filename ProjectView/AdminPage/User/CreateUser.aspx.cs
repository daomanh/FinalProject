using Business;
using Public;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectView.AdminPage.User
{
    public partial class CreateUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            tblUserBus Ub = new tblUserBus();
            DataTable dt =  Ub.checkAcount(username.Value.ToString());
            int count = dt.Rows.Count;

            Boolean ok = true;
            if (username.Value == null || username.Value.Equals("") || username.Value.Trim().Equals(""))
            {
                txtErrorUName.Visible = true;
                ok = false;
            }
            else
            {
                txtErrorUName.Visible = false;
            }
            if (count > 0)
            {
                txtErrorUName2.Visible = true;
                ok = false;
            }
            else
            {
                txtErrorUName2.Visible = false;
            }
            if (fullname.Value == null || fullname.Value.Equals("") || fullname.Value.Trim().Equals(""))
            {
                txtErrorFname.Visible = true;
                ok = false;
            }
            else
            {
                txtErrorFname.Visible = false;
            }
            if (phone.Value == null || phone.Value.Equals("") || phone.Value.Trim().Equals(""))
            {
                txtErrorPhone.Visible = true;
                ok = false;
            }
            else
            {
                txtErrorPhone.Visible = false;
            }
            if (email.Value == null || email.Value.Equals("") || email.Value.Trim().Equals(""))
            {
                txtErrorEmail.Visible = true;
                ok = false;
            }
            else
            {
                txtErrorEmail.Visible = false;
            }
            if (address.Value == null || address.Value.Equals("") || address.Value.Trim().Equals(""))
            {
                txtErrorAdr.Visible = true;
                ok = false;
            }
            else
            {
                txtErrorAdr.Visible = false;
            }
            if (Gender.SelectedValue.ToString() == "null")
            {
                txtErrorGender.Visible = true;
                ok = false;
            }
            else {
                txtErrorGender.Visible = false;
            }

            if (RoleChoice.SelectedValue.ToString() == "null")
            {
                txtErrorRole.Visible = true;
                ok = false;
            }
            else {
                txtErrorRole.Visible = false;
            }

            if (ok == false)
            {
                return;
            }
            else {
                string user = username.Value.ToString();
                string pass = "12345678";
                string name = fullname.Value.ToString();
                string phonenumber = phone.Value.ToString();
                string gender = Gender.SelectedValue.ToString();
                string emai = email.Value.ToString();
                string addresss = address.Value.ToString();
                string roll = RoleChoice.SelectedValue.ToString();

                
                TblUser u = new TblUser(user, pass, name, phonenumber, gender, emai, addresss, roll);
                Ub.InsertUser(u);
                Response.Redirect("User_index.aspx");
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}