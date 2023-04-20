using Domain;
using IHMDP.utils;

namespace IHMDP
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
           

        }

        private void OuvrirCompteManagerAjout(object sender, EventArgs e) => OuvrirCompteManager(EnumTypeRequete.INSERT);

        private void OuvrirCompteManagerModifier(object sender, EventArgs e) => OuvrirCompteManager(EnumTypeRequete.UPDATE);

        private void OuvrirCompteManagerSupprimer(object sender, EventArgs e) => OuvrirCompteManager(EnumTypeRequete.DELETE);

        private void OuvrirCompteManagerSelectionner(object sender, EventArgs e) => OuvrirCompteManager(EnumTypeRequete.SELECT);

        private void OuvrirCompteManager(EnumTypeRequete type)
        {
            CompteManager cm = new CompteManager(type);
            cm.MdiParent = this;
            cm.Show();

        }
    }
}