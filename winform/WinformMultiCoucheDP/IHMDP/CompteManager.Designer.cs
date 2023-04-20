namespace IHMDP
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxPseudo = new System.Windows.Forms.TextBox();
            this.textBoxTypeRequete = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pseudo";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(100, 31);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(153, 23);
            this.textBoxId.TabIndex = 2;
            // 
            // textBoxPseudo
            // 
            this.textBoxPseudo.Location = new System.Drawing.Point(100, 91);
            this.textBoxPseudo.Name = "textBoxPseudo";
            this.textBoxPseudo.Size = new System.Drawing.Size(153, 23);
            this.textBoxPseudo.TabIndex = 3;
            // 
            // textBoxTypeRequete
            // 
            this.textBoxTypeRequete.Enabled = false;
            this.textBoxTypeRequete.Location = new System.Drawing.Point(34, 138);
            this.textBoxTypeRequete.Name = "textBoxTypeRequete";
            this.textBoxTypeRequete.Size = new System.Drawing.Size(219, 23);
            this.textBoxTypeRequete.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "ExecuterRequete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SendQuery);
            // 
            // CompteManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 250);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxTypeRequete);
            this.Controls.Add(this.textBoxPseudo);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CompteManager";
            this.Text = "CompteManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxId;
        private TextBox textBoxPseudo;
        private TextBox textBoxTypeRequete;
        private Button button1;
    }
}