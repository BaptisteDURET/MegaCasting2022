using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.tables;

public partial class Artiste : Utilisateur
{
    //public long Identifiant { get; set; }

    public string Cv { get; set; } = null!;

    public string Nom { get; set; } = null!;

    public string Prenom { get; set; } = null!;

    public long IdentifiantSexe { get; set; }

   // public virtual Utilisateur IdentifiantNavigation { get; set; } = null!;

    public virtual Sexe IdentifiantSexeNavigation { get; set; } = null!;
}
