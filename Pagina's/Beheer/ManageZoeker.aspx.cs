using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina_s_Beheer_ManageZoeker : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack){
            LaadFotos();
            
            if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                FillForm(id);
            }
        }
    }

    private void FillForm(int id)
    {
        try
        {
            ZoekerModel zoekermodel = new ZoekerModel();
            Zoeker zoeker = zoekermodel.GetProduct(id);

            TextBox2.Text = zoeker.Beschrijving;
            TextBox1.Text = zoeker.Titel;
            TextBox3.Text = zoeker.Prijs.ToString();

            DropDownList2.SelectedValue = zoeker.Foto;
            DropDownList1.SelectedValue = zoeker.AfdelingID.ToString();
        }
        catch (Exception ex)
        {
            Label6.Text = ex.ToString();
        }
    }

    private void LaadFotos(){
    try{
    string[] images = Directory.GetFiles(Server.MapPath("../../Foto's/Zoekertjes/"));
            
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

    private Zoeker CreateProduct()
    {
        Zoeker zoeker = new Zoeker();

        zoeker.Titel = TextBox1.Text;
        zoeker.Prijs = Convert.ToInt32(TextBox3.Text);
        zoeker.AfdelingID = Convert.ToInt32(DropDownList1.SelectedValue);
        zoeker.Beschrijving = TextBox2.Text;
        zoeker.Foto = DropDownList2.SelectedValue;

        return zoeker;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ZoekerModel zoekermodel = new ZoekerModel();
        Zoeker zoeker = CreateProduct();

        if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            Label6.Text = zoekermodel.UpdateProduct(id, zoeker);
        }
        else
        {
            Label6.Text = zoekermodel.InsertProduct(zoeker);
        }
    }
}