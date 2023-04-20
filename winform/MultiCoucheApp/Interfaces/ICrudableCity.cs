using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICrudableCity
    {
        public abstract void Insert(string _cityName, string _countryCode);
        public abstract void Update(int _id, string _newCityName, string _newCountryCode);
        public abstract void Delete(int? _id, string? _newCityName, string? _newCountryCode);
    }
}
