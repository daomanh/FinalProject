using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectView.AdminPage.User
{
    public partial class UserDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = User_index.username;
            string fullname = User_index.fullname; 
            string email = User_index.email; 
            string adress = User_index.adress;
            string gender = User_index.gender;
            string phone = User_index.phone;
            string role = User_index.role;

            un.Text = username;
            txtUsername.Value = username;
            txtFullname.Value = fullname;
            txtEmail.Value = email;
            txtAddres.Value = adress;
            txtPhoneNumber.Value = phone;
            txtRole.Value = role;
            txtGender.Value = gender;
        }
    }
}