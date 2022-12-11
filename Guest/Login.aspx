<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/Guest.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Assignment_5.Guest.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center" style="border:dashed">
                <th>
                    <td><h1>Login</h1></td>
                       
                </th>
     
                <tr>
                    <td>Username</td>
                    <td>
                        <asp:TextBox ID="txtuname" runat="server"></asp:TextBox><br /><br />
                    </td>
                </tr>
                <tr>
                    <td> Password</td>
                    <td>
                        <asp:TextBox ID="txtpswd" runat="server" TextMode="Password"></asp:TextBox><br /><br />
                    </td>
                </tr>
                
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
            </td>
        </tr>
                         
            </table>
</asp:Content>
