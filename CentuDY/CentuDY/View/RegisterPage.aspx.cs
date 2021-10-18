using CentuDY.Controller;
using CentuDY.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.View
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string name = txtName.Text;
            string gender = "";
            string phoneNumberString = txtPhoneNumber.Text;
            string address = txtAddress.Text;
            string message = "";

            if (radioMale.Checked)
            {
                gender = "Male";
            }
            else if (radioFemale.Checked)
            {
                gender = "Female";
            }

            int roleId = 2;

            message = UserController.RegisterUser(roleId, username, password, confirmPassword, name, gender, phoneNumberString, address);
            lblError.Text = message;

            return;
        }
    }
}