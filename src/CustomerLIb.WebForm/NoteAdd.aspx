<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NoteAdd.aspx.cs" Inherits="CustomerLIb.WebForm.NoteAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Label Text="Note" runat="server"></asp:Label>
        <asp:TextBox ID="noteTxt" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <asp:Button CssClass="btn btn-primary" Text="Save" OnClick="OnClickSave" runat="server" />
</asp:Content>
