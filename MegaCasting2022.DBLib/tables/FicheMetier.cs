using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.tables;

public partial class FicheMetier : ContenuEditorial
{
    public string Description { get; set; } = null!;

    public int IdentifiantMetier { get; set; }

    public virtual Metier IdentifiantMetierNavigation { get; set; } = null!;
}