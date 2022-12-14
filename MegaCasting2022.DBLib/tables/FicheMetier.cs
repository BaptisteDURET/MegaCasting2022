using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.tables;

public partial class FicheMetier : ContenuEditorial
{
    //public long Identifiant { get; set; }

    public string Description { get; set; } = null!;

    public long IdentifiantMetier { get; set; }

    public virtual Metier IdentifiantMetierNavigation { get; set; } = null!;

    //public virtual ContenuEditorial IdentifiantNavigation { get; set; } = null!;
}