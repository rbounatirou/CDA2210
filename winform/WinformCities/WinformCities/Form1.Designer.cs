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
            this.textBoxConsole = new System.Windows.Forms.TextBox();
            this.dataGridViewCountries = new System.Windows.Forms.DataGridView();
            this.buttonRetirerCountry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).BeginInit();
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
            this.dataGridViewCities.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewCities_CellBeginEdit);
            this.dataGridViewCities.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridViewCities_KeyPress);
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
            // textBoxConsole
            // 
            this.textBoxConsole.Location = new System.Drawing.Point(12, 251);
            this.textBoxConsole.Multiline = true;
            this.textBoxConsole.Name = "textBoxConsole";
            this.textBoxConsole.Size = new System.Drawing.Size(414, 187);
            this.textBoxConsole.TabIndex = 2;
            // 
            // dataGridViewCountries
            // 
            this.dataGridViewCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCountries.Location = new System.Drawing.Point(455, 41);
            this.dataGridViewCountries.Name = "dataGridViewCountries";
            this.dataGridViewCountries.RowTemplate.Height = 25;
            this.dataGridViewCountries.Size = new System.Drawing.Size(317, 211);
            this.dataGridViewCountries.TabIndex = 3;
            // 
            // buttonRetirerCountry
            // 
            this.buttonRetirerCountry.Location = new System.Drawing.Point(470, 281);
            this.buttonRetirerCountry.Name = "buttonRetirerCountry";
            this.buttonRetirerCountry.Size = new System.Drawing.Size(152, 23);
            this.buttonRetirerCountry.TabIndex = 4;
            this.buttonRetirerCountry.Text = "Retirer countie";
            this.buttonRetirerCountry.UseVisualStyleBackColor = true;
            this.buttonRetirerCountry.Click += new System.EventHandler(this.buttonRetirerCountry_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRetirerCountry);
            this.Controls.Add(this.dataGridViewCountries);
            this.Controls.Add(this.textBoxConsole);
            this.Controls.Add(this.btnAjouterCities);
            this.Controls.Add(this.dataGridViewCities);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewCities;
        private Button btnAjouterCities;
        private TextBox textBoxConsole;
        private DataGridView dataGridViewCountries;
        private Button buttonRetirerCountry;
    }
}