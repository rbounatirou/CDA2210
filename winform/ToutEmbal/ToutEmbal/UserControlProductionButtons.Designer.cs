namespace ToutEmbal
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
            this.btStop = new System.Windows.Forms.Button();
            this.btReload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btStart.ForeColor = System.Drawing.Color.Blue;
            this.btStart.Image = global::ToutEmbal.Properties.Resources.vert;
            this.btStart.Location = new System.Drawing.Point(0, 0);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 108);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "X";
            this.btStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btStop.ForeColor = System.Drawing.Color.Blue;
            this.btStop.Image = global::ToutEmbal.Properties.Resources.rouge;
            this.btStop.Location = new System.Drawing.Point(90, 0);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 108);
            this.btStop.TabIndex = 1;
            this.btStop.Text = "X";
            this.btStop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btReload
            // 
            this.btReload.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btReload.ForeColor = System.Drawing.Color.Blue;
            this.btReload.Image = global::ToutEmbal.Properties.Resources.orange;
            this.btReload.Location = new System.Drawing.Point(184, 0);
            this.btReload.Name = "btReload";
            this.btReload.Size = new System.Drawing.Size(75, 108);
            this.btReload.TabIndex = 2;
            this.btReload.Text = "X";
            this.btReload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btReload.UseVisualStyleBackColor = true;
            this.btReload.Click += new System.EventHandler(this.btReload_Click);
            // 
            // UserControlProductionButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btReload);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Name = "UserControlProductionButtons";
            this.Size = new System.Drawing.Size(269, 113);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btStart;
        private Button btStop;
        private Button btReload;
    }
}
