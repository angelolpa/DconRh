namespace DconRh
{
    partial class CsRegistroPrestaServico
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
            this.LblEmpresa = new System.Windows.Forms.Label();
            this.CboxEmpresa = new System.Windows.Forms.ComboBox();
            this.CboxFuncionario = new System.Windows.Forms.ComboBox();
            this.DtDataRegistro = new System.Windows.Forms.DateTimePicker();
            this.LblFuncionario = new System.Windows.Forms.Label();
            this.LblEntrada = new System.Windows.Forms.Label();
            this.DtEntrada = new System.Windows.Forms.DateTimePicker();
            this.DtIntervalo = new System.Windows.Forms.DateTimePicker();
            this.DtSaida = new System.Windows.Forms.DateTimePicker();
            this.LblIntervalo = new System.Windows.Forms.Label();
            this.LblSaida = new System.Windows.Forms.Label();
            this.LblDataRegistro = new System.Windows.Forms.Label();
            this.DtHExecutada = new System.Windows.Forms.DateTimePicker();
            this.DtHoraExtra = new System.Windows.Forms.DateTimePicker();
            this.DtTotalHoras = new System.Windows.Forms.DateTimePicker();
            this.LblTotalHora = new System.Windows.Forms.Label();
            this.LblHorasExtras = new System.Windows.Forms.Label();
            this.LblHorasTrabalhadas = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblEmpresa
            // 
            this.LblEmpresa.AutoSize = true;
            this.LblEmpresa.Location = new System.Drawing.Point(9, 9);
            this.LblEmpresa.Name = "LblEmpresa";
            this.LblEmpresa.Size = new System.Drawing.Size(51, 13);
            this.LblEmpresa.TabIndex = 0;
            this.LblEmpresa.Text = "Empresa:";
            // 
            // CboxEmpresa
            // 
            this.CboxEmpresa.FormattingEnabled = true;
            this.CboxEmpresa.Location = new System.Drawing.Point(12, 25);
            this.CboxEmpresa.Name = "CboxEmpresa";
            this.CboxEmpresa.Size = new System.Drawing.Size(214, 21);
            this.CboxEmpresa.TabIndex = 3;
            // 
            // CboxFuncionario
            // 
            this.CboxFuncionario.FormattingEnabled = true;
            this.CboxFuncionario.Location = new System.Drawing.Point(12, 65);
            this.CboxFuncionario.Name = "CboxFuncionario";
            this.CboxFuncionario.Size = new System.Drawing.Size(214, 21);
            this.CboxFuncionario.TabIndex = 4;
            // 
            // DtDataRegistro
            // 
            this.DtDataRegistro.Location = new System.Drawing.Point(12, 105);
            this.DtDataRegistro.Name = "DtDataRegistro";
            this.DtDataRegistro.Size = new System.Drawing.Size(217, 20);
            this.DtDataRegistro.TabIndex = 5;
            // 
            // LblFuncionario
            // 
            this.LblFuncionario.AutoSize = true;
            this.LblFuncionario.Location = new System.Drawing.Point(9, 49);
            this.LblFuncionario.Name = "LblFuncionario";
            this.LblFuncionario.Size = new System.Drawing.Size(62, 13);
            this.LblFuncionario.TabIndex = 6;
            this.LblFuncionario.Text = "Funcionário";
            // 
            // LblEntrada
            // 
            this.LblEntrada.AutoSize = true;
            this.LblEntrada.Location = new System.Drawing.Point(9, 128);
            this.LblEntrada.Name = "LblEntrada";
            this.LblEntrada.Size = new System.Drawing.Size(47, 13);
            this.LblEntrada.TabIndex = 7;
            this.LblEntrada.Text = "Entrada:";
            // 
            // DtEntrada
            // 
            this.DtEntrada.CustomFormat = "";
            this.DtEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtEntrada.Location = new System.Drawing.Point(12, 144);
            this.DtEntrada.Name = "DtEntrada";
            this.DtEntrada.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DtEntrada.ShowUpDown = true;
            this.DtEntrada.Size = new System.Drawing.Size(68, 20);
            this.DtEntrada.TabIndex = 8;
            this.DtEntrada.Value = new System.DateTime(2018, 11, 19, 7, 0, 0, 0);
            this.DtEntrada.ValueChanged += new System.EventHandler(this.DtEntrada_ValueChanged);
            // 
            // DtIntervalo
            // 
            this.DtIntervalo.CustomFormat = "";
            this.DtIntervalo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtIntervalo.Location = new System.Drawing.Point(86, 144);
            this.DtIntervalo.Name = "DtIntervalo";
            this.DtIntervalo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DtIntervalo.ShowUpDown = true;
            this.DtIntervalo.Size = new System.Drawing.Size(68, 20);
            this.DtIntervalo.TabIndex = 9;
            this.DtIntervalo.Value = new System.DateTime(2018, 11, 19, 1, 0, 0, 0);
            this.DtIntervalo.ValueChanged += new System.EventHandler(this.DtIntervalo_ValueChanged);
            // 
            // DtSaida
            // 
            this.DtSaida.CustomFormat = "";
            this.DtSaida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtSaida.Location = new System.Drawing.Point(160, 144);
            this.DtSaida.Name = "DtSaida";
            this.DtSaida.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DtSaida.ShowUpDown = true;
            this.DtSaida.Size = new System.Drawing.Size(68, 20);
            this.DtSaida.TabIndex = 10;
            this.DtSaida.Value = new System.DateTime(2018, 11, 19, 16, 0, 0, 0);
            this.DtSaida.ValueChanged += new System.EventHandler(this.DtSaida_ValueChanged);
            // 
            // LblIntervalo
            // 
            this.LblIntervalo.AutoSize = true;
            this.LblIntervalo.Location = new System.Drawing.Point(83, 128);
            this.LblIntervalo.Name = "LblIntervalo";
            this.LblIntervalo.Size = new System.Drawing.Size(51, 13);
            this.LblIntervalo.TabIndex = 11;
            this.LblIntervalo.Text = "Intervalo:";
            // 
            // LblSaida
            // 
            this.LblSaida.AutoSize = true;
            this.LblSaida.Location = new System.Drawing.Point(158, 128);
            this.LblSaida.Name = "LblSaida";
            this.LblSaida.Size = new System.Drawing.Size(37, 13);
            this.LblSaida.TabIndex = 12;
            this.LblSaida.Text = "Saida:";
            // 
            // LblDataRegistro
            // 
            this.LblDataRegistro.AutoSize = true;
            this.LblDataRegistro.Location = new System.Drawing.Point(9, 89);
            this.LblDataRegistro.Name = "LblDataRegistro";
            this.LblDataRegistro.Size = new System.Drawing.Size(87, 13);
            this.LblDataRegistro.TabIndex = 13;
            this.LblDataRegistro.Text = "Data de Registro";
            // 
            // DtHExecutada
            // 
            this.DtHExecutada.CustomFormat = "";
            this.DtHExecutada.Enabled = false;
            this.DtHExecutada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtHExecutada.Location = new System.Drawing.Point(12, 183);
            this.DtHExecutada.Name = "DtHExecutada";
            this.DtHExecutada.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DtHExecutada.ShowUpDown = true;
            this.DtHExecutada.Size = new System.Drawing.Size(68, 20);
            this.DtHExecutada.TabIndex = 14;
            this.DtHExecutada.Value = new System.DateTime(2018, 11, 19, 0, 0, 0, 0);
            // 
            // DtHoraExtra
            // 
            this.DtHoraExtra.CustomFormat = "";
            this.DtHoraExtra.Enabled = false;
            this.DtHoraExtra.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtHoraExtra.Location = new System.Drawing.Point(87, 183);
            this.DtHoraExtra.Name = "DtHoraExtra";
            this.DtHoraExtra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DtHoraExtra.ShowUpDown = true;
            this.DtHoraExtra.Size = new System.Drawing.Size(68, 20);
            this.DtHoraExtra.TabIndex = 15;
            this.DtHoraExtra.Value = new System.DateTime(2018, 11, 19, 0, 0, 0, 0);
            // 
            // DtTotalHoras
            // 
            this.DtTotalHoras.CustomFormat = "";
            this.DtTotalHoras.Enabled = false;
            this.DtTotalHoras.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtTotalHoras.Location = new System.Drawing.Point(161, 183);
            this.DtTotalHoras.Name = "DtTotalHoras";
            this.DtTotalHoras.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DtTotalHoras.ShowUpDown = true;
            this.DtTotalHoras.Size = new System.Drawing.Size(68, 20);
            this.DtTotalHoras.TabIndex = 16;
            this.DtTotalHoras.Value = new System.DateTime(2018, 11, 19, 0, 0, 0, 0);
            // 
            // LblTotalHora
            // 
            this.LblTotalHora.AutoSize = true;
            this.LblTotalHora.Location = new System.Drawing.Point(158, 167);
            this.LblTotalHora.Name = "LblTotalHora";
            this.LblTotalHora.Size = new System.Drawing.Size(63, 13);
            this.LblTotalHora.TabIndex = 19;
            this.LblTotalHora.Text = "Total horas:";
            // 
            // LblHorasExtras
            // 
            this.LblHorasExtras.AutoSize = true;
            this.LblHorasExtras.Location = new System.Drawing.Point(84, 167);
            this.LblHorasExtras.Name = "LblHorasExtras";
            this.LblHorasExtras.Size = new System.Drawing.Size(69, 13);
            this.LblHorasExtras.TabIndex = 18;
            this.LblHorasExtras.Text = "Horas extras:";
            // 
            // LblHorasTrabalhadas
            // 
            this.LblHorasTrabalhadas.AutoSize = true;
            this.LblHorasTrabalhadas.Location = new System.Drawing.Point(9, 167);
            this.LblHorasTrabalhadas.Name = "LblHorasTrabalhadas";
            this.LblHorasTrabalhadas.Size = new System.Drawing.Size(75, 13);
            this.LblHorasTrabalhadas.TabIndex = 17;
            this.LblHorasTrabalhadas.Text = "H. Executada:";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(73, 209);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 21;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(154, 209);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.BtnRegistrar.TabIndex = 20;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // CsRegistroPrestaServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 242);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.LblTotalHora);
            this.Controls.Add(this.LblHorasExtras);
            this.Controls.Add(this.LblHorasTrabalhadas);
            this.Controls.Add(this.DtTotalHoras);
            this.Controls.Add(this.DtHoraExtra);
            this.Controls.Add(this.DtHExecutada);
            this.Controls.Add(this.LblDataRegistro);
            this.Controls.Add(this.LblSaida);
            this.Controls.Add(this.LblIntervalo);
            this.Controls.Add(this.DtSaida);
            this.Controls.Add(this.DtIntervalo);
            this.Controls.Add(this.DtEntrada);
            this.Controls.Add(this.LblEntrada);
            this.Controls.Add(this.LblFuncionario);
            this.Controls.Add(this.DtDataRegistro);
            this.Controls.Add(this.CboxFuncionario);
            this.Controls.Add(this.CboxEmpresa);
            this.Controls.Add(this.LblEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CsRegistroPrestaServico";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DCON RH - Registro Diario de Entrada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEmpresa;
        private System.Windows.Forms.ComboBox CboxEmpresa;
        private System.Windows.Forms.ComboBox CboxFuncionario;
        private System.Windows.Forms.DateTimePicker DtDataRegistro;
        private System.Windows.Forms.Label LblFuncionario;
        private System.Windows.Forms.Label LblEntrada;
        private System.Windows.Forms.DateTimePicker DtEntrada;
        private System.Windows.Forms.DateTimePicker DtIntervalo;
        private System.Windows.Forms.DateTimePicker DtSaida;
        private System.Windows.Forms.Label LblIntervalo;
        private System.Windows.Forms.Label LblSaida;
        private System.Windows.Forms.Label LblDataRegistro;
        private System.Windows.Forms.DateTimePicker DtHExecutada;
        private System.Windows.Forms.DateTimePicker DtHoraExtra;
        private System.Windows.Forms.DateTimePicker DtTotalHoras;
        private System.Windows.Forms.Label LblTotalHora;
        private System.Windows.Forms.Label LblHorasExtras;
        private System.Windows.Forms.Label LblHorasTrabalhadas;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnRegistrar;
    }
}