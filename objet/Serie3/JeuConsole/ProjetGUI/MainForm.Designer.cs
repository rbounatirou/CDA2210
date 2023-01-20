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
            this.newRoundButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNbRound = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dicePanel
            // 
            this.dicePanel.Location = new System.Drawing.Point(557, 640);
            this.dicePanel.Margin = new System.Windows.Forms.Padding(6);
            this.dicePanel.Name = "dicePanel";
            this.dicePanel.Size = new System.Drawing.Size(613, 226);
            this.dicePanel.TabIndex = 0;
            this.dicePanel.Click += new System.EventHandler(this.dicePanel_Click);
            this.dicePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.dicePanel_Paint);
            // 
            // dicerollButton
            // 
            this.dicerollButton.BackColor = System.Drawing.Color.Red;
            this.dicerollButton.ForeColor = System.Drawing.SystemColors.Control;
            this.dicerollButton.Location = new System.Drawing.Point(559, 525);
            this.dicerollButton.Margin = new System.Windows.Forms.Padding(6);
            this.dicerollButton.Name = "dicerollButton";
            this.dicerollButton.Size = new System.Drawing.Size(613, 96);
            this.dicerollButton.TabIndex = 1;
            this.dicerollButton.Text = "Relancer";
            this.dicerollButton.UseVisualStyleBackColor = false;
            this.dicerollButton.Click += new System.EventHandler(this.DiceRollButton_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(682, 433);
            this.labelScore.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(75, 32);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "score:";
            // 
            // newRoundButton
            // 
            this.newRoundButton.Location = new System.Drawing.Point(121, 525);
            this.newRoundButton.Margin = new System.Windows.Forms.Padding(6);
            this.newRoundButton.Name = "newRoundButton";
            this.newRoundButton.Size = new System.Drawing.Size(286, 96);
            this.newRoundButton.TabIndex = 3;
            this.newRoundButton.Text = "Manche suivante";
            this.newRoundButton.UseVisualStyleBackColor = true;
            this.newRoundButton.Click += new System.EventHandler(this.NewRoundButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 657);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manche actuelle";
            // 
            // lblNbRound
            // 
            this.lblNbRound.AutoSize = true;
            this.lblNbRound.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNbRound.Location = new System.Drawing.Point(191, 772);
            this.lblNbRound.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNbRound.Name = "lblNbRound";
            this.lblNbRound.Size = new System.Drawing.Size(0, 45);
            this.lblNbRound.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 960);
            this.Controls.Add(this.lblNbRound);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newRoundButton);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.dicerollButton);
            this.Controls.Add(this.dicePanel);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel dicePanel;
        private Button dicerollButton;
        private Label labelScore;
        private Button newRoundButton;
        private Label label1;
        private Label lblNbRound;
    }
}