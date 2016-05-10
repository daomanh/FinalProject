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

namespace ProjectView.AdminPage
{
    public partial class Index_review : System.Web.UI.Page
    {
        public static string name;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userLogin"] == null)
            {
                Response.Redirect("../index.aspx");
            }
            if (!IsPostBack)
            {
                tblReviewBus lb = new tblReviewBus();
                DataTable dt = lb.LoadCountReview();

                theID.DataSource = dt;
                theID.DataBind();
            }
        }

        protected void theID_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "chinhsua")
            {
                Label lbl = (Label)e.Item.FindControl("ID");
                Session["IDLocation"] = lbl.Text;

                Label lblname = (Label)e.Item.FindControl("locationName");
                //if (lbl != null) lblten.Text = lbl.Text;
                name = lblname.Text;
                Session["LocationName"] = lblname.Text;

                Response.Redirect("DetailReview.aspx?name=" + name.ToString());

            }
        }

        
    }
}