using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.tables;

public partial class Casting
{
    public long Identifiant { get; set; }

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

    public long IdentifiantProfessionnel { get; set; }

    public virtual Professionnel IdentifiantProfessionnelNavigation { get; set; } = null!;

    public virtual ICollection<Metier> IdentifiantMetiers { get; } = new List<Metier>();

    public virtual ICollection<Sexe> IdentifiantSexes { get; } = new List<Sexe>();

    public virtual ICollection<TypeContrat> IdentifiantTypeContrats { get; } = new List<TypeContrat>();

    public override string ToString()
    {
        return Identifiant + " - " + Intitule + " - Ref : " + Reference;
    }
}
