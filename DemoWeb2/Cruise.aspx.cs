using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Public;
using Business;
using System.Data;

namespace DemoWeb2
{
    public partial class Cruise : System.Web.UI.Page
    {
        

        private void loadDataCruise()
        {
            CruiseBus cb = new CruiseBus();
            DataSet ds = new DataSet();

            DataTable dt = cb.LoadCruise();

            DataList1.DataSource = dt;
            DataList1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadDataCruise();
            }
        }
    }
}