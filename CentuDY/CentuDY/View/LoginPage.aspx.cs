using CentuDY.Controller;
using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.View
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["UserId"] != null)
            {
                User user = UserController.GetUserById(Int32.Parse(Request.Cookies["UserId"].Value));

                txtUsername.Text = user.Username;
                txtPassword.Text = user.Password;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool isChecked = chkRemember.Checked;

            if(username.Length <= 0)
            {
                lblError.Text = "Username cannot be empty";
                return;
            } else if(password.Length <= 0)
            {
                lblError.Text = "Password cannot be empty";
                return;
            }

            User user = UserController.LoginUser(username, password);

            if (user == null)
            {
                lblError.Text = "USER NOT FOUND";
            }
            else
            {
                Session["User"] = user;
                User getUser = UserController.GetUserById(user.UserId);
                Session["Name"] = getUser.Name;
                Session["UserId"] = getUser.UserId;
                Session["RoleId"] = getUser.RoleId;

                if (isChecked)
                {
                    HttpCookie cookie = new HttpCookie("UserId");
                    cookie.Value = user.UserId.ToString();
                    cookie.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Add(cookie);
                }
                else
                {
                    if (Request.Cookies["UserId"] != null)
                    {
                        HttpCookie removeCookie = Request.Cookies["UserId"];
                        removeCookie.Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies.Add(removeCookie);
                    }
                }

                Response.Redirect("/View/HomePage.aspx");
            }
        }
    }
}