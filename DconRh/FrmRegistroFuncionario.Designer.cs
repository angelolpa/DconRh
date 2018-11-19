namespace DconRh
{
    partial class FrmRegistroFuncionario
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
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMatricula = new System.Windows.Forms.TextBox();
            this.CboxFuncao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CboxCargaHoraria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DtDataAdmissao = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(12, 25);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(121, 20);
            this.TxtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Funcionário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Matricula:";
            // 
            // TxtMatricula
            // 
            this.TxtMatricula.Location = new System.Drawing.Point(139, 25);
            this.TxtMatricula.Name = "TxtMatricula";
            this.TxtMatricula.Size = new System.Drawing.Size(100, 20);
            this.TxtMatricula.TabIndex = 3;
            // 
            // CboxFuncao
            // 
            this.CboxFuncao.FormattingEnabled = true;
            this.CboxFuncao.Items.AddRange(new object[] {
            "- - - - - - Listar Funções - - - - - -"});
            this.CboxFuncao.Location = new System.Drawing.Point(12, 64);
            this.CboxFuncao.Name = "CboxFuncao";
            this.CboxFuncao.Size = new System.Drawing.Size(158, 21);
            this.CboxFuncao.TabIndex = 5;
            this.CboxFuncao.Text = "- - - - - - Listar Funções - - - - - -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Função:";
            // 
            // CboxCargaHoraria
            // 
            this.CboxCargaHoraria.FormattingEnabled = true;
            this.CboxCargaHoraria.Items.AddRange(new object[] {
            "- Listar -",
            "36",
            "40",
            "48"});
            this.CboxCargaHoraria.Location = new System.Drawing.Point(176, 64);
            this.CboxCargaHoraria.Name = "CboxCargaHoraria";
            this.CboxCargaHoraria.Size = new System.Drawing.Size(63, 21);
            this.CboxCargaHoraria.TabIndex = 7;
            this.CboxCargaHoraria.Text = "- Listar -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Carga H.:";
            // 
            // DtDataAdmissao
            // 
            this.DtDataAdmissao.Location = new System.Drawing.Point(12, 107);
            this.DtDataAdmissao.Name = "DtDataAdmissao";
            this.DtDataAdmissao.Size = new System.Drawing.Size(227, 20);
            this.DtDataAdmissao.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data de Admissão:";
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(164, 137);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.BtnRegistrar.TabIndex = 11;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(83, 137);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmRegistroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 172);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DtDataAdmissao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CboxCargaHoraria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CboxFuncao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtMatricula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegistroFuncionario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DCON RH -  Registro de Funcionário";
            this.Load += new System.EventHandler(this.FrmRegistroFuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMatricula;
        private System.Windows.Forms.ComboBox CboxFuncao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboxCargaHoraria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtDataAdmissao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}