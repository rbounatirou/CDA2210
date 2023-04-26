using System;
using System.Collections.Generic;

namespace WinFormsMultiCouche.Models;

public partial class Compte
{
    public int Id { get; set; }

    public string Pseudo { get; set; } = null!;

    public virtual ICollection<Personnage> Personnages { get; set; } = new List<Personnage>();
}
