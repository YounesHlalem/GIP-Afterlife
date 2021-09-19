using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GastenboekModel
/// </summary>
public class GastenboekModel
{
    public List<Gastenboek> AlleBerichten()
    {
        try
        {
            using (AfterlifeDataBaseEntities db = new AfterlifeDataBaseEntities())
            {
                List<Gastenboek> gastenboek = (from x in db.Gastenboeks
                                               orderby x.Datum descending
                                               select x).ToList();
                return gastenboek;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }

    public string InvoerenBericht(Gastenboek gastenboek)
    {
        try
        {
            AfterlifeDataBaseEntities db = new AfterlifeDataBaseEntities();
            db.Gastenboeks.Add(gastenboek);
            db.SaveChanges();

            return "Bericht geplaats!";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }
}