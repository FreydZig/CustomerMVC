<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NotesList.aspx.cs" Inherits="CustomerLIb.WebForm.NotesList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="table">
        <%foreach (var note in Notes)
          {  %>
            <tr>
                <td>
                    <%=note.Note %>
                </td>
            </tr>
        <%} %>
    </table>
    <%var customerIDReq = Request.QueryString["customerID"];%>
    <a href="NoteAdd.aspx?customerID=<%=customerIDReq%>">Add note...</a>
</asp:Content>
