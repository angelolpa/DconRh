using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using Objects;
using Trabalho;

namespace DconRh
{
    public partial class FrmRegistroEmpresa : Form
    {
        public FrmRegistroEmpresa()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            CsEmpresaCommand csEmpresaCommand = new CsEmpresaCommand();
            csEmpresaCommand.InsertObjTrans(CsEmpresa_Preencher());

            MessageBox.Show("Cadastro Executado");

            this.DialogResult = DialogResult.No;
        }
        private CsEmpresa CsEmpresa_Preencher()
        {
            try
            {
                CsEmpresa csEmpresa = new CsEmpresa
                {
                    Nome = TxtNome.Text,
                    Cnpj = TxtCnpj.Text,
                    Telefone = MaskTxtTelefone.Text,
                    Endereco = TxtDescricao.Text
                };
                return csEmpresa;
            }
            catch
            {
                MessageBox.Show("Não foi posssivel preencher os dados");
            }

            return null;
        }
    }
}
