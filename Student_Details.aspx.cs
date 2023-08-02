using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Project_2
{
    public partial class Student_Deatils : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string email = Session["Email"] as string;
            string firstName = Session["FirstName"] as string;
            string lastName = Session["LastName"] as string;
            name.Text = firstName + " " + lastName;
            FName.Text = firstName;
            LName.Text= lastName;
            Email.Text = email;
         

        }
        protected void Update_Click(object sender, EventArgs e)
        {
            string email = Session["Email"] as string;
            Session["Email"] = email;
            Response.Redirect("~/Student_Update.aspx");
        }
        protected void Assignment_Click(object sender, EventArgs e)
        {
            string email = Session["Email"] as string;
            Session["Email"] = email;
            Response.Redirect("~/Student_Assignment.aspx");
        }
        protected void Sign_Out(object sender, EventArgs e)
        {
            Response.Redirect("~/index.html");
        }
    }
}