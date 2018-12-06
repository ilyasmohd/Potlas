<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" 
    CodeBehind="WebForm1.aspx.cs" Inherits="MasterPage_Example.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Button1" runat="server" Text="Button" />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

</asp:Content>
