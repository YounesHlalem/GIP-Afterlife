<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ManageZoeker.aspx.cs" Inherits="Pagina_s_Beheer_ManageZoeker" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="stylesheet" type="text/css" href="../../Stylesheets/AlgemeenStyle.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="gastenlayout">
        <div class="berichtaanmaak">
            <asp:Label ID="Label1" runat="server" Text="Titel"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Afdeling"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Afdeling" DataValueField="id"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AfterlifeDataBaseConnectionString %>" SelectCommand="SELECT * FROM [Afdeling] ORDER BY [Afdeling]"></asp:SqlDataSource>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Beschrijving"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Height="70px" Width="209px"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Foto"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Prijs"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Verzend" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>

