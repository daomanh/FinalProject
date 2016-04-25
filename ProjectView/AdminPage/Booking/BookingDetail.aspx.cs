using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectView.AdminPage.Booking
{
    public partial class BookingDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userLogin"] == null)
            {
                Response.Redirect("../index.aspx");
            }
            if (!IsPostBack)
            {
                loadData();
            }
        }

        private void loadData()
        {
            txtname.Value = AllBooking.Namecus;
            txtAddress.Value = AllBooking.Address;
            txtDate.Value = AllBooking.DateStart;
            txtEmail.Value = AllBooking.Email;
            txtLocationName.Value = AllBooking.LocationName;
            txtNumPeople.Value = AllBooking.NumberPeople;
            txtPhone.Value = AllBooking.Phone;
            
            txtEmailEnd.Value = AllBooking.Email;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string email = txtEmailEnd.Value;
            string content = txtREPLY.Value;
            int ID = Convert.ToInt16(Session["IDBooking"].ToString());
            if (content == null || content.Equals("") || content == "")
            {
                txtError.Visible = true;
            }
            else {
                Public.Booking bk = new Public.Booking(ID, "REPLY");
                BookingBus tblBus = new BookingBus();
                tblBus.updateSTTBoking(bk);

                SmtpClient stmp = new SmtpClient("smtp.gmail.com", 587);
                stmp.DeliveryMethod = SmtpDeliveryMethod.Network;
                stmp.EnableSsl = true;
                stmp.UseDefaultCredentials = false;

                stmp.Credentials = new NetworkCredential("ad.VietNamTour@gmail.com", "daomanh123");

                MailMessage mail = new MailMessage("ad.VietNamTour@gmail.com", email, "Confirm Your feedback to VIETNAMTOURISM", content);
                stmp.Send(mail);
            }
        }
    }
}