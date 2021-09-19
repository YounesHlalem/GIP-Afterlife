using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserinfoModel
/// </summary>
public class UserinfoModel
{
    public Userinformation GetUserInformation(string guId)
    {
        AfterlifeDataBaseEntities db = new AfterlifeDataBaseEntities();
  
        var info = (from x in db.Userinformations
                    where x.GUID == guId
                    select x).FirstOrDefault();
        return info;
    }

    public void InsertUserDetail(Userinformation userinformation)
    {
        AfterlifeDataBaseEntities db = new AfterlifeDataBaseEntities();
        db.Userinformations.Add(userinformation);
        db.SaveChanges();
    }
}