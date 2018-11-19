namespace DconRh
{
    partial class FrmRegistroEmpresa
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
            this.LblNome = new System.Windows.Forms.Label();
            this.LblCnpj = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.MaskTxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.TxtCnpj = new System.Windows.Forms.TextBox();
            this.LblTelefone = new System.Windows.Forms.Label();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.LblDescricao = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(12, 9);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(38, 13);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome:";
            // 
            // LblCnpj
            // 
            this.LblCnpj.AutoSize = true;
            this.LblCnpj.Location = new System.Drawing.Point(12, 48);
            this.LblCnpj.Name = "LblCnpj";
            this.LblCnpj.Size = new System.Drawing.Size(37, 13);
            this.LblCnpj.TabIndex = 1;
            this.LblCnpj.Text = "CNPJ:";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(15, 25);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(229, 20);
            this.TxtNome.TabIndex = 2;
            // 
            // MaskTxtTelefone
            // 
            this.MaskTxtTelefone.Location = new System.Drawing.Point(156, 64);
            this.MaskTxtTelefone.Mask = "(00) 00000-0000";
            this.MaskTxtTelefone.Name = "MaskTxtTelefone";
            this.MaskTxtTelefone.Size = new System.Drawing.Size(88, 20);
            this.MaskTxtTelefone.TabIndex = 3;
            // 
            // TxtCnpj
            // 
            this.TxtCnpj.Location = new System.Drawing.Point(15, 64);
            this.TxtCnpj.Name = "TxtCnpj";
            this.TxtCnpj.Size = new System.Drawing.Size(135, 20);
            this.TxtCnpj.TabIndex = 4;
            // 
            // LblTelefone
            // 
            this.LblTelefone.AutoSize = true;
            this.LblTelefone.Location = new System.Drawing.Point(153, 48);
            this.LblTelefone.Name = "LblTelefone";
            this.LblTelefone.Size = new System.Drawing.Size(52, 13);
            this.LblTelefone.TabIndex = 5;
            this.LblTelefone.Text = "Telefone:";
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Location = new System.Drawing.Point(15, 103);
            this.TxtDescricao.Multiline = true;
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(229, 135);
            this.TxtDescricao.TabIndex = 6;
            // 
            // LblDescricao
            // 
            this.LblDescricao.AutoSize = true;
            this.LblDescricao.Location = new System.Drawing.Point(12, 87);
            this.LblDescricao.Name = "LblDescricao";
            this.LblDescricao.Size = new System.Drawing.Size(58, 13);
            this.LblDescricao.TabIndex = 7;
            this.LblDescricao.Text = "Descrição:";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(88, 244);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 14;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(169, 244);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.BtnRegistrar.TabIndex = 13;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // FrmRegistroEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 272);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.LblDescricao);
            this.Controls.Add(this.TxtDescricao);
            this.Controls.Add(this.LblTelefone);
            this.Controls.Add(this.TxtCnpj);
            this.Controls.Add(this.MaskTxtTelefone);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblCnpj);
            this.Controls.Add(this.LblNome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegistroEmpresa";
            this.ShowIcon = false;
            this.Text = "DCON RH - Registro Empresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblCnpj;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.MaskedTextBox MaskTxtTelefone;
        private System.Windows.Forms.TextBox TxtCnpj;
        private System.Windows.Forms.Label LblTelefone;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.Label LblDescricao;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnRegistrar;
    }
}