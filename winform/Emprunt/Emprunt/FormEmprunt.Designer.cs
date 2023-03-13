namespace EmpruntForm
{
    partial class FormEmprunt
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelNombreRemboursement = new System.Windows.Forms.Label();
            this.labelPrixRemboursement = new System.Windows.Forms.Label();
            this.groupBoxTaux = new System.Windows.Forms.GroupBox();
            this.radioButtonNeufPourcent = new System.Windows.Forms.RadioButton();
            this.radioButtonHuitPourcent = new System.Windows.Forms.RadioButton();
            this.radioButtonSeptPourcent = new System.Windows.Forms.RadioButton();
            this.hsNombreMois = new System.Windows.Forms.HScrollBar();
            this.labelNombreMois = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxCapital = new System.Windows.Forms.TextBox();
            this.listBoxTypeMensualite = new System.Windows.Forms.ListBox();
            this.groupBoxTaux.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Capital Emprunté";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Durée en mois du \r\nremboursement";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Périodicité du remboursement";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(498, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Remboursement";
            // 
            // labelNombreRemboursement
            // 
            this.labelNombreRemboursement.AutoSize = true;
            this.labelNombreRemboursement.ForeColor = System.Drawing.Color.Red;
            this.labelNombreRemboursement.Location = new System.Drawing.Point(425, 258);
            this.labelNombreRemboursement.Name = "labelNombreRemboursement";
            this.labelNombreRemboursement.Size = new System.Drawing.Size(0, 15);
            this.labelNombreRemboursement.TabIndex = 5;
            // 
            // labelPrixRemboursement
            // 
            this.labelPrixRemboursement.AutoSize = true;
            this.labelPrixRemboursement.ForeColor = System.Drawing.Color.Red;
            this.labelPrixRemboursement.Location = new System.Drawing.Point(549, 322);
            this.labelPrixRemboursement.Name = "labelPrixRemboursement";
            this.labelPrixRemboursement.Size = new System.Drawing.Size(0, 15);
            this.labelPrixRemboursement.TabIndex = 6;
            // 
            // groupBoxTaux
            // 
            this.groupBoxTaux.Controls.Add(this.radioButtonNeufPourcent);
            this.groupBoxTaux.Controls.Add(this.radioButtonHuitPourcent);
            this.groupBoxTaux.Controls.Add(this.radioButtonSeptPourcent);
            this.groupBoxTaux.Location = new System.Drawing.Point(511, 50);
            this.groupBoxTaux.Name = "groupBoxTaux";
            this.groupBoxTaux.Size = new System.Drawing.Size(113, 131);
            this.groupBoxTaux.TabIndex = 7;
            this.groupBoxTaux.TabStop = false;
            this.groupBoxTaux.Text = "Taux d\'intérêt";
            // 
            // radioButtonNeufPourcent
            // 
            this.radioButtonNeufPourcent.AutoSize = true;
            this.radioButtonNeufPourcent.Location = new System.Drawing.Point(6, 101);
            this.radioButtonNeufPourcent.Name = "radioButtonNeufPourcent";
            this.radioButtonNeufPourcent.Size = new System.Drawing.Size(41, 19);
            this.radioButtonNeufPourcent.TabIndex = 2;
            this.radioButtonNeufPourcent.Tag = "0.09";
            this.radioButtonNeufPourcent.Text = "9%";
            this.radioButtonNeufPourcent.UseVisualStyleBackColor = true;
            this.radioButtonNeufPourcent.CheckedChanged += new System.EventHandler(this.RadioRate_CheckedChanged);
            // 
            // radioButtonHuitPourcent
            // 
            this.radioButtonHuitPourcent.AutoSize = true;
            this.radioButtonHuitPourcent.Location = new System.Drawing.Point(6, 66);
            this.radioButtonHuitPourcent.Name = "radioButtonHuitPourcent";
            this.radioButtonHuitPourcent.Size = new System.Drawing.Size(41, 19);
            this.radioButtonHuitPourcent.TabIndex = 1;
            this.radioButtonHuitPourcent.Tag = "0.08";
            this.radioButtonHuitPourcent.Text = "8%";
            this.radioButtonHuitPourcent.UseVisualStyleBackColor = true;
            this.radioButtonHuitPourcent.CheckedChanged += new System.EventHandler(this.RadioRate_CheckedChanged);
            // 
            // radioButtonSeptPourcent
            // 
            this.radioButtonSeptPourcent.AutoSize = true;
            this.radioButtonSeptPourcent.Checked = true;
            this.radioButtonSeptPourcent.Location = new System.Drawing.Point(6, 32);
            this.radioButtonSeptPourcent.Name = "radioButtonSeptPourcent";
            this.radioButtonSeptPourcent.Size = new System.Drawing.Size(41, 19);
            this.radioButtonSeptPourcent.TabIndex = 0;
            this.radioButtonSeptPourcent.TabStop = true;
            this.radioButtonSeptPourcent.Tag = "0.07";
            this.radioButtonSeptPourcent.Text = "7%";
            this.radioButtonSeptPourcent.UseVisualStyleBackColor = true;
            this.radioButtonSeptPourcent.CheckedChanged += new System.EventHandler(this.RadioRate_CheckedChanged);
            // 
            // hsNombreMois
            // 
            this.hsNombreMois.Location = new System.Drawing.Point(303, 152);
            this.hsNombreMois.Minimum = 1;
            this.hsNombreMois.Name = "hsNombreMois";
            this.hsNombreMois.Size = new System.Drawing.Size(183, 29);
            this.hsNombreMois.TabIndex = 8;
            this.hsNombreMois.Value = 1;
            this.hsNombreMois.ValueChanged += new System.EventHandler(this.HS_ValueChanged);
            // 
            // labelNombreMois
            // 
            this.labelNombreMois.AutoSize = true;
            this.labelNombreMois.Location = new System.Drawing.Point(227, 166);
            this.labelNombreMois.Name = "labelNombreMois";
            this.labelNombreMois.Size = new System.Drawing.Size(0, 15);
            this.labelNombreMois.TabIndex = 9;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(197, 50);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(156, 23);
            this.textBoxNom.TabIndex = 10;
            // 
            // textBoxCapital
            // 
            this.textBoxCapital.Location = new System.Drawing.Point(197, 97);
            this.textBoxCapital.Name = "textBoxCapital";
            this.textBoxCapital.Size = new System.Drawing.Size(156, 23);
            this.textBoxCapital.TabIndex = 11;
            this.textBoxCapital.Text = "0";
            // 
            // listBoxTypeMensualite
            // 
            this.listBoxTypeMensualite.FormattingEnabled = true;
            this.listBoxTypeMensualite.ItemHeight = 15;
            this.listBoxTypeMensualite.Location = new System.Drawing.Point(62, 288);
            this.listBoxTypeMensualite.Name = "listBoxTypeMensualite";
            this.listBoxTypeMensualite.Size = new System.Drawing.Size(168, 124);
            this.listBoxTypeMensualite.TabIndex = 12;
            this.listBoxTypeMensualite.SelectedIndexChanged += new System.EventHandler(this.ListMensualite_SelectIndexChanged);
            // 
            // FormEmprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxTypeMensualite);
            this.Controls.Add(this.textBoxCapital);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelNombreMois);
            this.Controls.Add(this.hsNombreMois);
            this.Controls.Add(this.groupBoxTaux);
            this.Controls.Add(this.labelPrixRemboursement);
            this.Controls.Add(this.labelNombreRemboursement);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEmprunt";
            this.Text = "Emprunts";
            this.groupBoxTaux.ResumeLayout(false);
            this.groupBoxTaux.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label labelNombreRemboursement;
        private Label labelPrixRemboursement;
        private GroupBox groupBoxTaux;
        private RadioButton radioButtonNeufPourcent;
        private RadioButton radioButtonHuitPourcent;
        private RadioButton radioButtonSeptPourcent;
        private HScrollBar hsNombreMois;
        private Label labelNombreMois;
        private TextBox textBoxNom;
        private TextBox textBoxCapital;
        private ListBox listBoxTypeMensualite;
    }
}