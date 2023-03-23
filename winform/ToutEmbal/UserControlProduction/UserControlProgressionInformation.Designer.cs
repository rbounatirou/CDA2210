namespace UserControlProduction
{
    partial class UserControlProgressionInformation
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            textBoxNbCaisse = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            textBoxTauxDefautDemarrage = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            textBoxTauxDefautHeure = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(textBoxNbCaisse);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(15);
            panel1.Size = new Size(500, 50);
            panel1.TabIndex = 0;
            panel1.Resize += OnPanelResize;
            // 
            // textBoxNbCaisse
            // 
            textBoxNbCaisse.Dock = DockStyle.Right;
            textBoxNbCaisse.Location = new Point(326, 15);
            textBoxNbCaisse.Name = "textBoxNbCaisse";
            textBoxNbCaisse.Size = new Size(159, 23);
            textBoxNbCaisse.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(15, 15);
            label1.Margin = new Padding(5);
            label1.Name = "label1";
            label1.Size = new Size(211, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre de caisse depuis le démarrage";
            label1.Resize += OnResize;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(textBoxTauxDefautDemarrage);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 100);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(15);
            panel3.Size = new Size(500, 42);
            panel3.TabIndex = 1;
            panel3.Resize += OnPanelResize;
            // 
            // textBoxTauxDefautDemarrage
            // 
            textBoxTauxDefautDemarrage.Dock = DockStyle.Right;
            textBoxTauxDefautDemarrage.Location = new Point(326, 15);
            textBoxTauxDefautDemarrage.Name = "textBoxTauxDefautDemarrage";
            textBoxTauxDefautDemarrage.Size = new Size(159, 23);
            textBoxTauxDefautDemarrage.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Location = new Point(15, 15);
            label3.Name = "label3";
            label3.Size = new Size(166, 15);
            label3.TabIndex = 0;
            label3.Text = "Taux défaut depuis démarrage";
            label3.Resize += OnResize;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(textBoxTauxDefautHeure);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 50);
            panel4.Margin = new Padding(5);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(15);
            panel4.Size = new Size(500, 50);
            panel4.TabIndex = 1;
            panel4.Resize += OnPanelResize;
            // 
            // textBoxTauxDefautHeure
            // 
            textBoxTauxDefautHeure.Dock = DockStyle.Right;
            textBoxTauxDefautHeure.Location = new Point(326, 15);
            textBoxTauxDefautHeure.Name = "textBoxTauxDefautHeure";
            textBoxTauxDefautHeure.Size = new Size(159, 23);
            textBoxTauxDefautHeure.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Location = new Point(15, 15);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 0;
            label2.Text = "Taux défaut heure";
            label2.Resize += OnResize;
            // 
            // UserControlProgressionInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "UserControlProgressionInformation";
            Size = new Size(500, 142);
            Resize += OnResize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox textBoxNbCaisse;
        private TextBox textBoxTauxDefautDemarrage;
        private TextBox textBoxTauxDefautHeure;
    }
}
