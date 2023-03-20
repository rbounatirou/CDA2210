using ProductionLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToutEmbal
{
    public partial class UserControlProductionButtons : UserControl
    {

        private Production linkedProduction;
        public UserControlProductionButtons(Production _link)
        {
            InitializeComponent();
            linkedProduction = _link;
            linkedProduction.ProductionStateChanged += new Production.Event_OnProductionStateChanged(this.StateChanged);
            string textToMade = (linkedProduction.VitesseProduction == EnumVitesseProduction.CAISSE_A ? "A" :
                (linkedProduction.VitesseProduction == EnumVitesseProduction.CAISSE_B ? "B" : "C"));
            ReloadButtons();
        }

        private void StateChanged(Production p) => ReloadButtons();

        private void ReloadButtons()
        {
            btStart.Enabled = linkedProduction.EtatProduction == EnumEtatProduction.NON_DEMARRE;
            btStop.Enabled = linkedProduction.EtatProduction == EnumEtatProduction.EN_COURS;
            btReload.Enabled = linkedProduction.EtatProduction == EnumEtatProduction.EN_PAUSE;
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            linkedProduction.Demarrer();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            linkedProduction.Arreter();
        }

        private void btReload_Click(object sender, EventArgs e)
        {
            linkedProduction.Continuer();
        }
    }
}
