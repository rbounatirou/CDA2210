namespace UserControlProduction
{
    partial class UserControlProductionProgressBar
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
            labelText = new Label();
            progressBarProduction = new ProgressBar();
            SuspendLayout();
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Dock = DockStyle.Left;
            labelText.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelText.Location = new Point(0, 0);
            labelText.Margin = new Padding(0);
            labelText.Name = "labelText";
            labelText.Size = new Size(140, 30);
            labelText.TabIndex = 0;
            labelText.Text = "Production N";
            // 
            // progressBarProduction
            // 
            progressBarProduction.Dock = DockStyle.Fill;
            progressBarProduction.Location = new Point(140, 0);
            progressBarProduction.Name = "progressBarProduction";
            progressBarProduction.Size = new Size(622, 35);
            progressBarProduction.TabIndex = 1;
            // 
            // UserControlProductionProgressBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(progressBarProduction);
            Controls.Add(labelText);
            Margin = new Padding(0);
            Name = "UserControlProductionProgressBar";
            Size = new Size(762, 35);
            Resize += OnResize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelText;
        private ProgressBar progressBarProduction;
    }
}
