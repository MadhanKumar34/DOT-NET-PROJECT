using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_2
{
    public partial class Faculty_Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Submit_Click(object sender, EventArgs e)
        {
            string FName = Fname.Text.Trim();
            string LName = Lname.Text.Trim();
            string email = Email.Text.Trim();
            string SQuestion = Squestion.Text.Trim();
            string password = Password.Text.Trim();

            if (password.Length >= 6)
            {

                string conn = "Data Source = MADHAN; Initial Catalog = PROJECT; Integrated Security = True";
                using (SqlConnection con = new SqlConnection(conn))
                {

                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("Select email from faculty where email=@email", con);
                    cmd1.Parameters.AddWithValue("@email", email);
                    SqlDataReader reader = cmd1.ExecuteReader();
                    if (reader.Read())
                    {
                        lblMessage.Text = "Email Already Exists...Try Using Login";
                        reader.Close(); 
                    }
                    else
                    {
                        reader.Close();
                        SqlCommand cmd = new SqlCommand("INSERT INTO Faculty (FirstName, LastName, Email, Password,SQuestion) VALUES (@FirstName, @LastName, @Email, @Password,@SQuestion)", con);
                        cmd.Parameters.AddWithValue("@FirstName", FName);
                        cmd.Parameters.AddWithValue("@LastName", LName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@SQuestion", SQuestion);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            lblMessage.Text = "Registration successful! Please Login";
                        }
                        else
                        {
                            // Display an error message for registration failure
                            lblMessage.Text = "Registration failed. Please try again.";
                        }
                    }
                }
            }
            else
            {
                lblMessage.Text = "Password Should be Atleast 6 Characters";
            }
        }
    }
}