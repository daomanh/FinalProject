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

namespace ProjectView.AdminPage.Contact
{
    public partial class AllContact : System.Web.UI.Page
    {
        public static string name;
        public static string phone;
        public static string email;
        public static string mesage;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userLogin"] == null)
            {
                Response.Redirect("../index.aspx");
            }
            if (!IsPostBack)
            {
                loadDataContent();
                Session["idContent"] = null;
            }
        }

        private void loadDataContent()
        {
            TblContactBus tblCB = new TblContactBus();
            DataTable dt = tblCB.LoadAllContact();

            theID.DataSource = dt;
            theID.DataBind();
        }

        protected void theID_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "chinhsua")
            {
                Label lbl = (Label)e.Item.FindControl("ID");
                Session["ID"] = lbl.Text;

                int id = Convert.ToInt16(lbl.Text.ToString());

                Label lblname = (Label)e.Item.FindControl("Name");
                //if (lbl != null) lblten.Text = lbl.Text;
                name = lblname.Text;                

                Label lblPHone = (Label)e.Item.FindControl("Phone");
                //if (lbl != null) lblten.Text = lbl.Text;
                phone = lblPHone.Text;

                Label lblMesage = (Label)e.Item.FindControl("Mesage");
                //if (lbl != null) lblten.Text = lbl.Text;
                mesage = lblMesage.Text;

                Label lblmail = (Label)e.Item.FindControl("Email");
                //if (lbl != null) lblten.Text = lbl.Text;
                email = lblmail.Text;

                Label lblSTT =(Label) e.Item.FindControl("STT");
                if (lblSTT.Text.Equals("REPLY"))
                {
                    Response.Redirect("ContactDetail.aspx?name=" + name.ToString());
                }
                else {
                    TblContact tblc = new TblContact(name, email, phone, mesage, "NOREAD");
                    TblContactBus tblBus = new TblContactBus();
                    tblBus.UPDATE_CONTACT("NotReply", id);

                    Response.Redirect("ContactDetail.aspx?name=" + name.ToString());
                }

            }
        }
    }
}