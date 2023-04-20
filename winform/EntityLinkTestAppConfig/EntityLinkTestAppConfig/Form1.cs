using EntityLinkTestAppConfig.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityLinkTestAppConfig
{
    public partial class Form1 : Form
    {
        public CitiesContext db;
        public Form1()
        {
            InitializeComponent();
            db = new CitiesContext();
            db.Cities.Load();
            dataGridView1.DataSource = db.Cities.Local.ToBindingList();
        }
    }
}