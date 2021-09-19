<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PostAanvragen.aspx.cs" Inherits="Pagina_s_PostAanvragen" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="stylesheet" type="text/css" href="../Stylesheets/AlgemeenStyle.css" />
    <style type="text/css">
        .auto-style1 {
            box-sizing: border-box;
            border-radius: 5px;
            border: 1px solid #ccc;
            margin-bottom: 20px;
            font-size: 14px;
            padding: 0 10px 0 10px;
            outline: none;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="gastenlayout">
        <div class="berichtaanmaak">
            <asp:Label ID="lblReageer" runat="server" Text="Plaatsen:" CssClass="lblReageer"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Titel" CssClass="lblGastenb"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" CssClass="txtContact"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Afdeling" CssClass="lblGastenb"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Afdeling" DataValueField="id" Height="23px" Width="300px"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AfterlifeDataBaseConnectionString %>" SelectCommand="SELECT * FROM [Afdeling] ORDER BY [Afdeling]"></asp:SqlDataSource>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Beschrijving" CssClass="lblGastenb"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Height="225px" Width="501px" CssClass="auto-style1"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Foto" CssClass="lblGastenb"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList2" runat="server" Height="39px" Width="300px"></asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Prijs" CssClass="lblGastenb"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox3" runat="server" CssClass="txtContact"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Verzend" OnClick="Button1_Click" CssClass="Contactbtn" />
            <br />
            <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>

