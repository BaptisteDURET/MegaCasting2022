using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.tables;

public partial class Utilisateur
{
    public long Identifiant { get; set; }

    public string NomUtilisateur { get; set; } = null!;

    public string MotDePasse { get; set; } = null!;

    public string? NumeroTelephone { get; set; }

    public string? Email { get; set; }

    //public virtual Artiste? Artiste { get; set; }

    //public virtual PartenaireDiffusion? PartenaireDiffusion { get; set; }

    //public virtual Professionnel? Professionnel { get; set; }
}
