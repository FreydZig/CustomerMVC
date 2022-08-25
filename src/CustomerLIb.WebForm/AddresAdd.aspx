<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddresAdd.aspx.cs" Inherits="CustomerLIb.WebForm.AddresAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Label Text="Addres Line" runat="server"></asp:Label>
        <asp:TextBox ID="addresAddresLine" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label Text="Addres Line 2" runat="server"></asp:Label>
        <asp:TextBox ID="addresAddresLine2" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label Text="Addres Type" runat="server"></asp:Label>
        <asp:TextBox ID="addresAddresType" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label Text="City" runat="server"></asp:Label>
        <asp:TextBox ID="addresCity" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label Text="Postal Code" runat="server"></asp:Label>
        <asp:TextBox ID="addresPostalCode" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label Text="State" runat="server"></asp:Label>
        <asp:TextBox ID="addresState" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label Text="Country" runat="server"></asp:Label>
        <asp:TextBox ID="addresCountry" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <asp:Button CssClass="btn btn-primary" Text="Save" OnClick="OnClickSave" runat="server"/>
</asp:Content>
