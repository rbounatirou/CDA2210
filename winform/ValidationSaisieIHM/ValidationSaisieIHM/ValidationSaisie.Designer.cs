namespace CreerFormulaires
{
    partial class FormValidationSaisie
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textMontant = new System.Windows.Forms.TextBox();
            this.textCodePostal = new System.Windows.Forms.TextBox();
            this.btValider = new System.Windows.Forms.Button();
            this.btEffacer = new System.Windows.Forms.Button();
            this.textDate = new System.Windows.Forms.TextBox();
            this.errorProviderNom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMontant = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCodePostal = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMontant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCodePostal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Montant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Code postal";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(126, 45);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(243, 23);
            this.textName.TabIndex = 4;
            this.textName.Tag = "Nom";
            this.textName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textMontant
            // 
            this.textMontant.Location = new System.Drawing.Point(126, 118);
            this.textMontant.Name = "textMontant";
            this.textMontant.Size = new System.Drawing.Size(243, 23);
            this.textMontant.TabIndex = 6;
            this.textMontant.Tag = "Montant";
            this.textMontant.TextChanged += new System.EventHandler(this.textMontant_TextChanged);
            // 
            // textCodePostal
            // 
            this.textCodePostal.Location = new System.Drawing.Point(126, 162);
            this.textCodePostal.Name = "textCodePostal";
            this.textCodePostal.Size = new System.Drawing.Size(243, 23);
            this.textCodePostal.TabIndex = 7;
            this.textCodePostal.Tag = "Code postal";
            this.textCodePostal.TextChanged += new System.EventHandler(this.textCodePostal_TextChanged);
            // 
            // btValider
            // 
            this.btValider.Enabled = false;
            this.btValider.Location = new System.Drawing.Point(294, 207);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(75, 23);
            this.btValider.TabIndex = 8;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // btEffacer
            // 
            this.btEffacer.Location = new System.Drawing.Point(294, 245);
            this.btEffacer.Name = "btEffacer";
            this.btEffacer.Size = new System.Drawing.Size(75, 23);
            this.btEffacer.TabIndex = 9;
            this.btEffacer.Text = "Effacer";
            this.btEffacer.UseVisualStyleBackColor = true;
            this.btEffacer.Click += new System.EventHandler(this.btEffacer_Click);
            // 
            // textDate
            // 
            this.textDate.Location = new System.Drawing.Point(126, 81);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(243, 23);
            this.textDate.TabIndex = 5;
            this.textDate.Tag = "Date";
            this.textDate.TextChanged += new System.EventHandler(this.textDate_TextChanged);
            // 
            // errorProviderNom
            // 
            this.errorProviderNom.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderNom.ContainerControl = this;
            // 
            // errorProviderDate
            // 
            this.errorProviderDate.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderDate.ContainerControl = this;
            // 
            // errorProviderMontant
            // 
            this.errorProviderMontant.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderMontant.ContainerControl = this;
            // 
            // errorProviderCodePostal
            // 
            this.errorProviderCodePostal.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderCodePostal.ContainerControl = this;
            // 
            // FormValidationSaisie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 285);
            this.Controls.Add(this.textDate);
            this.Controls.Add(this.btEffacer);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.textCodePostal);
            this.Controls.Add(this.textMontant);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormValidationSaisie";
            this.Text = "Validation Saisie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMontant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCodePostal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textName;
        private TextBox textMontant;
        private TextBox textCodePostal;
        private Button btValider;
        private Button btEffacer;
        private TextBox textDate;
        private ErrorProvider errorProviderNom;
        private ErrorProvider errorProviderDate;
        private ErrorProvider errorProviderMontant;
        private ErrorProvider errorProviderCodePostal;
    }
}