using System;
using System.Collections.Generic;

namespace EntityLinkTestAppConfig.Models;

public partial class Country
{
    public string CountryCode { get; set; } = null!;

    public string CountryName { get; set; } = null!;

    public virtual ICollection<City> Cities { get; set; } = new List<City>();
}
