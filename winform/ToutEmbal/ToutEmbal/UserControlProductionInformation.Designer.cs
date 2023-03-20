namespace ToutEmbal
{
    partial class UserControlProductionInformation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNbCaisses = new System.Windows.Forms.TextBox();
            this.textBoxTauxDefautHeure = new System.Windows.Forms.TextBox();
            this.textBoxTauxDefautDemarrage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de caisses depuis le démarrage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Taux défaut heure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Taux défaut depuis démarrage";
            // 
            // textBoxNbCaisses
            // 
            this.textBoxNbCaisses.Enabled = false;
            this.textBoxNbCaisses.Location = new System.Drawing.Point(286, 9);
            this.textBoxNbCaisses.Name = "textBoxNbCaisses";
            this.textBoxNbCaisses.Size = new System.Drawing.Size(100, 23);
            this.textBoxNbCaisses.TabIndex = 3;
            // 
            // textBoxTauxDefautHeure
            // 
            this.textBoxTauxDefautHeure.Enabled = false;
            this.textBoxTauxDefautHeure.Location = new System.Drawing.Point(286, 54);
            this.textBoxTauxDefautHeure.Name = "textBoxTauxDefautHeure";
            this.textBoxTauxDefautHeure.Size = new System.Drawing.Size(100, 23);
            this.textBoxTauxDefautHeure.TabIndex = 4;
            // 
            // textBoxTauxDefautDemarrage
            // 
            this.textBoxTauxDefautDemarrage.Enabled = false;
            this.textBoxTauxDefautDemarrage.Location = new System.Drawing.Point(286, 102);
            this.textBoxTauxDefautDemarrage.Name = "textBoxTauxDefautDemarrage";
            this.textBoxTauxDefautDemarrage.Size = new System.Drawing.Size(100, 23);
            this.textBoxTauxDefautDemarrage.TabIndex = 5;
            // 
            // UserControlProductionInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxTauxDefautDemarrage);
            this.Controls.Add(this.textBoxTauxDefautHeure);
            this.Controls.Add(this.textBoxNbCaisses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControlProductionInformation";
            this.Size = new System.Drawing.Size(406, 142);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxNbCaisses;
        private TextBox textBoxTauxDefautHeure;
        private TextBox textBoxTauxDefautDemarrage;
    }
}
