using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ContactModel
/// </summary>
public class ContactModel
{
    public string InvoerenBericht(Contact contact)
    {
        try
        {
            AfterlifeDataBaseEntities db = new AfterlifeDataBaseEntities();
            db.Contacts.Add(contact);
            db.SaveChanges();

            return "Bericht verzonden!";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }

    public Contact inlezenBericht(int id)
    {
        try
        {
            using (AfterlifeDataBaseEntities db = new AfterlifeDataBaseEntities())
            {
                Contact contact = db.Contacts.Find(id);
                return contact;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }
}