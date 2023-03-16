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

        #region attribut_nbFenetre
        private int nbFen_FormComboCheck;
        private int nbFen_FormLisProp;
        private int nbFen_FormListCombo;
        private int nbFen_FormDefilement;
        private int nbFen_FormEmprunt;
        private int nbFen_FormAdditionneur;
        private int nbFen_FormVerificationSaisie;

        #endregion
        public FormFormulaires()
        {

            InitializeComponent();
            toolStripSplitButtonPhase3.DropDown = phase3ToolStripMenuItem.DropDown;
            loginActuel = null;
            fenetresOuvertes = new();
            AskForAuthentification();
            toolStripLabelBottomDate.Text = DateTime.Now.ToShortDateString();
            
        }

        public void ResetCount()
        {
            nbFen_FormComboCheck = 0;
            nbFen_FormLisProp = 0;
            nbFen_FormListCombo = 0;
            nbFen_FormDefilement = 0;
            nbFen_FormEmprunt = 0;
            nbFen_FormAdditionneur = 0;
            nbFen_FormVerificationSaisie=0;
        }



        #region Authentification

        
        private void OpenAuthentificationForm(object sender, EventArgs e) => AskForAuthentification();



        private void OnLogin(object sender, FormClosingEventArgs e)
        {
            
            FormAuthentification fa = sender as FormAuthentification;
            if (fa.Login != null && loginActuel == null)
            {
                this.loginActuel = fa.Login;
                this.Show();
                EnableAllConnectionNeededComponent();
                toolStripLabelBottomAuthentification.Text = "Connexion en tant que " + loginActuel.Username;

            }
            toolStripLabelBottomAuthentification.Text = "Echec authentification" ;
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
            toolStripLabelBottomAuthentification.Text = "S'identifier";
            loginActuel = null;
            DisableAllConnectionNeededComponent();
        }
        #endregion

        private void OnClose(object sender, FormClosedEventArgs e)
        {
            Form fclose = sender as Form;
            fenetresOuvertes.Remove(fclose);
            toolStripLabelBottomAuthentification.Text = "Fermeture de la fenetre: " + fclose.Text;
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region CreationFenetre
        #region fenetreGeneres
        private void CreateFormSaisie()
        {
            FormSaisie f = new FormSaisie();
            InitForm(f);
            f.FormClosing += new FormClosingEventHandler(this.OnCloseSaisieMenu);

        }

        private void AskForAuthentification()
        {

            if (loginActuel != null)
            {
                DialogResult dr = MessageBox.Show("Pour vous connecter il faut vous deconnecter au préalable, voulez vous vous déconnecter?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Disconnect();
                }
            }
            if (loginActuel == null)
            {
                for (int i = fenetresOuvertes.Count() - 1; i >= 0; i--)
                {
                    fenetresOuvertes[i].Close();
                }
                fenetresOuvertes.Clear();

                FormAuthentification authentification = new FormAuthentification();
                authentification.FormClosing += new FormClosingEventHandler(this.OnLogin);
                authentification.FormClosed += new FormClosedEventHandler(this.OnClose);
                fenetresOuvertes.Add(authentification);
                this.Hide();
                authentification.ShowDialog();

            }
        }
        #endregion
        //Toolstrip
        private void additionneurToolStripMenuItem_Click(object sender, EventArgs e) => InitForm(new FormAdditionneur(), ref nbFen_FormAdditionneur);

        private void verificationSaisieToolStripMenuItem_Click(object sender, EventArgs e) => InitForm(new FormValidationSaisie(),  ref nbFen_FormVerificationSaisie);
        #region phase3toolstrip
        private void comboEtCheckboxToolStripMenuItem_Click(object sender, EventArgs e) => CreateFormSaisie();

        private void listeEtPropToolStripMenuItem_Click(object sender, EventArgs e) => InitForm(new FormListProp(),  ref nbFen_FormLisProp);

        private void listeEtComboToolStripMenuItem_Click(object sender, EventArgs e) => InitForm(new FormListCombo(),  ref nbFen_FormListCombo);

        private void defilementToolStripMenuItem_Click(object sender, EventArgs e) => InitForm(new FormCoposantDefilement(),  ref nbFen_FormDefilement);


        private void empruntToolStripMenuItem_Click(object sender, EventArgs e) => InitForm(new FormEmprunt(),  ref nbFen_FormEmprunt);

        #endregion
        #endregion

        #region initialisationFenetre
        private void InitForm<T>(T myform, ref int n) where T : Form
        {
            n++;
            myform.FormClosed += new FormClosedEventHandler(this.OnClose);
            myform.Text += " n°" + n;
            toolStripLabelBottomAuthentification.Text = "Ouverture de la fenetre " + myform.Text;
            fenetresOuvertes.Add(myform);
            myform.MdiParent = this;
            myform.Show();
        }



        private void InitForm<T>(T myform) where T : Form
        {
            myform.FormClosed += new FormClosedEventHandler(this.OnClose);            
            fenetresOuvertes.Add(myform);
            toolStripLabelBottomAuthentification.Text = "Ouverture de la fenetre " + myform.Text;
            myform.MdiParent = this;
            myform.Show();
        }

        #endregion


        private void OnCloseSaisieMenu(object sender, FormClosingEventArgs e)
        {
            FormSaisie fa = sender as FormSaisie;
            InitForm(new FormCheckBoxRadio(fa.SaisieUtilisateur != null ? fa.SaisieUtilisateur : ""), ref nbFen_FormComboCheck);
        }
        private void FormFormulaires_FormClosing(object sender, FormClosingEventArgs e)
        {
            toolStripLabelBottomAuthentification.Text = "Quitter";
            if (MessageBox.Show("Etes-vous sur de vouloir quitter l'application?", "Confirmation de commande", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void DisplaySelect_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tm = sender as ToolStripMenuItem;
            switch (tm.Text)
            {
                case "Cascade":
                    this.LayoutMdi(MdiLayout.Cascade);
                    break;
                case "Horizontal":
                    this.LayoutMdi(MdiLayout.TileHorizontal);
                    break;
                case "Vertical":
                    this.LayoutMdi(MdiLayout.TileVertical);
                    break;
            }
            toolStripLabelBottomAuthentification.Text = "Changement affichage : " + tm.Text;
        }
    }
}
