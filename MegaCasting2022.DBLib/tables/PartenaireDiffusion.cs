using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.tables;

public partial class PartenaireDiffusion : Utilisateur
{
    //public long Identifiant { get; set; }

    public string Entreprise { get; set; } = null!;

    public bool Verifie { get; set; }

    //public virtual Utilisateur IdentifiantNavigation { get; set; } = null!;
}
