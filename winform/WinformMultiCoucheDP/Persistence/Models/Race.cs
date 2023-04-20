using System;
using System.Collections.Generic;

namespace Persistence.Models;

public partial class Race
{
    public int Id { get; set; }

    public string Nom { get; set; } = null!;

    public virtual ICollection<Personnage> Personnages { get; set; } = new List<Personnage>();
}
