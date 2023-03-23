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
    public partial class UserControlProductionProgressBar : UserControl
    {

        private Production? linkedProduction;

        public Production? LinkedProduction
        {
            get => linkedProduction;
            set
            {
                linkedProduction = value;
                ChangeTextButtons();
                if (linkedProduction != null)
                    linkedProduction.ProductionActuelleQuantityChanged += new Production.Event_OnProductionQuantityChanged(this.QuantityChanged);
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
            labelText.Text = "Production " + text;
        }
        public UserControlProductionProgressBar()
        {
            InitializeComponent();
            ReloadMargin();
        }


        private void OnResize(object sender, EventArgs e) => ReloadMargin();

        private void ReloadMargin()
        {
            int H = labelText.Size.Height;
            labelText.Padding = labelText.Padding = new Padding(this.Padding.Left,
                (int)((double)(this.Height - H) / 2), this.Padding.Right, this.Padding.Bottom);
        }

        private void QuantityChanged(Production p)
        {
            if (this.InvokeRequired)
                this.Invoke(() => ReloadIHM());
            else
                ReloadIHM();
        }

        private void ReloadIHM()
        {
            if (linkedProduction == null)
            {
                progressBarProduction.Value = 0;
                return;
            }
            progressBarProduction.Value = (int)((double)linkedProduction.NbProductionActuelleViable / linkedProduction.ProductionDemande * 100);
        }
    }
}
