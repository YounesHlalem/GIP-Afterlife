using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina_s_ContactBeheer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            FillForm(id);
        }
    }

    private void FillForm(int id)
    {
        try
        {
            ContactModel contactmodel = new ContactModel();
            Contact contact = contactmodel.inlezenBericht(id);

            lblNaam.Text = contact.Naam;
            lblMail.Text = contact.Mail;
            lblDatum.Text = Convert.ToString(contact.Datum);
            lblOnderwerp.Text = contact.Onderwerp;
            lblBericht.Text = contact.Bericht;
            
        }
        catch (Exception ex)
        {
            lblStatus.Text = ex.ToString();
        }
    }
}