using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.tables;

public partial class Metier
{
    public long Identifiant { get; set; }

    public string Libelle { get; set; } = null!;

    public long IdentifiantDomaineMetier { get; set; }

    public virtual FicheMetier? FicheMetier { get; set; }

    public virtual DomaineMetier IdentifiantDomaineMetierNavigation { get; set; } = null!;

    public virtual ICollection<Casting> IdentifiantCastings { get; } = new List<Casting>();
}
