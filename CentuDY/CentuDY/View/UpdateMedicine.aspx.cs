using CentuDY.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.View
{
    public partial class UpdateMedicine : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if(Request.QueryString["id"] == null)
                {
                    Response.Redirect("/View/Medicine.aspx");
                }
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int medicineId = Int32.Parse(Request.QueryString["id"]);
            string name = txtName.Text;
            string desc = txtDescription.Text;
            string stock = txtStock.Text;
            string price = txtPrice.Text;
            string message = MedicineController.UpdateMedicine(medicineId, name, desc, stock, price);

            if(message != "")
            {
                lblError.Text = message;
            }
            else
            {
                Response.Redirect("/View/Medicine.aspx");
            }
        }
    }
}