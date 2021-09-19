using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina_s_Bestellingen : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string userId = User.Identity.GetUserId();

        AankoopBestelling(userId);
    }

    protected void Delete_Item(object sender, EventArgs e)
    {
        LinkButton selectedLink = (LinkButton)sender;
        string link = selectedLink.ID.Replace("del", "");
        int cartId = Convert.ToInt32(link);

        var cartModel = new BestellingModel();
        cartModel.DeleteCart(cartId);

        Response.Redirect("../Pagina's/Bestellingen.aspx");
    }

    private void AankoopBestelling(string userId)
    {
        BestellingModel cartModel = new BestellingModel();
        
        List<Bestelling> purchaseList = cartModel.OproepenBestellingen(userId);
        CreateShopTable(purchaseList);
    }

    private void CreateShopTable(IEnumerable<Bestelling> carts)
    {
        ZoekerModel model = new ZoekerModel();

        foreach (Bestelling Cart in carts)
        {
            
            Zoeker product = model.GetProduct(Cart.ZoekerID);

            ImageButton btnImage = new ImageButton
            {
                ImageUrl = string.Format("../Foto's/Zoekertjes/{0}", product.Foto),
                PostBackUrl = string.Format("../Pagina's/Zoeker.aspx?id={0}", product.id),
                CssClass = "btnImage"
            };

            LinkButton lnkDelete = new LinkButton
            {
                PostBackUrl = string.Format("../Pagina's/Bestellingen.aspx?productId={0}", Cart.id),
                Text = "Verwijderen",
                ID = "del" + Cart.id,
                CssClass = "lnkDelete"
            };

            lnkDelete.Click += Delete_Item;
            
            Table table = new Table { CssClass = "CartTable" };
            TableRow row1 = new TableRow();

            TableCell cell1_1 = new TableCell { Width = 150 };
            TableCell cell1_2 = new TableCell
            {
                Text = string.Format(product.Titel),
                HorizontalAlign = HorizontalAlign.Left,
                Width = 150, CssClass = "lblTitel",
            };
            TableCell cell1_3 = new TableCell { Text = "Prijs:  € " + product.Prijs,
                Width = 150,
            };
            TableCell cell1_4 = new TableCell { Text = "" };
            
            cell1_1.Controls.Add(btnImage);
            cell1_4.Controls.Add(lnkDelete);
            
            row1.Cells.Add(cell1_1);
            row1.Cells.Add(cell1_2);
            row1.Cells.Add(cell1_3);
            row1.Cells.Add(cell1_4);

            table.Rows.Add(row1);

            Panel1.Controls.Add(table);
        }
        
        Session[User.Identity.GetUserId()] = carts;
    }
}