<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MyWebUserControl.ascx.cs" Inherits="Caching_Example.MyWebUserControl" %>

<%@ OutputCache Duration="60" VaryByParam = "*" %>  

<table>
	<tr>
	  <td>My User Control</td>
	</tr>
	
	<tr>
	  <td> my Second column</td>
	</tr>

    <tr>
	  <td><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td>
	</tr>

</table>