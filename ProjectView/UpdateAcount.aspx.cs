using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Business;
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
    }
}