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
    public partial class Cart : System.Web.UI.Page
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

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            User user = (User)Session["User"];
            int medicineId = Int32.Parse((sender as Button).CommandArgument);

            CartController.RemoveCartItem(user.UserId, medicineId);
            fetchData();
        }

        protected void btnCheckOut_Click(object sender, EventArgs e)
        {

        }

        protected void btnMedicinePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/Medicine.aspx");
        }

        private void fetchData()
        {
            User user = (User)Session["User"];

            gvAllCartItems.DataSource = CartController.GetAllCartItemsByUserId(user.UserId);
            gvAllCartItems.DataBind();
        }

    }
}