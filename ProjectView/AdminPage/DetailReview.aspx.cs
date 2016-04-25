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
    public partial class DetailReview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userLogin"] == null)
            {
                Response.Redirect("../index.aspx");
            }

            LoadDataReviewOfLocation();
        }

        private void LoadDataReviewOfLocation()
        {
            int id = Convert.ToUInt16(Session["IDLocation"].ToString());
            tblReviewBus Review = new tblReviewBus();
            DataTable dt = Review.LoadReviewByLocationID(id);

            theID.DataSource = dt;
            theID.DataBind();
        }
        public static int IDReview;
        public static string Username;
        public static string content;
        public static string co;
        public static int IDRep;
        protected void theID_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "chinhsua")
            {
                Label lbl = (Label)e.Item.FindControl("lblIdReview");
                IDReview = Convert.ToInt16(lbl.Text.ToString());

                Label lblUser = (Label)e.Item.FindControl("USername");
                Username = lblUser.Text.ToString();

                Label lblMess = (Label)e.Item.FindControl("mess");
                content = lblMess.Text.ToString();

                Label lblSTT = (Label)e.Item.FindControl("Label1");

                Session["STT"] = lblSTT.Text;
                Session["IDReview"] = IDReview.ToString();
                if (lblSTT.Text.Equals("reply"))
                {
                    
                    tblReviewBus Review = new tblReviewBus();

                    DataTable dt2 = Review.ViewAllTblReviewByLocationID_Reply(IDReview);

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Content", typeof(string));

                    int count = dt2.Rows.Count;
                    for (int i = 0; i < count; i++)
                    {
                        int id = Convert.ToUInt16(dt2.Rows[i]["IDRep"].ToString());
                        IDRep = id;                        
                        string content = dt2.Rows[i]["Content"].ToString();
                        co = content;
                    }

                    Response.Redirect("ReviewRep_detail.aspx?name=" + IDReview.ToString());
                }

                Response.Redirect("ReplyReview_detail.aspx?name=" + IDReview.ToString());

            }
        }


    }
}