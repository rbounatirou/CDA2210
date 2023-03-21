using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonEssai
{
    public partial class AUserControl: UserControl
    {
        private string alltext;
        public AUserControl()
        {
            InitializeComponent();
        }

        [Category("Design"), Browsable(true), Description("Le titre que vous voulez afficher")]
        public string AllButtonText
        {
            get => alltext;
            set
            {
                alltext = value;
                button1.Text = button2.Text = alltext;
            }
        }
    }
}
