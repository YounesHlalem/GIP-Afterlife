using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina_s_Beheer_ManageAfdeling : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        AfdelingModel model = new AfdelingModel();
        Afdeling pt = CreateAfdeling();

        Label2.Text = model.InsertProductType(pt);
    }

    private Afdeling CreateAfdeling()
    {
        Afdeling p = new Afdeling();
        p.Afdeling1 = TextBox1.Text;

        return p;
    }
}