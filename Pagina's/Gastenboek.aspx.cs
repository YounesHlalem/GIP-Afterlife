using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina_s_Gastenboek : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        GastenboekModel gastenboekmodel = new GastenboekModel();
        List<Gastenboek> gastenboeken = gastenboekmodel.AlleBerichten();

        if (gastenboeken != null)
        {
            foreach (Gastenboek gastenboek in gastenboeken)
            {
                Panel productPanel = new Panel();

                Label lblNaam = new Label
                {
                    Text = gastenboek.Naam,
                    CssClass = "lblNaam"
                };

                Label lblMail = new Label
                {
                    Text = gastenboek.Mail,
                    CssClass = "lblMail"
                };

                Label lblBericht = new Label
                {
                    Text = gastenboek.Bericht,
                    CssClass = "lblBericht"
                };

                Label lblDatum = new Label
                {
                    Text = (gastenboek.Datum).ToString("dd/MM/yy"),
                    CssClass = "lblDatum"
                };

                Label lblstreep = new Label
                {
                    Text = "___________________________________________________________",
                    CssClass = "lblstreep"
                };

                productPanel.Controls.Add(lblNaam);
                productPanel.Controls.Add(new Literal { Text = "<br/>" });
                productPanel.Controls.Add(lblDatum);
                productPanel.Controls.Add(new Literal { Text = "<br/>" });
                productPanel.Controls.Add(new Literal { Text = "<br/>" });
                productPanel.Controls.Add(lblBericht);
                productPanel.Controls.Add(new Literal { Text = "<br/>" });
                productPanel.Controls.Add(new Literal { Text = "<br/>" });
                productPanel.Controls.Add(lblMail);
                productPanel.Controls.Add(new Literal { Text = "<br/>" });
                productPanel.Controls.Add(lblstreep);
                productPanel.Controls.Add(new Literal { Text = "<br/>" });
                productPanel.Controls.Add(new Literal { Text = "<br/>" });

                Panel1.Controls.Add(productPanel);
            }
        }
        else
            Panel1.Controls.Add(new Literal { Text = "Gastenboek is nog leeg!" });
    }

    private Gastenboek BerichtAanmaak()
    {
        Gastenboek gastenboek = new Gastenboek();
        DateTime vandaag = DateTime.Today;

        gastenboek.Naam = txtnieuwNaam.Text;
        gastenboek.Mail = txtnieuwMail.Text;
        gastenboek.Bericht = txtnieuwBericht.Text;
        gastenboek.Datum = vandaag;

        return gastenboek;
    }

    protected void btnBericht_Click(object sender, EventArgs e)
    {
        GastenboekModel gastenboekmodel = new GastenboekModel();
        Gastenboek gastenboek = BerichtAanmaak();

            lblStatus.Text = gastenboekmodel.InvoerenBericht(gastenboek);
    }
}