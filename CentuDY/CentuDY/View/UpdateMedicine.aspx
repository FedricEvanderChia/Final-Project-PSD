<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateMedicine.aspx.cs" Inherits="CentuDY.View.UpdateMedicine" %>

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
            <h2><asp:Label ID="lblTitle" runat="server" Text="Update Medicine"></asp:Label></h2>
            </br>
            </br>

            <asp:Label ID="Label1" runat="server" Text="Medicine Name"></asp:Label>
            </br>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </br>
            </br>

            <asp:Label ID="Label2" runat="server" Text="Description"></asp:Label>
            </br>
            <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
            </br>
            </br>
            
            <asp:Label ID="Label4" runat="server" Text="Stock"></asp:Label>
            </br>
            <asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
            </br>
            </br>

            <asp:Label ID="Label3" runat="server" Text="Price"></asp:Label>
            </br>
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            </br>
            </br>

            
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
            </br>
            </br>
          
            <asp:Button ID="btnUpdate" runat="server" Text="Update Medicine"  OnClick="btnUpdate_Click"/>
        </div>
    </form>
</body>
</html>
