<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ValidationControls_Example.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #table {
            height: 40px;
            width: 91px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table id="table">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="RequiredFieldExample:"></asp:Label>
                    <asp:TextBox ID="txtReqExample" runat="server" ></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter some text or number" Display="None" 
                        ControlToValidate="txtReqExample"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="reqLbl" runat="server" Text="RangefieldExample:"></asp:Label>
                    <asp:TextBox ID="txtRangeExample" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="RangeValidator" ControlToValidate="txtRangeExample" MaximumValue="5" MinimumValue="0"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="compare:"></asp:Label>
                    <asp:TextBox ID="txtcomp1" runat="server"></asp:TextBox>
                    <asp:TextBox ID="txtcomp2" runat="server"></asp:TextBox></td>
                <td>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="compared text boxes are not same, please make equal value" ControlToCompare="txtcomp1" ControlToValidate="txtcomp2"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="regular expression:"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="TextBox1" ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"></asp:RegularExpressionValidator>

                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="validation summary:"></asp:Label>
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="SingleParagraph" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Button"  />
                </td>

                <td>
                    <!--<asp:Button ID="Button2" runat="server" Text="Button" ValidationGroup="G" CausesValidation="false"/> -->
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
