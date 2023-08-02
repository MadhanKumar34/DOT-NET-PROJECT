using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_2
{
    public partial class Student_Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            // TODO: Implement login logic here
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Check if email and password are valid (e.g. by querying a database)
            string connectionString = "Data Source=MADHAN;Initial Catalog=PROJECT;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM STUDENT WHERE Email = @Email AND Password = @Password", con);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) // If there is a matching user in the database
                {
                    // Store user details in session or other storage for later use
                    Session["Email"] = email;
                    Session["FirstName"] = reader["FirstName"];
                    Session["LastName"] = reader["LastName"];
                    // ...

                    // Redirect to another page to display user details
                    Response.Redirect("~/Student_Details.aspx");
                }
                else
                {
                    // Display an error message for invalid login
                    lblMessage.Text = "Invalid email or password.";
                }
            }
        }
    }
}