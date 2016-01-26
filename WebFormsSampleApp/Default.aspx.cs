using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsSampleApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            operationSubTitleLabel.Text = "Let's make some calculations!";
            firstLabel.Text = "First value: ";
            secondLabel.Text = "Second value: ";
            resultLabel.Text = "Result: ";
            operationSelectLabel.Text = "Select operation: ";
        }

        protected void calculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                responseLabel.Attributes.Add("style", "display: none");
                if (mathOperationSelector.SelectedValue.Equals("sum"))
                {
                    resultTextBox.Text = (int.Parse(firstInputTextBox.Text) + int.Parse(secondInputTextBox.Text)).ToString();
                }
                else
                {
                    resultTextBox.Text = (int.Parse(firstInputTextBox.Text) * int.Parse(secondInputTextBox.Text)).ToString();
                }
                
            }
            catch(Exception ex)
            {
                responseLabel.Text = "Please enter appropriate values!";
                responseLabel.Attributes.Add("style", "display: block");
                responseLabel.Attributes.Add("class", "label label-danger");
            } 
        }
    }
}