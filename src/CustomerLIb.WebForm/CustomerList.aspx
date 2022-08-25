<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomerList.aspx.cs" Inherits="CustomerLIb.WebForm.CustomerList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="table">      
        <tr>
            <td>
                First Name
            </td>
            <td>
                Last Name
            </td>
            <td>
                Adress
            </td>
            <td>
                Phone Number
            </td>
            <td>
                Email
            </td>
            <td>
                Total Purchases Amount
            </td>  
            <td>
                Notes
            </td>
            <td></td>
        </tr>
    </table>
    <table class="table">
        <% foreach (var customer in Customers)
            {  %>
        
        <tr>
            <td>
                <a href="CustomerEdit.aspx?customerID=<%=customer.CustomerId%>">
                    <%=customer.FirstName %>
                </a>
                
            </td>
            <td>
                <%=customer.LastName %>
            </td>
            <td>

                <a href="AddressList.aspx?customerID=<%=customer.CustomerId%>">
                    Address
                </a>
            </td>
            <td>
                <%=customer.PhoneNumber %>
            </td>
            <td>
                <%=customer.Email %>
            </td>
            <td>
                <%=customer.TotalPurchasesAmount %>
            </td>  
            <td>
                <a href="NotesList.aspx?customerID=<%=customer.CustomerId%>">
                    Notes
                </a>
            </td>
            <td>
                <a href="CustomerList.aspx?customerID=<%=customer.CustomerId%>"> Delete...</a>
            </td>
        </tr>

        <% } %>
    </table>
</asp:Content>
