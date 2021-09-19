using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AfdelingModel
/// </summary>
public class AfdelingModel
{
    public string InsertProductType(Afdeling afdeling)
    {
        try
        {
            AfterlifeDataBaseEntities db = new AfterlifeDataBaseEntities();
            db.Afdelings.Add(afdeling);
            db.SaveChanges();

            return afdeling.Afdeling1 + " is toegevoegd.";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string UpdateProductType(int id, Afdeling afdeling)
    {
        try
        {
            AfterlifeDataBaseEntities db = new AfterlifeDataBaseEntities();

            Afdeling p = db.Afdelings.Find(id);

            p.Afdeling1 = afdeling.Afdeling1;

            db.SaveChanges();
            return afdeling.Afdeling1 + " is geupdate.";

        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string DeleteProductType(int id)
    {
        try
        {
            AfterlifeDataBaseEntities db = new AfterlifeDataBaseEntities();
            Afdeling afdeling = db.Afdelings.Find(id);

            db.Afdelings.Attach(afdeling);
            db.Afdelings.Remove(afdeling);
            db.SaveChanges();

            return afdeling.Afdeling1 + " is verwijdert.";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }
}