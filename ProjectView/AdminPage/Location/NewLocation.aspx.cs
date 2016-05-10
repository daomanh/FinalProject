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

            tblLocationBus lb = new tblLocationBus();
            DataTable dtSearch = lb.Search_location_by_name(locationName);
            int count = dtSearch.Rows.Count;
            if (count > 0)
            {
                txtErrorName2.Visible = true;
            }

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

                if (FileUpload1.HasFile)
                {

                    Boolean fileOK = false;
                    Boolean fileOK2 = false;

                    string url = FileUpload1.FileName;
                    string urlICON = FileUpload2.FileName;

                    string fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
                    string fileExtension2 = System.IO.Path.GetExtension(FileUpload2.FileName).ToLower();
                    string[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };
                    string[] allowedExtensions2 = { ".gif", ".png", ".jpeg", ".jpg" };

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
                    else
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
                        else
                        {
                            TblLocation lbl = new TblLocation(locationName, locationArea, locationContent, dateCreate, username);
                            lb.InsertTblLocation(lbl);
                            DataTable dt = lb.SelectTopID();

                            int row = dt.Rows.Count;

                            if (row > 0)
                            {
                                //location ID
                                DataRow dr = dt.Rows[0];
                                test11.Value = dr["ID"].ToString();
                                idnew = Convert.ToInt32(dr["ID"].ToString());
                                //
                            }

                            FileUpload2.PostedFile.SaveAs(Server.MapPath(".") + "//image//" + urlICON);
                            string path2 = "/AdminPage/Location/image/" + url.ToString();
                            TblPicture pt2 = new TblPicture(idnew, urlICON, path2, "icon", "writer");

                            FileUpload1.PostedFile.SaveAs(Server.MapPath(".") + "//image//" + url);
                            string path = "/AdminPage/Location/image/" + url.ToString();
                            TblPicture pt = new TblPicture(idnew, url, path, "showerLocation", "writer");

                            tblPictureBus pb = new tblPictureBus();
                            pb.InsertTblPicture(pt);
                            pb.InsertTblPicture(pt2);

                            Response.Redirect("../Index.aspx");
                        }
                    }
                }

                else
                {


                    TblLocation lbl = new TblLocation(locationName, locationArea, locationContent, dateCreate, username);
                    lb.InsertTblLocation(lbl);
                    DataTable dt = lb.SelectTopID();

                    int row = dt.Rows.Count;

                    if (row > 0)
                    {
                        //location ID
                        DataRow dr = dt.Rows[0];
                        test11.Value = dr["ID"].ToString();
                        idnew = Convert.ToInt32(dr["ID"].ToString());
                        //
                    }

                    TblPicture pt2 = new TblPicture(idnew, "NOIMAGE_ico", "/AdminPage/Location/image/icon_NOIMG.png", "icon", "writer");

                    TblPicture pt = new TblPicture(idnew, "NOIMAGE", "/AdminPage/Location/image/noImage.png", "showerLocation", "writer");
                    tblPictureBus pb = new tblPictureBus();
                    pb.InsertTblPicture(pt);
                    pb.InsertTblPicture(pt2);

                    Response.Redirect("../Index.aspx");
                }


            }

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            nameLocation.Value = "";
            content.Value = "";
        }
    }
}