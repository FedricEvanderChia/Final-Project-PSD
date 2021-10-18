<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="CentuDY.View.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1><asp:Label ID="lblTitle" runat="server" Text="Home Page"></asp:Label></h1>
            Welcome, <asp:Label ID="lblName" Text='<%# Eval("Name") %>' runat="server" />
            </br>
            </br>
            </br>
        </div>

        <asp:GridView ID="gvRecommendedMedicine" runat="server">
        </asp:GridView>
        <br />
        <br />

        <div>
            <asp:Button ID="btnViewCart" runat="server" Text="View Cart" OnClick="btnViewCart_Click" />
        </div>
        <div>
            <asp:Button ID="btnViewTransHistory" runat="server" Text="View Transaction History" OnClick="btnViewTransHistory_Click" />
        </div>
        </br>
        </br>
        
        <div>
            <asp:Button ID="btnInsertMedicine" runat="server" Text="Insert Medicine" OnClick="btnInsertMedicine_Click" />
        </div>
        <div>
            <asp:Button ID="btnViewUsers" runat="server" Text="View Users" OnClick="btnViewUsers_Click" />
        </div>
        <div>
            <asp:Button ID="btnViewTransReport" runat="server" Text="View Transaction Report" OnClick="btnViewTransReport_Click" />
        </div>
        </br>
        </br>

        <div>
            <asp:Button ID="btnViewMedicine" runat="server" Text="View Medicine" OnClick="btnViewMedicine_Click"/>
        </div>
        <div>
            <asp:Button ID="btnViewProfile" runat="server" Text="View Profile" OnClick="btnViewProfile_Click"/>
        </div>
        <div>
            <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click"/>
        </div>

    </form>
</body>
</html>
