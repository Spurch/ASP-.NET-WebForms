using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebControlsHomeWork
{
    public partial class About : Page
    {
        public string[] Universities;
        public string[] Specialties;
        public string[] Courses;
        public string SelectedCourses;

        protected void Page_Init(object sender, EventArgs e)
        {
            SelectedCourses = "";
            Universities = new string[]{ "UNWE", "SU", "TU", "NBU"};
            Specialties = new string[] { "Mathematics", "Computer Science", "Literature" };
            Courses = new string[] { "Linear Algebra 101", "Geometry", "C# Part 1", "Applied Statistics", "Object Oriented Programing", "Data Structures", "Ancient Literature", "History of Medival Literature", "Contemporary Literature" };
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                SelectedCourses += coursesList.SelectedItem.Value;
                return;
            }

            List<ListItem> universities = new List<ListItem>();
            List<ListItem> specialties = new List<ListItem>();
            List<ListItem> courses = new List<ListItem>();

            for (int i = 0; i < Universities.Length; i++)
            {
                universities.Add(new ListItem(Universities[i], i.ToString()));
            }
            universityList.DataSource = universities;
            universityList.DataBind();

            for (int i = 0; i < Specialties.Length; i++)
            {
                specialties.Add(new ListItem(Specialties[i], i.ToString()));
            }
            specialtyList.DataSource = specialties;
            specialtyList.DataBind();

            for (int i = 0; i < Courses.Length; i++)
            {
                courses.Add(new ListItem(Courses[i], i.ToString()));
            }
            coursesList.DataSource = courses;
            coursesList.DataBind();
        }

        protected void OnStudentSubmit(object sender, EventArgs e)
        {
            var h1 = new HtmlGenericControl("h1");
            h1.InnerText = "Submited Student Info:";
            result.Controls.Add(h1);

            var label = new HtmlGenericControl("label");
            var p = new HtmlGenericControl("p");

            label.Attributes.Add("for", firstName.ID);
            label.InnerText = "First name:";
            p.InnerText = firstName.Text;

            result.Controls.Add(label);
            result.Controls.Add(p);

            label = new HtmlGenericControl("label");
            p = new HtmlGenericControl("p");

            label.Attributes.Add("for", lastName.ID);
            label.InnerText = "Last name:";
            p.InnerText = lastName.Text;

            result.Controls.Add(label);
            result.Controls.Add(p);

            label = new HtmlGenericControl("label");
            p = new HtmlGenericControl("p");

            label.Attributes.Add("for", facultyNumber.ID);
            label.InnerText = "Faculty number:";
            p.InnerText = facultyNumber.Text;

            result.Controls.Add(label);
            result.Controls.Add(p);

            label = new HtmlGenericControl("label");
            p = new HtmlGenericControl("p");

            label.Attributes.Add("for", universityList.ID);
            label.InnerText = "University:";
            p.InnerText = universityList.SelectedValue;

            result.Controls.Add(label);
            result.Controls.Add(p);

            label = new HtmlGenericControl("label");
            p = new HtmlGenericControl("p");

            label.Attributes.Add("for", specialtyList.ID);
            label.InnerText = "Specialty:";
            p.InnerText = specialtyList.SelectedValue;

            result.Controls.Add(label);
            result.Controls.Add(p);

            label = new HtmlGenericControl("label");
            p = new HtmlGenericControl("p");

            label.Attributes.Add("for", coursesList.ID);
            label.InnerText = "Courses:";
            string temp = "";
            
            foreach(ListItem item in coursesList.Items)
            {
                if (item.Selected)
                {
                    temp += " " + item.Value;   
                }
            }

            p.InnerText = temp;
            result.Controls.Add(label);
            result.Controls.Add(p);
        }
    }
}