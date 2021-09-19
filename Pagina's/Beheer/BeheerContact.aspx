<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BeheerContact.aspx.cs" Inherits="Pagina_s_ContactBeheer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="stylesheet" type="text/css" href="../../Stylesheets/AlgemeenStyle.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="gastenlayout">
        <div class="berichtaanmaak">
            Naam:&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblNaam" runat="server" Text=""></asp:Label>
            <br />
            <br />
            Email:&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblMail" runat="server" Text=""></asp:Label>
            <br />
            <br />
            Datum:&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblDatum" runat="server" Text=""></asp:Label>
            <br />
            <br />
            Onderwerp:&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblOnderwerp" runat="server" Text=""></asp:Label>
            <br />
            <br />
            Bericht:&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblBericht" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>

