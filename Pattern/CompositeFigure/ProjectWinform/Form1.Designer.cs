namespace ProjectWinform
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
            buttonDraw = new Button();
            panelDessiner = new Panel();
            SuspendLayout();
            // 
            // buttonDraw
            // 
            buttonDraw.Location = new Point(12, 12);
            buttonDraw.Name = "buttonDraw";
            buttonDraw.Size = new Size(326, 54);
            buttonDraw.TabIndex = 0;
            buttonDraw.Text = "Dessiner";
            buttonDraw.UseVisualStyleBackColor = true;
            buttonDraw.Click += buttonDraw_Click;
            // 
            // panelDessiner
            // 
            panelDessiner.Location = new Point(362, 12);
            panelDessiner.Name = "panelDessiner";
            panelDessiner.Size = new Size(408, 426);
            panelDessiner.TabIndex = 1;
            panelDessiner.Paint += panelDessiner_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelDessiner);
            Controls.Add(buttonDraw);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDraw;
        private Panel panelDessiner;
    }
}