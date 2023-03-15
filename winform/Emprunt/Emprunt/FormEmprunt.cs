using Emprunts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationSaisieBibli;

namespace CreerFormulaires
{
    public partial class FormEmprunt : Form
    {

        private Emprunt emprunt;

        public static int DUREE_MAXALE_EMPRUNT_MOIS_IHM = 25 * 12;

        public FormEmprunt()
        {
            emprunt = new Emprunt(0, 0.07f, 1, EnumTypeRemboursement.MENSUEL);
            InitializeComponent();
            List<EnumTypeRemboursement> typeremboursements = Enum.GetValues(typeof(EnumTypeRemboursement)).Cast<EnumTypeRemboursement>().ToList();
            foreach (EnumTypeRemboursement t in typeremboursements)
            {
                listBoxTypeMensualite.Items.Add(t);
            }
            listBoxTypeMensualite.SelectedIndex = 0;
            
            hsNombreMois.Maximum = DUREE_MAXALE_EMPRUNT_MOIS_IHM;

        }

        private void ListMensualite_SelectIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTypeMensualite.SelectedIndex >= 0) { 
                int val = (int)listBoxTypeMensualite.SelectedItem;
                if (hsNombreMois.Value < val)
                {
                    hsNombreMois.Value = val;
                }
                hsNombreMois.Minimum = val;
                hsNombreMois.SmallChange = val;
                hsNombreMois.LargeChange = val;

                int nouvelleValeur = RedefinirNombreDeMoisTotalDeLEmprunt(val);
               
                emprunt.SetMensualite(nouvelleValeur,
                    (EnumTypeRemboursement)Enum.ToObject(typeof(EnumTypeRemboursement), val));
                hsNombreMois.Value = nouvelleValeur;
                UpdateInfo();
                
            }
            
            
        }

        private int RedefinirNombreDeMoisTotalDeLEmprunt(int val)
        {
            if (hsNombreMois.Value % val != 0)
            {
                int div = hsNombreMois.Value / val;
                if ((div + 1) * val < hsNombreMois.Maximum)
                {
                    return ((div + 1) * val);
                }
                else
                {
                    return div * val;
                }
            }
            return hsNombreMois.Value;
        }

        private void UpdateInfo()
        {
            labelNombreMois.Text = Convert.ToString(hsNombreMois.Value);
            labelNombreRemboursement.Text = emprunt.CalculerNombreRemboursement().ToString();
            labelPrixRemboursement.Text = Math.Round(emprunt.CalculerMontantTotalRemboursement(),2).ToString();
        }



        private void HS_ValueChanged(object sender, EventArgs e)
        {
            //emprunt.DureeRemboursementEnMois = hsNombreMois.Value;
            if (hsNombreMois.Value % (int)emprunt.TypeRemboursement != 0)
            {
                hsNombreMois.Value = Math.Max(hsNombreMois.Value / (int)emprunt.TypeRemboursement, 1) * (int)emprunt.TypeRemboursement;
            }
            emprunt.DureeRemboursementEnMois = hsNombreMois.Value;
            UpdateInfo();
        }

        private void RadioRate_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            double taux = Convert.ToDouble((string)rb.Tag);
            emprunt.TauxInteretAnnuel = taux;
            UpdateInfo();
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;            
            emprunt.Nom = tb.Text;
        }

        private void textBoxCapital_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (VerificationSaisie.MatchForIntegerPrice(tb.Text, 10))
            {
                emprunt.CapitalEmprunte = Convert.ToDouble(tb.Text);
                UpdateInfo();
            }
            tb.BackColor = (VerificationSaisie.MatchForIntegerPrice(tb.Text, 10) ? Color.White :  Color.Red);



        }


    }
}
