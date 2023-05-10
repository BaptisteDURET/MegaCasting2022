using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.tables;

public partial class PartenaireDiffusion : Utilisateur
{
    public string Entreprise { get; set; } = null!;

    public bool Verifie { get; set; }

    public override string ToString()
    {
        return Identifiant + " - " + Nom + " - " + Entreprise;
    }
}
