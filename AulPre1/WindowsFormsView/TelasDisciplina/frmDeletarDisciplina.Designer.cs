﻿namespace WindowsFormsView.TelasDisciplina
{
    partial class frmDeletarDisciplina
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
            this.txtDeletarDisciplina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeletarDisciplina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDeletarDisciplina
            // 
            this.txtDeletarDisciplina.Location = new System.Drawing.Point(164, 28);
            this.txtDeletarDisciplina.Name = "txtDeletarDisciplina";
            this.txtDeletarDisciplina.Size = new System.Drawing.Size(100, 20);
            this.txtDeletarDisciplina.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Digite o ID da Disciplina ->";
            // 
            // btnDeletarDisciplina
            // 
            this.btnDeletarDisciplina.Location = new System.Drawing.Point(124, 70);
            this.btnDeletarDisciplina.Name = "btnDeletarDisciplina";
            this.btnDeletarDisciplina.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarDisciplina.TabIndex = 6;
            this.btnDeletarDisciplina.Text = "Deletar";
            this.btnDeletarDisciplina.UseVisualStyleBackColor = true;
            this.btnDeletarDisciplina.Click += new System.EventHandler(this.btnDeletarDisciplina_Click);
            // 
            // frmDeletarDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 113);
            this.Controls.Add(this.txtDeletarDisciplina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeletarDisciplina);
            this.Name = "frmDeletarDisciplina";
            this.Text = "frmDeletarDisciplina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeletarDisciplina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeletarDisciplina;
    }
}