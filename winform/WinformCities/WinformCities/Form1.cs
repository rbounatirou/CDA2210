using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RequeteTierces;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using WinformCities.Models;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace WinformCities
{
    public partial class Form1 : Form
    {
        private CitiesContext dbContext;
        private List<int> lineToAdds;
        private List<int> lineToUpdate;

        public Form1()
        {
            InitializeComponent();
            // instantiation du context et chargement
            dbContext = new CitiesContext();
            dbContext.Cities.Load();
            


            // creatioon d'un lien entre la source et le datagridview
            string str = "SELECT Cities.city_name, Cities.country_code, COUNT(*) AS country_with_same_code FROM Cities INNER JOIN Cities AS C2 ON C2.country_code = Cities.country_code GROUP BY Cities.city_name, Cities.country_code;";
            this.dataGridViewCities.DataSource = dbContext.Cities.Local.ToBindingList();

            dataGridViewCities.Columns[3].Visible = false;
            dbContext.Countries.Load();
            this.dataGridViewCountries.DataSource = dbContext.Countries.Local.ToBindingList();
            /*dataGridViewCities.RowEnter += (sender, e) =>
            {
                DataGridViewRowCollection data = dataGridViewCountries.Rows;
                data.
                
            };*/
            /*var test = (from Cities in dbContext.Cities
                        join Countries in dbContext.Countries
                        on Cities.CountryCode equals Countries.CountryCode                        
                        select new
                        {
                            productName = Cities.CityName,
                            countryCode = Cities.CountryCode
                            
                        }).ToList();
            IQueryable<object> test2 = dbContext.Cities.Join(dbContext.Cities, city => city.CountryCode, city2 => city2.CountryCode, (city, city2) =>
            new
            {
                cityName = city.CityName,
                countryCode = city.CountryCode
            });
            dataGridView2.DataSource = test2.ToList();*/
           
            /*var Data = dbContext.Cities.Join(dbContext.Countries, 
                c => c.CityId, 
                ct => ct.Cities,
                (_c, _ct) => new { City = _c, Country = _ct});*/
            //var count = dbContext.Cities.FromSqlRaw(str).ToList();
            
           /* SqlConnection db = dbContext.Database.GetDbConnection() as SqlConnection;
            List <RequeteCountCities>  rqc= new();
            try
            {
                
                db.Open();
                SqlCommand command = db.CreateCommand();
                command.CommandText = str;
                DbDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    RequeteCountCities rq = new RequeteCountCities();
                    int i = 0;
                    object[] values = new object[3];
                    while (dr.Read())
                    {
                        dr.GetValues(values);
                        rq = new RequeteCountCities();
                        rq.CityName = (string)values[0];
                        rq.CountryCode = (string)values[1];
                        rq.nbSameCode = (int)values[2];
                        rqc.Add(rq);

                    }
                    
                }

            } catch { 
            }*/
        }




        public void AjouterCity(City c)
        {
            Trace("Apres add");

            dbContext.SaveChanges();
            Refresh();
        }

        public void RetirerCity(City c)
        {
            Trace("Avant supp");
            dbContext.Cities.Remove(c);
            Trace("Apres supp");
            dbContext.SaveChanges();
            Refresh();
        }
        private void Refresh()
        {
            dataGridViewCities.Refresh();
        }
        private void btnAjouterCities_Click(object sender, EventArgs e)
        {
            City city = new City();

            int index = dataGridViewCities.SelectedCells[0].RowIndex;
            if (dataGridViewCities.Rows[index].Cells[1].Value != null &&
                dataGridViewCities.Rows[index].Cells[2].Value != null)
            {
                city.CityName = dataGridViewCities.Rows[index].Cells[1].Value.ToString();
                city.CountryCode = dataGridViewCities.Rows[index].Cells[2].Value.ToString();
            }
            //dataGridViewCities.Rows.RemoveAt(index);
            AjouterCity(city);
        }

        private void Trace(string message)
        {
            textBoxConsole.Text = "";
            textBoxConsole.Text += "-----------------------" + message + "------------------------" + Environment.NewLine;
            dbContext.ChangeTracker.DetectChanges();
            textBoxConsole.Text += dbContext.ChangeTracker.DebugView.LongView;
        }



        private void dataGridViewCities_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                DialogResult dr = MessageBox.Show("Supprimer les lignes?","Info",MessageBoxButtons.YesNo);
                if (dr == DialogResult.No)
                    return;
                for (int i = dataGridViewCities.SelectedRows.Count-1; i >= 0 ; i--)
                {
                    RetirerCity((City)dataGridViewCities.SelectedRows[i].DataBoundItem);
                }
            } else if (e.KeyChar == '\n')
            {
               
            }
            
        }

        private void dataGridViewCities_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridView s = sender as DataGridView;
            if (s.SelectedCells[0].ColumnIndex == 0 || s.SelectedCells.Count > 1)
            {
                e.Cancel = true;
            }
        }

        private void buttonRetirerCountry_Click(object sender, EventArgs e)
        {
            string countryCode = "FR";
            Country? c = dbContext.Countries.Find(countryCode);
            if (c != null)
            {
                
                foreach(City ct in dbContext.Cities.Where(x => x.CountryCode == countryCode).ToList())
                {
                    dbContext.Cities.Remove(ct);
                }
                dbContext.Countries.Remove(c);
                dbContext.SaveChanges();

            }
            
        }
    }
}