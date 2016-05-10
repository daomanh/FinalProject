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

namespace ProjectView.AdminPage.User
{
    public partial class User_index : System.Web.UI.Page
    {
        public static string username;
        public static string fullname;
        public static string passw;
        public static string email;
        public static string adress;
        public static string gender;
        public static string phone;
        public static string role;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadDataUser();             
            }
        }

        private void loadDataUser()
        {
            tblUserBus Ub = new tblUserBus();
            DataTable dt = Ub.LoadUser();

            theID.DataSource = dt;
            theID.DataBind();
        }

        protected void theID_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "chinhsua")
            {
                Label lblID = (Label)e.Item.FindControl("ID");
                Session["IDU"] = lblID.Text;                
 

                Label lblUsername = (Label)e.Item.FindControl("Username");
                //if (lbl != null) lblten.Text = lbl.Text;
                username = lblUsername.Text;
                Session["us"] = lblUsername.Text;

                Label lblfullname = (Label)e.Item.FindControl("Fullname");
                //if (lbl != null) lblten.Text = lbl.Text;
                fullname = lblfullname.Text;

                Label lblemail = (Label)e.Item.FindControl("Email");
                //if (lbl != null) lblten.Text = lbl.Text;
                email = lblemail.Text;

                Label lbladress = (Label)e.Item.FindControl("Addres");
                //if (lbl != null) lblten.Text = lbl.Text;
                adress = lbladress.Text;

                Label lblgender = (Label)e.Item.FindControl("Gender");
                //if (lbl != null) lblten.Text = lbl.Text;
                gender = lblgender.Text;

                Label lblphone = (Label)e.Item.FindControl("PhoneNumber");
                //if (lbl != null) lblten.Text = lbl.Text;
                phone = lblphone.Text;

                Label lblPass = (Label)e.Item.FindControl("Pass");
                //if (lbl != null) lblten.Text = lbl.Text;
                passw = lblPass.Text;

                Label lblrole = (Label)e.Item.FindControl("Roll");
                //if (lbl != null) lblten.Text = lbl.Text;
                role = lblrole.Text;

                if (role == "admin")
                {
                    Response.Redirect("AdminDetailPage.aspx?Uname=" + username.ToString());
                }
                Response.Redirect("UserDetail.aspx?Uname=" + username.ToString());

            }
            if (e.CommandName == "delete")
            {
                Label lblID = (Label)e.Item.FindControl("ID");
                int idd = Convert.ToUInt16(lblID.Text);
                tblUserBus bus = new tblUserBus();
                
                int del = bus.DeleteUser(idd);
                if (del != 0)
                {
                    loadDataUser();
                }
            }
        }
    }
}