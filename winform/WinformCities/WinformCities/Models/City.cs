using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WinformCities.Models;

public partial class City
{
    [Key]
    public int CityId { get; set; }

    public string? CityName { get; set; }

    public string CountryCode { get; set; } = null!;

    public virtual Country CountryCodeNavigation { get; set; } = null!;
}
