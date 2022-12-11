<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/Guest.Master" AutoEventWireup="true" CodeBehind="UserReg.aspx.cs" Inherits="Assignment_5.Guest.UserReg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center">
                <tr>
                    <td><h1>REGISTRATION</h1></td>
                       
                </tr>

                <tr>
                    <td>Name</td>
                    <td>
                      <asp:TextBox ID="txtname" runat="server"></asp:TextBox><br /><br />
                    </td>
                </tr>

                   <tr>
                    <td>Age</td>
                    <td>
                       <asp:TextBox ID="txtage" runat="server"></asp:TextBox><br /><br />
                    </td>
                </tr>
                
                <tr>
                    <td>Email</td>
                    <td>
                       <asp:TextBox ID="txtmail" runat="server"></asp:TextBox><br /><br />
                    </td>
                </tr>

                 <tr>
                    <td>Phone</td>
                    <td>
                       <asp:TextBox ID="txtphone" runat="server"></asp:TextBox><br /><br />
                    </td>
                </tr>
              
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
