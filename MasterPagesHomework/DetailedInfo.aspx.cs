using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPagesHomework
{
    public partial class DetailedInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            userFlavourText.Text = "Some flavour text generated from code-behind";
            userFlavourText.TextMode = TextBoxMode.MultiLine;
            userFlavourText.Rows = 20;
            userFlavourText.Style.Add("resize", "none");
        }
    }
}