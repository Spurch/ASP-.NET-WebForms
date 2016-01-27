using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataBindingHomeWork
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // ConnectionString to NorthWind Database.
            string connectionString = "Data Source=./;Initial Catalog=Northwind;Integrated Security=True";
            // Create SQLDataSource.
            SqlDataSource sqlDataSource = new SqlDataSource();
            sqlDataSource.ID = "NorthWindDataSource";
            this.Page.Controls.Add(sqlDataSource);
            // Bind ConnectionString to SQLDataSource.
            sqlDataSource.ConnectionString = connectionString;
            // Retrieve records with only 5 Columns from Employees table of NorthWind Database.
            sqlDataSource.SelectCommand = "SELECT CONCAT(FirstName, ' ', LastName) AS Employee, EmployeeID  FROM Employees";
            // Bind SQLDataSource to GridView after retrieving the records.
            GridView1.DataSource = sqlDataSource;
            GridView1.DataBind();
        }
    }
}