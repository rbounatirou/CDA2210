namespace UserControlProduction
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
            this.textBoxNbCaisse = new System.Windows.Forms.TextBox();
            this.textBoxDefautHeure = new System.Windows.Forms.TextBox();
            this.textBoxDefautDepuisDemarrage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de caisses depuis le démarrage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Taux défaut heure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Taux défaut depuis démarrage";
            // 
            // textBoxNbCaisse
            // 
            this.textBoxNbCaisse.Location = new System.Drawing.Point(284, 14);
            this.textBoxNbCaisse.Name = "textBoxNbCaisse";
            this.textBoxNbCaisse.Size = new System.Drawing.Size(100, 23);
            this.textBoxNbCaisse.TabIndex = 3;
            // 
            // textBoxDefautHeure
            // 
            this.textBoxDefautHeure.Location = new System.Drawing.Point(284, 66);
            this.textBoxDefautHeure.Name = "textBoxDefautHeure";
            this.textBoxDefautHeure.Size = new System.Drawing.Size(100, 23);
            this.textBoxDefautHeure.TabIndex = 4;
            // 
            // textBoxDefautDepuisDemarrage
            // 
            this.textBoxDefautDepuisDemarrage.Location = new System.Drawing.Point(284, 112);
            this.textBoxDefautDepuisDemarrage.Name = "textBoxDefautDepuisDemarrage";
            this.textBoxDefautDepuisDemarrage.Size = new System.Drawing.Size(100, 23);
            this.textBoxDefautDepuisDemarrage.TabIndex = 5;
            // 
            // UserControlProductionInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxDefautDepuisDemarrage);
            this.Controls.Add(this.textBoxDefautHeure);
            this.Controls.Add(this.textBoxNbCaisse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControlProductionInformation";
            this.Size = new System.Drawing.Size(398, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxNbCaisse;
        private TextBox textBoxDefautHeure;
        private TextBox textBoxDefautDepuisDemarrage;
    }
}
