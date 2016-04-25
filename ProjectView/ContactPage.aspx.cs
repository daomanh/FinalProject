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
using System.Net;
using System.Net.Mail;


namespace ProjectView
{
    public partial class ContactPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            string name = txtName.Value;
            string email = txtEmail.Value;
            string phone = txtPhone.Value;
            string mesage = txtMesage.Value;

            TblContact tblc = new TblContact(name, email, phone, mesage, "NOREAD");
            TblContactBus tblBus = new TblContactBus();
            tblBus.INSERT_CONTACT(tblc);

            //send mail after insert done
            SmtpClient stmp = new SmtpClient("smtp.gmail.com", 587);
            stmp.DeliveryMethod = SmtpDeliveryMethod.Network;
            stmp.EnableSsl = true;
            stmp.UseDefaultCredentials = false;

            stmp.Credentials = new NetworkCredential("ad.VietNamTour@gmail.com", "daomanh123");

            MailMessage mail = new MailMessage("ad.VietNamTour@gmail.com", email, "Thank Your feedback to VIETNAMTOURISM", "Thank your feedback. We will soon have the answers to you via email.");
            stmp.Send(mail);

            //send admin
            MailMessage mail2 = new MailMessage("ad.VietNamTour@gmail.com", "ad.VietNamTour@gmail.com" , "New Contact from VIETNAMTOURISM", "Admin has new feedback from: "+ name + "on VIETNAMTOURISM website.");
            stmp.Send(mail2);

        }
    }
}