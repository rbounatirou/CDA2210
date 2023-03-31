namespace ClientForm
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
            this.richTextBoxReception = new System.Windows.Forms.RichTextBox();
            this.buttonEnvoi = new System.Windows.Forms.Button();
            this.textBoxEnvoi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBoxReception
            // 
            this.richTextBoxReception.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxReception.Name = "richTextBoxReception";
            this.richTextBoxReception.Size = new System.Drawing.Size(569, 427);
            this.richTextBoxReception.TabIndex = 0;
            this.richTextBoxReception.Text = "";
            // 
            // buttonEnvoi
            // 
            this.buttonEnvoi.Location = new System.Drawing.Point(445, 445);
            this.buttonEnvoi.Name = "buttonEnvoi";
            this.buttonEnvoi.Size = new System.Drawing.Size(136, 23);
            this.buttonEnvoi.TabIndex = 1;
            this.buttonEnvoi.Text = "button1";
            this.buttonEnvoi.UseVisualStyleBackColor = true;
            this.buttonEnvoi.Click += new System.EventHandler(this.buttonEnvoi_Click);
            // 
            // textBoxEnvoi
            // 
            this.textBoxEnvoi.Location = new System.Drawing.Point(12, 445);
            this.textBoxEnvoi.Name = "textBoxEnvoi";
            this.textBoxEnvoi.Size = new System.Drawing.Size(417, 23);
            this.textBoxEnvoi.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 488);
            this.Controls.Add(this.textBoxEnvoi);
            this.Controls.Add(this.buttonEnvoi);
            this.Controls.Add(this.richTextBoxReception);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBoxReception;
        private Button buttonEnvoi;
        private TextBox textBoxEnvoi;
    }
}