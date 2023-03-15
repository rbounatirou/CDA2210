using LoginBibli;
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
    public partial class FormAuthentification : Form
    {

        private Login login;

        public Login Login { get => login; }
        public FormAuthentification()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            login = Login.TryConnect(textBoxLogin.Text, textBoxPassword.Text);
            if (login != null)
            {               
                this.Close();
            }
            else
                MessageBox.Show("Erreur connection", "Erreur connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

            
    }
}
