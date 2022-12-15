using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.tables;

public partial class Professionnel : Utilisateur
{
    public Professionnel()
    {
        
    }
    //public long Identifiant { get; set; }

    public string Entreprise { get; set; } = null!;

    public bool Verifie { get; set; }

    public virtual ICollection<Casting> Castings { get; } = new List<Casting>();

    //public virtual Utilisateur IdentifiantNavigation { get; set; } = null!;

    public virtual ICollection<PackDeCasting> IdentifiantPacks { get; } = new List<PackDeCasting>();
    public override string ToString()
    {
        return Identifiant + " - " + NomUtilisateur + " - " + Entreprise;
    }
}
