namespace UserControlProduction
{
    partial class UserControlProductionInteraction
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btStart = new Button();
            btRestart = new Button();
            btStop = new Button();
            SuspendLayout();
            // 
            // btStart
            // 
            btStart.BackgroundImage = Properties.Resources.vert;
            btStart.BackgroundImageLayout = ImageLayout.Stretch;
            btStart.Dock = DockStyle.Left;
            btStart.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btStart.ForeColor = Color.Red;
            btStart.Location = new Point(10, 10);
            btStart.Name = "btStart";
            btStart.Size = new Size(90, 180);
            btStart.TabIndex = 1;
            btStart.TextAlign = ContentAlignment.BottomCenter;
            btStart.UseVisualStyleBackColor = true;
            btStart.Click += btStart_Click;
            // 
            // btRestart
            // 
            btRestart.BackgroundImage = Properties.Resources.rouge;
            btRestart.BackgroundImageLayout = ImageLayout.Stretch;
            btRestart.Dock = DockStyle.Right;
            btRestart.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btRestart.ForeColor = Color.Red;
            btRestart.Location = new Point(190, 10);
            btRestart.Name = "btRestart";
            btRestart.Size = new Size(90, 180);
            btRestart.TabIndex = 3;
            btRestart.TextAlign = ContentAlignment.BottomCenter;
            btRestart.UseVisualStyleBackColor = true;
            btRestart.Click += btRestart_Click;
            // 
            // btStop
            // 
            btStop.BackgroundImage = Properties.Resources.orange;
            btStop.BackgroundImageLayout = ImageLayout.Stretch;
            btStop.Dock = DockStyle.Left;
            btStop.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btStop.ForeColor = Color.Red;
            btStop.Location = new Point(100, 10);
            btStop.Name = "btStop";
            btStop.Size = new Size(90, 180);
            btStop.TabIndex = 2;
            btStop.TextAlign = ContentAlignment.BottomCenter;
            btStop.UseVisualStyleBackColor = true;
            btStop.Click += btStop_Click;
            // 
            // UserControlProductionInteraction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btStop);
            Controls.Add(btRestart);
            Controls.Add(btStart);
            Name = "UserControlProductionInteraction";
            Padding = new Padding(10);
            Size = new Size(290, 200);
            Resize += OnResize;
            ResumeLayout(false);
        }

        #endregion

        private Button btStart;
        private Button btRestart;
        private Button btStop;
    }
}