<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BeheerCBerichten.aspx.cs" Inherits="Pagina_s_BeheerCBerichten" %>

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
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id" DataSourceID="sdsContact" ForeColor="#333333" GridLines="None" OnRowEditing="GridView1_RowEditing">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" DeleteText="Verwijderen" EditText="Bekijken" />
                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="Naam" HeaderText="Naam" SortExpression="Naam" />
                    <asp:BoundField DataField="Mail" HeaderText="Mail" SortExpression="Mail" />
                    <asp:BoundField DataField="Onderwerp" HeaderText="Onderwerp" SortExpression="Onderwerp" />
                    <asp:BoundField DataField="Bericht" HeaderText="Bericht" SortExpression="Bericht" />
                    <asp:BoundField DataField="Datum" HeaderText="Datum" SortExpression="Datum" />
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
            <asp:SqlDataSource ID="sdsContact" runat="server" ConnectionString="<%$ ConnectionStrings:AfterlifeDataBaseConnectionString %>" DeleteCommand="DELETE FROM [Contact] WHERE [id] = @id" InsertCommand="INSERT INTO [Contact] ([Naam], [Mail], [Onderwerp], [Bericht], [Datum]) VALUES (@Naam, @Mail, @Onderwerp, @Bericht, @Datum)" SelectCommand="SELECT * FROM [Contact]" UpdateCommand="UPDATE [Contact] SET [Naam] = @Naam, [Mail] = @Mail, [Onderwerp] = @Onderwerp, [Bericht] = @Bericht, [Datum] = @Datum WHERE [id] = @id">
                <DeleteParameters>
                    <asp:Parameter Name="id" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="Naam" Type="String" />
                    <asp:Parameter Name="Mail" Type="String" />
                    <asp:Parameter Name="Onderwerp" Type="String" />
                    <asp:Parameter Name="Bericht" Type="String" />
                    <asp:Parameter Name="Datum" Type="DateTime" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Naam" Type="String" />
                    <asp:Parameter Name="Mail" Type="String" />
                    <asp:Parameter Name="Onderwerp" Type="String" />
                    <asp:Parameter Name="Bericht" Type="String" />
                    <asp:Parameter Name="Datum" Type="DateTime" />
                    <asp:Parameter Name="id" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </div>
</asp:Content>

