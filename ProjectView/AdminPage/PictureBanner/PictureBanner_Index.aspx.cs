using Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Public;

namespace ProjectView.AdminPage.PictureBanner
{
    public partial class PictureBanner_Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userLogin"] == null)
            {
                Response.Redirect("../index.aspx");
            }
            if (!IsPostBack)
            {
                LoadSlider();
            }
        }

        private void LoadSlider()
        {
            string roll = "banner";
            tblPictureBus Ptc = new tblPictureBus();
            DataTable dt = Ptc.LoadDataPictureByRoll(roll);

            theID.DataSource = dt;
            theID.DataBind();
        }
        public static string url;
        public static string name;

        protected void theID_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "chinhsua")
            {
                Label lbl = (Label)e.Item.FindControl("id");
                Session["id"] = lbl.Text;

                Label lblname = (Label)e.Item.FindControl("name");
                //if (lbl != null) lblten.Text = lbl.Text;
                name = lblname.Text;
                Session["name"] = lbl.Text;

                Label urllbl = (Label)e.Item.FindControl("url");
                //if (lbl != null) lblten.Text = lbl.Text;
                url = urllbl.Text;


                Response.Redirect("DetailImage.aspx?name=" + name.ToString());

            }
            if (e.CommandName == "delete")
            {
                Label lbl2 = (Label)e.Item.FindControl("id");
                int idd = Convert.ToUInt16(lbl2.Text);
                tblPictureBus bus = new tblPictureBus();
                

                int del = bus.DeleteTblPicture(idd);
                if (del != 0)
                {
                    LoadSlider();
                }
            }
        }
    }
}