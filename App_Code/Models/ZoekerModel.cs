using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ZoekerModel
/// </summary>
public class ZoekerModel
{
    public string InsertProduct(Zoeker zoeker)
    {
        try
        {
            AfterlifeDataBaseEntities db = new AfterlifeDataBaseEntities();
            db.Zoekers.Add(zoeker);
            db.SaveChanges();

            return zoeker.Titel + " is toegevoegd.";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string UpdateProduct(int id, Zoeker zoeker)
    {
        try
        {
            AfterlifeDataBaseEntities db = new AfterlifeDataBaseEntities();

            Zoeker p = db.Zoekers.Find(id);

            p.Titel = zoeker.Titel;
            p.Prijs = zoeker.Prijs;
            p.AfdelingID = zoeker.AfdelingID;
            p.Beschrijving = zoeker.Beschrijving;
            p.Foto = zoeker.Foto;

            db.SaveChanges();
            return zoeker.Titel + " is geupdate.";

        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string DeleteProduct(int id)
    {
        try
        {
            AfterlifeDataBaseEntities db = new AfterlifeDataBaseEntities();
            Zoeker zoeker = db.Zoekers.Find(id);

            db.Zoekers.Attach(zoeker);
            db.Zoekers.Remove(zoeker);
            db.SaveChanges();

            return zoeker.Titel + " is verwijdert.";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public Zoeker GetProduct(int id)
    {
        try
        {
            using (AfterlifeDataBaseEntities db = new AfterlifeDataBaseEntities())
            {
                Zoeker zoeker = db.Zoekers.Find(id);
                return zoeker;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }

    public List<Zoeker> GetAllProduct()
    {
        try
        {
            using (AfterlifeDataBaseEntities db = new AfterlifeDataBaseEntities())
            {
                List<Zoeker> zoeker = (from x in db.Zoekers
                                       orderby x.id descending
                                       select x ).ToList();
                return zoeker;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }

    public List<Zoeker> GetProductByType(int afdelingID)
    {
        try
        {
            using (AfterlifeDataBaseEntities db = new AfterlifeDataBaseEntities())
            {
                List<Zoeker> zoeker = (from x in db.Zoekers
                                          where x.AfdelingID == afdelingID
                                       select x).ToList();
                return zoeker;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }
}

    