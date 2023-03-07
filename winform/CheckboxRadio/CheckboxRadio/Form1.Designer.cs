﻿namespace CheckboxRadio
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_input = new System.Windows.Forms.TextBox();
            this.groupBox_choix = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox_bg = new System.Windows.Forms.GroupBox();
            this.rd_bg_Bleu = new System.Windows.Forms.RadioButton();
            this.rd_bg_Vert = new System.Windows.Forms.RadioButton();
            this.rd_bg_Rouge = new System.Windows.Forms.RadioButton();
            this.lbl_result = new System.Windows.Forms.Label();
            this.groupBox_case = new System.Windows.Forms.GroupBox();
            this.rd_case_upper = new System.Windows.Forms.RadioButton();
            this.rd_case_lower = new System.Windows.Forms.RadioButton();
            this.groupBox_font = new System.Windows.Forms.GroupBox();
            this.rd_font_blanc = new System.Windows.Forms.RadioButton();
            this.rd_font_noir = new System.Windows.Forms.RadioButton();
            this.rd_font_rouge = new System.Windows.Forms.RadioButton();
            this.groupBox_choix.SuspendLayout();
            this.groupBox_bg.SuspendLayout();
            this.groupBox_case.SuspendLayout();
            this.groupBox_font.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tapez votre texte";
            // 
            // txtbox_input
            // 
            this.txtbox_input.Location = new System.Drawing.Point(32, 45);
            this.txtbox_input.Name = "txtbox_input";
            this.txtbox_input.Size = new System.Drawing.Size(248, 23);
            this.txtbox_input.TabIndex = 1;
            this.txtbox_input.TextChanged += new System.EventHandler(this.textbox_input);
            // 
            // groupBox_choix
            // 
            this.groupBox_choix.Controls.Add(this.checkBox3);
            this.groupBox_choix.Controls.Add(this.checkBox2);
            this.groupBox_choix.Controls.Add(this.checkBox1);
            this.groupBox_choix.Enabled = false;
            this.groupBox_choix.Location = new System.Drawing.Point(310, 27);
            this.groupBox_choix.Name = "groupBox_choix";
            this.groupBox_choix.Size = new System.Drawing.Size(200, 111);
            this.groupBox_choix.TabIndex = 2;
            this.groupBox_choix.TabStop = false;
            this.groupBox_choix.Text = "Choix";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(20, 79);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(56, 19);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Casse";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(20, 54);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(145, 19);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Couleur des caractères";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(20, 29);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Couleur du fond";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox_bg
            // 
            this.groupBox_bg.Controls.Add(this.rd_bg_Bleu);
            this.groupBox_bg.Controls.Add(this.rd_bg_Vert);
            this.groupBox_bg.Controls.Add(this.rd_bg_Rouge);
            this.groupBox_bg.Location = new System.Drawing.Point(32, 219);
            this.groupBox_bg.Name = "groupBox_bg";
            this.groupBox_bg.Size = new System.Drawing.Size(95, 100);
            this.groupBox_bg.TabIndex = 3;
            this.groupBox_bg.TabStop = false;
            this.groupBox_bg.Text = "Fond";
            this.groupBox_bg.Visible = false;
            // 
            // rd_bg_Bleu
            // 
            this.rd_bg_Bleu.AutoSize = true;
            this.rd_bg_Bleu.Location = new System.Drawing.Point(6, 72);
            this.rd_bg_Bleu.Name = "rd_bg_Bleu";
            this.rd_bg_Bleu.Size = new System.Drawing.Size(48, 19);
            this.rd_bg_Bleu.TabIndex = 7;
            this.rd_bg_Bleu.Tag = "BgBleu";
            this.rd_bg_Bleu.Text = "Bleu";
            this.rd_bg_Bleu.UseVisualStyleBackColor = true;
            // 
            // rd_bg_Vert
            // 
            this.rd_bg_Vert.AutoSize = true;
            this.rd_bg_Vert.Location = new System.Drawing.Point(6, 47);
            this.rd_bg_Vert.Name = "rd_bg_Vert";
            this.rd_bg_Vert.Size = new System.Drawing.Size(45, 19);
            this.rd_bg_Vert.TabIndex = 6;
            this.rd_bg_Vert.Tag = "BgVert";
            this.rd_bg_Vert.Text = "Vert";
            this.rd_bg_Vert.UseVisualStyleBackColor = true;
            // 
            // rd_bg_Rouge
            // 
            this.rd_bg_Rouge.AutoSize = true;
            this.rd_bg_Rouge.Checked = true;
            this.rd_bg_Rouge.Location = new System.Drawing.Point(6, 22);
            this.rd_bg_Rouge.Name = "rd_bg_Rouge";
            this.rd_bg_Rouge.Size = new System.Drawing.Size(59, 19);
            this.rd_bg_Rouge.TabIndex = 5;
            this.rd_bg_Rouge.TabStop = true;
            this.rd_bg_Rouge.Tag = "BgRouge";
            this.rd_bg_Rouge.Text = "Rouge";
            this.rd_bg_Rouge.UseVisualStyleBackColor = true;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(32, 172);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(38, 15);
            this.lbl_result.TabIndex = 4;
            this.lbl_result.Text = "label2";
            this.lbl_result.Visible = false;
            // 
            // groupBox_case
            // 
            this.groupBox_case.Controls.Add(this.rd_case_upper);
            this.groupBox_case.Controls.Add(this.rd_case_lower);
            this.groupBox_case.Location = new System.Drawing.Point(275, 241);
            this.groupBox_case.Name = "groupBox_case";
            this.groupBox_case.Size = new System.Drawing.Size(200, 76);
            this.groupBox_case.TabIndex = 6;
            this.groupBox_case.TabStop = false;
            this.groupBox_case.Text = "Casse";
            this.groupBox_case.Visible = false;
            // 
            // rd_case_upper
            // 
            this.rd_case_upper.AutoSize = true;
            this.rd_case_upper.Location = new System.Drawing.Point(14, 47);
            this.rd_case_upper.Name = "rd_case_upper";
            this.rd_case_upper.Size = new System.Drawing.Size(84, 19);
            this.rd_case_upper.TabIndex = 1;
            this.rd_case_upper.Tag = "CaseUpper";
            this.rd_case_upper.Text = "Majuscules";
            this.rd_case_upper.UseVisualStyleBackColor = true;
            // 
            // rd_case_lower
            // 
            this.rd_case_lower.AutoSize = true;
            this.rd_case_lower.Checked = true;
            this.rd_case_lower.Location = new System.Drawing.Point(13, 22);
            this.rd_case_lower.Name = "rd_case_lower";
            this.rd_case_lower.Size = new System.Drawing.Size(85, 19);
            this.rd_case_lower.TabIndex = 0;
            this.rd_case_lower.TabStop = true;
            this.rd_case_lower.Tag = "CaseLower";
            this.rd_case_lower.Text = "Minuscules";
            this.rd_case_lower.UseVisualStyleBackColor = true;
            // 
            // groupBox_font
            // 
            this.groupBox_font.Controls.Add(this.rd_font_blanc);
            this.groupBox_font.Controls.Add(this.rd_font_noir);
            this.groupBox_font.Controls.Add(this.rd_font_rouge);
            this.groupBox_font.Location = new System.Drawing.Point(158, 219);
            this.groupBox_font.Name = "groupBox_font";
            this.groupBox_font.Size = new System.Drawing.Size(95, 100);
            this.groupBox_font.TabIndex = 7;
            this.groupBox_font.TabStop = false;
            this.groupBox_font.Text = "Caractères";
            this.groupBox_font.Visible = false;
            // 
            // rd_font_blanc
            // 
            this.rd_font_blanc.AutoSize = true;
            this.rd_font_blanc.Location = new System.Drawing.Point(6, 47);
            this.rd_font_blanc.Name = "rd_font_blanc";
            this.rd_font_blanc.Size = new System.Drawing.Size(54, 19);
            this.rd_font_blanc.TabIndex = 6;
            this.rd_font_blanc.Tag = "FontBlanc";
            this.rd_font_blanc.Text = "Blanc";
            this.rd_font_blanc.UseVisualStyleBackColor = true;
            // 
            // rd_font_noir
            // 
            this.rd_font_noir.AutoSize = true;
            this.rd_font_noir.Location = new System.Drawing.Point(6, 72);
            this.rd_font_noir.Name = "rd_font_noir";
            this.rd_font_noir.Size = new System.Drawing.Size(48, 19);
            this.rd_font_noir.TabIndex = 7;
            this.rd_font_noir.Tag = "FontNoir";
            this.rd_font_noir.Text = "Noir";
            this.rd_font_noir.UseVisualStyleBackColor = true;
            // 
            // rd_font_rouge
            // 
            this.rd_font_rouge.AutoSize = true;
            this.rd_font_rouge.Checked = true;
            this.rd_font_rouge.Location = new System.Drawing.Point(6, 22);
            this.rd_font_rouge.Name = "rd_font_rouge";
            this.rd_font_rouge.Size = new System.Drawing.Size(59, 19);
            this.rd_font_rouge.TabIndex = 5;
            this.rd_font_rouge.TabStop = true;
            this.rd_font_rouge.Tag = "FontRouge";
            this.rd_font_rouge.Text = "Rouge";
            this.rd_font_rouge.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 327);
            this.Controls.Add(this.groupBox_font);
            this.Controls.Add(this.groupBox_case);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.groupBox_bg);
            this.Controls.Add(this.groupBox_choix);
            this.Controls.Add(this.txtbox_input);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Tag = "";
            this.Text = "CheckBox et RadioButton";
            this.groupBox_choix.ResumeLayout(false);
            this.groupBox_choix.PerformLayout();
            this.groupBox_bg.ResumeLayout(false);
            this.groupBox_bg.PerformLayout();
            this.groupBox_case.ResumeLayout(false);
            this.groupBox_case.PerformLayout();
            this.groupBox_font.ResumeLayout(false);
            this.groupBox_font.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtbox_input;
        private GroupBox groupBox_choix;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private GroupBox groupBox_bg;
        private RadioButton rd_bg_Bleu;
        private RadioButton rd_bg_Vert;
        private RadioButton rd_bg_Rouge;
        private Label lbl_result;
        private GroupBox groupBox_case;
        private RadioButton rd_case_upper;
        private RadioButton rd_case_lower;
        private GroupBox groupBox_font;
        private RadioButton rd_font_blanc;
        private RadioButton rd_font_noir;
        private RadioButton rd_font_rouge;
    }
}