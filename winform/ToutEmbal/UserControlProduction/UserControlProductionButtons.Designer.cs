namespace UserControlProduction
{
    partial class UserControlProductionButtons
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
            this.btStart = new System.Windows.Forms.Button();
            this.btRestart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btStart.ForeColor = System.Drawing.Color.Blue;
            this.btStart.Image = global::UserControlProduction.Properties.Resources.vert;
            this.btStart.Location = new System.Drawing.Point(3, 3);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(105, 201);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "X";
            this.btStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btStart.UseVisualStyleBackColor = true;
            // 
            // btRestart
            // 
            this.btRestart.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btRestart.Image = global::UserControlProduction.Properties.Resources.orange;
            this.btRestart.Location = new System.Drawing.Point(114, 3);
            this.btRestart.Name = "btRestart";
            this.btRestart.Size = new System.Drawing.Size(105, 201);
            this.btRestart.TabIndex = 1;
            this.btRestart.Text = "X";
            this.btRestart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRestart.UseVisualStyleBackColor = true;
            // 
            // btStop
            // 
            this.btStop.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btStop.Image = global::UserControlProduction.Properties.Resources.rouge;
            this.btStop.Location = new System.Drawing.Point(225, 3);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(105, 201);
            this.btStop.TabIndex = 2;
            this.btStop.Text = "X";
            this.btStop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btStop.UseVisualStyleBackColor = true;
            // 
            // UserControlProductionButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btRestart);
            this.Controls.Add(this.btStart);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "UserControlProductionButtons";
            this.Size = new System.Drawing.Size(334, 210);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btStart;
        private Button btRestart;
        private Button btStop;
    }
}
