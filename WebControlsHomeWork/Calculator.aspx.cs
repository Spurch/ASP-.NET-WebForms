using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebControlsHomeWork
{
    public partial class Calculator : Page
    {
        private static double firstValue;
        private static double secondValue;
        private static double currentSum;

        private static string currentValue;
        private static string LastOperation;

        private static bool clearDisplayFlag;
        private static bool secondaryOperation;

        protected void Page_Load(object sender, EventArgs e)
        {
            clearDisplayFlag = true;
            secondaryOperation = false;
        }

        protected void number_Click(object sender, EventArgs e)
        {
            if (clearDisplayFlag)
            {
                CalculatorDisplay.Text = "";
                clearDisplayFlag = false;
            }
            Button btn = (Button)sender;
            currentValue += btn.Text;
            CalculatorDisplay.Text = currentValue.ToString();
        }

        protected void clearAll_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            firstValue = 0;
            currentSum = 0;
            currentValue = "";
            secondValue = 0;
        }

        protected void result_Click(object sender, EventArgs e)
        {
            double temp;
            switch (LastOperation)
            {
                case "+":
                    temp = (firstValue + double.Parse(CalculatorDisplay.Text));
                    CalculatorDisplay.Text = temp.ToString();
                    break;
                case "-":
                    temp = (firstValue - double.Parse(CalculatorDisplay.Text));
                    CalculatorDisplay.Text = temp.ToString();
                    break;
                case "*":
                    temp = (firstValue * double.Parse(CalculatorDisplay.Text));
                    CalculatorDisplay.Text = temp.ToString();
                    break;
                case "/":
                    if(double.Parse(CalculatorDisplay.Text) == 0)
                    {
                        CalculatorDisplay.Text = "ERROR!";
                        break;
                    }
                    temp = (firstValue / double.Parse(CalculatorDisplay.Text));
                    CalculatorDisplay.Text = temp.ToString();
                    break;
                case "&radic;":
                    temp = Math.Sqrt(firstValue);
                    CalculatorDisplay.Text = temp.ToString();
                    break;
                default:
                    break;
            }
            clearDisplayFlag = true;
            secondaryOperation = false;
            LastOperation = "";
            currentValue = "";
        }

        protected void operation_Click(object sender, EventArgs e)
        {
            clearDisplayFlag = true;
            currentValue = "";

            Button btn = (Button)sender;
            string operation = btn.Text;
            double current;

            if (secondaryOperation)
            {
                current = firstValue + double.Parse(CalculatorDisplay.Text);
                CalculatorDisplay.Text = current.ToString();
                firstValue = current;
            }
            else
            {
                firstValue = double.Parse(CalculatorDisplay.Text);
                secondaryOperation = true;
            }

            switch (operation)
            {
                case "+":
                    LastOperation = "+";
                    break;
                case "-":
                    LastOperation = "-";
                    break;
                case "*":
                    LastOperation = "*";
                    break;
                case "/":
                    LastOperation = "/";
                    break;
                case "&radic;":
                    LastOperation = "&radic;";
                    break;
            }
        }
    }
}