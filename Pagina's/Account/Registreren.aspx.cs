using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina_s_Account_Registreren : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void button1_Click(object sender, EventArgs e)
    {
        var userStore = new UserStore<IdentityUser>();
        
        userStore.Context.Database.Connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AfterlifeDataBaseConnectionString"].ConnectionString;
        var manager = new UserManager<IdentityUser>(userStore);
        
        var user = new IdentityUser { UserName = naam.Text };

        if (password.Text == Cpassword.Text)
        {
            try
            {
                IdentityResult result = manager.Create(user, password.Text);
                if (result.Succeeded)
                {
                    Userinformation info = new Userinformation
                    {
                        Voornaam = Voornaam.Text,
                        Achternaam = Achternaam.Text,
                        Adres = Adres.Text,
                        Postcode = Convert.ToInt32(Postcode.Text),
                        Mail = Mail.Text,
                        GUID = user.Id
                    };

                    UserinfoModel model = new UserinfoModel();
                    model.InsertUserDetail(info);
                    
                    var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                    var userIdentity = manager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                    
                    authenticationManager.SignIn(new AuthenticationProperties(), userIdentity);
                    Response.Redirect("../../Index.aspx");
                }
                else
                {
                    Literal1.Text = result.Errors.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                Literal1.Text = ex.ToString();
            }
        }
        else
        {
            Literal1.Text = "Wachtwoord moet overeenkomen!";
        }
    }
}