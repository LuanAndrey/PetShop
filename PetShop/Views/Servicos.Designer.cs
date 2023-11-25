namespace PetShop
{
    partial class Servicos
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
            this.grbPorte = new System.Windows.Forms.GroupBox();
            this.rdbGrande = new System.Windows.Forms.RadioButton();
            this.rdbMedio = new System.Windows.Forms.RadioButton();
            this.rdbPequeno = new System.Windows.Forms.RadioButton();
            this.grbServico = new System.Windows.Forms.GroupBox();
            this.rdbCombo = new System.Windows.Forms.RadioButton();
            this.rdbTosa = new System.Windows.Forms.RadioButton();
            this.rdbBanho = new System.Windows.Forms.RadioButton();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.grbPorte.SuspendLayout();
            this.grbServico.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPorte
            // 
            this.grbPorte.Controls.Add(this.rdbGrande);
            this.grbPorte.Controls.Add(this.rdbMedio);
            this.grbPorte.Controls.Add(this.rdbPequeno);
            this.grbPorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPorte.Location = new System.Drawing.Point(149, 40);
            this.grbPorte.Name = "grbPorte";
            this.grbPorte.Size = new System.Drawing.Size(200, 100);
            this.grbPorte.TabIndex = 0;
            this.grbPorte.TabStop = false;
            this.grbPorte.Text = "Porte";
            // 
            // rdbGrande
            // 
            this.rdbGrande.AutoSize = true;
            this.rdbGrande.Location = new System.Drawing.Point(7, 69);
            this.rdbGrande.Name = "rdbGrande";
            this.rdbGrande.Size = new System.Drawing.Size(81, 24);
            this.rdbGrande.TabIndex = 2;
            this.rdbGrande.TabStop = true;
            this.rdbGrande.Text = "Grande";
            this.rdbGrande.UseVisualStyleBackColor = true;
            this.rdbGrande.CheckedChanged += new System.EventHandler(this.rdbGrande_CheckedChanged);
            // 
            // rdbMedio
            // 
            this.rdbMedio.AutoSize = true;
            this.rdbMedio.Location = new System.Drawing.Point(6, 45);
            this.rdbMedio.Name = "rdbMedio";
            this.rdbMedio.Size = new System.Drawing.Size(70, 24);
            this.rdbMedio.TabIndex = 1;
            this.rdbMedio.TabStop = true;
            this.rdbMedio.Text = "Medio";
            this.rdbMedio.UseVisualStyleBackColor = true;
            this.rdbMedio.CheckedChanged += new System.EventHandler(this.rdbMedio_CheckedChanged);
            // 
            // rdbPequeno
            // 
            this.rdbPequeno.AutoSize = true;
            this.rdbPequeno.Location = new System.Drawing.Point(6, 21);
            this.rdbPequeno.Name = "rdbPequeno";
            this.rdbPequeno.Size = new System.Drawing.Size(91, 24);
            this.rdbPequeno.TabIndex = 0;
            this.rdbPequeno.TabStop = true;
            this.rdbPequeno.Text = "Pequeno";
            this.rdbPequeno.UseVisualStyleBackColor = true;
            this.rdbPequeno.CheckedChanged += new System.EventHandler(this.rdbPequeno_CheckedChanged);
            // 
            // grbServico
            // 
            this.grbServico.Controls.Add(this.rdbCombo);
            this.grbServico.Controls.Add(this.rdbTosa);
            this.grbServico.Controls.Add(this.rdbBanho);
            this.grbServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbServico.Location = new System.Drawing.Point(149, 166);
            this.grbServico.Name = "grbServico";
            this.grbServico.Size = new System.Drawing.Size(200, 100);
            this.grbServico.TabIndex = 3;
            this.grbServico.TabStop = false;
            this.grbServico.Text = "Serviços";
            // 
            // rdbCombo
            // 
            this.rdbCombo.AutoSize = true;
            this.rdbCombo.Location = new System.Drawing.Point(7, 69);
            this.rdbCombo.Name = "rdbCombo";
            this.rdbCombo.Size = new System.Drawing.Size(126, 24);
            this.rdbCombo.TabIndex = 2;
            this.rdbCombo.TabStop = true;
            this.rdbCombo.Text = "Banho e Tosa";
            this.rdbCombo.UseVisualStyleBackColor = true;
            this.rdbCombo.CheckedChanged += new System.EventHandler(this.rdbCombo_CheckedChanged);
            // 
            // rdbTosa
            // 
            this.rdbTosa.AutoSize = true;
            this.rdbTosa.Location = new System.Drawing.Point(6, 45);
            this.rdbTosa.Name = "rdbTosa";
            this.rdbTosa.Size = new System.Drawing.Size(62, 24);
            this.rdbTosa.TabIndex = 1;
            this.rdbTosa.TabStop = true;
            this.rdbTosa.Text = "Tosa";
            this.rdbTosa.UseVisualStyleBackColor = true;
            this.rdbTosa.CheckedChanged += new System.EventHandler(this.rdbTosa_CheckedChanged);
            // 
            // rdbBanho
            // 
            this.rdbBanho.AutoSize = true;
            this.rdbBanho.Location = new System.Drawing.Point(6, 21);
            this.rdbBanho.Name = "rdbBanho";
            this.rdbBanho.Size = new System.Drawing.Size(74, 24);
            this.rdbBanho.TabIndex = 0;
            this.rdbBanho.TabStop = true;
            this.rdbBanho.Text = "Banho";
            this.rdbBanho.UseVisualStyleBackColor = true;
            this.rdbBanho.CheckedChanged += new System.EventHandler(this.rdbBanho_CheckedChanged);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(149, 316);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(200, 44);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(149, 284);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 5;
            this.lblValor.Text = "Valor";
            this.lblValor.Click += new System.EventHandler(this.lblValor_Click);
            // 
            // Servicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.grbServico);
            this.Controls.Add(this.grbPorte);
            this.Name = "Servicos";
            this.Text = "Serviços";
            this.grbPorte.ResumeLayout(false);
            this.grbPorte.PerformLayout();
            this.grbServico.ResumeLayout(false);
            this.grbServico.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPorte;
        private System.Windows.Forms.RadioButton rdbGrande;
        private System.Windows.Forms.RadioButton rdbMedio;
        private System.Windows.Forms.RadioButton rdbPequeno;
        private System.Windows.Forms.GroupBox grbServico;
        private System.Windows.Forms.RadioButton rdbCombo;
        private System.Windows.Forms.RadioButton rdbTosa;
        private System.Windows.Forms.RadioButton rdbBanho;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblValor;
    }
}