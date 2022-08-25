<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddressList.aspx.cs" Inherits="CustomerLIb.WebForm.AddressList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="table">
        <tr>
            <td>
                AddressLine
            </td>
            <td>
                AddressLine2
            </td>
            <td>
                AddressType
            </td>
            <td>
                City
            </td>
            <td>
                PostalCode
            </td>
            <td>
                State
            </td>
            <td>
                Country
            </td>
        </tr>
    </table>
    <table class="table">
        <%foreach (var addres in Address)
            {  %>
            <tr>
                <td>
                    <%=addres.AddressLine %>
                </td>
                <td>
                    <%=addres.AddressLine2 %>
                </td>
                <td>
                    <%=addres.AddressType %>
                </td>
                <td>
                    <%=addres.City %>
                </td>
                <td>
                    <%=addres.PostalCode %>
                </td>
                <td>
                    <%=addres.State %>
                </td>
                <td>
                    <%=addres.Country %>
                </td>
            </tr>
        <%} %>
    </table>
    <%var customerId =  Request.QueryString["customerID"]; %>
    <a href="AddresAdd.aspx?customerID=<%=customerId%>">Add addres...</a>
</asp:Content>
