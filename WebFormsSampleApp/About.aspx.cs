using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsSampleApp
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            httpSubTitleLabel.Text = "Let's try the Http Handler!";
        }

        protected void httpButton_Click(object sender, EventArgs e)
        {
            MyTextImage.ImageUrl = "Imagehadnler.ashx?text=" + HttpContext.Current.Server.UrlEncode(MyTextBox.Text);
        }
    }
}