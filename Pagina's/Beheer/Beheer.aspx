<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Beheer.aspx.cs" Inherits="Pagina_s_Beheer_Beheer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="stylesheet" type="text/css" href="../../Stylesheets/AlgemeenStyle.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="gastenlayout">
        <div class="berichtaanmaak">
            <asp:Button ID="btnBerichten" runat="server" Text="Postvak in" PostBackUrl="~/Pagina's/Beheer/BeheerCBerichten.aspx" />
            <asp:Button ID="btnPlaatsingen" runat="server" Text="Aangevragen plaatsingen" PostBackUrl="~/Pagina's/Beheer/AanvragenBeheer.aspx" />
            <asp:Button ID="btnAlgemeen" runat="server" Text="Winkels en Afdelingen" PostBackUrl="~/Pagina's/Beheer/Beheer.aspx" />
            <br />
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Pagina's/Beheer/ManageZoeker.aspx" CssClass="button">Voeg een zoeker toe</asp:LinkButton>
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="sdsZoeker" Width="100%" AllowPaging="True" AllowSorting="True" OnRowEditing="GridView1_RowEditing" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="AfdelingID" HeaderText="AfdelingID" SortExpression="AfdelingID" />
                    <asp:BoundField DataField="Titel" HeaderText="Titel" SortExpression="Titel" />
                    <asp:BoundField DataField="Prijs" HeaderText="Prijs" SortExpression="Prijs" />
                    <asp:BoundField DataField="Beschrijving" HeaderText="Beschrijving" SortExpression="Beschrijving" />
                    <asp:BoundField DataField="Foto" HeaderText="Foto" SortExpression="Foto" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <asp:SqlDataSource ID="sdsZoeker" runat="server" ConnectionString="<%$ ConnectionStrings:AfterlifeDataBaseConnectionString %>" DeleteCommand="DELETE FROM [Zoeker] WHERE [id] = @id" InsertCommand="INSERT INTO [Zoeker] ([AfdelingID], [Titel], [Prijs], [Beschrijving], [Foto]) VALUES (@AfdelingID, @Titel, @Prijs, @Beschrijving, @Foto)" SelectCommand="SELECT * FROM [Zoeker]" UpdateCommand="UPDATE [Zoeker] SET [AfdelingID] = @AfdelingID, [Titel] = @Titel, [Prijs] = @Prijs, [Beschrijving] = @Beschrijving, [Foto] = @Foto WHERE [id] = @id">
                <DeleteParameters>
                    <asp:Parameter Name="id" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="AfdelingID" Type="Int32" />
                    <asp:Parameter Name="Titel" Type="String" />
                    <asp:Parameter Name="Prijs" Type="Int32" />
                    <asp:Parameter Name="Beschrijving" Type="String" />
                    <asp:Parameter Name="Foto" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="AfdelingID" Type="Int32" />
                    <asp:Parameter Name="Titel" Type="String" />
                    <asp:Parameter Name="Prijs" Type="Int32" />
                    <asp:Parameter Name="Beschrijving" Type="String" />
                    <asp:Parameter Name="Foto" Type="String" />
                    <asp:Parameter Name="id" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>

            <br />

            <asp:LinkButton ID="LinkButton2" runat="server" CssClass="button" PostBackUrl="~/Pagina's/Beheer/ManageAfdeling.aspx">Voeg een afdeling toe</asp:LinkButton>
            <br />
            <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="sdsAfdeling" Width="100%" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="Afdeling" HeaderText="Afdeling" SortExpression="Afdeling" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <asp:SqlDataSource ID="sdsAfdeling" runat="server" ConnectionString="<%$ ConnectionStrings:AfterlifeDataBaseConnectionString %>" DeleteCommand="DELETE FROM [Afdeling] WHERE [id] = @id" InsertCommand="INSERT INTO [Afdeling] ([Afdeling]) VALUES (@Afdeling)" SelectCommand="SELECT * FROM [Afdeling]" UpdateCommand="UPDATE [Afdeling] SET [Afdeling] = @Afdeling WHERE [id] = @id">
                <DeleteParameters>
                    <asp:Parameter Name="id" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="Afdeling" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Afdeling" Type="String" />
                    <asp:Parameter Name="id" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </div>
</asp:Content>

