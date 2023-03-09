namespace ListeProp
{
    partial class FormList
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
            this.list_personnes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textCount = new System.Windows.Forms.TextBox();
            this.textSelectedIndex = new System.Windows.Forms.TextBox();
            this.textContent = new System.Windows.Forms.TextBox();
            this.textIndexElement = new System.Windows.Forms.TextBox();
            this.textNouvelElement = new System.Windows.Forms.TextBox();
            this.btAjout = new System.Windows.Forms.Button();
            this.btSelectionner = new System.Windows.Forms.Button();
            this.btVider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_personnes
            // 
            this.list_personnes.FormattingEnabled = true;
            this.list_personnes.ItemHeight = 15;
            this.list_personnes.Location = new System.Drawing.Point(12, 194);
            this.list_personnes.Name = "list_personnes";
            this.list_personnes.Size = new System.Drawing.Size(160, 169);
            this.list_personnes.TabIndex = 0;
            this.list_personnes.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "LstListe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "NouvelElément";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(264, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "IndexElément";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(264, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Propriétés";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Items.Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "SelectedIndex";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Text";
            // 
            // textCount
            // 
            this.textCount.Enabled = false;
            this.textCount.Location = new System.Drawing.Point(407, 209);
            this.textCount.Name = "textCount";
            this.textCount.Size = new System.Drawing.Size(40, 23);
            this.textCount.TabIndex = 8;
            // 
            // textSelectedIndex
            // 
            this.textSelectedIndex.Enabled = false;
            this.textSelectedIndex.Location = new System.Drawing.Point(407, 257);
            this.textSelectedIndex.Name = "textSelectedIndex";
            this.textSelectedIndex.Size = new System.Drawing.Size(40, 23);
            this.textSelectedIndex.TabIndex = 9;
            // 
            // textContent
            // 
            this.textContent.Enabled = false;
            this.textContent.Location = new System.Drawing.Point(407, 313);
            this.textContent.Name = "textContent";
            this.textContent.Size = new System.Drawing.Size(100, 23);
            this.textContent.TabIndex = 10;
            // 
            // textIndexElement
            // 
            this.textIndexElement.Location = new System.Drawing.Point(264, 46);
            this.textIndexElement.Name = "textIndexElement";
            this.textIndexElement.Size = new System.Drawing.Size(53, 23);
            this.textIndexElement.TabIndex = 11;
            // 
            // textNouvelElement
            // 
            this.textNouvelElement.Location = new System.Drawing.Point(12, 46);
            this.textNouvelElement.Name = "textNouvelElement";
            this.textNouvelElement.Size = new System.Drawing.Size(160, 23);
            this.textNouvelElement.TabIndex = 12;
            // 
            // btAjout
            // 
            this.btAjout.Location = new System.Drawing.Point(12, 90);
            this.btAjout.Name = "btAjout";
            this.btAjout.Size = new System.Drawing.Size(160, 23);
            this.btAjout.TabIndex = 13;
            this.btAjout.Text = "Ajout Liste";
            this.btAjout.UseVisualStyleBackColor = true;
            this.btAjout.Click += new System.EventHandler(this.btAjout_Click);
            // 
            // btSelectionner
            // 
            this.btSelectionner.Location = new System.Drawing.Point(356, 45);
            this.btSelectionner.Name = "btSelectionner";
            this.btSelectionner.Size = new System.Drawing.Size(128, 23);
            this.btSelectionner.TabIndex = 14;
            this.btSelectionner.Text = "Sélectionner";
            this.btSelectionner.UseVisualStyleBackColor = true;
            this.btSelectionner.Click += new System.EventHandler(this.btSelectionner_Click);
            // 
            // btVider
            // 
            this.btVider.Location = new System.Drawing.Point(356, 90);
            this.btVider.Name = "btVider";
            this.btVider.Size = new System.Drawing.Size(128, 23);
            this.btVider.TabIndex = 15;
            this.btVider.Text = "Vider la liste";
            this.btVider.UseVisualStyleBackColor = true;
            this.btVider.Click += new System.EventHandler(this.buttonVider_Click);
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 375);
            this.Controls.Add(this.btVider);
            this.Controls.Add(this.btSelectionner);
            this.Controls.Add(this.btAjout);
            this.Controls.Add(this.textNouvelElement);
            this.Controls.Add(this.textIndexElement);
            this.Controls.Add(this.textContent);
            this.Controls.Add(this.textSelectedIndex);
            this.Controls.Add(this.textCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_personnes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormList";
            this.Text = "Les listes et leurs propriétés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox list_personnes;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textCount;
        private TextBox textSelectedIndex;
        private TextBox textContent;
        private TextBox textIndexElement;
        private TextBox textNouvelElement;
        private Button btAjout;
        private Button btSelectionner;
        private Button btVider;
    }
}