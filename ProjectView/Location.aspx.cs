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

namespace ProjectView
{
    public partial class Location : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadPictureOfLocation();
                Session["nameLocationtest"] = null;
                Session["strPath"] = HttpContext.Current.Request.Url.AbsolutePath;
            }
        }

        private void LoadPictureOfLocation()
        {
            tblPictureBus pb = new tblPictureBus();
            DataTable dt = pb.LoadLocationAndpicture();

            PagedDataSource pgitems = new PagedDataSource();
            System.Data.DataView dv = new System.Data.DataView(dt);
            pgitems.DataSource = dv;
            pgitems.AllowPaging = true;
            pgitems.PageSize = 5;
            pgitems.CurrentPageIndex = PageNumber;
            if (pgitems.PageCount > 1)
            {
                rptPages.Visible = true;
                System.Collections.ArrayList pages = new System.Collections.ArrayList();
                for (int i = 0; i < pgitems.PageCount; i++)
                    pages.Add((i + 1).ToString());
                rptPages.DataSource = pages;
                rptPages.DataBind();
            }
            else
                rptPages.Visible = false;
            
            //theLocation.DataSource = dt;
            //theLocation.DataBind();
            theLocation.DataSource = pgitems;

            theLocation.DataBind();
        }

        public int PageNumber
        {
            get
            {
                if (ViewState["PageNumber"] != null)
                    return Convert.ToInt32(ViewState["PageNumber"]);
                else
                    return 0;
            }
            set
            {
                ViewState["PageNumber"] = value;
            }
        }

        protected void rptPages_ItemCommand1(object source, RepeaterCommandEventArgs e)
        {
            PageNumber = Convert.ToInt32(e.CommandArgument) - 1;
            LoadPictureOfLocation();
        }

        public static string namelct;

        protected void theLocation_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "chinhsua")
            {
                Label lbl = (Label)e.Item.FindControl("Label1");
                Session["IDLocation"] = lbl.Text;

                Label lblShow = (Label)e.Item.FindControl("NameLocation");
                //if (lbl != null) lblten.Text = lbl.Text;

                namelct = lblShow.Text;
                //lblten.Text = namelct.ToString();

                Label ViewerLBL = (Label)e.Item.FindControl("Label2");
                Session["Viewer"] = ViewerLBL.Text;

                Label CountBooking = (Label)e.Item.FindControl("Label3");
                Session["CountBooking"] = CountBooking.Text;

                tblLocationBus tblBUS = new tblLocationBus();

                int LocationID = Convert.ToUInt16(lbl.Text.ToString());
                int Viewer = Convert.ToUInt16(ViewerLBL.Text.ToString());
                int newV = Viewer + 1;
                tblBUS.Update_Viewer(LocationID, newV);

                Session["nameLocationtest"] = lblShow.Text;
                Response.Redirect("DetailLocation.aspx?name=" + namelct.ToString());
            }
        }
    }
}