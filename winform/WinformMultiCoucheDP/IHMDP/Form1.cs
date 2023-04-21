using Domain;
using IHMDP.utils;
using InterfaceDP;

namespace IHMDP
{
    public partial class Form1 : Form
    {
        private ICrudCompte crudCompteConfig;
        public Form1()
        {
            InitializeComponent();
           

        }

        public Form1(ICrudCompte configCompte)
        {
            InitializeComponent();
            crudCompteConfig = configCompte;

        }

        private void OuvrirCompteManagerAjout(object sender, EventArgs e) => OuvrirCompteManager(EnumTypeRequete.INSERT);

        private void OuvrirCompteManagerModifier(object sender, EventArgs e) => OuvrirCompteManager(EnumTypeRequete.UPDATE);

        private void OuvrirCompteManagerSupprimer(object sender, EventArgs e) => OuvrirCompteManager(EnumTypeRequete.DELETE);

        private void OuvrirCompteManagerSelectionner(object sender, EventArgs e) => OuvrirCompteManager(EnumTypeRequete.SELECT);

        private void OuvrirCompteManager(EnumTypeRequete type)
        {
            CompteManager cm = new CompteManager(type, crudCompteConfig);
            cm.MdiParent = this;
            cm.Show();

        }
    }
}