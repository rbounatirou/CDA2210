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

namespace UserControlProduction
{
    public partial class UserControlProgressionInformation : UserControl
    {

        private Production? linkedProduction;

        public Production LinkedProduction
        {
            get => linkedProduction;
            set
            {
                linkedProduction = value;
                if (linkedProduction != null)
                {
                    linkedProduction.ProductionActuelleQuantityChanged += new Production.Event_OnProductionQuantityChanged(this.QuantityChanged);
                }
                UpdateIHM();
            }
        }
        public UserControlProgressionInformation()
        {
            InitializeComponent();
        }

        private void OnResize(object sender, EventArgs e)
        {

            foreach (Control c in this.Controls)
            {

                c.Size = new Size(c.Width, this.Height / (this.Controls.Count));
            }
        }

        private void OnPanelResize(object sender, EventArgs e)
        {
            Panel s = sender as Panel;
            int value = (int)Math.Floor(s.Height / 4.0d);
            s.Padding = new Padding(value, value, value, value);
            return;

        }

        private void UpdateIHM()
        {
            if (linkedProduction != null)
            {
                textBoxNbCaisse.Text = linkedProduction.NbProductionActuelleViable.ToString();
                textBoxTauxDefautHeure.Text = Math.Round(
                    (double)linkedProduction.NbProductionActuelleNonViableDerniereHeure /
                    Math.Max(1, (linkedProduction.NbProductionActuelleNonViableDerniereHeure + linkedProduction.NbProductionActuelleViableDerniereHeure)), 4).ToString();
                textBoxTauxDefautDemarrage.Text = Math.Round(
                    (double)linkedProduction.NbProductionActuelleNonViable /
                    Math.Max(1, (linkedProduction.NbProductionActuelleNonViable + linkedProduction.NbProductionActuelleViable)), 4).ToString();

            }
            else
            {
                textBoxNbCaisse.Text = textBoxTauxDefautDemarrage.Text = textBoxTauxDefautHeure.Text = "";
            }
        }

        private void QuantityChanged(Production p)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(() => UpdateIHM());
            }
            else
            {
                UpdateIHM();
            }
        }

    }
}
