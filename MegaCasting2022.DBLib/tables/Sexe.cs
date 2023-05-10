using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.tables;

public partial class Sexe
{
    public int Identifiant { get; set; }

    public string Libelle { get; set; } = null!;

    public virtual ICollection<Artiste> Artistes { get; } = new List<Artiste>();

    public virtual ICollection<Casting> IdentifiantCastings { get; } = new List<Casting>();

    public override string ToString()
    {
        return Identifiant + " - " + Libelle;
    }
}
