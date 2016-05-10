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
    public partial class AdminDetailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            string username = User_index.username;
            string pas = User_index.passw;
            string fullname = User_index.fullname;
            string email = User_index.email;
            string adress = User_index.adress;
            string gender = User_index.gender;
            string phone = User_index.phone;
            string role = User_index.role;

            un.Text = username;
            txtUsername.Value = username;
            txtPass.Value = pas;
            txtFullname.Value = fullname;
            txtEmail.Value = email;
            txtAddres.Value = adress;
            txtPhoneNumber.Value = phone;
            Role.SelectedValue = role;
            Gender.SelectedValue = gender;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Session["U_ID"].ToString());
            string username = txtUsername.Value;
            string pas = txtPass.Value;
            string fullname = txtFullname.Value;
            string email = txtEmail.Value;
            string adress = txtAddres.Value;
            string gender = Gender.SelectedValue.ToString();
            string phone = txtPhoneNumber.Value;
            string role = Role.SelectedValue.ToString();

            Boolean ok = true;
            tblUserBus Ub = new tblUserBus();
            DataTable dt = Ub.checkAcount(username);
            int count = dt.Rows.Count;

            if (count > 0 && username != Session["userLogin"].ToString())
            {
                txtErrorUName2.Visible = true;
                ok = false;
            }
            else
            {
                txtErrorUName2.Visible = false;
                ok = true;
            }
            if (username == "" || username.Equals("") || username == null)
            {
                txtErrorUName.Visible = true;
                ok = false;
            }
            else
            {
                txtErrorUName.Visible = false;
                ok = true;
            }
            if (pas == "" || pas.Equals("") || pas == null)
            {
                txtErrorpass.Visible = true;
                ok = false;
            }
            else
            {
                txtErrorpass.Visible = false;
                ok = true;
            }
            if (fullname == "" || fullname.Equals("") || fullname == null)
            {
                txtErrorFname.Visible = true;
                ok = false;
            }
            else
            {
                txtErrorFname.Visible = false;
                ok = true;
            }
            if (email == "" || email.Equals("") || email == null)
            {
                txtErrorEmail.Visible = true;
                ok = false;
            }
            else
            {
                txtErrorEmail.Visible = false;
                ok = true;
            }
            if (adress == "" || adress.Equals("") || adress == null)
            {
                txtErrorAdr.Visible = true;
                ok = false;
            }
            else
            {
                txtErrorAdr.Visible = false;
                ok = true;
            }
            if (phone == "" || phone.Equals("") || phone == null)
            {
                txtErrorPhone.Visible = true;
                ok = false;
            }
            else
            {
                txtErrorPhone.Visible = false;
                ok = true;
            }
            if (ok == true)
            {
                TblUser ur = new TblUser(id, username, pas, fullname, phone, gender, email, adress, role);
                int check = Ub.UpdateUser(ur);
                if (check > 0)
                {
                    Session["userLogin"] = null;
                    Session["U_ID"] = null;
                    Response.Redirect("/LoginPage.aspx");
                }
                else
                {
                    Response.Redirect("../Error404.aspx");
                }
            }
            else
            {
                Response.Redirect("../Error404.aspx");
            }
        }
    }
}