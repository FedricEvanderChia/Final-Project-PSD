using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.View
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["User"] == null)
                {
                    Response.Redirect("/View/LoginPage.aspx");
                }
                else
                {
                    fetchData();
                }
            }
        }

        protected void btnHomePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/HomePage.aspx");
        }

        protected void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            User user = (User)Session["User"];

            Response.Redirect("/View/UpdateProfile.aspx?id=" + user.UserId);
        }

        protected void btnChangePassword_Click(object sender, EventArgs e)
        {
            User user = (User)Session["User"];
            Response.Redirect("/View/ChangePassword.aspx?id=" + user.UserId);
        }

        private void fetchData()
        {
            User user = (User)Session["User"];

            lblUsername.Text = user.Username;
            lblName.Text = user.Name;
            lblGender.Text = user.Gender;
            lblPhoneNumber.Text = user.PhoneNumber;
            lblAddress.Text = user.Address;
        }
    }
}