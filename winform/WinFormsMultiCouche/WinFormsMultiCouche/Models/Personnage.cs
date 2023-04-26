using System;
using System.Collections.Generic;

namespace WinFormsMultiCouche.Models;

public partial class Personnage
{
    public int Id { get; set; }

    public string CharacterName { get; set; } = null!;

    public int IdRace { get; set; }

    public int IdCompte { get; set; }

    public virtual Compte IdCompteNavigation { get; set; } = null!;

    public virtual Race IdRaceNavigation { get; set; } = null!;
}
