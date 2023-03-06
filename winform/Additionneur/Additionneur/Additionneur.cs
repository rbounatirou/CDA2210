using AdditionneurBibli;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Additionneur
{
    public partial class Additionneur : Form
    {
        OperationHistory resultat;
        public Additionneur()
        {
            InitializeComponent();
            resultat = new OperationHistory();
        }

        

        private void btVal_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            resultat.AddNumberInCurrentOperation(int.Parse(button.Text));
            button.BackColor = Color.FromArgb(0, 0, 60 + int.Parse(button.Text)*((255 - 60) / 10));
            button.ForeColor = Color.FromArgb(255, 255, 0);

            /*switch (int.Parse(button.Text) % 5)
            {
                case 0:
                    button.BackColor = Color.Red;
                    break;
                case 1:
                    button.BackColor = Color.Orange;
                    break;
                case 2:
                    button.BackColor = Color.Yellow;
                    break;
                case 3:
                    button.BackColor = Color.DarkGreen;
                    break;
                case 4:
                    button.BackColor = Color.Blue;
                    break;
            }*/
            UpdateResultTextbox();
        }

        private void btVider_Click(object sender, EventArgs e)
        {
            resultat.Clear();
            UpdateResultTextbox();
        }

        private void btCalculer_Click(object sender, EventArgs e)
        {
            resultat.AddNewAddition();
            UpdateResultTextbox();
          
        }

        private void UpdateResultTextbox()
        {
            textResult.Text = resultat.GetResults();
        }

    }
}
