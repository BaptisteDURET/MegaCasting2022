using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.tables;

public partial class Artiste : Utilisateur
{
    public string Cv { get; set; } = null!;

    public string Nom { get; set; } = null!;

    public string Prenom { get; set; } = null!;

    public int IdentifiantSexe { get; set; }

    public virtual Sexe IdentifiantSexeNavigation { get; set; } = null!;
}
