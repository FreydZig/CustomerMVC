<%@ Page Title="Customer Esit" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomerEdit.aspx.cs" Inherits="CustomerLIb.WebForm.CustomerEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Label Text="ID" runat="server"></asp:Label>
        <asp:TextBox ID="customerID" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label Text="First name" runat="server"></asp:Label>
        <asp:TextBox ID="customerFirstName" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label Text="Last name" runat="server"></asp:Label>
        <asp:TextBox ID="customerLastName" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label Text="Phone number" runat="server"></asp:Label>
        <asp:TextBox ID="customerPhoneNumber" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label Text="Email" runat="server"></asp:Label>
        <asp:TextBox ID="customerEmail" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label Text="Total purchases amount" runat="server"></asp:Label>
        <asp:TextBox ID="customerTotalPurchasesAmount" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <asp:Button CssClass="btn btn-primary" Text="Save" OnClick="OnClickSave" runat="server" />
</asp:Content>
