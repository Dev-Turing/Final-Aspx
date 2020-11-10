<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="chitiet.aspx.cs" Inherits="WebApplication1.chitiet" %>
<%@ MasterType VirtualPath="~/Site1.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link type="text/css" rel="stylesheet" href="css/chitiet.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-chitiet">
        <div class="content-center">
            <div class="space" >
                <asp:Label ID="Label1" CssClass="lbl-1" runat="server" Text="Tên Sản Phẩm"></asp:Label>
            </div>
            <div class="space">
                <asp:Image ID="Image1" runat="server" Width="300px" Height="200px" />
            </div>
            <div class="space">
                <p>Chi tiết sản phẩm</p>
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </div>
            <div class="space">
                <asp:Button ID="Button1" runat="server" Text="Mua Hàng" OnClick="Button1_Click" />
            </div>
        </div>
    </div>
</asp:Content>
