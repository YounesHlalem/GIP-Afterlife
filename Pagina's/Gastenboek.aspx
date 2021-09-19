<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Gastenboek.aspx.cs" Inherits="Pagina_s_Gastenboek" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="stylesheet" type="text/css" href="../Stylesheets/AlgemeenStyle.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="gastenlayout">
        <div class="berichtaanmaak">
            <asp:Label ID="Label1" runat="server" Text="Gastenboek:" CssClass="lblReageer"></asp:Label>
            <br />
            <br />
            <asp:Panel ID="Panel1" runat="server"></asp:Panel>
        </div>
        <br />
        <hr />
        <div class="berichtaanmaak">

            <asp:Label ID="lblReageer" runat="server" Text="Reageer:" CssClass="lblReageer"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblnieuwNaam" runat="server" Text="Naam:" CssClass="lblGastenb"></asp:Label>
            <br />
            <asp:TextBox ID="txtnieuwNaam" runat="server" CssClass="txtContact"></asp:TextBox>
            <br />
            <asp:Label ID="lblnieuwMail" runat="server" Text="E-mail:" CssClass="lblGastenb"></asp:Label>
            <br />
            <asp:TextBox ID="txtnieuwMail" runat="server" CssClass="txtContact"></asp:TextBox>
            <br />
            <asp:Label ID="lblnieuwBericht" runat="server" Text="Uw bericht:" CssClass="lblGastenb"></asp:Label>
            <br />
            <asp:TextBox ID="txtnieuwBericht" runat="server" TextMode="MultiLine" Height="174px" Width="501px"></asp:TextBox>
            <br />
            <asp:Button ID="btnBericht" runat="server" Text="Verzenden" OnClick="btnBericht_Click" CssClass="Contactbtn" />
            <br />
            <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>

