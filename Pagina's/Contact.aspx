<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Pagina_s_Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="stylesheet" type="text/css" href="../Stylesheets/AlgemeenStyle.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="gastenlayout">
        <div class="berichtaanmaak">
            <asp:Label ID="Label1" runat="server" Text="Contact:" CssClass="lblReageer"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblNaam" runat="server" Text="Naam:" CssClass="contactlabels"></asp:Label>
            <br />
            <asp:TextBox ID="txtNaam" runat="server" CssClass="txtContact"></asp:TextBox>
            <br />
            <asp:Label ID="lblMail" runat="server" Text="E-mail:" CssClass="contactlabels"></asp:Label>
            <br />
            <asp:TextBox ID="txtMail" runat="server" CssClass="txtContact"></asp:TextBox>
            <br />
            <asp:Label ID="lblOnderwerp" runat="server" Text="Onderwerp:" CssClass="contactlabels"></asp:Label>
            <br />
            <asp:TextBox ID="txtOnderwerp" runat="server" CssClass="txtContact"></asp:TextBox>
            <br />
            <asp:Label ID="lblBericht" runat="server" Text="Uw bericht:" CssClass="contactlabels"></asp:Label>
            <br />
            <asp:TextBox ID="txtBericht" runat="server" TextMode="MultiLine" Height="205px" Width="502px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnBericht" runat="server" Text="Verzenden" OnClick="btnBericht_Click" CssClass="Contactbtn" />
            <br />
            <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>

