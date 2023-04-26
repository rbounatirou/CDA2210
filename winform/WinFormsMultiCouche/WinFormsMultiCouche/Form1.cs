using Microsoft.EntityFrameworkCore;
using WinFormsMultiCouche.Models;
using WinFormsMultiCouche.src;

namespace WinFormsMultiCouche
{
    public partial class Form1 : Form
    {

        private DbJeuContext dbJeu;
        public Form1()
        {
            InitializeComponent();
            dbJeu = new DbJeuContext();
            dbJeu.Comptes.Load();
            dbJeu.Races.Load();
            dbJeu.Personnages.Load();
        }

        private void compteToolStripMenuItem_Click(object sender, EventArgs e) => OuvrirFenetreCompte(EnumTypeRequete.INSERT);

        private void OuvrirFenetreCompte(EnumTypeRequete e)
        {
            CompteManager compte = new CompteManager(e);
            compte.MdiParent = this;
            compte.Show();
        }

        private void raceToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void compteToolStripMenuItem1_Click(object sender, EventArgs e) => OuvrirFenetreCompte(EnumTypeRequete.UPDATE);

        private void compteToolStripMenuItem2_Click(object sender, EventArgs e) => OuvrirFenetreCompte(EnumTypeRequete.DELETE);

        private void compteToolStripMenuItem3_Click(object sender, EventArgs e) => OuvrirFenetreCompte(EnumTypeRequete.SELECT);

    }
}