using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPagesHomework
{
    public partial class BasicInfo : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            userAvatar.Width = Unit.Percentage(40);
            userAvatar.Height = Unit.Percentage(40);
            userAvatar.ImageUrl = "http://pre08.deviantart.net/871b/th/pre/i/2010/109/8/4/creepy_shadow_avatar_by_eliotchan.jpg";
        }
    }
}