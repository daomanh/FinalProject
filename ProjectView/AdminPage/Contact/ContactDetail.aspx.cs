using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectView.AdminPage.Contact
{
    public partial class ContactDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userLogin"] == null)
            {
                Response.Redirect("../index.aspx");
            }
            if (!IsPostBack)
            {

                txtname.Value = AllContact.name;
                txtEmail.Value = AllContact.email;
                txtPhone.Value = AllContact.phone;
                txtMesage.Value = AllContact.mesage;
                txtEmailEnd.Value = AllContact.email;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string email = txtEmailEnd.Value;
            string content = txtREPLY.Value;
            int ID = Convert.ToInt16(Session["ID"].ToString());
            if (content == null || content.Equals("") || content == "")
            {
                txtError.Visible = true; 
            }
            else {
                TblContactBus tblBus = new TblContactBus();
                tblBus.UPDATE_CONTACT("REPLY", ID);

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