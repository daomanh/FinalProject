using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ProjectView
{
    public partial class SearchResult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDataSearch();
            }
        }

        private void LoadDataSearch()
        {
            string nameLocation = Index.nameLocation;
            string Area = Index.Area;

            tblLocationBus lbus = new tblLocationBus();            
            DataTable dt = lbus.SearchLocationByName_Area(nameLocation, Area);

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
            LoadDataSearch();
        }

        protected void theLocation_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}