namespace WinformCities
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
            this.dataGridViewCities = new System.Windows.Forms.DataGridView();
            this.btnAjouterCities = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCities)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCities
            // 
            this.dataGridViewCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCities.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewCities.Name = "dataGridViewCities";
            this.dataGridViewCities.RowTemplate.Height = 25;
            this.dataGridViewCities.Size = new System.Drawing.Size(414, 233);
            this.dataGridViewCities.TabIndex = 0;
            // 
            // btnAjouterCities
            // 
            this.btnAjouterCities.Location = new System.Drawing.Point(470, 12);
            this.btnAjouterCities.Name = "btnAjouterCities";
            this.btnAjouterCities.Size = new System.Drawing.Size(152, 23);
            this.btnAjouterCities.TabIndex = 1;
            this.btnAjouterCities.Text = "Ajouter cities";
            this.btnAjouterCities.UseVisualStyleBackColor = true;
            this.btnAjouterCities.Click += new System.EventHandler(this.btnAjouterCities_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAjouterCities);
            this.Controls.Add(this.dataGridViewCities);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCities)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewCities;
        private Button btnAjouterCities;
    }
}