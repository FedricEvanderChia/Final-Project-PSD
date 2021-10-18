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
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["id"] == null)
                {
                    Response.Redirect("/View/Profile.aspx");
                }
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int userId = Int32.Parse(Request.QueryString["id"]);
            string oldPw = txtOldPw.Text;
            string newPw = txtNewPw.Text;
            string confNewPw = txtConfirmNewPw.Text;
            string message = "";

            message = UserController.ChangePassword(userId, oldPw, newPw, confNewPw);

            if(message != "")
            {
                lblError.Text = message;
            }
            else
            {
                User user = UserController.GetUserById(userId);
                Session["User"] = user;
                Response.Redirect("/View/Profile.aspx");
            }
        }
    }
}