<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GetPostMethodsExample.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="post" action="Details.aspx">
        <div>

            <!-- <input type="Text" name="FirstName" title="First Name" value="FirstName"/>
                <input type="Text" name="LastName" title="Last Name" value="LastName"/>
                <input type="Text" name="Age" title="Age" value="age"/>
                <input type="Hidden" name="UserStatus" value="New" />
                <input type="Submit" value="Enter" /> -->

            <h9>First Name  </h9><input type="Text" name="FirstName" title="First Name" /><br />
            <h9>Last Name   </h9><input type="Text" name="LastName" title="Last Name"><br />
            <h10>Age   </h10><input type="Text" name="Age" title="Age" /><br />
            <input type="Hidden" name="UserStatus" value="New" />
            <input type="Submit" value="Enter" />
        </div>
    </form>
</body>
</html>
