using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var user = Context.User.Identity;
        if (user.IsAuthenticated)
        {
            loglink.Visible = false;
            reglink.Visible = false;

            gebruikersnaam.Visible = true;
            logoutlink.Visible = true;

            BestellingModel model = new BestellingModel();
            string userId = HttpContext.Current.User.Identity.GetUserId();
            gebruikersnaam.Text = Context.User.Identity.Name;
        }
        else
        {
            loglink.Visible = true;
            reglink.Visible = true;

            gebruikersnaam.Visible = false;
            logoutlink.Visible = false;
        }
    }

    protected void logoutlink_Click(object sender, EventArgs e)
    {
        IAuthenticationManager authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
        authenticationManager.SignOut();
        Response.Redirect("/Pagina's/Account/Login.aspx");
    }
}
