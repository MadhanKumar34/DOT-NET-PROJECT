using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_2
{
    public partial class Faculty_Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Submit_Click(object sender, EventArgs e)
        {
            string email = Session["Email"] as string;
            string FName = Fname.Text.Trim();
            string LName = Lname.Text.Trim();
            string password = Password.Text.Trim();
            if (password.Length >= 6)
            {

                string conn = "Data Source = MADHAN; Initial Catalog = PROJECT; Integrated Security = True";
                using (SqlConnection con = new SqlConnection(conn))
                {

                    con.Open();


                    SqlCommand cmd = new SqlCommand("UPDATE FACULTY SET FirstName=@FirstName,LastName=@LastName,Password=@Password where email=@Email", con);
                    cmd.Parameters.AddWithValue("@FirstName", FName);
                    cmd.Parameters.AddWithValue("@LastName", LName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected >= 0)
                    {
                        lblMessage.Text = "Updated successfully! Please Login";
                    }
                    else
                    {
                        // Display an error message for registration failure
                        lblMessage.Text = "Updation failed. Please try again.";
                    }

                }
            }
            else
            {
                // Display an error message for registration failure
                lblMessage.Text = "Minimum 6 characters are required for Password..!";
            }
        }
    }
}