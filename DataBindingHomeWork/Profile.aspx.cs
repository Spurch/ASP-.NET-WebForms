using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataBindingHomeWork
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var result = Request.QueryString["ID"];

            // ConnectionString to NorthWind Database.
            string connectionString = "Data Source=./;Initial Catalog=Northwind;Integrated Security=True";
            // Create SQLDataSource.
            SqlDataSource sqlDataSource = new SqlDataSource();
            sqlDataSource.ID = "NorthWindDataSource";
            this.Page.Controls.Add(sqlDataSource);
            // Bind ConnectionString to SQLDataSource.
            sqlDataSource.ConnectionString = connectionString;
            // Retrieve records with only 5 Columns from Employees table of NorthWind Database.
            sqlDataSource.SelectCommand = "SELECT * FROM Employees WHERE EmployeeID = " + result + ";";
            DetailsView1.DataSource = sqlDataSource;
            DetailsView1.DataBind();
        }
    }
}