﻿using MonEssai;

namespace WinFormsApp1
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
            this.aUserControl = new MonEssai.AUserControl();
            this.SuspendLayout();
            // 
            // aUserControl
            // 
            this.aUserControl.AllButtonText = "A";
            this.aUserControl.Location = new System.Drawing.Point(101, 42);
            this.aUserControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.aUserControl.Name = "aUserControl";
            this.aUserControl.Size = new System.Drawing.Size(249, 65);
            this.aUserControl.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aUserControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private AUserControl aUserControl;
    }
}