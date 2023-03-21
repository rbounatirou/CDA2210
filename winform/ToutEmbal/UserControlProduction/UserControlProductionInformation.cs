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
    public partial class UserControlProductionInformation : UserControl
    {

        private Production linkedProduction;
        public UserControlProductionInformation(Production _linkedProduction)
        {
            InitializeComponent();
            linkedProduction = _linkedProduction;
            linkedProduction.ProductionActuelleChanged += new Production.Event_OnProductionChanged(this.ProductionChanged);
        }

        public void ProductionChanged(Production p)
        {

        }



    }
}
