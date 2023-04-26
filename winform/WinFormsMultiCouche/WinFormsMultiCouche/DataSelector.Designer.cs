namespace WinFormsMultiCouche
{
    partial class DataSelector
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
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSelect
            // 
            this.dataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelect.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.ReadOnly = true;
            this.dataGridViewSelect.RowTemplate.Height = 25;
            this.dataGridViewSelect.Size = new System.Drawing.Size(652, 240);
            this.dataGridViewSelect.TabIndex = 0;
            // 
            // DataSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 265);
            this.Controls.Add(this.dataGridViewSelect);
            this.Name = "DataSelector";
            this.Text = "DataSelector";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewSelect;
    }
}