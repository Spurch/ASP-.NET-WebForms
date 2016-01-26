using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebControlsHomeWork
{
    public partial class Contact : Page
    {
        /*
            Ultra-duper mega cool code snippet from StackOverflow - It'll save your life one day!
        */
        private static Control FindControlIterative(Control root, string id)
        {
            Control ctl = root;
            var ctls = new LinkedList<Control>();

            while (ctl != null)
            {
                if (ctl.ID == id)
                    return ctl;
                foreach (Control child in ctl.Controls)
                {
                    if (child.ID == id)
                        return child;
                    if (child.HasControls())
                        ctls.AddLast(child);
                }
                if (ctls.First != null)
                {
                    ctl = ctls.First.Value;
                    ctls.Remove(ctl);
                }
                else return null;
            }
            return null;
        }

        private static List<TextBox> GetAllFreeCells(Control root, bool flag = false)
        {
            List<TextBox> resultList = new List<TextBox>();
            Control ctl = root;
            foreach (Control child in ctl.Controls)
            {
                foreach(Control cell in child.Controls)
                {
                    foreach(TextBox text in cell.Controls)
                    {
                        if (flag)
                        {
                            if (!IsItFreeToPlay(text as TextBox))
                            {
                                resultList.Add(text as TextBox);
                            }
                        }
                        else
                        {
                            if (IsItFreeToPlay(text as TextBox))
                            {
                                resultList.Add(text as TextBox);
                            }
                        }
                        
                    }
                }
            }
     
            return resultList;
        }

        private static bool IsItFreeToPlay(TextBox cell)
        {
            if(cell.Attributes["disabled"] != null)
            {
                return false;
            }

            return true;
        }

        private void DummyPlayerMove(string PlayerMoveCellId)
        {
            Random rand = new Random();
            TextBox currentBox = new TextBox();
            if (GetAllFreeCells(TicTacToeField).Any())
            {
                int size = GetAllFreeCells(TicTacToeField).Count;
                if (size <= 1)
                {
                    currentBox = GetAllFreeCells(TicTacToeField)[0];
                }
                else
                {
                    var currentIndex = rand.Next(0, size);
                    currentBox = GetAllFreeCells(TicTacToeField)[currentIndex];
                }

                currentBox.Attributes.Add("disabled", "disabled");
                currentBox.Attributes.Add("style", "text-align:center");
                currentBox.Attributes.Add("value", "O");
            }            
        }

        private bool IsWinningCondition()
        {
            var list = GetAllFreeCells(TicTacToeField, true);
            
            return false;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string controlName = Page.Request.Params["__EVENTTARGET"];
                var control = (TextBox)FindControl(controlName);
                control.Attributes.Add("disabled", "disabled");
                control.Attributes.Add("style", "text-align:center");
                control.Attributes.Add("value", control.Text);
                DummyPlayerMove(control.ClientID);
            }
        }
    }
}