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
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadSlider();
                LoadTopNewCreate();
                LoadTopViews();
                LoadTopRate();
                LoadArea();
                Session["strPath"] = HttpContext.Current.Request.Url.AbsolutePath;
            }
        }

        private void LoadArea()
        {
            TblAreaBus tbla = new TblAreaBus();
            DataTable dt = tbla.LoadArea();

            area.DataSource = dt;
            area.DataValueField = "AreaName";
            area.DataBind();
        }

        private void LoadTopViews()
        {
            tblLocationBus lcb = new tblLocationBus();
            DataTable dt = lcb.SelectTopView();

            TopView.DataSource = dt;
            TopView.DataBind();
        }

        private void LoadTopRate()
        {
            tblLocationBus lcb = new tblLocationBus();
            DataTable dt = lcb.SelectTopRate();

            TopRate.DataSource = dt;
            TopRate.DataBind();
        }

        private void LoadTopNewCreate()
        {
            tblLocationBus lcb = new tblLocationBus();
            DataTable dt = lcb.SelectTopNewCreate();

            TheNewestCreate.DataSource = dt;
            TheNewestCreate.DataBind();
        }

        private void LoadSlider()
        {
            string roll = "banner";
            tblPictureBus Ptc = new tblPictureBus();
            DataTable dt = Ptc.LoadDataPictureByRoll(roll);

            theID.DataSource = dt;
            theID.DataBind();
        }
        public string namelct;
        protected void TheNewestCreate_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "chinhsua")
            {
                Label lbl = (Label)e.Item.FindControl("Label1");
                Session["IDLocation"] = lbl.Text;

                Label lblShow = (Label)e.Item.FindControl("namelocation");
                //if (lbl != null) lblten.Text = lbl.Text;
                namelct = lblShow.Text;
                //lblten.Text = namelct.ToString();


                Label ViewerLBL = (Label)e.Item.FindControl("lblViewer");
                Session["Viewer"] = ViewerLBL.Text;


                Label Label2 = (Label)e.Item.FindControl("Label2");
                Session["CountBooking"] = Label2.Text;

                tblLocationBus tblBUS = new tblLocationBus();

                int LocationID = Convert.ToUInt16(lbl.Text.ToString());
                int Viewer = Convert.ToUInt16(ViewerLBL.Text.ToString());
                int newV = Viewer + 1;
                tblBUS.Update_Viewer(LocationID, newV);

                Session["nameLocationtest"] = lblShow.Text;
                Response.Redirect("DetailLocation.aspx?name=" + namelct.ToString());
            }
        }

        protected void TopRate_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "chinhsua")
            {
                Label lbl = (Label)e.Item.FindControl("lblIDTopRate");
                Session["IDLocation"] = lbl.Text;

                Label lblShow = (Label)e.Item.FindControl("lblNameRate");
                //if (lbl != null) lblten.Text = lbl.Text;
                namelct = lblShow.Text;
                //lblten.Text = namelct.ToString();

                Label ViewerLBL = (Label)e.Item.FindControl("lblViewer");
                Session["Viewer"] = ViewerLBL.Text;

                Label Label2 = (Label)e.Item.FindControl("Label2");
                Session["CountBooking"] = Label2.Text;

                tblLocationBus tblBUS = new tblLocationBus();

                int LocationID = Convert.ToUInt16(lbl.Text.ToString());
                int Viewer = Convert.ToUInt16(ViewerLBL.Text.ToString());
                int newV = Viewer + 1;
                tblBUS.Update_Viewer(LocationID, newV);

                Session["nameLocationtest"] = lblShow.Text;
                Response.Redirect("DetailLocation.aspx?name=" + namelct.ToString());
            }
        }

        protected void TopView_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "chinhsua")
            {
                Label lbl = (Label)e.Item.FindControl("Label1");
                Session["IDLocation"] = lbl.Text;

                Label lblShow = (Label)e.Item.FindControl("NAMELOCATION");
                //if (lbl != null) lblten.Text = lbl.Text;
                namelct = lblShow.Text;
                //lblten.Text = namelct.ToString();

                Label ViewerLBL = (Label)e.Item.FindControl("lblViewer");
                Session["Viewer"] = ViewerLBL.Text;

                Label Label2 = (Label)e.Item.FindControl("Label2");
                Session["CountBooking"] = Label2.Text;

                tblLocationBus tblBUS = new tblLocationBus();

                int LocationID = Convert.ToUInt16(lbl.Text.ToString());
                int Viewer = Convert.ToUInt16(ViewerLBL.Text.ToString());
                int newV = Viewer + 1;
                tblBUS.Update_Viewer(LocationID, newV);

                Session["nameLocationtest"] = lblShow.Text;
                Response.Redirect("DetailLocation.aspx?name=" + namelct.ToString());
            }
        }

        public static string Area;
        public static string nameLocation;

        protected void search_Click(object sender, EventArgs e)
        {
             Area = area.SelectedValue.ToString();
             nameLocation = txtArrival.Value;

            

            Response.Redirect("SearchResult.aspx?name=" + Area.ToString() +"or"+ nameLocation.ToString());
        }
    }
}