<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="CentuDY.View.Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1><asp:Label ID="lblTitle" runat="server" Text="Profile"></asp:Label></h1>
            <br />
            
            <asp:Label ID="Label1" runat="server" Text="Username : "></asp:Label>
            <asp:Label ID="lblUsername" runat="server" Text='<%# Eval("Username") %>'></asp:Label>
            <br />
            <br />
            
            <asp:Label ID="Label3" runat="server" Text="Name : "></asp:Label>
            <asp:Label ID="lblName" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
            <br />
            <br />
            
            <asp:Label ID="Label5" runat="server" Text="Gender : "></asp:Label>
            <asp:Label ID="lblGender" runat="server" Text='<%# Eval("Gender") %>'></asp:Label>
            <br />
            <br />
            
            <asp:Label ID="Label7" runat="server" Text="Phone Number : "></asp:Label>
            <asp:Label ID="lblPhoneNumber" runat="server" Text='<%# Eval("PhoneNumber") %>'></asp:Label>
            <br />
            <br />
            
            <asp:Label ID="Label9" runat="server" Text="Address : "></asp:Label>
            <asp:Label ID="lblAddress" runat="server" Text='<%# Eval("Address") %>'></asp:Label>
            <br />
            <br />

            <div>
                <asp:Button ID="btnUpdateProfile" runat="server" Text="Update Profile" OnClick="btnUpdateProfile_Click"/> &nbsp
                <asp:Button ID="btnChangePassword" runat="server" Text="Change Password" OnClick="btnChangePassword_Click"/>
            </div>
            <br />
            <div>
                <asp:Button ID="btnHomePage" runat="server" Text="Home Page" OnClick="btnHomePage_Click"/>
            </div>
        </div>
    </form>
</body>
</html>
