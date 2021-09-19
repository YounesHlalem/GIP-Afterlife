<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ManageAfdeling.aspx.cs" Inherits="Pagina_s_Beheer_ManageAfdeling" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="stylesheet" type="text/css" href="../../Stylesheets/AlgemeenStyle.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="gastenlayout">
        <div class="berichtaanmaak">
            <asp:Label ID="Label1" runat="server" Text="Afdeling naam:"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Verstuur" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>

