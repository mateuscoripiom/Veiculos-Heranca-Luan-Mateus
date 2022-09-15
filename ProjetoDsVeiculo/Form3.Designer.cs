namespace ProjetoDsVeiculo
{
    partial class Form3
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
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.lblcarga = new System.Windows.Forms.Label();
            this.lbleixos = new System.Windows.Forms.Label();
            this.lblcabine = new System.Windows.Forms.Label();
            this.lblporte = new System.Windows.Forms.Label();
            this.lblcambio = new System.Windows.Forms.Label();
            this.lblmodelo = new System.Windows.Forms.Label();
            this.lblcor = new System.Windows.Forms.Label();
            this.lblveiculo = new System.Windows.Forms.Label();
            this.lblmarca = new System.Windows.Forms.Label();
            this.lblmotor = new System.Windows.Forms.Label();
            this.txtcarga = new System.Windows.Forms.TextBox();
            this.txteixos = new System.Windows.Forms.TextBox();
            this.txtcabine = new System.Windows.Forms.TextBox();
            this.txtporte = new System.Windows.Forms.TextBox();
            this.txtcambio = new System.Windows.Forms.TextBox();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.txtcor = new System.Windows.Forms.TextBox();
            this.txtveiculo = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtmotor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(497, 320);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(147, 55);
            this.btnvoltar.TabIndex = 71;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(324, 320);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(147, 55);
            this.btnconsultar.TabIndex = 69;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(153, 320);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(147, 55);
            this.btncadastrar.TabIndex = 68;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // lblcarga
            // 
            this.lblcarga.AutoSize = true;
            this.lblcarga.Location = new System.Drawing.Point(433, 248);
            this.lblcarga.Name = "lblcarga";
            this.lblcarga.Size = new System.Drawing.Size(79, 13);
            this.lblcarga.TabIndex = 67;
            this.lblcarga.Text = "Tipo de carga :";
            // 
            // lbleixos
            // 
            this.lbleixos.AutoSize = true;
            this.lbleixos.Location = new System.Drawing.Point(433, 204);
            this.lbleixos.Name = "lbleixos";
            this.lbleixos.Size = new System.Drawing.Size(92, 13);
            this.lbleixos.TabIndex = 66;
            this.lbleixos.Text = "Número de eixos :";
            // 
            // lblcabine
            // 
            this.lblcabine.AutoSize = true;
            this.lblcabine.Location = new System.Drawing.Point(433, 160);
            this.lblcabine.Name = "lblcabine";
            this.lblcabine.Size = new System.Drawing.Size(84, 13);
            this.lblcabine.TabIndex = 65;
            this.lblcabine.Text = "Tipo de cabine :";
            // 
            // lblporte
            // 
            this.lblporte.AutoSize = true;
            this.lblporte.Location = new System.Drawing.Point(433, 119);
            this.lblporte.Name = "lblporte";
            this.lblporte.Size = new System.Drawing.Size(38, 13);
            this.lblporte.TabIndex = 64;
            this.lblporte.Text = "Porte :";
            // 
            // lblcambio
            // 
            this.lblcambio.AutoSize = true;
            this.lblcambio.Location = new System.Drawing.Point(433, 82);
            this.lblcambio.Name = "lblcambio";
            this.lblcambio.Size = new System.Drawing.Size(86, 13);
            this.lblcambio.TabIndex = 63;
            this.lblcambio.Text = "Tipo de câmbio :";
            // 
            // lblmodelo
            // 
            this.lblmodelo.AutoSize = true;
            this.lblmodelo.Location = new System.Drawing.Point(78, 248);
            this.lblmodelo.Name = "lblmodelo";
            this.lblmodelo.Size = new System.Drawing.Size(48, 13);
            this.lblmodelo.TabIndex = 62;
            this.lblmodelo.Text = "Modelo :";
            // 
            // lblcor
            // 
            this.lblcor.AutoSize = true;
            this.lblcor.Location = new System.Drawing.Point(78, 204);
            this.lblcor.Name = "lblcor";
            this.lblcor.Size = new System.Drawing.Size(29, 13);
            this.lblcor.TabIndex = 61;
            this.lblcor.Text = "Cor :";
            // 
            // lblveiculo
            // 
            this.lblveiculo.AutoSize = true;
            this.lblveiculo.Location = new System.Drawing.Point(78, 160);
            this.lblveiculo.Name = "lblveiculo";
            this.lblveiculo.Size = new System.Drawing.Size(100, 13);
            this.lblveiculo.TabIndex = 60;
            this.lblveiculo.Text = "Código do veículo :";
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Location = new System.Drawing.Point(78, 119);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(43, 13);
            this.lblmarca.TabIndex = 59;
            this.lblmarca.Text = "Marca :";
            // 
            // lblmotor
            // 
            this.lblmotor.AutoSize = true;
            this.lblmotor.Location = new System.Drawing.Point(78, 82);
            this.lblmotor.Name = "lblmotor";
            this.lblmotor.Size = new System.Drawing.Size(78, 13);
            this.lblmotor.TabIndex = 58;
            this.lblmotor.Text = "Tipo de motor :";
            // 
            // txtcarga
            // 
            this.txtcarga.Location = new System.Drawing.Point(575, 244);
            this.txtcarga.Name = "txtcarga";
            this.txtcarga.Size = new System.Drawing.Size(158, 20);
            this.txtcarga.TabIndex = 57;
            // 
            // txteixos
            // 
            this.txteixos.Location = new System.Drawing.Point(575, 200);
            this.txteixos.Name = "txteixos";
            this.txteixos.Size = new System.Drawing.Size(158, 20);
            this.txteixos.TabIndex = 56;
            // 
            // txtcabine
            // 
            this.txtcabine.Location = new System.Drawing.Point(575, 156);
            this.txtcabine.Name = "txtcabine";
            this.txtcabine.Size = new System.Drawing.Size(158, 20);
            this.txtcabine.TabIndex = 55;
            // 
            // txtporte
            // 
            this.txtporte.Location = new System.Drawing.Point(575, 115);
            this.txtporte.Name = "txtporte";
            this.txtporte.Size = new System.Drawing.Size(158, 20);
            this.txtporte.TabIndex = 54;
            // 
            // txtcambio
            // 
            this.txtcambio.Location = new System.Drawing.Point(575, 78);
            this.txtcambio.Name = "txtcambio";
            this.txtcambio.Size = new System.Drawing.Size(158, 20);
            this.txtcambio.TabIndex = 53;
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(198, 244);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(158, 20);
            this.txtmodelo.TabIndex = 52;
            // 
            // txtcor
            // 
            this.txtcor.Location = new System.Drawing.Point(198, 200);
            this.txtcor.Name = "txtcor";
            this.txtcor.Size = new System.Drawing.Size(158, 20);
            this.txtcor.TabIndex = 51;
            // 
            // txtveiculo
            // 
            this.txtveiculo.Location = new System.Drawing.Point(198, 156);
            this.txtveiculo.Name = "txtveiculo";
            this.txtveiculo.Size = new System.Drawing.Size(158, 20);
            this.txtveiculo.TabIndex = 50;
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(198, 115);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(158, 20);
            this.txtmarca.TabIndex = 49;
            // 
            // txtmotor
            // 
            this.txtmotor.Location = new System.Drawing.Point(198, 78);
            this.txtmotor.Name = "txtmotor";
            this.txtmotor.Size = new System.Drawing.Size(158, 20);
            this.txtmotor.TabIndex = 48;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.lblcarga);
            this.Controls.Add(this.lbleixos);
            this.Controls.Add(this.lblcabine);
            this.Controls.Add(this.lblporte);
            this.Controls.Add(this.lblcambio);
            this.Controls.Add(this.lblmodelo);
            this.Controls.Add(this.lblcor);
            this.Controls.Add(this.lblveiculo);
            this.Controls.Add(this.lblmarca);
            this.Controls.Add(this.lblmotor);
            this.Controls.Add(this.txtcarga);
            this.Controls.Add(this.txteixos);
            this.Controls.Add(this.txtcabine);
            this.Controls.Add(this.txtporte);
            this.Controls.Add(this.txtcambio);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.txtcor);
            this.Controls.Add(this.txtveiculo);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.txtmotor);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Caminhão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Label lblcarga;
        private System.Windows.Forms.Label lbleixos;
        private System.Windows.Forms.Label lblcabine;
        private System.Windows.Forms.Label lblporte;
        private System.Windows.Forms.Label lblcambio;
        private System.Windows.Forms.Label lblmodelo;
        private System.Windows.Forms.Label lblcor;
        private System.Windows.Forms.Label lblveiculo;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.Label lblmotor;
        private System.Windows.Forms.TextBox txtcarga;
        private System.Windows.Forms.TextBox txteixos;
        private System.Windows.Forms.TextBox txtcabine;
        private System.Windows.Forms.TextBox txtporte;
        private System.Windows.Forms.TextBox txtcambio;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.TextBox txtcor;
        private System.Windows.Forms.TextBox txtveiculo;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtmotor;
    }
}