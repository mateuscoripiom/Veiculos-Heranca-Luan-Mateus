﻿namespace ProjetoDsVeiculo
{
    partial class Form1
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
            this.btnsair = new System.Windows.Forms.Button();
            this.btncaminhao = new System.Windows.Forms.Button();
            this.btncarro = new System.Windows.Forms.Button();
            this.lbldupla = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(513, 204);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(148, 43);
            this.btnsair.TabIndex = 8;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btncaminhao
            // 
            this.btncaminhao.Location = new System.Drawing.Point(326, 204);
            this.btncaminhao.Name = "btncaminhao";
            this.btncaminhao.Size = new System.Drawing.Size(148, 43);
            this.btncaminhao.TabIndex = 7;
            this.btncaminhao.Text = "Caminhão";
            this.btncaminhao.UseVisualStyleBackColor = true;
            this.btncaminhao.Click += new System.EventHandler(this.btncaminhao_Click);
            // 
            // btncarro
            // 
            this.btncarro.Location = new System.Drawing.Point(140, 204);
            this.btncarro.Name = "btncarro";
            this.btncarro.Size = new System.Drawing.Size(148, 43);
            this.btncarro.TabIndex = 6;
            this.btncarro.Text = "Carro";
            this.btncarro.UseVisualStyleBackColor = true;
            this.btncarro.Click += new System.EventHandler(this.btncarro_Click);
            // 
            // lbldupla
            // 
            this.lbldupla.AutoSize = true;
            this.lbldupla.Location = new System.Drawing.Point(85, 32);
            this.lbldupla.Name = "lbldupla";
            this.lbldupla.Size = new System.Drawing.Size(182, 13);
            this.lbldupla.TabIndex = 9;
            this.lbldupla.Text = "LUAN HIDEMI E MATEUS CORIPIO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbldupla);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btncaminhao);
            this.Controls.Add(this.btncarro);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btncaminhao;
        private System.Windows.Forms.Button btncarro;
        private System.Windows.Forms.Label lbldupla;
    }
}

