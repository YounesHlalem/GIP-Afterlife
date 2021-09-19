using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina_s_Zoeker : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
    }

    private void FillPage()
    {
        if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            ZoekerModel model = new ZoekerModel();
            Zoeker zoeker = model.GetProduct(id);
            
            lblTitle.Text = zoeker.Titel;
            lblDescription.Text = zoeker.Beschrijving;
            lblPrice.Text = "Prijs per stuk:<br/>€ " + zoeker.Prijs;
            imgProduct.ImageUrl = "../Foto's/Zoekertjes/" + zoeker.Foto;
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            string gebruikerID = Context.User.Identity.GetUserId();

            if (gebruikerID != null)
            {

                int id = Convert.ToInt32(Request.QueryString["id"]);

                Bestelling bestelling = new Bestelling
                {
                    Hoeveelheid = 0,
                    GebruikerID = gebruikerID,
                    Datum = DateTime.Now,
                    IsBesteld = true,
                    ZoekerID = id
                };

                BestellingModel model = new BestellingModel();
                lblResult.Text = model.InsertCart(bestelling);
            }
            else
            {
                lblResult.Text = "U moet ingelogd zijn om een bestelling te kunnen maken";
            }
        }
    }
}