using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina_s_Contact : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private Contact BerichtAanmaak()
    {
        Contact contact = new Contact();
        DateTime vandaag = DateTime.Now;

        contact.Naam = txtNaam.Text;
        contact.Mail = txtMail.Text;
        contact.Bericht = txtBericht.Text;
        contact.Onderwerp = txtOnderwerp.Text;
        contact.Datum = vandaag;

        return contact;
    }
        
    protected void btnBericht_Click(object sender, EventArgs e)
    {
        ContactModel contactmodel = new ContactModel();
        Contact contact = BerichtAanmaak();

        lblStatus.Text = contactmodel.InvoerenBericht(contact);
    }
}