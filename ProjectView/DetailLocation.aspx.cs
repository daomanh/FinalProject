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
using System.Web.Services;
using System.Web.Script.Services;
using System.Configuration;

namespace ProjectView
{
    public partial class DetailLocation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LocationName1.Text = Session["nameLocationtest"].ToString();
                LocationName2.Text = Session["nameLocationtest"].ToString();
                LoadDataLocation();
                LoadDataPictureOfLocation();
                LoadDataReviewOfLocation();
                
            }
        }

        private void LoadDataReviewOfLocation()
        {
            int id = Convert.ToUInt16(Session["IDLocation"].ToString());
            tblReviewBus Review = new tblReviewBus();
            DataTable dt = Review.LoadReviewByLocationID_NOTREPLY(id);

            DataTable dt2 = Review.ViewAllTblReviewByLocationID_Reply(id);

            Comment2.DataSource = dt2;
            Comment2.DataBind();

            Reviewtbl.DataSource = dt;
            Reviewtbl.DataBind();
        }

        private void LoadDataPictureOfLocation()
        {
            int id = Convert.ToUInt16(Session["IDLocation"].ToString());
            if (id == 0)
            {
                Response.Redirect("Location.aspx");
            }
            else {
                tblPictureBus picB = new tblPictureBus();
                DataTable dt = picB.LoadDataPictureByLocationID(id);

                picture1.DataSource = dt;
                picture1.DataBind();
            }
        }

        private void LoadDataLocation()
        {
            int id = Convert.ToUInt16(Session["IDLocation"].ToString());
            tblLocationBus lctB = new tblLocationBus();
            DataTable dt = lctB.Search_location_by_id(id);

            theLocation.DataSource = dt;
            theLocation.DataBind();
        }



        protected void submit_Click(object sender, EventArgs e)
        {

            if (Session["U_ID"] == null)
            {
                txtError.Visible = true;
            }
            else {
                int U_ID = Convert.ToInt16(Session["U_ID"].ToString());
                int locationID = Convert.ToUInt16(Session["IDLocation"].ToString());

                int day = DateTime.Now.Day;
                int month = DateTime.Now.Month;
                int year = DateTime.Now.Year;
                // datecreate: mm / dd / yyyy
                string dateCreate = month + "/" + day + "/" + year;

                string content = textContent.Value;

                TblReview rv = new TblReview(locationID, U_ID, dateCreate, content);
                tblReviewBus rb = new tblReviewBus();
                rb.InsertTblReview(rv);
                Response.Redirect("index.aspx");
            }
        }

        protected void btnBooking_Click(object sender, EventArgs e)
        {
            int locationID = Convert.ToUInt16(Session["IDLocation"].ToString());
            string nameLocation = Session["nameLocationtest"].ToString();
            Response.Redirect("BookingPage.aspx?name=" + nameLocation);
        }

    }
}