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
    public partial class FormSaisie : Form
    {
        private string? saisieUtilisateur;

        
        public string? SaisieUtilisateur { get => saisieUtilisateur;  }

        public FormSaisie()
        {
            InitializeComponent();
            saisieUtilisateur = null;

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            saisieUtilisateur = textBoxSaisie.Text;
            this.Close();
        }
    }
}
