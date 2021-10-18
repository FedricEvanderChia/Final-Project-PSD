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
    public partial class AddtoCartPage : System.Web.UI.Page
    {
        public object CartContoller { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["id"] == null)
                {
                    Response.Redirect("/View/Medicine.aspx");
                }
                else
                {
                    fetchData();
                }
            }
        }

        protected void btnAddtoCart_Click(object sender, EventArgs e)
        {
            User user = (User)Session["User"];
            int medicineId = Int32.Parse(Request.QueryString["id"]);
            var medicine = MedicineController.GetMedicineById(medicineId);

            string quantity = txtQuantity.Text;
            int stock = (int)medicine.Stock;
            string message = CartController.AddtoCart(user.UserId, medicineId, quantity, stock);

            if (message != "")
            {
                lblError.Text = message;
            }
            else
            {
                Response.Redirect("/View/Cart.aspx");
            }
        }

        protected void btnMedicinePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/Medicine.aspx");
        }

        private void fetchData()
        {
            int medicineId = Int32.Parse(Request.QueryString["id"]);
            var medicine = MedicineController.GetMedicineById(medicineId);

            lblName.Text = medicine.Name;
            lblDesc.Text = medicine.Description;
            lblStock.Text = medicine.Stock.ToString();
            lblPrice.Text = medicine.Price.ToString();
        }

    }
}