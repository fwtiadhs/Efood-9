﻿namespace MrDelivery
{
    partial class Comm4
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
            this.epiklbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // epiklbl
            // 
            this.epiklbl.AutoSize = true;
            this.epiklbl.Location = new System.Drawing.Point(43, 26);
            this.epiklbl.Name = "epiklbl";
            this.epiklbl.Size = new System.Drawing.Size(35, 13);
            this.epiklbl.TabIndex = 0;
            this.epiklbl.Text = "label1";
            this.epiklbl.Click += new System.EventHandler(this.epiklbl_Click);
            // 
            // Comm4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 111);
            this.Controls.Add(this.epiklbl);
            this.Name = "Comm4";
            this.Text = "Comm4";
            this.Load += new System.EventHandler(this.Comm4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label epiklbl;
    }
}