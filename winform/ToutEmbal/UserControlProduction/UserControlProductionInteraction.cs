using ProductionLibrary;

namespace UserControlProduction
{
    public partial class UserControlProductionInteraction : UserControl
    {

        private Production? linkedProduction;

        public Production? LinkedProduction
        {
            get => linkedProduction; set
            {
                linkedProduction = value;
                if (linkedProduction != null)
                {
                    linkedProduction.ProductionStateChanged += new Production.Event_OnProductionStateChanged(this.StateChanged);
                }
                ChangeTextButtons();
                ReloadButtons();
            }
        }

        private void ChangeTextButtons()
        {
            string text = "";
            if (linkedProduction != null)
            {
                switch (linkedProduction.VitesseProduction)
                {
                    case EnumVitesseProduction.CAISSE_A:
                        text = "A";
                        break;
                    case EnumVitesseProduction.CAISSE_B:
                        text = "B";
                        break;
                    case EnumVitesseProduction.CAISSE_C:
                        text = "C";
                        break;
                }
            }
            foreach (Control c in Controls)
            {
                c.Text = text;
            }
        }
        public UserControlProductionInteraction()
        {
            InitializeComponent();
        }

        private void OnResize(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                c.Size = new Size((this.Size.Width - ((this.Margin.Left + this.Margin.Right) + (c.Margin.Right * (Controls.Count - 1)))) / this.Controls.Count,
                    this.Size.Height - (this.Margin.Top + this.Margin.Bottom));
            }
        }

        private void StateChanged(Production p)
        {
            if (this.InvokeRequired)
                this.Invoke(() => ReloadButtons());
            else
                ReloadButtons();
        }

        private void ReloadButtons()
        {
            btStart.Enabled = linkedProduction != null && linkedProduction.EtatProduction == EnumEtatProduction.NON_DEMARRE;
            btRestart.Enabled = linkedProduction != null && linkedProduction.EtatProduction == EnumEtatProduction.EN_PAUSE;
            btStop.Enabled = linkedProduction != null && linkedProduction.EtatProduction == EnumEtatProduction.EN_COURS;
        }


        private void btStart_Click(object sender, EventArgs e) => linkedProduction.Demarrer();
        private void btRestart_Click(object sender, EventArgs e) => linkedProduction.Continuer();
        private void btStop_Click(object sender, EventArgs e) => linkedProduction.Arreter();

    }
}
