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
    public partial class BookingPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userLogin"] != null)
            {
                int id = Convert.ToInt16(Session["U_ID"].ToString());

                tblUserBus UBUS = new tblUserBus();
                DataTable dt = UBUS.selectUserByID(id);
                int row = dt.Rows.Count;
                for (int i = 0; i < row; i++)
                {
                    name.Value = dt.Rows[i]["Fullname"].ToString();
                    Email.Value = dt.Rows[i]["Email"].ToString();
                    phonenumber.Value = dt.Rows[i]["PhoneNumber"].ToString();
                    address.Value = dt.Rows[i]["Addres"].ToString();
                }
            }
            tour.Value = Session["nameLocationtest"].ToString();
            locationName.Text = Session["nameLocationtest"].ToString();
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            int u_iD;
            if (Session["userLogin"] != null)
            {
                u_iD = Convert.ToUInt16(Session["U_ID"].ToString());
            }
            else {
                u_iD = 0;
            }


            string nameOFCustomer = name.Value;
            string adress = address.Value;
            string phoneNumber = phonenumber.Value;
            string email = Email.Value;
            int loctionID = Convert.ToInt16(Session["IDLocation"].ToString());
            int numberpeople = Convert.ToInt16(numbeRpeople.Value);
            string datestart = DateStart.Value;

            if (name.Value == null || name.Value.Equals(" "))
            {
                return;
            }
            if (email == null || email.Equals(""))
            {
                return;
            }
            if (numberpeople < 0)
            {
                txtNumberError.Visible = true;
            }

            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            // datecreate: mm / dd / yyyy

            string[] s = datestart.Split('-');

            int dayCreate = Convert.ToInt32(s[2]);
            int montCreate = Convert.ToInt32(s[1]);
            int yearCreate = Convert.ToInt32(s[0]);

            if (yearCreate >= year)
            {
                if (montCreate >= month)
                {
                    if (dayCreate < day && montCreate == month)
                    {
                        return;
                    }
                    else
                    {
                        Booking b = new Booking(u_iD, nameOFCustomer, adress, phoneNumber, email, loctionID, numberpeople, datestart, "newBooking");
                        BookingBus bbus = new BookingBus();

                        bbus.insertBooking(b);

                        tblLocationBus tblLBus = new tblLocationBus();

                        int CountBooking = Convert.ToInt16(Session["CountBooking"].ToString());
                        int newCountBooking = CountBooking + 1;
                        tblLBus.EditRateLocation(loctionID, newCountBooking);
                        string cont = "Name Customer:" + nameOFCustomer + Environment.NewLine +
                            "Email:" + email + Environment.NewLine +
                            "Date Start:" + datestart + Environment.NewLine +
                            "Thank for booking";

                        SendingEmail(email, cont);
                        txtDONE.Visible = true;
                        txtErrorDate.Visible = false;
                        txtNumberError.Visible = false;
                    }
                }
                else {
                    txtErrorDate.Visible = true;
                }
            }
            else {
                txtErrorDate.Visible = true;
            }

        }




        private void SendingEmail(string email, string cont)
        {
            SmtpClient stmp = new SmtpClient("smtp.gmail.com", 587);
            stmp.DeliveryMethod = SmtpDeliveryMethod.Network;
            stmp.EnableSsl = true;
            stmp.UseDefaultCredentials = false;

            stmp.Credentials = new NetworkCredential("ad.VietNamTour@gmail.com", "daomanh123");

            MailMessage mail = new MailMessage("ad.VietNamTour@gmail.com", email, "Confirm Booking", cont);
            stmp.Send(mail);
        }
    }
}