using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Objects;
using Trabalho;

namespace DconRh
{
    public partial class CsRegistroFuncao : Form
    {
        CsFuncao csFuncao;

        public CsRegistroFuncao()
        {
            InitializeComponent();
        }

        private void CsRegistroFuncao_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            CsFuncaoCommand csFuncaoCommand = new CsFuncaoCommand();
            csFuncaoCommand.InsertObjTrans(CsFuncao_Preencher());
        }

        private CsFuncao CsFuncao_Preencher()
        {
            try
            {
                CsFuncao csFuncao = new CsFuncao
                {
                    Nome = TxtNome.Text,
                    Descricao = TxtDescricao.Text
                };
            }
            catch (Exception exception)
            {
                MessageBox.Show("Houve um erro durante a transferência de dados, detalhes:" + exception.Message);
            }
            return csFuncao;
        }
    }
}
