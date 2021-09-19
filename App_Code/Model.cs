﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class Afdeling
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Afdeling()
    {
        this.Zoekers = new HashSet<Zoeker>();
    }

    public int id { get; set; }
    public string Afdeling1 { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Zoeker> Zoekers { get; set; }
}

public partial class Bestelling
{
    public int id { get; set; }
    public string GebruikerID { get; set; }
    public int ZoekerID { get; set; }
    public int Hoeveelheid { get; set; }
    public Nullable<System.DateTime> Datum { get; set; }
    public bool IsBesteld { get; set; }

    public virtual Zoeker Zoeker { get; set; }
}

public partial class Contact
{
    public int id { get; set; }
    public string Naam { get; set; }
    public string Mail { get; set; }
    public string Onderwerp { get; set; }
    public string Bericht { get; set; }
    public Nullable<System.DateTime> Datum { get; set; }
}

public partial class Gastenboek
{
    public int id { get; set; }
    public string Naam { get; set; }
    public string Mail { get; set; }
    public string Bericht { get; set; }
    public System.DateTime Datum { get; set; }
}

public partial class Plaatsing
{
    public int id { get; set; }
    public int AfdelingID { get; set; }
    public string Titel { get; set; }
    public int Prijs { get; set; }
    public string Beschrijving { get; set; }
    public string Foto { get; set; }
    public string Voornaam { get; set; }
    public string Achternaam { get; set; }
    public string Adres { get; set; }
    public Nullable<int> Postcode { get; set; }
    public string Mail { get; set; }
}

public partial class Userinformation
{
    public int ID { get; set; }
    public string GUID { get; set; }
    public string Voornaam { get; set; }
    public string Achternaam { get; set; }
    public string Adres { get; set; }
    public int Postcode { get; set; }
    public string Mail { get; set; }
}

public partial class Zoeker
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Zoeker()
    {
        this.Bestellings = new HashSet<Bestelling>();
    }

    public int id { get; set; }
    public int AfdelingID { get; set; }
    public string Titel { get; set; }
    public Nullable<int> Prijs { get; set; }
    public string Beschrijving { get; set; }
    public string Foto { get; set; }

    public virtual Afdeling Afdeling { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Bestelling> Bestellings { get; set; }
}