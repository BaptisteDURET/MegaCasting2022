using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.tables;

public partial class ContenuEditorial
{
    public long Identifiant { get; set; }

    public string Titre { get; set; } = null!;

    //public virtual Conseil? Conseil { get; set; }

    //public virtual FicheMetier? FicheMetier { get; set; }

    //public virtual Interview? Interview { get; set; }
}
