using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina_s_Beheer_Beheer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridViewRow row = GridView1.Rows[e.NewEditIndex];
        
        int rowId = Convert.ToInt32(row.Cells[1].Text);
        
        Response.Redirect("~/Pagina's/Beheer/ManageZoeker.aspx?id= " + rowId);
    }
}