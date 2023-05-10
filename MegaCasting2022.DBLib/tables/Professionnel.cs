using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.tables;

public partial class Professionnel : Utilisateur
{
    public Professionnel()
    {
        
    }

    public string Entreprise { get; set; } = null!;

    public bool Verifie { get; set; }

    public virtual ICollection<Casting> Castings { get; } = new List<Casting>();

    public virtual ICollection<PackDeCasting> IdentifiantPacks { get; } = new List<PackDeCasting>();
    public override string ToString()
    {
        return Identifiant + " - " + Nom + " - " + Entreprise;
    }
}
