<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="CentuDY.View.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #lblError{
            color: red;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1><asp:Label ID="lblTitle" runat="server" Text="Register Page"></asp:Label></h1>
            </br>
            </br>

            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
            </br>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            </br>
            </br>

            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            </br>
            <asp:TextBox ID="txtPassword" runat="server" Type="password"></asp:TextBox>
            </br>
            </br>

            <asp:Label ID="Label4" runat="server" Text="Confirm Password"></asp:Label>
            </br>
            <asp:TextBox ID="txtConfirmPassword" runat="server" Type="password"></asp:TextBox>
            </br>
            </br>

            <asp:Label ID="Label5" runat="server" Text="Name"></asp:Label>
            </br>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </br>
            </br>

            <asp:Label ID="Label6" runat="server" Text="Gender"></asp:Label>
            </br>
            <asp:RadioButton ID="radioMale" runat="server" Text="Male" GroupName="gender" />
            <asp:RadioButton ID="radioFemale" runat="server" Text="Female" GroupName="gender"/>
            </br>
            </br>

            <asp:Label ID="Label7" runat="server" Text="Phone Number"></asp:Label>
            </br>
            <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
            </br>
            </br>

            <asp:Label ID="Label8" runat="server" Text="Address"></asp:Label>
            </br>
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            </br>
            </br>

            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
            </br>
            </br>

            <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click"/>
        </div>
    </form>
</body>
</html>
