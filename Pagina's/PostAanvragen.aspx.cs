using Microsoft.AspNet.Identity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina_s_PostAanvragen : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (!IsPostBack)
        {
            LaadFotos();
        }
    }

    private void LaadFotos()
    {
        try
        {
            string[] images = Directory.GetFiles(Server.MapPath("../Foto's/Zoekertjes/"));

            ArrayList imageList = new ArrayList();
            foreach (string image in images)
            {
                string imageName = image.Substring(image.LastIndexOf(@"\", StringComparison.Ordinal) + 1);
                imageList.Add(imageName);
            }

            DropDownList2.DataSource = imageList;
            DropDownList2.AppendDataBoundItems = true;
            DropDownList2.DataBind();
        }
        catch (Exception e)
        {
            Label6.Text = e.ToString();
        }
    }

    private Plaatsing Plaats()
    {
        Plaatsing plaatsing = new Plaatsing();

        plaatsing.Titel = TextBox1.Text;
        plaatsing.Prijs = Convert.ToInt32(TextBox3.Text);
        plaatsing.AfdelingID = Convert.ToInt32(DropDownList1.SelectedValue);
        plaatsing.Beschrijving = TextBox2.Text;
        plaatsing.Foto = DropDownList2.SelectedValue;

        return plaatsing;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        PlaatsingModel plaatsingmodel = new PlaatsingModel();
        Plaatsing plaats = Plaats();

        if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            Label6.Text = plaatsingmodel.Aanvraag(plaats);
        }
        else
        {
            Label6.Text = plaatsingmodel.Aanvraag(plaats);
        }
    }
}