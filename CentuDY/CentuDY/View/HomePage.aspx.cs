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
    public partial class HomePage : System.Web.UI.Page
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

        protected void btnViewMedicine_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/Medicine.aspx");
        }

        protected void btnViewProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/Profile.aspx");
        }

        protected void btnViewCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/Cart.aspx");
        }

        protected void btnViewTransHistory_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/TransactionHistory.aspx");
        }

        protected void btnInsertMedicine_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/InsertMedicine.aspx");
        }

        protected void btnViewUsers_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/Users.aspx");
        }

        protected void btnViewTransReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/TransactionReport.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["UserId"] != null)
            {
                HttpCookie removeCookie = Request.Cookies["UserId"];
                removeCookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(removeCookie);
            }

            Response.Redirect("/View/LoginPage.aspx");
        }

        private void fetchData()
        {
            if (Session["Name"] != null){
                lblName.Text = Session["Name"].ToString();

                if (Session["RoleId"] != null)
                {
                    int roleId = int.Parse(Session["RoleId"].ToString());
                    Role role = RoleController.GetRoleById(roleId);

                    if (role.RoleName == "Member")
                    {
                        btnInsertMedicine.Style["visibility"] = "hidden";
                        btnViewUsers.Style["visibility"] = "hidden";
                        btnViewTransReport.Style["visibility"] = "hidden";

                        gvRecommendedMedicine.DataSource = MedicineController.Get5RandomMedicines();
                        gvRecommendedMedicine.DataBind();
                    }
                    else if(role.RoleName == "Administrator")
                    {
                        btnViewCart.Style["visibility"] = "hidden";
                        btnViewTransHistory.Style["visibility"] = "hidden";
                    }
                }
            }
        }
    }
}