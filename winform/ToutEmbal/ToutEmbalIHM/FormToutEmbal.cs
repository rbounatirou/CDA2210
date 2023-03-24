using ProductionLibrary;
using System.Drawing.Text;
using UserControlProduction;

namespace ToutEmbalIHM
{
    public partial class FormToutEmbal : Form
    {

        private Production[] sesProduction;
        Dictionary<EnumVitesseProduction, int> nbProduction;
        public FormToutEmbal()
        {
            InitializeComponent();
            nbProduction = new Dictionary<EnumVitesseProduction, int>();
            List<EnumVitesseProduction> vitessesPossibles = Enum.GetValues(typeof(EnumVitesseProduction)).Cast<EnumVitesseProduction>().ToList();
            foreach (EnumVitesseProduction v in vitessesPossibles)
            {
                nbProduction.Add(v, 0);
            }
            GenerateProductionElements(new Production(EnumVitesseProduction.CAISSE_A));
            GenerateProductionElements(new Production(EnumVitesseProduction.CAISSE_B));
            GenerateProductionElements(new Production(EnumVitesseProduction.CAISSE_C));

        }

        private void GenerateProductionElements(Production p)
        {
            nbProduction[p.VitesseProduction]++;
            GenererOngletProduction(p);
            GenererToolbarProduction(p);
            GenererInterractButton(p);
            AjouterItemDemarrer(p);
            AjouterItemContinuer(p);
            AjouterItemStop(p);
        }

        private void AjouterItemDemarrer(Production p)
        {
            int prodNb = nbProduction[p.VitesseProduction];
            ToolStripItem added = demarrer_menu.DropDownItems.Add(StringForProduction(p) + (prodNb > 1 ? "(" + prodNb + ")" : ""));
            p.ProductionStateChanged += new Production.Event_OnProductionStateChanged(
                new Action<Production>((p) =>
                {
                    if (!this.InvokeRequired)
                        added.Enabled = p.EtatProduction == EnumEtatProduction.NON_DEMARRE;
                    else
                        this.Invoke(() => added.Enabled = p.EtatProduction == EnumEtatProduction.NON_DEMARRE);
                })
             );
            added.Click += new System.EventHandler((sender, e) =>
            {
                p.Demarrer();
            });
            added.Tag = p;
        }

        private void AjouterItemStop(Production p)
        {
            int prodNb = nbProduction[p.VitesseProduction];
            ToolStripItem added = arreter_menu.DropDownItems.Add(StringForProduction(p) + (prodNb > 1 ? "(" + prodNb + ")" : ""));
            p.ProductionStateChanged += new Production.Event_OnProductionStateChanged(
                new Action<Production>((p) =>
                {
                    if (!this.InvokeRequired)
                        added.Enabled = p.EtatProduction == EnumEtatProduction.EN_COURS;
                    else
                        this.Invoke(() => added.Enabled = p.EtatProduction == EnumEtatProduction.EN_COURS);
                })
             );
            added.Click += new System.EventHandler((sender, e) =>
            {
                p.Arreter();
            });
            added.Tag = p;
        }

        private void AjouterItemContinuer(Production p)
        {
            int prodNb = nbProduction[p.VitesseProduction];
            ToolStripItem added = continuer_menu.DropDownItems.Add(StringForProduction(p) + (prodNb > 1 ? "(" + prodNb + ")" : ""));
            p.ProductionStateChanged += new Production.Event_OnProductionStateChanged(
                new Action<Production>((p) =>
                {
                    if (!this.InvokeRequired)
                        added.Enabled = p.EtatProduction == EnumEtatProduction.EN_PAUSE;
                    else
                        this.Invoke(() => added.Enabled = p.EtatProduction == EnumEtatProduction.EN_PAUSE);
                })
             );
            added.Click += new System.EventHandler((sender, e) =>
            {
                p.Continuer();
            });
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
        private void GenererOngletProduction(Production p)
        {
            /*if(tabControlInformation.TabPages.Count> 0)
                tabControlInformation.TabPages.Insert(tabControlInformation.TabPages.Count-1,"Production " + StringForProduction(p));
            else*/
            int prodNb = nbProduction[p.VitesseProduction];
            tabControlInformation.TabPages.Add("Production " + StringForProduction(p) + (prodNb > 1 ? "(" + prodNb + ")" : ""));
            UserControlProgressionInformation InfoProgression = new UserControlProgressionInformation();
            InfoProgression.LinkedProduction = p;
            InfoProgression.Scale(new SizeF(0.8f, 1.1f));
            tabControlInformation.TabPages[tabControlInformation.TabPages.Count - 1].Controls.Add(InfoProgression);
        }

        private void GenererToolbarProduction(Production p)
        {
            UserControlProductionProgressBar progressBar = new UserControlProductionProgressBar(p, nbProduction[p.VitesseProduction]);
            //progressBar.LinkedProduction = p;
            progressBar.Size = new Size(panelProgressBar.Size.Width - 10, (panelProgressBar.Height - (panelProgressBar.Padding.All * 2)) / 3);
            panelProgressBar.Controls.Add(progressBar);
            progressBar.Dock = DockStyle.Top;

            progressBar.BringToFront();
        }

        private void GenererInterractButton(Production p)
        {
            UserControlProductionInteraction interraction = new UserControlProductionInteraction(p, nbProduction[p.VitesseProduction]);
            interraction.Size = new Size(panelInterraction.Size.Width / 4, panelInterraction.Size.Height - 10);
            //interraction.LinkedProduction = p;
            panelInterraction.Controls.Add(interraction);
            interraction.Dock = DockStyle.Left;
            interraction.BringToFront();
        }

        private void ajouter_ItemAClick(object sender, EventArgs e) => GenerateProductionElements(new Production(EnumVitesseProduction.CAISSE_A));
        private void ajouter_ItemBClick(object sender, EventArgs e) => GenerateProductionElements(new Production(EnumVitesseProduction.CAISSE_B));
        private void ajouter_ItemCClick(object sender, EventArgs e) => GenerateProductionElements(new Production(EnumVitesseProduction.CAISSE_C));
    }
}