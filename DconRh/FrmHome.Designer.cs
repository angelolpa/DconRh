namespace DconRh
{
    partial class FrmHome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadatrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lançamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horasExtraordináriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lançamentosMensalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quemSomosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadatrarToolStripMenuItem,
            this.lançamentosToolStripMenuItem,
            this.relatórioToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadatrarToolStripMenuItem
            // 
            this.cadatrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresaToolStripMenuItem,
            this.funcionarioToolStripMenuItem,
            this.funcaoToolStripMenuItem});
            this.cadatrarToolStripMenuItem.Name = "cadatrarToolStripMenuItem";
            this.cadatrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadatrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.empresaToolStripMenuItem.Text = "Matriz/Filial";
            this.empresaToolStripMenuItem.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.funcionarioToolStripMenuItem.Text = "Funcionário";
            this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.funcionarioToolStripMenuItem_Click);
            // 
            // funcaoToolStripMenuItem
            // 
            this.funcaoToolStripMenuItem.Name = "funcaoToolStripMenuItem";
            this.funcaoToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.funcaoToolStripMenuItem.Text = "Funcao";
            this.funcaoToolStripMenuItem.Click += new System.EventHandler(this.funcaoToolStripMenuItem_Click);
            // 
            // lançamentosToolStripMenuItem
            // 
            this.lançamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horasExtraordináriasToolStripMenuItem});
            this.lançamentosToolStripMenuItem.Name = "lançamentosToolStripMenuItem";
            this.lançamentosToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.lançamentosToolStripMenuItem.Text = "Lançamentos";
            // 
            // horasExtraordináriasToolStripMenuItem
            // 
            this.horasExtraordináriasToolStripMenuItem.Name = "horasExtraordináriasToolStripMenuItem";
            this.horasExtraordináriasToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.horasExtraordináriasToolStripMenuItem.Text = "Registro Diário";
            this.horasExtraordináriasToolStripMenuItem.Click += new System.EventHandler(this.horasExtraordináriasToolStripMenuItem_Click);
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lançamentosMensalToolStripMenuItem});
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // lançamentosMensalToolStripMenuItem
            // 
            this.lançamentosMensalToolStripMenuItem.Name = "lançamentosMensalToolStripMenuItem";
            this.lançamentosMensalToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.lançamentosMensalToolStripMenuItem.Text = "Lançamentos Mensal";
            this.lançamentosMensalToolStripMenuItem.Click += new System.EventHandler(this.lançamentosMensalToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quemSomosToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // quemSomosToolStripMenuItem
            // 
            this.quemSomosToolStripMenuItem.Name = "quemSomosToolStripMenuItem";
            this.quemSomosToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.quemSomosToolStripMenuItem.Text = "Quem Somos?";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(117, 17);
            this.toolStripStatusLabel1.Text = "Versão Registrada 1.0";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DconRh.Properties.Resources._13e6a6f667959c8ee2e6131f86f312bf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHome";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DCON RH - Tela Inicial";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadatrarToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lançamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horasExtraordináriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lançamentosMensalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quemSomosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcaoToolStripMenuItem;
    }
}