using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DconRh
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroEmpresa frmRegistroEmpresa = new FrmRegistroEmpresa();
            frmRegistroEmpresa.ShowDialog();
        }

        private void horasExtraordináriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CsRegistroPrestaServico csRegistroPrestaServico = new CsRegistroPrestaServico();
            csRegistroPrestaServico.ShowDialog();
            
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroFuncionario frmRegistroFuncionario = new FrmRegistroFuncionario();
            frmRegistroFuncionario.ShowDialog();
        }

        private void funcaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CsRegistroFuncao csRegistroFuncao = new CsRegistroFuncao();
            csRegistroFuncao.ShowDialog();
        }

        private void lançamentosMensalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relatório.Form1 form1 = new relatório.Form1();

            form1.ShowDialog();
        }
    }
}
