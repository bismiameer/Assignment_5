<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="BlockUser.aspx.cs" Inherits="Assignment_5.Admin.BlockUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Admin Home Page</h1>
  
    <table>
       
        <tr>
           
            <h2>Block</h2>
       
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="EmployeeId" OnRowDeleting="GridView1_RowDeleting">
                    <Columns>
                        <asp:BoundField DataField="Name" HeaderText="Name" />
                        <asp:BoundField DataField="Email" HeaderText="Email" />
                        <asp:BoundField DataField="Phone" HeaderText="Phone No." />
                        <asp:BoundField DataField="Age" HeaderText="Age" />
                        <asp:BoundField DataField="status" HeaderText="status" />
                        <asp:CommandField DeleteText="Block User" HeaderText="Deny" ShowDeleteButton="True" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>

       </table>
    <table>
        <tr>
             <h2>Blocked Users</h2>
            <td>
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="EmployeeId" >
                    <Columns>
                        <asp:BoundField DataField="Name" HeaderText="Name" />
                        <asp:BoundField DataField="Email" HeaderText="Email" />
                        <asp:BoundField DataField="Phone" HeaderText="Phone No." />
                        <asp:BoundField DataField="Age" HeaderText="Age" />
                        <asp:BoundField DataField="status" HeaderText="Status" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>