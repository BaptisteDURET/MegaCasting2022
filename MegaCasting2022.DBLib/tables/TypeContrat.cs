﻿using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.tables;

public partial class TypeContrat
{
    public int Identifiant { get; set; }

    public string LibelleCourt { get; set; } = null!;

    public string LibelleLong { get; set; } = null!;

    public virtual ICollection<Casting> IdentifiantCastings { get; } = new List<Casting>();

    public override string ToString()
    {
        return Identifiant + " - " + LibelleCourt;
    }
}
