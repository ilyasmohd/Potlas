<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Button ID="Button1" runat="server" Text="Button" CausesValidation="false" /><br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
            <asp:Table ID="Table1" runat="server"></asp:Table>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" CausesValidation="true"
                OnTextChanged="DropDownList1_TextChanged"
                OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Enabled="true" Text="Select Month" Selected="True" Value="-1"></asp:ListItem>
                <asp:ListItem Text="January" Value="1"></asp:ListItem>
                <asp:ListItem Text="February" Value="2"></asp:ListItem>
                <asp:ListItem Text="March" Value="3"></asp:ListItem>
                <asp:ListItem Text="April" Value="41"></asp:ListItem>

            </asp:DropDownList>

            <asp:DropDownList ID="dropdownlist2" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="CustomerName" DataValueField="CustomerID" AppendDataBoundItems="True">
                <%--<asp:ListItem Selected="True" Value="-1">select</asp:ListItem>--%>
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TestDB2ConnectionString %>" SelectCommand="SELECT [CustomerID], [CustomerName] FROM [Customers]"></asp:SqlDataSource>
            <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource2" DataTextField="CustomerName" DataValueField="CustomerID">
            </asp:DropDownList>
        </div>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:TestDB2ConnectionString2 %>" SelectCommand="SELECT [CustomerID], [CustomerName] FROM [Customers]"></asp:SqlDataSource>
    </form>
</body>
</html>
