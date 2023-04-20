using Interfaces;

namespace CoucheDomaine
{
    public class DomainDbInteract
    {
        private List<> cities;
        private List<ICrudableCity> countries;

        public DomainDbInteract(List<ICrudableCity> cities, List<ICrudableCity> countries)
        {
            this.cities = cities;
            this.countries = countries;
        }

        public void AjouterCity(ICrudableCity insert)
        {

        }
    }
}