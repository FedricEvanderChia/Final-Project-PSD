<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="CentuDY.View.TransactionHistory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2><asp:Label ID="lblTitle" runat="server" Text="Transaction History"></asp:Label></h2>
            <br />
            
            <br />
            <br />
            <asp:Button ID="btnHomePage" runat="server" Text="Home Page" OnClick="btnHomePage_Click"/>
        </div>
    </form>
</body>
</html>
