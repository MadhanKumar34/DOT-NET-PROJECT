using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_2
{
    public partial class Faculty_Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string email = Session["Email"] as string;
            string firstName = Session["FirstName"] as string;
            string lastName = Session["LastName"] as string;
            name.Text = firstName + " " + lastName;
            FName.Text = firstName;
            LName.Text = lastName;
            Email.Text = email;

        }
        protected void Update_Click(object sender, EventArgs e)
        {
            string email = Session["Email"] as string;
            Session["Email"] = email;
            Response.Redirect("~/Faculty_Update.aspx");
        }
        protected void Assignment_Click(object sender, EventArgs e)
        {
            string email = Session["Email"] as string;
            Session["Email"] = email;
            string firstName = Session["FirstName"] as string;
            string lastName = Session["LastName"] as string;
            Session["FullName"] = firstName + " " + lastName;
            Response.Redirect("~/Faculty_Assignment.aspx");
        }
        protected void Sign_Out(object sender, EventArgs e)
        {
            Response.Redirect("~/index.html");
        }
    }
}