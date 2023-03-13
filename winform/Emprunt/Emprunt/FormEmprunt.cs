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

namespace EmpruntForm
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

            emprunt = null;


        }

        private void ListMensualite_SelectIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTypeMensualite.SelectedIndex >= 0) { 
                int val = (int)listBoxTypeMensualite.SelectedItem;

                
                hsNombreMois.LargeChange = val;
                //emprunt.TypeRemboursement = (EnumTypeRemboursement)Enum.ToObject(typeof(EnumTypeRemboursement), val);
                RedefinirNombreDeMoisTotalDeLEmprunt();
                emprunt.SetMensualite(hsNombreMois.Value,
                    (EnumTypeRemboursement)Enum.ToObject(typeof(EnumTypeRemboursement), val));
                UpdateInfo();
                
            }
            
            
        }

        private void RedefinirNombreDeMoisTotalDeLEmprunt()
        {
            if (hsNombreMois.Value % hsNombreMois.LargeChange != 0)
            {
                int div = Math.Max(hsNombreMois.Value / hsNombreMois.LargeChange, 1);
                if ((div + 1) * hsNombreMois.LargeChange < hsNombreMois.Maximum)
                {
                    hsNombreMois.Value = (div + 1) * hsNombreMois.LargeChange;
                }
                else
                {
                    hsNombreMois.Value = div * hsNombreMois.LargeChange;
                }
            }
        }

        private void UpdateInfo()
        {
            /*if (hsNombreMois.Value % hsNombreMois.LargeChange != 0)
            {
                int div = Math.Max(hsNombreMois.Value / hsNombreMois.LargeChange,1);
                if ((div + 1) * hsNombreMois.LargeChange < hsNombreMois.Maximum) {
                    hsNombreMois.Value = (div + 1) * hsNombreMois.LargeChange;
                } else
                {
                    hsNombreMois.Value = div * hsNombreMois.LargeChange;
                }
            }*/
      
            /*emprunt = new Emprunt()
            labelNombreMois.Text = Convert.ToString(hsNombreMois.Value);
            labelNombreRemboursement.Text = emprunt.CalculerNombreRemboursement().ToString();
            labelPrixRemboursement.Text = emprunt.CalculerMontantTotalRemboursement().ToString();*/
        }



        private void HS_ValueChanged(object sender, EventArgs e)
        {
            //emprunt.DureeRemboursementEnMois = hsNombreMois.Value;
            UpdateInfo();
        }

        private void RadioRate_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            double taux = (double)rb.Tag;
            emprunt.TauxInteretAnnuel = taux;
        }
    }
}
