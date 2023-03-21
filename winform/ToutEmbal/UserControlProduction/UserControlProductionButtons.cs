using ProductionLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlProduction
{

    
    public partial class UserControlProductionButtons : UserControl
    {
        private Production linkedProduction;

        public Production LinkedProduction { get; set; }
        public UserControlProductionButtons(Production _linkedProduction)
        {
            InitializeComponent();
            this.linkedProduction = _linkedProduction;
            this.linkedProduction.ProductionStateChanged += new Production.Event_OnProductionStateChanged(this.StateChanged);
            ReloadButtons();
        }

        public void StateChanged(Production p) => ReloadButtons();

        public void ReloadButtons()
        {
            btStart.Enabled = linkedProduction.EtatProduction == EnumEtatProduction.NON_DEMARRE;
            btRestart.Enabled = linkedProduction.EtatProduction == EnumEtatProduction.EN_PAUSE;
            btStop.Enabled = linkedProduction.EtatProduction == EnumEtatProduction.EN_COURS;
        }


        public void btStart_Click(object sender, EventArgs e) => linkedProduction.Demarrer();
        public void btRestart_Click(object sender, EventArgs e) => linkedProduction.Continuer();
        public void btStop_Click(object sender, EventArgs e) => linkedProduction.Arreter();

    }
}
