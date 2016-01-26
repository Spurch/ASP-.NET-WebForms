using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebControlsHomeWork
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void GenerateNumber(object sender, EventArgs e)
        {
            int start = Int32.Parse(rangeStart.Text);
            int end = Int32.Parse(rangeEnd.Text);
            var rand = new Random();
            var result = rand.Next(start, end);
            resultBox.Text = result.ToString();
        }

        protected void OnHtmlSubmit(object sender, EventArgs e)
        {
            submitedLabel.Text = htmlEscapedField.Text;
            submitedText.Text = htmlEscapedField.Text;
        }
    }
}