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

namespace CreerFormulaires
{
    public partial class FormAdditionneur : Form
    {
        OperationHistory resultat;
        public FormAdditionneur()
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
            Afficher();
        }

        /*private void Afficher()
        {
            Addition[] addition = resultat.Additions;
            //addition[0].AjouterNombre(2);
            textResult.Text = "";
            for (int i = 0; i< addition.Length; i++)
            {
                textResult.Text += (i > 0 ? Environment.NewLine : "") +
                    AdditionToString(addition[i]) +
                    (i < (addition.Length - 1) ? ("=" + addition[i].GetResult()) : "");
            }
        }*/

        private void Afficher()
        {
            textResult.Text = resultat.ToString();
        }

        private void btVider_Click(object sender, EventArgs e)
        {
            resultat.Clear();
            Afficher();
        }

        private void btCalculer_Click(object sender, EventArgs e)
        {
            resultat.AddNewAddition();
            Afficher();
          
        }


    }
}
