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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadDataUser();
                Session["id"] = null;
            }
        }

        private void loadDataUser()
        {
            tblUserBus Ub = new tblUserBus();
            DataTable dt = Ub.LoadUser();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}