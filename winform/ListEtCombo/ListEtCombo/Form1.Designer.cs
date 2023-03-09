namespace ListEtCombo
{
    partial class Form1
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
            this.comboSource = new System.Windows.Forms.ComboBox();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonAllRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonAllLeft = new System.Windows.Forms.Button();
            this.listBox_Cible = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btUp = new System.Windows.Forms.Button();
            this.btDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboSource
            // 
            this.comboSource.FormattingEnabled = true;
            this.comboSource.Items.AddRange(new object[] {
            "France",
            "Belgique",
            "Bulgarie",
            "Allemagne",
            "Espagne",
            "Japon",
            "Portugal",
            "Grece"});
            this.comboSource.Location = new System.Drawing.Point(19, 41);
            this.comboSource.Name = "comboSource";
            this.comboSource.Size = new System.Drawing.Size(153, 23);
            this.comboSource.TabIndex = 0;
            this.comboSource.DropDown += new System.EventHandler(this.ComboSource_DropDown);
            this.comboSource.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(227, 41);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(57, 23);
            this.buttonRight.TabIndex = 1;
            this.buttonRight.Text = ">";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.BtRight_Click);
            // 
            // buttonAllRight
            // 
            this.buttonAllRight.Location = new System.Drawing.Point(227, 70);
            this.buttonAllRight.Name = "buttonAllRight";
            this.buttonAllRight.Size = new System.Drawing.Size(57, 23);
            this.buttonAllRight.TabIndex = 2;
            this.buttonAllRight.Text = ">>";
            this.buttonAllRight.UseVisualStyleBackColor = true;
            this.buttonAllRight.Click += new System.EventHandler(this.BtAllRight_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Enabled = false;
            this.buttonLeft.Location = new System.Drawing.Point(227, 158);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(57, 23);
            this.buttonLeft.TabIndex = 3;
            this.buttonLeft.Text = "<";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.BtLeft_Click);
            // 
            // buttonAllLeft
            // 
            this.buttonAllLeft.Enabled = false;
            this.buttonAllLeft.Location = new System.Drawing.Point(227, 187);
            this.buttonAllLeft.Name = "buttonAllLeft";
            this.buttonAllLeft.Size = new System.Drawing.Size(57, 23);
            this.buttonAllLeft.TabIndex = 4;
            this.buttonAllLeft.Text = "<<";
            this.buttonAllLeft.UseVisualStyleBackColor = true;
            this.buttonAllLeft.Click += new System.EventHandler(this.BtAllLeft_Click);
            // 
            // listBox_Cible
            // 
            this.listBox_Cible.FormattingEnabled = true;
            this.listBox_Cible.ItemHeight = 15;
            this.listBox_Cible.Location = new System.Drawing.Point(303, 41);
            this.listBox_Cible.Name = "listBox_Cible";
            this.listBox_Cible.Size = new System.Drawing.Size(123, 169);
            this.listBox_Cible.TabIndex = 5;
            this.listBox_Cible.SelectedIndexChanged += new System.EventHandler(this.ListCible_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cible";
            // 
            // btUp
            // 
            this.btUp.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btUp.Location = new System.Drawing.Point(329, 227);
            this.btUp.Name = "btUp";
            this.btUp.Size = new System.Drawing.Size(37, 38);
            this.btUp.TabIndex = 8;
            this.btUp.Text = "↑";
            this.btUp.UseVisualStyleBackColor = true;
            this.btUp.Click += new System.EventHandler(this.BtUp_Click);
            // 
            // btDown
            // 
            this.btDown.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btDown.Location = new System.Drawing.Point(370, 227);
            this.btDown.Name = "btDown";
            this.btDown.Size = new System.Drawing.Size(37, 38);
            this.btDown.TabIndex = 9;
            this.btDown.Text = "↓";
            this.btDown.UseVisualStyleBackColor = true;
            this.btDown.Click += new System.EventHandler(this.BtDown_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 279);
            this.Controls.Add(this.btDown);
            this.Controls.Add(this.btUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Cible);
            this.Controls.Add(this.buttonAllLeft);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonAllRight);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.comboSource);
            this.Name = "Form1";
            this.Text = "Les listes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboSource;
        private Button buttonRight;
        private Button buttonAllRight;
        private Button buttonLeft;
        private Button buttonAllLeft;
        private ListBox listBox_Cible;
        private Label label1;
        private Label label2;
        private Button btUp;
        private Button btDown;
    }
}