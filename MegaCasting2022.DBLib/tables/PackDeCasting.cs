using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.tables;

public partial class PackDeCasting
{
    public long Identifiant { get; set; }

    public string Libelle { get; set; } = null!;

    public short NombreCastings { get; set; }

    public decimal Prix { get; set; }

    public short TempsDiffusionOffreEnHeure { get; set; }

    public virtual ICollection<Professionnel> IdentifiantProfessionels { get; } = new List<Professionnel>();
}
