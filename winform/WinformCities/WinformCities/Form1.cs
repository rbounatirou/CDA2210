using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WinformCities.Models;

namespace WinformCities
{
    public partial class Form1 : Form
    {
        private CitiesContext dbContext;
        public Form1()
        {
            InitializeComponent();
            // instantiation du context et chargement
            dbContext = new CitiesContext();
            dbContext.Cities.Load();


            // creatioon d'un lien entre la source et le datagridview
            this.dataGridViewCities.DataSource = dbContext.Cities.Local.ToBindingList();

        }




        public void AjouterCity(City c)
        {
            
            dbContext.Cities.Add(c);
            dbContext.SaveChanges();

        }

        private void btnAjouterCities_Click(object sender, EventArgs e)
        {
            City city = new City();

            city.CityName = (string)dataGridViewCities.SelectedCells[1].Value;
            city.CountryCode = (string)dataGridViewCities.SelectedCells[2].Value;
        }
    }
}