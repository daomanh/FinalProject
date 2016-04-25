using Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectView.AdminPage
{
    public partial class ReviewRep_detail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userLogin"] == null)
            {
                Response.Redirect("../index.aspx");
            }
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        private void LoadData()
        {

            txtname.Value = DetailReview.Username;
            txtMesage.Value = DetailReview.content;
            txtEmailEnd.Value = Session["userLogin"].ToString();

            //int IDReview = Convert.ToInt16(Session["IDReview"].ToString());
            //tblReviewBus Review = new tblReviewBus();

            //DataTable dt2 = Review.ViewAllTblReviewByLocationID_Reply(IDReview);
            //theID.DataSource = dt2;
            //theID.DataBind();
            txtREPLY.Value = DetailReview.co;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string mess = txtREPLY.Value;
           
            int idr = DetailReview.IDRep;
            string UserName = txtEmailEnd.Value;

            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            // datecreate: mm / dd / yyyy
            string dateCreate = month + "/" + day + "/" + year;

            Public.ReplyReview rr = new Public.ReplyReview(idr, UserName, dateCreate, mess);
            ReplyReviewBUS rrBUS = new ReplyReviewBUS();
            rrBUS.UpdateReplyReview(rr);

           
        }
    }
}