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
    public partial class NewLocation : System.Web.UI.Page
    {
        int idnew;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userLogin"] == null)
            {
                Response.Redirect("../index.aspx");
            }
            if (!IsPostBack)
            {
                string u = Session["userLogin"].ToString();
                username.Value = u;
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
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string locationName = nameLocation.Value.ToString();
            string locationArea = areaDDL.SelectedValue.ToString();
            string locationContent = content.Value.ToString();
            string username = Session["userLogin"].ToString();

            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            // datecreate: mm / dd / yyyy
            string dateCreate = month + "/" + day + "/" + year;

            if (locationName == null || locationName.Equals(""))
            {
                txtErrorName.Visible = true;
            }

            if (locationContent == null || content.Value.Equals(" ") || locationContent == " " || locationContent.Trim().Equals(""))
            {
                txtErrorContent.Visible = true;              
            }
            else
            {
                tblLocationBus lb = new tblLocationBus();

                TblLocation lbl = new TblLocation(locationName, locationArea, locationContent, dateCreate, username);
                lb.InsertTblLocation(lbl);

                if (FileUpload1.HasFile)
                {
                    DataTable dt = lb.SelectTopID();

                    int row = dt.Rows.Count;
                    if (row > 0)
                    {
                        //location ID
                        DataRow dr = dt.Rows[0];
                        test11.Value = dr["ID"].ToString();
                        idnew = Convert.ToInt32(dr["ID"].ToString());
                        //
                        string url = FileUpload1.FileName;
                        FileUpload1.PostedFile.SaveAs(Server.MapPath(".") + "//image//" + url);
                        string path = "/AdminPage/Location/image/" + url.ToString();
                        TblPicture pt = new TblPicture(idnew, url, path, "showerLocation", "writer");

                        tblPictureBus pb = new tblPictureBus();
                        pb.InsertTblPicture(pt);
                    }
                }
                else
                {
                    TblPicture pt = new TblPicture(idnew, "NOIMAGE", "/AdminPage/Location/image/noImage.png", "showerLocation", "writer");

                    tblPictureBus pb = new tblPictureBus();
                    pb.InsertTblPicture(pt);
                }
                Response.Redirect("../Index.aspx");
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            nameLocation.Value = "";
            content.Value = "";
        }
    }
}