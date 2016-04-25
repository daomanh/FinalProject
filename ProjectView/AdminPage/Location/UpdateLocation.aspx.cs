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

namespace ProjectView.AdminPage.Location
{
    public partial class UpdateLocation : System.Web.UI.Page
    {
        tblLocationBus lb = new tblLocationBus();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userLogin"] == null)
            {
                Response.Redirect("../index.aspx");
            }
            if (!IsPostBack)
            {
                test.Value = Session["IDLocation"].ToString();
                nameLocationU2.Text = Index.name;
              //  Area.Value = Index.area;
                content.Value = Index.content;
                NameLocationV.Text = Index.name;

                LoadArea();
            }
        }
        private void LoadArea()
        {
            TblAreaBus tbla = new TblAreaBus();
            DataTable dt = tbla.LoadArea();

            areaDDL.DataSource = dt;
            areaDDL.DataValueField = "AreaName";

            areaDDL.DataBind();

            areaDDL.SelectedValue = Index.area;
        }
        protected void btnReset_Click(object sender, EventArgs e)
        {
            test.Value = Session["IDLocation"].ToString();
            nameLocationU2.Text = Index.name;
            //  Area.Value = Index.area;
            content.Value = Index.content;
            NameLocationV.Text = Index.name;

            LoadArea();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(test.Value.ToString());
            string locationName = nameLocationU2.Text;
            string locationArea = areaDDL.SelectedValue.ToString();
            string locationContent = content.Value.ToString();
            string username = Session["userLogin"].ToString();

            if (locationName == null || locationName.Equals(""))
            {
                txtErrorName.Visible = true;
            }

            if (locationContent == null || content.Value.Equals(" ") || locationContent == " " || locationContent.Trim().Equals(""))
            {
                txtErrorContent.Visible = true;
            }

            TblLocation lbl = new TblLocation(locationName, locationArea, locationContent, username, 0, id);
            if (lb.UpdateTblLocation(lbl) != 0)
            {
                Response.Redirect("../Index.aspx");
            }
            else
            {
                Response.Redirect("/dasdasdadasd.aspx");
            }




        }
    }
}