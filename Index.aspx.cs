using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ZoekerModel zoekermodel = new ZoekerModel();
        List<Zoeker> zoekers = zoekermodel.GetAllProduct();

        if (zoekers != null)
        {
            foreach (Zoeker zoeker in zoekers)
            {
                Panel productPanel = new Panel
                {
                    CssClass = "inlineBlock"
                };

                ImageButton imageButton = new ImageButton
                {
                    ImageUrl = "~/Foto's/Zoekertjes/" + zoeker.Foto,
                    CssClass = "ZoekerFoto",
                    PostBackUrl = string.Format("~/Pagina's/Zoeker.aspx?id={0}", zoeker.id)
                };
                Label lblTitel = new Label
                {
                    Text = zoeker.Titel,
                };
                Label lblPrijs = new Label
                {
                    Text = "€ " + zoeker.Prijs,
                };

                Table table = new Table { CssClass = "indexpanel" };
                TableRow row1 = new TableRow();

                TableCell cell1_1 = new TableCell { Width = 200 };
                TableCell cell1_2 = new TableCell
                {
                    Text = string.Format(zoeker.Titel),
                    HorizontalAlign = HorizontalAlign.Left,
                    Width = 300,
                    CssClass = "lblindexTitel",
                };
                TableCell cell1_4 = new TableCell
                {
                    Text = "Prijs:  € " + zoeker.Prijs,
                    Width = 150,
                    CssClass = "lblindexPrijs",
                };
                TableCell cell1_3 = new TableCell { Text = "" };

                cell1_1.Controls.Add(imageButton);

                row1.Cells.Add(cell1_1);
                row1.Cells.Add(cell1_2);
                row1.Cells.Add(cell1_3);
                row1.Cells.Add(cell1_4);

                table.Rows.Add(row1);

                pnlindexlay.Controls.Add(table);
                pnlindexlay.Controls.Add(new LiteralControl("<hr />"));
            }
        }
        else
            pnlindexlay.Controls.Add(new Literal { Text = "Er werden geen zoekertjes gevonden!" });
    }
}