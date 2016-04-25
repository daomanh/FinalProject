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
using System.IO;

namespace ProjectView.AdminPage.PictureBanner
{
    public partial class NewImageBanner : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userLogin"] == null)
            {
                Response.Redirect("../index.aspx");
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string url = FileUpload1.FileName;
                FileUpload1.PostedFile.SaveAs(Server.MapPath(".") + "/image/" + url);
                string path = "/AdminPage/PictureBanner/image/" + url.ToString();
                int id = 0;
                TblPicture pt = new TblPicture(id , url, path, "banner", "banner");

                tblPictureBus pb = new tblPictureBus();
                int a = pb.InsertTblPicture(pt);
                if (a > 0)
                {
                    string url2 = FileUpload2.FileName;
                    FileUpload2.PostedFile.SaveAs(Server.MapPath(".") + "/image/" + url2);
                    string path2 = "/AdminPage/PictureBanner/image/" + url2.ToString();
                    
                    TblPicture pt2 = new TblPicture(id, url2, path2, "banner", "banner");

                    tblPictureBus pb2 = new tblPictureBus();
                    pb2.InsertTblPicture(pt2);


                    Response.Redirect("/Index.aspx");
                }
                else
                {
                    Response.Redirect("/asdsa.aspx");
                }

            }
        }


        protected void btnReset_Click(object sender, EventArgs e)
        {
           
        }
    }
}