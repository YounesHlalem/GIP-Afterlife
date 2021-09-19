using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PlaatsingModel
/// </summary>
public class PlaatsingModel
{
    public string Aanvraag(Plaatsing plaatsing)
    {
        try
        {
            AfterlifeDataBaseEntities db = new AfterlifeDataBaseEntities();
            db.Plaatsings.Add(plaatsing);
            db.SaveChanges();

            return plaatsing.Titel + " word bekeken.";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }
}