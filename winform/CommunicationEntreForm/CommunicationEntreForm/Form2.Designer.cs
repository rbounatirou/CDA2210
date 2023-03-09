namespace CommunicationEntreForm
{
    partial class Form2
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
            this.btOui = new System.Windows.Forms.Button();
            this.btNon = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btOui
            // 
            this.btOui.Location = new System.Drawing.Point(32, 114);
            this.btOui.Name = "btOui";
            this.btOui.Size = new System.Drawing.Size(75, 23);
            this.btOui.TabIndex = 0;
            this.btOui.Text = "Oui";
            this.btOui.UseVisualStyleBackColor = true;
            this.btOui.Click += new System.EventHandler(this.buttonClicked);
            // 
            // btNon
            // 
            this.btNon.Location = new System.Drawing.Point(133, 114);
            this.btNon.Name = "btNon";
            this.btNon.Size = new System.Drawing.Size(75, 23);
            this.btNon.TabIndex = 1;
            this.btNon.Text = "Non";
            this.btNon.UseVisualStyleBackColor = true;
            this.btNon.Click += new System.EventHandler(this.buttonClicked);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(54, 50);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(0, 15);
            this.lblText.TabIndex = 2;
            this.lblText.Click += new System.EventHandler(this.buttonClicked);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 162);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btNon);
            this.Controls.Add(this.btOui);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btOui;
        private Button btNon;
        private Label lblText;
    }
}