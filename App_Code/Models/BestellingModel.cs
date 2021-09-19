using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BestellingModel
/// </summary>
public class BestellingModel
{
    public string InsertCart(Bestelling bestelling)
    {
        try
        {
            AfterlifeDataBaseEntities db = new AfterlifeDataBaseEntities();
            db.Bestellings.Add(bestelling);
            db.SaveChanges();

            return "Toegevoegd aan favorieten!";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string UpdateCart(int id, Bestelling bestelling)
    {
        try
        {
            AfterlifeDataBaseEntities db = new AfterlifeDataBaseEntities();

            //Fetch object from db
            Bestelling p = db.Bestellings.Find(id);

            p.Datum = bestelling.Datum;
            p.GebruikerID = bestelling.GebruikerID;
            p.Hoeveelheid = bestelling.Hoeveelheid;
            p.IsBesteld = bestelling.IsBesteld;
            p.ZoekerID = bestelling.ZoekerID;

            db.SaveChanges();
            return bestelling.Datum + " is geupdate.";

        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string DeleteCart(int id)
    {
        try
        {
            AfterlifeDataBaseEntities db = new AfterlifeDataBaseEntities();
            Bestelling bestelling = db.Bestellings.Find(id);

            db.Bestellings.Attach(bestelling);
            db.Bestellings.Remove(bestelling);
            db.SaveChanges();

            return bestelling.Datum + " is verwijdert.";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public List<Bestelling> OproepenBestellingen(string gebruikerid)
    {
        AfterlifeDataBaseEntities db = new AfterlifeDataBaseEntities();
        List<Bestelling> orders = (from x in db.Bestellings
                                   where x.GebruikerID == gebruikerid
                             && x.IsBesteld
                             orderby x.Datum descending
                             select x).ToList();
        return orders;
    }

    public int OproepenAantal(string gebruikerid)
    {
        try
        {
            AfterlifeDataBaseEntities db = new AfterlifeDataBaseEntities();
            int aantal = (from x in db.Bestellings
                          where x.GebruikerID == gebruikerid
                          && x.IsBesteld
                          select x.Hoeveelheid).Sum();

            return aantal;
        }
        catch
        {
            return 0;
        }
    }

    public void UpdateAantal(int id, int aantal)
    {
        AfterlifeDataBaseEntities db = new AfterlifeDataBaseEntities();
        Bestelling p = db.Bestellings.Find(id);
        p.Hoeveelheid = aantal;

        db.SaveChanges();
    }

    public void MarkAsPaid(List<Bestelling> bestellingen)
    {
        AfterlifeDataBaseEntities db = new AfterlifeDataBaseEntities();

        if (bestellingen != null)
        {
            foreach (Bestelling bestelling in bestellingen)
            {
                Bestelling vorigebestellingen = db.Bestellings.Find(bestelling.id);
                vorigebestellingen.Datum = DateTime.Now;
                vorigebestellingen.IsBesteld = false;
            }
            db.SaveChanges();
        }
    }
}