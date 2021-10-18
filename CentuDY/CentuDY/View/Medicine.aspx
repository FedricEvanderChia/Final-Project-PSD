<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Medicine.aspx.cs" Inherits="CentuDY.View.Medicine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1><asp:Label ID="lblTitle" runat="server" Text="Medicine Page"></asp:Label></h1>
            <br />

            <asp:TextBox ID="txtSearch" runat="server" ></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
            <br />
            <br />

            <asp:GridView ID="gvAllMedicines" AutoGenerateColumns="false" runat="server" >
                <Columns>
                    <asp:BoundField  DataField="Name" HeaderText="Medicine Name" />
	                <asp:BoundField  DataField="Description" HeaderText="Description" />
                    <asp:BoundField  DataField="Stock" HeaderText="Stock" />
	                <asp:BoundField  DataField="Price" HeaderText="Price" />
                    
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnAddtoCart" runat="server" CommandArgument='<%# Eval("MedicineId") %>' Text="Add" OnClick="btnAddtoCart_Click"/>
                            <asp:Button ID="btnUpdate" runat="server" CommandArgument='<%# Eval("MedicineId") %>' Text="Update" OnClick="btnUpdate_Click"/>
                            <asp:Button ID="btnDelete" runat="server" CommandArgument='<%# Eval("MedicineId") %>' Text="Delete" OnClick="btnDelete_Click"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
            <br />
            
            <div>
                <asp:Button ID="btnInsertMedicine" runat="server" Text="Insert Medicine" OnClick="btnInsertMedicine_Click"/>
            </div>

            <div>
                <asp:Button ID="btnHomePage" runat="server" Text="Home Page" OnClick="btnHomePage_Click"/>
            </div>
        </div>
    </form>
</body>
</html>
