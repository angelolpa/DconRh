using System;
using System.Windows.Forms;
using Objects;
using Trabalho;

namespace DconRh
{
    public partial class FrmRegistroFuncionario : Form
    {
        CsFuncionarioCommand csFuncionarioCommand;

        public FrmRegistroFuncionario()
        {
            InitializeComponent();
        }

        private CsFuncionario CsFuncionario_Preencher()
        {
            try
            {
                CsFuncionario csFuncionario = new CsFuncionario
                {
                    Matricula = Convert.ToInt32(TxtMatricula.Text),
                    Nome = TxtNome.Text,
                    FkFuncao = Convert.ToInt32(CboxFuncao.Text),
                    DataAdmissao = DtDataAdmissao.Value,
                    CargaHoraria = Convert.ToInt32(CboxCargaHoraria.Text)
                };
                return csFuncionario;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return null;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if(Int32.TryParse(TxtMatricula.Text, out int result))
            {
                csFuncionarioCommand = new CsFuncionarioCommand();
                csFuncionarioCommand.InsertObjTrans(CsFuncionario_Preencher());
            }
            else
            {
                MessageBox.Show("Por favor digite somente números no campo de matricula");
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
