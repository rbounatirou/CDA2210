﻿namespace LabyrintheIHM
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
            this.panelLabyrinthe = new System.Windows.Forms.Panel();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.labelSlide = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.btSerialize = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCoordonees = new System.Windows.Forms.RadioButton();
            this.radioButtonPoids = new System.Windows.Forms.RadioButton();
            this.radioButtonAucun = new System.Windows.Forms.RadioButton();
            this.radioButtonDjikstra = new System.Windows.Forms.RadioButton();
            this.radioButtonValeur = new System.Windows.Forms.RadioButton();
            this.numericUpDownDepX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDepY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEndX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEndY = new System.Windows.Forms.NumericUpDown();
            this.groupBoxDjikstra = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChangerDjikstra = new System.Windows.Forms.Button();
            this.groupBoxLabyrinthe = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDownH = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownW = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndY)).BeginInit();
            this.groupBoxDjikstra.SuspendLayout();
            this.groupBoxLabyrinthe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownW)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLabyrinthe
            // 
            this.panelLabyrinthe.Location = new System.Drawing.Point(23, 25);
            this.panelLabyrinthe.Name = "panelLabyrinthe";
            this.panelLabyrinthe.Size = new System.Drawing.Size(400, 400);
            this.panelLabyrinthe.TabIndex = 0;
            this.panelLabyrinthe.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLabyrinthe_Paint);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(13, 514);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(265, 41);
            this.hScrollBar1.TabIndex = 1;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // labelSlide
            // 
            this.labelSlide.AutoSize = true;
            this.labelSlide.Location = new System.Drawing.Point(358, 527);
            this.labelSlide.Name = "labelSlide";
            this.labelSlide.Size = new System.Drawing.Size(13, 15);
            this.labelSlide.TabIndex = 2;
            this.labelSlide.Text = "0";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(13, 561);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(437, 23);
            this.buttonLoad.TabIndex = 3;
            this.buttonLoad.Text = "Load from file";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonCharger_Click);
            // 
            // btSerialize
            // 
            this.btSerialize.Location = new System.Drawing.Point(13, 602);
            this.btSerialize.Name = "btSerialize";
            this.btSerialize.Size = new System.Drawing.Size(437, 53);
            this.btSerialize.TabIndex = 4;
            this.btSerialize.Text = "Serialize labyrinthe";
            this.btSerialize.UseVisualStyleBackColor = true;
            this.btSerialize.Click += new System.EventHandler(this.btSerialize_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonCoordonees);
            this.groupBox1.Controls.Add(this.radioButtonPoids);
            this.groupBox1.Controls.Add(this.radioButtonAucun);
            this.groupBox1.Controls.Add(this.radioButtonDjikstra);
            this.groupBox1.Controls.Add(this.radioButtonValeur);
            this.groupBox1.Location = new System.Drawing.Point(23, 431);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 37);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // radioButtonCoordonees
            // 
            this.radioButtonCoordonees.AutoSize = true;
            this.radioButtonCoordonees.Location = new System.Drawing.Point(321, 12);
            this.radioButtonCoordonees.Name = "radioButtonCoordonees";
            this.radioButtonCoordonees.Size = new System.Drawing.Size(89, 19);
            this.radioButtonCoordonees.TabIndex = 4;
            this.radioButtonCoordonees.TabStop = true;
            this.radioButtonCoordonees.Text = "Coordonees";
            this.radioButtonCoordonees.UseVisualStyleBackColor = true;
            // 
            // radioButtonPoids
            // 
            this.radioButtonPoids.AutoSize = true;
            this.radioButtonPoids.Location = new System.Drawing.Point(227, 12);
            this.radioButtonPoids.Name = "radioButtonPoids";
            this.radioButtonPoids.Size = new System.Drawing.Size(54, 19);
            this.radioButtonPoids.TabIndex = 3;
            this.radioButtonPoids.TabStop = true;
            this.radioButtonPoids.Text = "Poids";
            this.radioButtonPoids.UseVisualStyleBackColor = true;
            this.radioButtonPoids.CheckedChanged += new System.EventHandler(this.radioButtonCheckedChanged);
            // 
            // radioButtonAucun
            // 
            this.radioButtonAucun.AutoSize = true;
            this.radioButtonAucun.Location = new System.Drawing.Point(461, 12);
            this.radioButtonAucun.Name = "radioButtonAucun";
            this.radioButtonAucun.Size = new System.Drawing.Size(60, 19);
            this.radioButtonAucun.TabIndex = 2;
            this.radioButtonAucun.TabStop = true;
            this.radioButtonAucun.Text = "Aucun";
            this.radioButtonAucun.UseVisualStyleBackColor = true;
            this.radioButtonAucun.CheckedChanged += new System.EventHandler(this.radioButtonCheckedChanged);
            // 
            // radioButtonDjikstra
            // 
            this.radioButtonDjikstra.AutoSize = true;
            this.radioButtonDjikstra.Location = new System.Drawing.Point(121, 12);
            this.radioButtonDjikstra.Name = "radioButtonDjikstra";
            this.radioButtonDjikstra.Size = new System.Drawing.Size(64, 19);
            this.radioButtonDjikstra.TabIndex = 1;
            this.radioButtonDjikstra.TabStop = true;
            this.radioButtonDjikstra.Text = "Djikstra";
            this.radioButtonDjikstra.UseVisualStyleBackColor = true;
            this.radioButtonDjikstra.CheckedChanged += new System.EventHandler(this.radioButtonCheckedChanged);
            // 
            // radioButtonValeur
            // 
            this.radioButtonValeur.AutoSize = true;
            this.radioButtonValeur.Location = new System.Drawing.Point(6, 12);
            this.radioButtonValeur.Name = "radioButtonValeur";
            this.radioButtonValeur.Size = new System.Drawing.Size(57, 19);
            this.radioButtonValeur.TabIndex = 0;
            this.radioButtonValeur.TabStop = true;
            this.radioButtonValeur.Text = "Valeur";
            this.radioButtonValeur.UseVisualStyleBackColor = true;
            this.radioButtonValeur.CheckedChanged += new System.EventHandler(this.radioButtonCheckedChanged);
            // 
            // numericUpDownDepX
            // 
            this.numericUpDownDepX.Location = new System.Drawing.Point(63, 69);
            this.numericUpDownDepX.Name = "numericUpDownDepX";
            this.numericUpDownDepX.Size = new System.Drawing.Size(62, 23);
            this.numericUpDownDepX.TabIndex = 6;
            // 
            // numericUpDownDepY
            // 
            this.numericUpDownDepY.Location = new System.Drawing.Point(143, 69);
            this.numericUpDownDepY.Name = "numericUpDownDepY";
            this.numericUpDownDepY.Size = new System.Drawing.Size(65, 23);
            this.numericUpDownDepY.TabIndex = 7;
            // 
            // numericUpDownEndX
            // 
            this.numericUpDownEndX.Location = new System.Drawing.Point(63, 108);
            this.numericUpDownEndX.Name = "numericUpDownEndX";
            this.numericUpDownEndX.Size = new System.Drawing.Size(62, 23);
            this.numericUpDownEndX.TabIndex = 8;
            // 
            // numericUpDownEndY
            // 
            this.numericUpDownEndY.Location = new System.Drawing.Point(143, 108);
            this.numericUpDownEndY.Name = "numericUpDownEndY";
            this.numericUpDownEndY.Size = new System.Drawing.Size(65, 23);
            this.numericUpDownEndY.TabIndex = 9;
            // 
            // groupBoxDjikstra
            // 
            this.groupBoxDjikstra.Controls.Add(this.label4);
            this.groupBoxDjikstra.Controls.Add(this.label3);
            this.groupBoxDjikstra.Controls.Add(this.label2);
            this.groupBoxDjikstra.Controls.Add(this.label1);
            this.groupBoxDjikstra.Controls.Add(this.buttonChangerDjikstra);
            this.groupBoxDjikstra.Controls.Add(this.numericUpDownEndY);
            this.groupBoxDjikstra.Controls.Add(this.numericUpDownDepX);
            this.groupBoxDjikstra.Controls.Add(this.numericUpDownEndX);
            this.groupBoxDjikstra.Controls.Add(this.numericUpDownDepY);
            this.groupBoxDjikstra.Location = new System.Drawing.Point(493, 484);
            this.groupBoxDjikstra.Name = "groupBoxDjikstra";
            this.groupBoxDjikstra.Size = new System.Drawing.Size(214, 177);
            this.groupBoxDjikstra.TabIndex = 10;
            this.groupBoxDjikstra.TabStop = false;
            this.groupBoxDjikstra.Text = "Djikstra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Arrive";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Depart";
            // 
            // buttonChangerDjikstra
            // 
            this.buttonChangerDjikstra.Location = new System.Drawing.Point(63, 141);
            this.buttonChangerDjikstra.Name = "buttonChangerDjikstra";
            this.buttonChangerDjikstra.Size = new System.Drawing.Size(145, 30);
            this.buttonChangerDjikstra.TabIndex = 10;
            this.buttonChangerDjikstra.Text = "Changer";
            this.buttonChangerDjikstra.UseVisualStyleBackColor = true;
            this.buttonChangerDjikstra.Click += new System.EventHandler(this.buttonChangerDjikstra_Click);
            // 
            // groupBoxLabyrinthe
            // 
            this.groupBoxLabyrinthe.Controls.Add(this.label6);
            this.groupBoxLabyrinthe.Controls.Add(this.label5);
            this.groupBoxLabyrinthe.Controls.Add(this.button1);
            this.groupBoxLabyrinthe.Controls.Add(this.numericUpDownH);
            this.groupBoxLabyrinthe.Controls.Add(this.numericUpDownW);
            this.groupBoxLabyrinthe.Location = new System.Drawing.Point(442, 319);
            this.groupBoxLabyrinthe.Name = "groupBoxLabyrinthe";
            this.groupBoxLabyrinthe.Size = new System.Drawing.Size(259, 106);
            this.groupBoxLabyrinthe.TabIndex = 11;
            this.groupBoxLabyrinthe.TabStop = false;
            this.groupBoxLabyrinthe.Text = "Ajouter Labyrinthe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "H";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "W";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDownH
            // 
            this.numericUpDownH.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownH.Location = new System.Drawing.Point(161, 35);
            this.numericUpDownH.Maximum = new decimal(new int[] {
            51,
            0,
            0,
            0});
            this.numericUpDownH.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownH.Name = "numericUpDownH";
            this.numericUpDownH.Size = new System.Drawing.Size(62, 23);
            this.numericUpDownH.TabIndex = 1;
            this.numericUpDownH.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDownW
            // 
            this.numericUpDownW.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownW.Location = new System.Drawing.Point(64, 35);
            this.numericUpDownW.Maximum = new decimal(new int[] {
            51,
            0,
            0,
            0});
            this.numericUpDownW.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownW.Name = "numericUpDownW";
            this.numericUpDownW.Size = new System.Drawing.Size(67, 23);
            this.numericUpDownW.TabIndex = 0;
            this.numericUpDownW.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 673);
            this.Controls.Add(this.groupBoxLabyrinthe);
            this.Controls.Add(this.groupBoxDjikstra);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btSerialize);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.labelSlide);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.panelLabyrinthe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndY)).EndInit();
            this.groupBoxDjikstra.ResumeLayout(false);
            this.groupBoxDjikstra.PerformLayout();
            this.groupBoxLabyrinthe.ResumeLayout(false);
            this.groupBoxLabyrinthe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelLabyrinthe;
        private HScrollBar hScrollBar1;
        private Label labelSlide;
        private Button buttonLoad;
        private Button btSerialize;
        private GroupBox groupBox1;
        private RadioButton radioButtonAucun;
        private RadioButton radioButtonDjikstra;
        private RadioButton radioButtonValeur;
        private RadioButton radioButtonPoids;
        private NumericUpDown numericUpDownDepX;
        private NumericUpDown numericUpDownDepY;
        private NumericUpDown numericUpDownEndX;
        private NumericUpDown numericUpDownEndY;
        private GroupBox groupBoxDjikstra;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonChangerDjikstra;
        private RadioButton radioButtonCoordonees;
        private GroupBox groupBoxLabyrinthe;
        private Label label6;
        private Label label5;
        private Button button1;
        private NumericUpDown numericUpDownH;
        private NumericUpDown numericUpDownW;
    }
}