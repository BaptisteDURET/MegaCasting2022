using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.tables;

public partial class DomaineMetier
{
    public int Identifiant { get; set; }

    public string Libelle { get; set; } = null!;

    public virtual ICollection<Metier> Metiers { get; } = new List<Metier>();
}
