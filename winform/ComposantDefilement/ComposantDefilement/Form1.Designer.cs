namespace ComposantDefilement
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hScrollBarBlue = new System.Windows.Forms.HScrollBar();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelColor = new System.Windows.Forms.Panel();
            this.hScrollBarRed = new System.Windows.Forms.HScrollBar();
            this.hScrollBarGreen = new System.Windows.Forms.HScrollBar();
            this.numericUpDownRed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGreen = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBlue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rouge";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vert";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bleu";
            // 
            // hScrollBarBlue
            // 
            this.hScrollBarBlue.LargeChange = 1;
            this.hScrollBarBlue.Location = new System.Drawing.Point(84, 114);
            this.hScrollBarBlue.Maximum = 255;
            this.hScrollBarBlue.Name = "hScrollBarBlue";
            this.hScrollBarBlue.Size = new System.Drawing.Size(240, 25);
            this.hScrollBarBlue.TabIndex = 5;
            this.hScrollBarBlue.Tag = "HSBlue";
            this.hScrollBarBlue.ValueChanged += new System.EventHandler(this.HS_ColorValueChanged);
            // 
            // panelRed
            // 
            this.panelRed.Location = new System.Drawing.Point(444, 21);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(48, 23);
            this.panelRed.TabIndex = 9;
            // 
            // panelGreen
            // 
            this.panelGreen.Location = new System.Drawing.Point(444, 70);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(48, 23);
            this.panelGreen.TabIndex = 10;
            // 
            // panelBlue
            // 
            this.panelBlue.Location = new System.Drawing.Point(444, 114);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(48, 23);
            this.panelBlue.TabIndex = 10;
            // 
            // panelColor
            // 
            this.panelColor.Location = new System.Drawing.Point(15, 175);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(477, 100);
            this.panelColor.TabIndex = 11;
            // 
            // hScrollBarRed
            // 
            this.hScrollBarRed.LargeChange = 1;
            this.hScrollBarRed.Location = new System.Drawing.Point(84, 21);
            this.hScrollBarRed.Maximum = 255;
            this.hScrollBarRed.Name = "hScrollBarRed";
            this.hScrollBarRed.Size = new System.Drawing.Size(240, 25);
            this.hScrollBarRed.TabIndex = 12;
            this.hScrollBarRed.Tag = "HSRed";
            this.hScrollBarRed.ValueChanged += new System.EventHandler(this.HS_ColorValueChanged);
            // 
            // hScrollBarGreen
            // 
            this.hScrollBarGreen.LargeChange = 1;
            this.hScrollBarGreen.Location = new System.Drawing.Point(84, 68);
            this.hScrollBarGreen.Maximum = 255;
            this.hScrollBarGreen.Name = "hScrollBarGreen";
            this.hScrollBarGreen.Size = new System.Drawing.Size(240, 25);
            this.hScrollBarGreen.TabIndex = 13;
            this.hScrollBarGreen.Tag = "HSGreen";
            this.hScrollBarGreen.ValueChanged += new System.EventHandler(this.HS_ColorValueChanged);
            // 
            // numericUpDownRed
            // 
            this.numericUpDownRed.Location = new System.Drawing.Point(349, 18);
            this.numericUpDownRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRed.Name = "numericUpDownRed";
            this.numericUpDownRed.Size = new System.Drawing.Size(89, 23);
            this.numericUpDownRed.TabIndex = 14;
            this.numericUpDownRed.Tag = "NumRed";
            this.numericUpDownRed.ValueChanged += new System.EventHandler(this.NUD_ValueChanged);
            // 
            // numericUpDownGreen
            // 
            this.numericUpDownGreen.Location = new System.Drawing.Point(349, 70);
            this.numericUpDownGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownGreen.Name = "numericUpDownGreen";
            this.numericUpDownGreen.Size = new System.Drawing.Size(89, 23);
            this.numericUpDownGreen.TabIndex = 15;
            this.numericUpDownGreen.Tag = "NumGreen";
            this.numericUpDownGreen.ValueChanged += new System.EventHandler(this.NUD_ValueChanged);
            // 
            // numericUpDownBlue
            // 
            this.numericUpDownBlue.Location = new System.Drawing.Point(349, 114);
            this.numericUpDownBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBlue.Name = "numericUpDownBlue";
            this.numericUpDownBlue.Size = new System.Drawing.Size(89, 23);
            this.numericUpDownBlue.TabIndex = 16;
            this.numericUpDownBlue.Tag = "NumBlue";
            this.numericUpDownBlue.ValueChanged += new System.EventHandler(this.NUD_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 299);
            this.Controls.Add(this.numericUpDownBlue);
            this.Controls.Add(this.numericUpDownGreen);
            this.Controls.Add(this.numericUpDownRed);
            this.Controls.Add(this.hScrollBarGreen);
            this.Controls.Add(this.hScrollBarRed);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.panelBlue);
            this.Controls.Add(this.panelGreen);
            this.Controls.Add(this.panelRed);
            this.Controls.Add(this.hScrollBarBlue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Defilement";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private HScrollBar hScrollBarBlue;
        private Panel panelRed;
        private Panel panelGreen;
        private Panel panelBlue;
        private Panel panelColor;
        private HScrollBar hScrollBarRed;
        private HScrollBar hScrollBarGreen;
        private NumericUpDown numericUpDownRed;
        private NumericUpDown numericUpDownGreen;
        private NumericUpDown numericUpDownBlue;
    }
}