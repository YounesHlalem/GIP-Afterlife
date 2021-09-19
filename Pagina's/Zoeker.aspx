<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Zoeker.aspx.cs" Inherits="Pagina_s_Zoeker" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="stylesheet" type="text/css" href="../Stylesheets/ZoekerStyle.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="inhoud">
        <table>
            <tr>
                <td rowspan="4" style="width: 400px">
                    <asp:Image ID="imgProduct" runat="server" CssClass="foto" />
                </td>
                <td style="width: 400px;">
                    <h2>
                        <asp:Label ID="lblTitle" runat="server" CssClass="titel"></asp:Label></h2>
                    <hr />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDescription" runat="server" CssClass="beschrijving"></asp:Label>
                </td>
                <td style="margin-left: 10px">
                    <asp:Label ID="lblPrice" runat="server" CssClass="prijs"></asp:Label><br />
                    <br />
                    
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnAdd" runat="server" CssClass="knop" Text="+ Favorieten" OnClick="btnAdd_Click" />
                    <br />
                    <asp:Label ID="lblResult" runat="server" CssClass="resultaat"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

