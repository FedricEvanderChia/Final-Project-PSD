<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="CentuDY.View.LoginPage" %>

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
            <h1><asp:Label ID="lblTitle" runat="server" Text="Login Page"></asp:Label></h1>
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
            <asp:Label ID="Label3" runat="server" Text="Remember Me"></asp:Label>
            <asp:CheckBox ID="chkRemember" runat="server" />
            </br>
            </br>
            <asp:Label ID="lblError" runat="server" Text="" color="red  "></asp:Label>
            </br>
            </br>
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"/>
        </div>
    </form>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/View/RegisterPage.aspx">Register</asp:HyperLink>
</body>
</html>
