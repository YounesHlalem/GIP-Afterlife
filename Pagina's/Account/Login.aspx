<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Pagina_s_Account_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welkom op Afterlife</title>
    <link rel="stylesheet" type="text/css" href="../../Stylesheets/LoginStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="logo">Welkom op Afterlife</div>
        <div class="login-block">
            <h1>Inloggen</h1>
            <asp:TextBox runat="server" placeholder="Gebruikersnaam" id="username"></asp:TextBox>
            <asp:TextBox runat="server" placeholder="Wachtwoord" id="password" TextMode="Password"></asp:TextBox>
            <asp:Button id="button1" runat="server" Text="Login" OnClick="button1_Click"/>
            
            <p class="extra">Nog geen account: <a href="Registreren.aspx" id="reg">Registreer nu >></a></p>
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </div>
        <div class="gast">
            <asp:Button id="button2" runat="server" Text="Doorgaan zonder inloggen >>" PostBackUrl="~/Index.aspx" />
        </div>
    </form>
</body>
</html>
