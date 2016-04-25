using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using System.Data;
namespace ProjectView
{
    public partial class UserPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userLogin"] == null)
            {
                Response.Redirect("index.aspx");
            }
            if (!IsPostBack)
            {
                LoadDataBooking();
            }
        }

        private void LoadDataBooking()
        {
            if (Session["U_ID"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            int id = Convert.ToInt16(Session["U_ID"].ToString());

            BookingBus bbus = new BookingBus();
            DataTable dt = bbus.selectBookingAndLocation_BY_U_ID(id);

            theID.DataSource = dt;
            theID.DataBind();
        }
    }
}