﻿namespace WindowsFormsView
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
            this.btnCarregarform1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCarregarform1
            // 
            this.btnCarregarform1.Location = new System.Drawing.Point(23, 32);
            this.btnCarregarform1.Name = "btnCarregarform1";
            this.btnCarregarform1.Size = new System.Drawing.Size(75, 23);
            this.btnCarregarform1.TabIndex = 0;
            this.btnCarregarform1.Text = "Abrir Form 1";
            this.btnCarregarform1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCarregarform1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCarregarform1;
    }
}