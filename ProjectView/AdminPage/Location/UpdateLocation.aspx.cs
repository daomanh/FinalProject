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
        private int ID;
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
                LoadDataPictureOfLocation();
                LoadArea();
            }
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
                Session["PID"] = dt.Rows[0]["ID"].ToString();

                DataTable dtICON = picB.LoadDataPictureICONByLocationID(id);
                ICON.DataSource = dtICON;
                ICON.DataBind();
                Session["ICONID"] = dtICON.Rows[0]["ID"].ToString();
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

            
            TblLocation lbl = new TblLocation(locationName, locationArea, locationContent, dateCreate, username,id);

            if (lb.UpdateTblLocation(lbl) != 0)
            {
                tblPictureBus pb = new tblPictureBus();
                Boolean fileOK = false;
                Boolean fileOK2 = false;

                string fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
                string fileExtension2 = System.IO.Path.GetExtension(FileUpload2.FileName).ToLower();
                string[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };
                string[] allowedExtensions2 = { ".gif", ".png", ".jpeg", ".jpg" };
                

                if (FileUpload2.HasFile)
                {
                    for (int i = 0; i < allowedExtensions2.Length; i++)
                    {
                        if (fileExtension2 == allowedExtensions2[i])
                        {
                            fileOK2 = true;
                        }
                        else
                        {
                            fileOK2 = false;
                        }
                    }
                    if (fileOK2 == false)
                    {
                        txtERRORIMG2.Visible = true;
                    }
                    else {
                        int i2 = Convert.ToInt32(Session["ICONID"].ToString());
                        int del2 = pb.DeleteTblPicture(i2);
                        if (del2 != 0)
                        {
                            string url2 = FileUpload2.FileName;
                            FileUpload2.PostedFile.SaveAs(Server.MapPath(".") + "//image//" + url2);
                            string path2 = "/AdminPage/Location/image/" + url2.ToString();
                            TblPicture pt2 = new TblPicture(id, url2, path2, "icon", "writer");

                            pb.InsertTblPicture(pt2);
                        }
                        else
                        {
                            Response.Redirect("../Error404.aspx");
                        }
                    }
                }

                if (FileUpload1.HasFile)
                {
                    for (int i = 0; i < allowedExtensions.Length; i++)
                    {
                        if (fileExtension == allowedExtensions[i])
                        {
                            fileOK = true;
                        }
                        else
                        {
                            fileOK = false;
                        }
                    }
                    if (fileOK == false)
                    {
                        txtERRORIMG1.Visible = true;
                    }
                    else {
                        int i = Convert.ToInt32(Session["PID"].ToString());
                        int del = pb.DeleteTblPicture(i);

                        if (del != 0)
                        {
                            string url = FileUpload1.FileName;
                            FileUpload1.PostedFile.SaveAs(Server.MapPath(".") + "//image//" + url);
                            string path = "/AdminPage/Location/image/" + url.ToString();
                            TblPicture pt = new TblPicture(id, url, path, "showerLocation", "writer");

                            pb.InsertTblPicture(pt);

                        }
                        else
                        {
                            Response.Redirect("../Error404.aspx");
                        }
                    }
                }

                Response.Redirect("../Index.aspx");
            }
            else
            {
                Response.Redirect("../Error404.aspx");
            }
        }
    }
}