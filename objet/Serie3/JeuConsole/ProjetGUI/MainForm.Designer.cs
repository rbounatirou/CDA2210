namespace ProjetGUI
{
    partial class MainForm
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
            this.dicePanel = new System.Windows.Forms.Panel();
            this.dicerollButton = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dicePanel
            // 
            this.dicePanel.Location = new System.Drawing.Point(300, 300);
            this.dicePanel.Name = "dicePanel";
            this.dicePanel.Size = new System.Drawing.Size(330, 106);
            this.dicePanel.TabIndex = 0;
            this.dicePanel.Click += new System.EventHandler(this.dicePanel_Click);
            this.dicePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.dicePanel_Paint);
            // 
            // dicerollButton
            // 
            this.dicerollButton.BackColor = System.Drawing.Color.Red;
            this.dicerollButton.ForeColor = System.Drawing.SystemColors.Control;
            this.dicerollButton.Location = new System.Drawing.Point(301, 246);
            this.dicerollButton.Name = "dicerollButton";
            this.dicerollButton.Size = new System.Drawing.Size(330, 45);
            this.dicerollButton.TabIndex = 1;
            this.dicerollButton.Text = "Relancer";
            this.dicerollButton.UseVisualStyleBackColor = false;
            this.dicerollButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(367, 203);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(38, 15);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "score:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.dicerollButton);
            this.Controls.Add(this.dicePanel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel dicePanel;
        private Button dicerollButton;
        private Label labelScore;
    }
}