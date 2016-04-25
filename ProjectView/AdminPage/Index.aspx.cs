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
    public partial class Index : System.Web.UI.Page
    {
        public static string name;
        public static string area;
        public static string content;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userLogin"] == null)
            {
                Response.Redirect("../index.aspx");
            }
            if (!IsPostBack)
            {
                loadDataLocation();
                Session["id"] = null;
            }
        }

        private void loadDataLocation()
        {
            tblLocationBus lb = new tblLocationBus();
            DataTable dt = lb.LoadLocation();

            theID.DataSource = dt;
            theID.DataBind();
        }

       
        protected void theID_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "chinhsua")
            {
                Label lbl = (Label)e.Item.FindControl("idLocation");
                Session["IDLocation"] = lbl.Text;

                Label lblname = (Label)e.Item.FindControl("locationName");
                //if (lbl != null) lblten.Text = lbl.Text;
                name = lblname.Text;
                Session["LocationName"] = lbl.Text;

                Label lblArea = (Label)e.Item.FindControl("Area");
                //if (lbl != null) lblten.Text = lbl.Text;
                area = lblArea.Text;

                Label lblContent = (Label)e.Item.FindControl("locationContent");
                //if (lbl != null) lblten.Text = lbl.Text;
                content = lblContent.Text;


                Response.Redirect("Location/UpdateLocation.aspx?name=" + name.ToString());

            }
            if (e.CommandName == "delete")
            {
                Label lbl2 = (Label)e.Item.FindControl("idLocation");
                int idd = Convert.ToUInt16(lbl2.Text);
                tblLocationBus bus = new tblLocationBus();

                int del = bus.DeleteTblLocation(idd);
                if (del != 0)
                {
                    loadDataLocation();
                }
            }
        }

    }
}