<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="CentuDY.View.UpdateProfile" %>

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
            <h2><asp:Label ID="lblTitle" runat="server" Text="Update Profile"></asp:Label></h2>
            </br>
            </br>

            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
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
            
            <asp:Label ID="Label4" runat="server" Text="Phone Number"></asp:Label>
            </br>
            <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
            </br>
            </br>

            <asp:Label ID="Label3" runat="server" Text="Address"></asp:Label>
            </br>
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            </br>
            </br>

            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
            </br>
            </br>
          
            <asp:Button ID="btnUpdate" runat="server" Text="Update Profile"  OnClick="btnUpdate_Click"/>
        </div>
    </form>
</body>
</html>
