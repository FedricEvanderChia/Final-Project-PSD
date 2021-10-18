<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddtoCartPage.aspx.cs" Inherits="CentuDY.View.AddtoCartPage" %>

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
            <h2><asp:Label ID="lblTitle" runat="server" Text="Add to Cart"></asp:Label></h2>
            <br />

            <asp:Label ID="Label1" runat="server" Text="Name : "></asp:Label>
            <asp:Label ID="lblName" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
            <br />
            <br />
            
            <asp:Label ID="Label3" runat="server" Text="Description : "></asp:Label>
            <asp:Label ID="lblDesc" runat="server" Text='<%# Eval("Description") %>'></asp:Label>
            <br />
            <br />
            
            <asp:Label ID="Label5" runat="server" Text="Stock : "></asp:Label>
            <asp:Label ID="lblStock" runat="server" Text='<%# Eval("Stock") %>'></asp:Label>
            <br />
            <br />
            
            <asp:Label ID="Label7" runat="server" Text="Price : "></asp:Label>
            <asp:Label ID="lblPrice" runat="server" Text='<%# Eval("Price") %>'></asp:Label>
            <br />
            <br />
            
            <asp:Label ID="Label9" runat="server" Text="Quantity : "></asp:Label>
            <asp:TextBox ID="txtQuantity" runat="server" />
            <br />
            <br />
            
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
            <br />
            <br />
            
            <div>
                <asp:Button ID="btnAddtoCart" runat="server" Text="Add to Cart" OnClick="btnAddtoCart_Click"/>
            </div>
            <br />

            <asp:Button ID="btnMedicinePage" runat="server" Text="Medicine Page" OnClick="btnMedicinePage_Click"/>
        </div>
    </form>
</body>
</html>
