<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CachingExample.aspx.cs" Inherits="Caching_Example.CachingExample" %>

<%@ Register Src="~/UserControls/MyWebUserControl.ascx" TagName="myUserControl" TagPrefix="Tweb" %>
<%@ OutputCache Duration="20" VaryByParam="Id" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <Tweb:myUserControl ID="myControl" runat="server" />
        <hr />
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
        <div>
        </div>
        <hr />
    </form>
</body>
</html>
