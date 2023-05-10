using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.tables;

public partial class Casting
{
    public int Identifiant { get; set; }

    public string Intitule { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public DateTime DateDebutPublication { get; set; }

    public short DureeDiffusion { get; set; }

    public DateTime DateDebutContrat { get; set; }

    public short NombrePosteDispo { get; set; }

    public string Localisation { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string DescriptionProfilRecherche { get; set; } = null!;

    public string? Email { get; set; }

    public string? NumeroTelephone { get; set; }

    public string? Fax { get; set; }

    public string? SiteWeb { get; set; }

    public string? AdressePostale { get; set; }

    public bool Verifie { get; set; }

    public int IdentifiantProfessionnel { get; set; }

    public int? IdentifiantMetier { get; set; }

    public int? IdentifiantSexe { get; set; }

    public int IdentifiantTypeContrat { get; set; }

    public virtual Professionnel IdentifiantProfessionnelNavigation { get; set; } = null!;

    public virtual Metier? IdentifiantMetierNavigation { get; set; }

    public virtual Sexe? IdentifiantSexeNavigation { get; set; }

    public virtual TypeContrat IdentifiantTypeContratNavigation { get; set; } = null!;

    public override string ToString()
    {
        return Identifiant + " - " + Intitule + " - Ref : " + Reference;
    }
}
