namespace CreerFormulaires
{
    partial class FormFormulaires
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFormulaires));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sidentifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phase1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.additionneurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phase2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificationSaisieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phase3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboEtCheckboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeEtPropToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeEtComboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defilementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.empruntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fenêtresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAuthentification = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButtonPhase3 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelBottomDate = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelBottomAuthentification = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.phase1ToolStripMenuItem,
            this.phase2ToolStripMenuItem,
            this.phase3ToolStripMenuItem,
            this.fenêtresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.fenêtresToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(875, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sidentifierToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitterToolStripMenuItem});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // sidentifierToolStripMenuItem
            // 
            this.sidentifierToolStripMenuItem.Name = "sidentifierToolStripMenuItem";
            this.sidentifierToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.sidentifierToolStripMenuItem.Text = "S\'identifier";
            this.sidentifierToolStripMenuItem.Click += new System.EventHandler(this.OpenAuthentificationForm);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(127, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.Exit);
            // 
            // phase1ToolStripMenuItem
            // 
            this.phase1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.additionneurToolStripMenuItem});
            this.phase1ToolStripMenuItem.Enabled = false;
            this.phase1ToolStripMenuItem.Name = "phase1ToolStripMenuItem";
            this.phase1ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.phase1ToolStripMenuItem.Text = "Phase 1";
            // 
            // additionneurToolStripMenuItem
            // 
            this.additionneurToolStripMenuItem.Name = "additionneurToolStripMenuItem";
            this.additionneurToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.additionneurToolStripMenuItem.Text = "Additionneur";
            this.additionneurToolStripMenuItem.Click += new System.EventHandler(this.additionneurToolStripMenuItem_Click);
            // 
            // phase2ToolStripMenuItem
            // 
            this.phase2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verificationSaisieToolStripMenuItem});
            this.phase2ToolStripMenuItem.Enabled = false;
            this.phase2ToolStripMenuItem.Name = "phase2ToolStripMenuItem";
            this.phase2ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.phase2ToolStripMenuItem.Text = "Phase 2";
            // 
            // verificationSaisieToolStripMenuItem
            // 
            this.verificationSaisieToolStripMenuItem.Name = "verificationSaisieToolStripMenuItem";
            this.verificationSaisieToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.verificationSaisieToolStripMenuItem.Text = "Verification saisie";
            this.verificationSaisieToolStripMenuItem.Click += new System.EventHandler(this.verificationSaisieToolStripMenuItem_Click);
            // 
            // phase3ToolStripMenuItem
            // 
            this.phase3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comboEtCheckboxToolStripMenuItem,
            this.listeEtPropToolStripMenuItem,
            this.listeEtComboToolStripMenuItem,
            this.defilementToolStripMenuItem,
            this.toolStripSeparator3,
            this.empruntToolStripMenuItem});
            this.phase3ToolStripMenuItem.Enabled = false;
            this.phase3ToolStripMenuItem.Name = "phase3ToolStripMenuItem";
            this.phase3ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.phase3ToolStripMenuItem.Text = "Phase 3";
            // 
            // comboEtCheckboxToolStripMenuItem
            // 
            this.comboEtCheckboxToolStripMenuItem.Name = "comboEtCheckboxToolStripMenuItem";
            this.comboEtCheckboxToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.comboEtCheckboxToolStripMenuItem.Text = "Checkbox et radiobt";
            this.comboEtCheckboxToolStripMenuItem.Click += new System.EventHandler(this.comboEtCheckboxToolStripMenuItem_Click);
            // 
            // listeEtPropToolStripMenuItem
            // 
            this.listeEtPropToolStripMenuItem.Name = "listeEtPropToolStripMenuItem";
            this.listeEtPropToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.listeEtPropToolStripMenuItem.Text = "Liste et prop";
            this.listeEtPropToolStripMenuItem.Click += new System.EventHandler(this.listeEtPropToolStripMenuItem_Click);
            // 
            // listeEtComboToolStripMenuItem
            // 
            this.listeEtComboToolStripMenuItem.Name = "listeEtComboToolStripMenuItem";
            this.listeEtComboToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.listeEtComboToolStripMenuItem.Text = "Liste et combo";
            this.listeEtComboToolStripMenuItem.Click += new System.EventHandler(this.listeEtComboToolStripMenuItem_Click);
            // 
            // defilementToolStripMenuItem
            // 
            this.defilementToolStripMenuItem.Name = "defilementToolStripMenuItem";
            this.defilementToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.defilementToolStripMenuItem.Text = "Defilement";
            this.defilementToolStripMenuItem.Click += new System.EventHandler(this.defilementToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(178, 6);
            // 
            // empruntToolStripMenuItem
            // 
            this.empruntToolStripMenuItem.Name = "empruntToolStripMenuItem";
            this.empruntToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.empruntToolStripMenuItem.Text = "Emprunt";
            this.empruntToolStripMenuItem.Click += new System.EventHandler(this.empruntToolStripMenuItem_Click);
            // 
            // fenêtresToolStripMenuItem
            // 
            this.fenêtresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem,
            this.toolStripSeparator2});
            this.fenêtresToolStripMenuItem.Enabled = false;
            this.fenêtresToolStripMenuItem.Name = "fenêtresToolStripMenuItem";
            this.fenêtresToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.fenêtresToolStripMenuItem.Text = "Fenêtres";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.DisplaySelect_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.DisplaySelect_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.DisplaySelect_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAuthentification,
            this.toolStripSplitButtonPhase3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(875, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAuthentification
            // 
            this.toolStripButtonAuthentification.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAuthentification.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAuthentification.Image")));
            this.toolStripButtonAuthentification.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAuthentification.Name = "toolStripButtonAuthentification";
            this.toolStripButtonAuthentification.Size = new System.Drawing.Size(67, 22);
            this.toolStripButtonAuthentification.Text = "S\'identifier";
            this.toolStripButtonAuthentification.Click += new System.EventHandler(this.OpenAuthentificationForm);
            // 
            // toolStripSplitButtonPhase3
            // 
            this.toolStripSplitButtonPhase3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButtonPhase3.Enabled = false;
            this.toolStripSplitButtonPhase3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonPhase3.Image")));
            this.toolStripSplitButtonPhase3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonPhase3.Name = "toolStripSplitButtonPhase3";
            this.toolStripSplitButtonPhase3.Size = new System.Drawing.Size(63, 22);
            this.toolStripSplitButtonPhase3.Text = "Phase 3";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelBottomDate,
            this.toolStripLabelBottomAuthentification});
            this.toolStrip2.Location = new System.Drawing.Point(0, 502);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(875, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabelBottomDate
            // 
            this.toolStripLabelBottomDate.Name = "toolStripLabelBottomDate";
            this.toolStripLabelBottomDate.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripLabelBottomAuthentification
            // 
            this.toolStripLabelBottomAuthentification.Name = "toolStripLabelBottomAuthentification";
            this.toolStripLabelBottomAuthentification.Size = new System.Drawing.Size(0, 22);
            // 
            // FormFormulaires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 527);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormFormulaires";
            this.Text = "Créer des formulaires";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFormulaires_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem connectionToolStripMenuItem;
        private ToolStripMenuItem phase1ToolStripMenuItem;
        private ToolStripMenuItem phase2ToolStripMenuItem;
        private ToolStripMenuItem phase3ToolStripMenuItem;
        private ToolStripMenuItem fenêtresToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonAuthentification;
        private ToolStripSplitButton toolStripSplitButtonPhase3;
        private ToolStripMenuItem sidentifierToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem additionneurToolStripMenuItem;
        private ToolStripMenuItem verificationSaisieToolStripMenuItem;
        private ToolStripMenuItem comboEtCheckboxToolStripMenuItem;
        private ToolStripMenuItem listeEtPropToolStripMenuItem;
        private ToolStripMenuItem listeEtComboToolStripMenuItem;
        private ToolStripMenuItem defilementToolStripMenuItem;
        private ToolStripMenuItem empruntToolStripMenuItem;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem horizontalToolStripMenuItem;
        private ToolStripMenuItem verticalToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStrip toolStrip2;
        private ToolStripLabel toolStripLabelBottomDate;
        private ToolStripLabel toolStripLabelBottomAuthentification;
    }
}