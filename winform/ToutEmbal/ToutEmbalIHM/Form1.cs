using ProductionLibrary;
using System.Drawing.Text;
using UserControlProduction;

namespace ToutEmbalIHM
{
    public partial class Form1 : Form
    {

        private Production[] sesProduction;
        public Form1()
        {
            sesProduction = new Production[3];
            sesProduction[0] = new Production(EnumVitesseProduction.CAISSE_A);
            sesProduction[1] = new Production(EnumVitesseProduction.CAISSE_B);
            sesProduction[2] = new Production(EnumVitesseProduction.CAISSE_C);


            InitializeComponent();

            GenerateProductionElements(sesProduction[0]);
            GenerateProductionElements(sesProduction[1]);
            GenerateProductionElements(sesProduction[2]);
            
        }

        private void GenerateProductionElements(Production p)
        {
            GenererOngletProduction(p);
            GenererToolbarProduction(p);
            GenererInterractButton(p);
            AjouterItemDemarrer(p);
            AjouterItemArret(p);
            AjouterItemStop(p);
            p.ProductionStateChanged += new Production.Event_OnProductionStateChanged(this.StateChanged);
        }

        private void AjouterItemDemarrer(Production p)
        {
            ToolStripItem added = demarrer_menu.DropDownItems.Add(StringForProduction(p));
            added.Tag = p;
        }

        private void AjouterItemStop(Production p)
        {
            ToolStripItem added = arreter_menu.DropDownItems.Add(StringForProduction(p));
            added.Tag = p;
        }

        private void AjouterItemArret(Production p)
        {
            ToolStripItem added = continuer_menu.DropDownItems.Add(StringForProduction(p));
            added.Tag = p;
        }


        private string StringForProduction(Production p)
        {
            string text = "";
            if (p != null)
            {
                switch (p.VitesseProduction)
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
            return text;
        }

        private void GenererComposantMenu(Production p)
        {

        }
        private void GenererOngletProduction(Production p)
        {
            /*if(tabControlInformation.TabPages.Count> 0)
                tabControlInformation.TabPages.Insert(tabControlInformation.TabPages.Count-1,"Production " + StringForProduction(p));
            else*/
            tabControlInformation.TabPages.Add("Production " + StringForProduction(p));
            UserControlProgressionInformation InfoProgression = new UserControlProgressionInformation();
            InfoProgression.LinkedProduction = p;
            InfoProgression.Scale(new SizeF(0.8f, 1.1f));
            tabControlInformation.TabPages[tabControlInformation.TabPages.Count - 1].Controls.Add(InfoProgression);
        }

        private void GenererToolbarProduction(Production p)
        {
            UserControlProductionProgressBar progressBar = new UserControlProductionProgressBar();
            progressBar.LinkedProduction = p;
            progressBar.Size = new Size(panelProgressBar.Size.Width - 10, (panelProgressBar.Height - (panelProgressBar.Padding.All * 2)) / 3);
            panelProgressBar.Controls.Add(progressBar);
            progressBar.Dock = DockStyle.Top;

            progressBar.BringToFront();
        }

        private void GenererInterractButton(Production p)
        {
            UserControlProductionInteraction interraction = new UserControlProductionInteraction();
            interraction.Size = new Size(panelInterraction.Size.Width / 5, panelInterraction.Size.Height - 10);
            interraction.LinkedProduction = p;
            panelInterraction.Controls.Add(interraction);
            interraction.Dock = DockStyle.Left;
            interraction.BringToFront();
        }

        private void StateChanged(Production p)
        {
            if (this.InvokeRequired)
            {
                //this.Invoke(() => ChangeState(p.VitesseProduction));
            }
            else
            {
                //ChangeState(p.VitesseProduction);
            }
        }
        /*private void ChangeState(EnumVitesseProduction p)
        {
            if (p == EnumVitesseProduction.CAISSE_A)
                ChangeStateA();
            else if (p == EnumVitesseProduction.CAISSE_B)
                ChangeStateB();
            else if (p == EnumVitesseProduction.CAISSE_C)
                ChangeStateC();
        }
        private void ChangeStateA()
        {
            EnumEtatProduction et = sesProduction[0].EtatProduction;
            demarrer_ItemA.Enabled = et == EnumEtatProduction.NON_DEMARRE;
            arreter_ItemA.Enabled = et == EnumEtatProduction.EN_COURS;
            continuer_ItemA.Enabled = et == EnumEtatProduction.EN_PAUSE;

        }

        private void ChangeStateB()
        {
            EnumEtatProduction et = sesProduction[1].EtatProduction;
            demarrer_ItemB.Enabled = et == EnumEtatProduction.NON_DEMARRE;
            arreter_ItemB.Enabled = et == EnumEtatProduction.EN_COURS;
            continuer_ItemB.Enabled = et == EnumEtatProduction.EN_PAUSE;
        }

        private void ChangeStateC()
        {
            EnumEtatProduction et = sesProduction[2].EtatProduction;
            demarrer_ItemC.Enabled = et == EnumEtatProduction.NON_DEMARRE;
            arreter_ItemC.Enabled = et == EnumEtatProduction.EN_COURS;
            continuer_ItemC.Enabled = et == EnumEtatProduction.EN_PAUSE;
        }*/

        #region toolitem
        private void demarrer_ItemA_Click(object sender, EventArgs e) => sesProduction[0].Demarrer();

        private void demarrer_ItemB_Click(object sender, EventArgs e) => sesProduction[1].Demarrer();

        private void demarrer_ItemC_Click(object sender, EventArgs e) => sesProduction[2].Demarrer();

        private void arreter_ItemA_Click(object sender, EventArgs e) => sesProduction[0].Arreter();

        private void arreter_ItemB_Click(object sender, EventArgs e) => sesProduction[1].Arreter();

        private void arreter_ItemC_Click(object sender, EventArgs e) => sesProduction[2].Arreter();

        private void continuer_ItemA_Click(object sender, EventArgs e) => sesProduction[0].Continuer();

        private void continuer_ItemB_Click(object sender, EventArgs e) => sesProduction[1].Continuer();

        private void continuer_ItemC_Click(object sender, EventArgs e) => sesProduction[2].Continuer();
        #endregion

        private void DemarrerProductionAssocieToolItem(object sender, EventArgs e)
        {
            ToolStripItem tsi = sender as ToolStripItem;
            Production p = tsi.Tag as Production;
            if (p != null)
            {
                p.Demarrer();
            }
        }

        private void ContinuerProductionAssocieToolItem(object sender, EventArgs e)
        {
            ToolStripItem tsi = sender as ToolStripItem;
            Production p = tsi.Tag as Production;
            if (p != null)
            {
                p.Continuer();
            }
        }

        private void ArreterProductionAssocieToolItem(object sender, EventArgs e)
        {
            ToolStripItem tsi = sender as ToolStripItem;
            Production p = tsi.Tag as Production;
            if (p != null)
            {
                p.Arreter();
            }
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajouter_ItemAClick(object sender, EventArgs e) => GenerateProductionElements(new Production(EnumVitesseProduction.CAISSE_A));
        private void ajouter_ItemBClick(object sender, EventArgs e) => GenerateProductionElements(new Production(EnumVitesseProduction.CAISSE_B));
        private void ajouter_ItemCClick(object sender, EventArgs e) => GenerateProductionElements(new Production(EnumVitesseProduction.CAISSE_C));
    }
}