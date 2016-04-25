using Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Public;

namespace ProjectView.AdminPage.Booking
{
    public partial class AllBooking : System.Web.UI.Page
    {
        public static string Namecus;
        public static string Address;
        public static string Email;
        public static string Phone;
        public static string LocationName;
        public static string NumberPeople;
        public static string DateStart;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userLogin"] == null)
            {
                Response.Redirect("../index.aspx");
            }
            if (!IsPostBack)
            {
                LoadDataBooking();
            }
        }

        private void LoadDataBooking()
        {
            BookingBus booking = new BookingBus();
            DataTable dt = booking.selectBookingAndLocation();

            theID.DataSource = dt;
            theID.DataBind();
        }

        protected void theID_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

            Label ID = (Label)e.Item.FindControl("ID");
            Session["IDBooking"] = ID.Text;
            int IDB = Convert.ToInt16(ID.Text.ToString());

            Label Stt = (Label)e.Item.FindControl("STT");
            if (Stt.Text.Equals("REPLY"))
            {

            }
            else
            {
                Public.Booking bk = new Public.Booking(IDB, "seen");
                BookingBus tblBus = new BookingBus();
                tblBus.updateSTTBoking(bk);
            }

            Label namecus = (Label)e.Item.FindControl("Name");
            Namecus = namecus.Text;

            Label email = (Label)e.Item.FindControl("Email");
            Email = email.Text;
            Label phone = (Label)e.Item.FindControl("Phone");
            Phone = phone.Text;
            Label locationName = (Label)e.Item.FindControl("locationName");
            LocationName = locationName.Text;
            Label Date = (Label)e.Item.FindControl("Date");
            DateStart = Date.Text;
            Label AddLBL = (Label)e.Item.FindControl("Address");
            Address = AddLBL.Text;
            Label numberPeople = (Label)e.Item.FindControl("numberPeople");
            NumberPeople = numberPeople.Text;

            Response.Redirect("BookingDetail.aspx?name=" + ID.ToString());

            
        }
    }
}