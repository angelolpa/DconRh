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

        private void cadatrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void horasExtraordináriasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroFuncionario frmRegistroFuncionario = new FrmRegistroFuncionario();

            frmRegistroFuncionario.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
