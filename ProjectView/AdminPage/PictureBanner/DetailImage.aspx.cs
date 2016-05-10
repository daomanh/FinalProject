using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectView.AdminPage.PictureBanner
{
    public partial class DetailImage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            image.Src = PictureBanner_Index.url;
            name.Text = PictureBanner_Index.name;
        }
    }
}