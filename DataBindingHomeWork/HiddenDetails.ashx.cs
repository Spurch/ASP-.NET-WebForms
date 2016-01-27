using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DataBindingHomeWork
{
    /// <summary>
    /// Summary description for HiddenDetails
    /// </summary>
    public class HiddenDetails : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string id = context.Request.QueryString["ID"];
            string connect = "Data Source=./;Initial Catalog=Northwind;Integrated Security=True";
            string query = "SELECT Photo, HomePhone, Address, Notes FROM Employees WHERE EmployeeID =" + id + ";";
            if (id != null)
            {
                using (SqlConnection conn = new SqlConnection(connect))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("EmployeeID", context.Request.QueryString["ID"]);
                        conn.Open();
                        SqlDataReader rdr = cmd.ExecuteReader();
                        if (rdr.HasRows)
                        {
                            while (rdr.Read())
                            {
                                context.Response.Write("<p>" + "Phone: " + rdr["HomePhone"].ToString() + "</p>");
                                context.Response.Write("<p>" + "Address: " + rdr["Address"].ToString() + "</p>");
                                context.Response.Write("<p>" + "Notes: " + rdr["Notes"].ToString() + "</p>");
                            }
                        }
                    }
                }
            }
            else
            {
                context.Response.Write("<p>No customer selected</p>");
            }
            context.Response.End();
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}