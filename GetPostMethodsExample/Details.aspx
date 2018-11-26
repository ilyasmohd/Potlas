<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="GetPostMethodsExample.Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    Hello <% =Convert.ToString(Request.QueryString["FirstName"]) %>
    Values coming from query string:
    <%=Request.QueryString["LastName"] %>. You are <%= Request.QueryString["Age"] %> years old! 

    <% 
        if (Request.QueryString["UserStatus"] == "New")
        {
            Response.Write("This is your first visit to this Web site!");
        }

        Response.Write("this is the value comming from page body: FirstName:" + Request.Form["FirstName"] + "  LastName:" + Request.Form["LastName"]);
    %>
</body>
</html>
