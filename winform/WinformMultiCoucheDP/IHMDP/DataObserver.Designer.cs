namespace IHMDP
{
    partial class DataObserver
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
            this.dataGridViewObserver = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObserver)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewObserver
            // 
            this.dataGridViewObserver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewObserver.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewObserver.Name = "dataGridViewObserver";
            this.dataGridViewObserver.ReadOnly = true;
            this.dataGridViewObserver.RowTemplate.Height = 25;
            this.dataGridViewObserver.Size = new System.Drawing.Size(776, 240);
            this.dataGridViewObserver.TabIndex = 0;
            // 
            // DataObserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 266);
            this.Controls.Add(this.dataGridViewObserver);
            this.Name = "DataObserver";
            this.Text = "DataObserver";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObserver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewObserver;
    }
}