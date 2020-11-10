<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="listItem.aspx.cs" Inherits="WebApplication1.listItem" %>
<%@ MasterType VirtualPath="~/Site1.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link type="text/css" rel="stylesheet" href="css/listitem.css"/> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-listitem">
        <asp:DataList ID="DataList" runat="server" Width="100%" Height="100%">
            <ItemTemplate>
                <div class="content">
                    <div class="content-left">
                        <asp:Image ID="Image1" CssClass="image-content" runat="server" ImageUrl='<%# "./image/" + Eval("Hinh") %>' Width="90%" Height="80%"/>
                    </div>
                    <div class="content-right">
                        <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("MaSP") %>' OnClick="LinkButton1_Click">Chi tiết sản phẩm</asp:LinkButton>
                    </div>
                </div>
                <hr />
            </ItemTemplate>
        </asp:DataList>
    </div>
</asp:Content>
