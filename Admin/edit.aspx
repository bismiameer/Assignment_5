<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="Assignment_5.Admin.edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center" style="border:dashed">
                <th>
                    <td><h1>Approve or Deny</h1></td>
                       
                </th>
                <tr>
                    <td></td>
                    <td><asp:Button ID="Button1" runat="server" Text="approve" OnClick="Button1_Click"  /></td>
                    <td> <asp:Button ID="Button2" runat="server" Text="Deny" OnClick="Button2_Click" /></td>
                </tr>   
            </table>
</asp:Content>