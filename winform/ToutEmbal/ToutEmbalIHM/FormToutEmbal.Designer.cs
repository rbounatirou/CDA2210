namespace ToutEmbalIHM
{
    partial class FormToutEmbal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fichierToolStripMenuItem = new ToolStripMenuItem();
            productionToolStripMenuItem = new ToolStripMenuItem();
            demarrer_menu = new ToolStripMenuItem();
            arreter_menu = new ToolStripMenuItem();
            continuer_menu = new ToolStripMenuItem();
            ajouterToolStripMenuItem = new ToolStripMenuItem();
            ajouter_ItemA = new ToolStripMenuItem();
            ajouter_ItemB = new ToolStripMenuItem();
            ajouter_ItemC = new ToolStripMenuItem();
            tabControlInformation = new TabControl();
            panelProgressBar = new Panel();
            panelInterraction = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem, productionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(832, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(54, 20);
            fichierToolStripMenuItem.Text = "Fichier";
            // 
            // productionToolStripMenuItem
            // 
            productionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { demarrer_menu, arreter_menu, continuer_menu, ajouterToolStripMenuItem });
            productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            productionToolStripMenuItem.Size = new Size(78, 20);
            productionToolStripMenuItem.Text = "Production";
            // 
            // demarrer_menu
            // 
            demarrer_menu.Name = "demarrer_menu";
            demarrer_menu.Size = new Size(127, 22);
            demarrer_menu.Text = "Démarrer";
            // 
            // arreter_menu
            // 
            arreter_menu.Name = "arreter_menu";
            arreter_menu.Size = new Size(127, 22);
            arreter_menu.Text = "Arrêter";
            // 
            // continuer_menu
            // 
            continuer_menu.Name = "continuer_menu";
            continuer_menu.Size = new Size(127, 22);
            continuer_menu.Text = "Continuer";
            // 
            // ajouterToolStripMenuItem
            // 
            ajouterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajouter_ItemA, ajouter_ItemB, ajouter_ItemC });
            ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            ajouterToolStripMenuItem.Size = new Size(127, 22);
            ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // ajouter_ItemA
            // 
            ajouter_ItemA.Name = "ajouter_ItemA";
            ajouter_ItemA.Size = new Size(82, 22);
            ajouter_ItemA.Text = "A";
            ajouter_ItemA.Click += ajouter_ItemAClick;
            // 
            // ajouter_ItemB
            // 
            ajouter_ItemB.Name = "ajouter_ItemB";
            ajouter_ItemB.Size = new Size(82, 22);
            ajouter_ItemB.Text = "B";
            ajouter_ItemB.Click += ajouter_ItemBClick;
            // 
            // ajouter_ItemC
            // 
            ajouter_ItemC.Name = "ajouter_ItemC";
            ajouter_ItemC.Size = new Size(82, 22);
            ajouter_ItemC.Text = "C";
            ajouter_ItemC.Click += ajouter_ItemCClick;
            // 
            // tabControlInformation
            // 
            tabControlInformation.Location = new Point(382, 115);
            tabControlInformation.Name = "tabControlInformation";
            tabControlInformation.SelectedIndex = 0;
            tabControlInformation.Size = new Size(450, 235);
            tabControlInformation.TabIndex = 9;
            // 
            // panelProgressBar
            // 
            panelProgressBar.AutoScroll = true;
            panelProgressBar.BackColor = SystemColors.Control;
            panelProgressBar.Dock = DockStyle.Bottom;
            panelProgressBar.Location = new Point(0, 355);
            panelProgressBar.Name = "panelProgressBar";
            panelProgressBar.Padding = new Padding(10);
            panelProgressBar.Size = new Size(832, 173);
            panelProgressBar.TabIndex = 10;
            // 
            // panelInterraction
            // 
            panelInterraction.AutoScroll = true;
            panelInterraction.BackColor = SystemColors.Control;
            panelInterraction.Dock = DockStyle.Top;
            panelInterraction.Location = new Point(0, 24);
            panelInterraction.Name = "panelInterraction";
            panelInterraction.Size = new Size(832, 82);
            panelInterraction.TabIndex = 11;
            // 
            // FormToutEmbal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 528);
            Controls.Add(panelInterraction);
            Controls.Add(panelProgressBar);
            Controls.Add(tabControlInformation);
            Controls.Add(menuStrip1);
            Cursor = Cursors.Arrow;
            MainMenuStrip = menuStrip1;
            Name = "FormToutEmbal";
            Text = "PRODUCTION DES CAISSES";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem productionToolStripMenuItem;
        private ToolStripMenuItem demarrer_menu;
        private ToolStripMenuItem arreter_menu;
        private ToolStripMenuItem continuer_menu;
        private TabControl tabControlInformation;
        private Panel panelProgressBar;
        private Panel panelInterraction;
        private ToolStripMenuItem ajouterToolStripMenuItem;
        private ToolStripMenuItem ajouter_ItemA;
        private ToolStripMenuItem ajouter_ItemB;
        private ToolStripMenuItem ajouter_ItemC;
    }
}