using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Business;
using Public;

namespace ProjectView
{
    public partial class UpdateAcount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userLogin"] == null)
            {
                Response.Redirect("index.aspx");
            }
            if (!IsPostBack)
            {
                LoadDataAccount();
            }
        }

        private void LoadDataAccount()
        {
            int id = Convert.ToInt16(Session["U_ID"].ToString());

            tblUserBus ub = new tblUserBus();
            DataTable dt = ub.selectUserByID(id);

            int count = dt.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                txtUsername.Value = dt.Rows[i]["Username"].ToString();
                txtPass.Value = dt.Rows[i]["Pass"].ToString();
                txtFullname.Value = dt.Rows[i]["Fullname"].ToString();
                txtPhoneNumber.Value = dt.Rows[i]["PhoneNumber"].ToString();
                txtEmail.Value = dt.Rows[i]["Email"].ToString();
                txtAddres.Value = dt.Rows[i]["Addres"].ToString();
                string gender = dt.Rows[i]["Gender"].ToString();
                Gender.SelectedValue = gender;
            }
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
            string role = "user";

            Boolean ok = true;
            tblUserBus Ub = new tblUserBus();
            DataTable dt = Ub.checkAcount(username);
            int count = dt.Rows.Count;

            if (count > 0 && username!= Session["userLogin"].ToString())
            {
                txtErrorUName2.Visible = true;
                ok = false;
            }
            else
            {
                txtErrorUName2.Visible = false;
                ok = true;
            }
            if (username=="" || username.Equals("")|| username == null)
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
                TblUser ur = new TblUser(id,username, pas, fullname, phone, gender, email, adress, role);
                int check = Ub.UpdateUser(ur);
                if (check > 0)
                {
                    Session["userLogin"] = null;
                    Session["U_ID"] = null;
                    Response.Redirect("LoginPage.aspx");
                }
                else
                {
                    Response.Redirect("Error404.aspx");
                }
            }
            else
            {
                Response.Redirect("Error404.aspx");
            }
        }
    }
}