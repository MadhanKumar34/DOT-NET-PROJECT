using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_2
{
    public partial class Student_FPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            // TODO: Implement login logic here
            string email = Email.Text.Trim();
            string Squestion = SQuestion.Text.Trim();

            // Check if email and password are valid (e.g. by querying a database)
            string connectionString = "Data Source=MADHAN;Initial Catalog=PROJECT;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Password FROM STUDENT WHERE Email = @Email AND Squestion = @SQuestion", con);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Squestion", Squestion);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {  // If there is a matching user in the database

                    string password = reader[0].ToString();
                    lblMessage.Text = "Your Password Is "+password;
                    // ...

                    // Redirect to another page to display user details

                }
                else
            {
                // Display an error message for invalid login
                lblMessage.Text = "Invalid email or Security Question.";
            }
        }
        }
    }
}