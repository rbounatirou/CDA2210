using LoginBibli;
using Microsoft.VisualBasic.Logging;
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
    public partial class FormFormulaires : Form
    {
        private Login? loginActuel;
        private List<Form> fenetresOuvertes;
        public FormFormulaires()
        {
            InitializeComponent();
            toolStripSplitButtonPhase3.DropDown = phase3ToolStripMenuItem.DropDown;
            loginActuel = null;
            fenetresOuvertes = new();
        }



        #region Authentification
        private void OpenAuthentificationForm(object sender, EventArgs e)
        {
            if (loginActuel != null)
            {
                DialogResult dr = MessageBox.Show("Pour vous connecter il faut vous deconnecter au préalable, voulez vous vous déconnecter?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr==DialogResult.Yes)
                {
                    Disconnect();
                }
            } 
            if (loginActuel == null) { 
                FormAuthentification authentification = new FormAuthentification();
                authentification.FormClosing += new FormClosingEventHandler(this.OnLogin);
                authentification.FormClosed += new FormClosedEventHandler(this.OnClose);
                fenetresOuvertes.Add(authentification);
                authentification.Show();
            }                        
        }

        
        private void OnLogin(object sender, FormClosingEventArgs e)
        {
            FormAuthentification fa = sender as FormAuthentification;
            if (fa.Login != null && loginActuel == null)
            {
                this.loginActuel = fa.Login;
                EnableAllConnectionNeededComponent();
            }
        }



        private void DisableAllConnectionNeededComponent() => SetNeedConnectComponentEnableState(false);

        private void EnableAllConnectionNeededComponent() => SetNeedConnectComponentEnableState(true);

        private void SetNeedConnectComponentEnableState(bool state)
        {
            phase1ToolStripMenuItem.Enabled = state;
            phase2ToolStripMenuItem.Enabled = state;
            phase3ToolStripMenuItem.Enabled = state;
            fenêtresToolStripMenuItem.Enabled = state;
            toolStripSplitButtonPhase3.Enabled = state;
        }

        private void Disconnect()
        {
            loginActuel = null;
            DisableAllConnectionNeededComponent();
        }


        #endregion

        private void OnClose(object sender, FormClosedEventArgs e)
        {
            Form fclose = sender as Form;
            fenetresOuvertes.Remove(fclose);
        }
    }
}
