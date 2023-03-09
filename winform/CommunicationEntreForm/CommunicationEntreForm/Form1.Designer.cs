namespace CommunicationEntreForm
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
            this.btEnvoi = new System.Windows.Forms.Button();
            this.textboxInfoSent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btEnvoi
            // 
            this.btEnvoi.Location = new System.Drawing.Point(12, 62);
            this.btEnvoi.Name = "btEnvoi";
            this.btEnvoi.Size = new System.Drawing.Size(75, 23);
            this.btEnvoi.TabIndex = 0;
            this.btEnvoi.Text = "Envoyer";
            this.btEnvoi.UseVisualStyleBackColor = true;
            this.btEnvoi.Click += new System.EventHandler(this.btEnvoi_Click);
            // 
            // textboxInfoSent
            // 
            this.textboxInfoSent.Location = new System.Drawing.Point(12, 12);
            this.textboxInfoSent.Name = "textboxInfoSent";
            this.textboxInfoSent.Size = new System.Drawing.Size(190, 23);
            this.textboxInfoSent.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 106);
            this.Controls.Add(this.textboxInfoSent);
            this.Controls.Add(this.btEnvoi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btEnvoi;
        private TextBox textboxInfoSent;
    }
}