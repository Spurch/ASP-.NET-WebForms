using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPagesHomework
{
    public partial class FriendList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            listAllFriends.Width = Unit.Percentage(100);
            listAllFriends.Height = Unit.Percentage(100);
        }
    }
}