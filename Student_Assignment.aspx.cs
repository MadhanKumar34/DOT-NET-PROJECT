using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_2
{
    public partial class Student_Assignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string connectionString = "Data Source=MADHAN;Initial Catalog=PROJECT;Integrated Security=True"; // Replace with your actual connection string

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Retrieve data from the database
                    SqlCommand command = new SqlCommand("SELECT * FROM Assignments", connection);
                    SqlDataReader reader = command.ExecuteReader();

                    // Bind the data to the GridView control
                    GridView1.DataSource = reader;
                    GridView1.DataBind();

                    // Close the reader and connection
                    reader.Close();
                    connection.Close();
                }
            }

        }
        protected void Sign_Out(object sender, EventArgs e)
        {
            Response.Redirect("~/index.html");
        }
    }
}