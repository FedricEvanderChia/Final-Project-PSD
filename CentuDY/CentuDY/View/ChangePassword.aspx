<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="CentuDY.View.ChangePassword" %>

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
            <h2><asp:Label ID="lblTitle" runat="server" Text="Change Password"></asp:Label></h2>
            </br>
            </br>
            
            <asp:Label ID="Label2" runat="server" Text="Old Password"></asp:Label>
            </br>
            <asp:TextBox ID="txtOldPw" runat="server" Type="password"></asp:TextBox>
            </br>
            </br>
            
            <asp:Label ID="Label1" runat="server" Text="New Password"></asp:Label>
            </br>
            <asp:TextBox ID="txtNewPw" runat="server" Type="password"></asp:TextBox>
            </br>
            </br>
            
            <asp:Label ID="Label3" runat="server" Text="Confirm Password"></asp:Label>
            </br>
            <asp:TextBox ID="txtConfirmNewPw" runat="server" Type="password"></asp:TextBox>
            </br>
            </br>
            
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
            </br>
            </br>

            <asp:Button ID="btnUpdate" runat="server" Text="Update Password"  OnClick="btnUpdate_Click"/>
        </div>
    </form>
</body>
</html>
