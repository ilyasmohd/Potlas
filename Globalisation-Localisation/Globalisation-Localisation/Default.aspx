<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Globalisation_Localisation.Default" %>

<!DOCTYPE html>

<!-- <html dir="rtl" xmlns="http://www.w3.org/1999/xhtml"> -->
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlLanguages" runat="server" AutoPostBack="true">
                <asp:ListItem Text="English" Value="en-us" />
                <asp:ListItem Text="French" Value="fr-fr" />
            </asp:DropDownList>
        </div>
        <div>
            <asp:Label runat="server" ID="myId" Text="<%$ Resources:Resource1, String1 %>"></asp:Label>
            <asp:Label ID="Label1" runat="server" Text="Hello" meta:resourcekey="LabelString" ></asp:Label>
        </div>
    </form>
</body>
</html>
