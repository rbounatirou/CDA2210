namespace WinFormsMultiCouche
{
    partial class CompteManager
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
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxPseudo = new System.Windows.Forms.TextBox();
            this.textBoxTypeRequete = new System.Windows.Forms.TextBox();
            this.btValider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(115, 25);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(218, 23);
            this.textBoxId.TabIndex = 0;
            // 
            // textBoxPseudo
            // 
            this.textBoxPseudo.Location = new System.Drawing.Point(115, 76);
            this.textBoxPseudo.Name = "textBoxPseudo";
            this.textBoxPseudo.Size = new System.Drawing.Size(218, 23);
            this.textBoxPseudo.TabIndex = 1;
            // 
            // textBoxTypeRequete
            // 
            this.textBoxTypeRequete.Enabled = false;
            this.textBoxTypeRequete.Location = new System.Drawing.Point(12, 135);
            this.textBoxTypeRequete.Name = "textBoxTypeRequete";
            this.textBoxTypeRequete.Size = new System.Drawing.Size(321, 23);
            this.textBoxTypeRequete.TabIndex = 2;
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(12, 180);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(321, 44);
            this.btValider.TabIndex = 3;
            this.btValider.Text = "Effectuer requete";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "pseudo";
            // 
            // CompteManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 236);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.textBoxTypeRequete);
            this.Controls.Add(this.textBoxPseudo);
            this.Controls.Add(this.textBoxId);
            this.Name = "CompteManager";
            this.Text = "CompteManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxId;
        private TextBox textBoxPseudo;
        private TextBox textBoxTypeRequete;
        private Button btValider;
        private Label label1;
        private Label label2;
    }
}