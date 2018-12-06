<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Themes_Skins_CSS_Example.WebForm1" 
     Theme="MyFirstTheme" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label" ></asp:Label>
            <asp:Button ID="Button1" runat="server" Text="Button" BackColor="Red" />
        </div>
        
           <!-- Inherits="Themes_Skins_CSS_Example.WebForm1" Theme="MyFirstTheme" %>-->
    </form>
</body>
</html>
