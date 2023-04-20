namespace IHMDP
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compteToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutToolStripMenuItem,
            this.modificationToolStripMenuItem,
            this.suppressionToolStripMenuItem,
            this.selectionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajoutToolStripMenuItem
            // 
            this.ajoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compteToolStripMenuItem});
            this.ajoutToolStripMenuItem.Name = "ajoutToolStripMenuItem";
            this.ajoutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ajoutToolStripMenuItem.Text = "Ajout";
            // 
            // compteToolStripMenuItem
            // 
            this.compteToolStripMenuItem.Name = "compteToolStripMenuItem";
            this.compteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.compteToolStripMenuItem.Text = "Compte";
            this.compteToolStripMenuItem.Click += new System.EventHandler(this.OuvrirCompteManagerAjout);
            // 
            // modificationToolStripMenuItem
            // 
            this.modificationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compteToolStripMenuItem1});
            this.modificationToolStripMenuItem.Name = "modificationToolStripMenuItem";
            this.modificationToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.modificationToolStripMenuItem.Text = "Modification";
            // 
            // compteToolStripMenuItem1
            // 
            this.compteToolStripMenuItem1.Name = "compteToolStripMenuItem1";
            this.compteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.compteToolStripMenuItem1.Text = "Compte";
            this.compteToolStripMenuItem1.Click += new System.EventHandler(this.OuvrirCompteManagerModifier);
            // 
            // suppressionToolStripMenuItem
            // 
            this.suppressionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compteToolStripMenuItem2});
            this.suppressionToolStripMenuItem.Name = "suppressionToolStripMenuItem";
            this.suppressionToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.suppressionToolStripMenuItem.Text = "Suppression";
            this.suppressionToolStripMenuItem.Click += new System.EventHandler(this.OuvrirCompteManagerSupprimer);
            // 
            // compteToolStripMenuItem2
            // 
            this.compteToolStripMenuItem2.Name = "compteToolStripMenuItem2";
            this.compteToolStripMenuItem2.Size = new System.Drawing.Size(117, 22);
            this.compteToolStripMenuItem2.Text = "Compte";
            // 
            // selectionToolStripMenuItem
            // 
            this.selectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compteToolStripMenuItem3});
            this.selectionToolStripMenuItem.Name = "selectionToolStripMenuItem";
            this.selectionToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.selectionToolStripMenuItem.Text = "Selection";
            // 
            // compteToolStripMenuItem3
            // 
            this.compteToolStripMenuItem3.Name = "compteToolStripMenuItem3";
            this.compteToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.compteToolStripMenuItem3.Text = "Compte";
            this.compteToolStripMenuItem3.Click += new System.EventHandler(this.OuvrirCompteManagerSelectionner);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ajoutToolStripMenuItem;
        private ToolStripMenuItem compteToolStripMenuItem;
        private ToolStripMenuItem modificationToolStripMenuItem;
        private ToolStripMenuItem compteToolStripMenuItem1;
        private ToolStripMenuItem suppressionToolStripMenuItem;
        private ToolStripMenuItem compteToolStripMenuItem2;
        private ToolStripMenuItem selectionToolStripMenuItem;
        private ToolStripMenuItem compteToolStripMenuItem3;
    }
}