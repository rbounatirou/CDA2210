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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 536);
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
    }
}