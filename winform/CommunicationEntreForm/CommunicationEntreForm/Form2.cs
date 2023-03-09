using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommunicationEntreForm
{
    public partial class Form2 : Form
    {
        private TextBox tx;
        public Form2(TextBox text)
        {
            InitializeComponent();
            tx = text;
            lblText.Text = text.Text;
        }

        private void buttonClicked(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            tx.Text = (bt == null ? "NULL" : bt.Text);
            this.Close();
        }
    }
}
