using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectView.AdminPage
{
    public partial class ReplyReview_detail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userLogin"] == null)
            {
                Response.Redirect("../index.aspx");
            }
            if (!IsPostBack)
            {
                txtname.Value = DetailReview.Username;
                txtMesage.Value = DetailReview.content;
                txtEmailEnd.Value = Session["userLogin"].ToString();
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string mess = txtREPLY.Value;
            int IDReview = Convert.ToInt16(Session["IDReview"].ToString());
            string UserName = txtEmailEnd.Value;

            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            // datecreate: mm / dd / yyyy
            string dateCreate = month + "/" + day + "/" + year;

            Public.ReplyReview rr = new Public.ReplyReview(IDReview, UserName, dateCreate, mess);
            ReplyReviewBUS rrBUS = new ReplyReviewBUS();
            rrBUS.InsertRepylReview(rr);

            string stt = "reply";
            tblReviewBus Review = new tblReviewBus();
            int check = Review.UpdateSTTTblReview(stt, IDReview);
        }
    }
}