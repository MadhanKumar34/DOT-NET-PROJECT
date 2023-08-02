using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Project_2
{
    public partial class Faculty_Assignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 
           
        }
        protected void Submit_Click(object sender, EventArgs e)
        {
            string subject = Subject.Text;
            string topic = Topic.Text;
            string duedate=DueDate.Text;
            string email = Session["Email"] as string;
            string fullname = Session["FullName"] as string;



            string conn = "Data Source = MADHAN; Initial Catalog = PROJECT; Integrated Security = True";
                using (SqlConnection con = new SqlConnection(conn))
                {

                    con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO Assignments (Subject, Topic, Instructor, DueDate) VALUES (@Subject, @Topic, @Instructor, @DueDate)", con);
                        cmd.Parameters.AddWithValue("@Subject", subject);
                        cmd.Parameters.AddWithValue("@Topic", topic);
                        cmd.Parameters.AddWithValue("@Instructor", fullname);
                        cmd.Parameters.AddWithValue("@DueDate", duedate);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            lblMessage.Text = "AssignMent Added Successfully";
                        }
                        else
                        {
                            // Display an error message for registration failure
                            lblMessage.Text = "Please try again.";
                        }
                    
                }
        }
        protected void Sign_Out(object sender, EventArgs e)
        {
            Response.Redirect("~/index.html");
        }
    }
}