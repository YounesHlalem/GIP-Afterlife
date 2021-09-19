<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registreren.aspx.cs" Inherits="Pagina_s_Account_Registreren" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welkom op Afterlife</title>
    <link rel="stylesheet" type="text/css" href="../../Stylesheets/RegisterStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="logo">Registreren op Afterlife</div>
        <div class="login-block">
            <h1>Maak uw gratis account aan!</h1>
            <asp:TextBox runat="server" id="naam" placeholder="Gebruikersnaam" CssClass="invoer1"></asp:TextBox>
            <asp:TextBox runat="server" id="password" TextMode="Password" placeholder="Wachtwoord" CssClass="invoer2"></asp:TextBox>
            <asp:TextBox runat="server" id="Cpassword" TextMode="Password" placeholder="Bevestig wachtwoord" CssClass="invoer2"></asp:TextBox>
            <asp:TextBox runat="server" id="Voornaam" placeholder="Voornaam" CssClass="invoer1"></asp:TextBox>
            <asp:TextBox runat="server" id="Achternaam" placeholder="Achternaam" CssClass="invoer1"></asp:TextBox>
            <asp:TextBox runat="server" id="Adres" placeholder="Adres" CssClass="invoer1"></asp:TextBox>
            <asp:TextBox runat="server" id="Postcode" placeholder="Postcode" CssClass="invoer1"></asp:TextBox>
            <asp:TextBox runat="server" id="Mail" placeholder="E-mail" CssClass="invoer1"></asp:TextBox>
            <asp:Button id="button1" runat="server" Text="Registreren" OnClick="button1_Click"/>
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
            <p class="extra">Heb je al een account? <a href="Login.aspx" id="reg">Log je nu in >></a></p>
        </div>
    </form>
</body>
</html>