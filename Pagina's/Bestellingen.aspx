<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Bestellingen.aspx.cs" Inherits="Pagina_s_Bestellingen" %>

<asp:content id="Content1" contentplaceholderid="head" runat="Server">
    <link rel="stylesheet" type="text/css" href="../Stylesheets/AlgemeenStyle.css" />
</asp:content>
<asp:content id="Content2" contentplaceholderid="ContentPlaceHolder1" runat="Server">
    <div class="wrapper">
        <div class="inhoud">
            <asp:Label ID="label1" runat="server" Text="Favorieten:" Font-Size="XX-Large" ForeColor="White"></asp:Label>
            <asp:Panel ID="Panel1" runat="server"></asp:Panel>
        </div>
    </div>
    
</asp:content>

