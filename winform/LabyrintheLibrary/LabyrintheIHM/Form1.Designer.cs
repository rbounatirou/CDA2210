namespace LabyrintheIHM
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
            this.buttonBitmap = new System.Windows.Forms.Button();
            this.btSerialize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelLabyrinthe
            // 
            this.panelLabyrinthe.Location = new System.Drawing.Point(12, 12);
            this.panelLabyrinthe.Name = "panelLabyrinthe";
            this.panelLabyrinthe.Size = new System.Drawing.Size(448, 413);
            this.panelLabyrinthe.TabIndex = 0;
            this.panelLabyrinthe.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLabyrinthe_Paint);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(23, 458);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(265, 41);
            this.hScrollBar1.TabIndex = 1;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // labelSlide
            // 
            this.labelSlide.AutoSize = true;
            this.labelSlide.Location = new System.Drawing.Point(338, 484);
            this.labelSlide.Name = "labelSlide";
            this.labelSlide.Size = new System.Drawing.Size(38, 15);
            this.labelSlide.TabIndex = 2;
            this.labelSlide.Text = "label1";
            // 
            // buttonBitmap
            // 
            this.buttonBitmap.Location = new System.Drawing.Point(23, 531);
            this.buttonBitmap.Name = "buttonBitmap";
            this.buttonBitmap.Size = new System.Drawing.Size(437, 23);
            this.buttonBitmap.TabIndex = 3;
            this.buttonBitmap.Text = "Save as bitmap";
            this.buttonBitmap.UseVisualStyleBackColor = true;
            this.buttonBitmap.Click += new System.EventHandler(this.buttonBitmap_Click);
            // 
            // btSerialize
            // 
            this.btSerialize.Location = new System.Drawing.Point(23, 572);
            this.btSerialize.Name = "btSerialize";
            this.btSerialize.Size = new System.Drawing.Size(437, 53);
            this.btSerialize.TabIndex = 4;
            this.btSerialize.Text = "Serialize labyrinthe";
            this.btSerialize.UseVisualStyleBackColor = true;
            this.btSerialize.Click += new System.EventHandler(this.btSerialize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 637);
            this.Controls.Add(this.btSerialize);
            this.Controls.Add(this.buttonBitmap);
            this.Controls.Add(this.labelSlide);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.panelLabyrinthe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelLabyrinthe;
        private HScrollBar hScrollBar1;
        private Label labelSlide;
        private Button buttonBitmap;
        private Button btSerialize;
    }
}