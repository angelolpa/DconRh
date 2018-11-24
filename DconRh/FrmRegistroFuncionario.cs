using System;
using System.Windows.Forms;
using Objects;
using Trabalho;

namespace DconRh
{
    public partial class FrmRegistroFuncionario : Form
    {
        CsFuncionarioCommand csFuncionarioCommand;
        CsFuncaoCommand csFuncaoCommand;

        public FrmRegistroFuncionario()
        {
            InitializeComponent();
            CsFuncao_Preencher();
        }

        private CsFuncionario CsFuncionario_Preencher()
        {
            try
            {
                CsFuncionario csFuncionario = new CsFuncionario();

                csFuncionario.Matricula = Convert.ToInt32(TxtMatricula.Text);
                csFuncionario.Nome = TxtNome.Text;
                csFuncionario.FkFuncao = CsFuncao_Fk_Preencher();
                csFuncionario.DataAdmissao = Convert.ToDateTime(DtDataAdmissao.Value.ToShortDateString());
                csFuncionario.CargaHoraria = Convert.ToInt32(CboxCargaHoraria.Text);

                return csFuncionario;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return null;
        }
        
        private int CsFuncao_Fk_Preencher()
        {
            return csFuncaoCommand.SeacherNameFuncao(" WHERE nome = @Nome ", CboxFuncao.Text)[0].Id;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if(Int32.TryParse(TxtMatricula.Text, out int result))
            {
                csFuncionarioCommand = new CsFuncionarioCommand();
                csFuncionarioCommand.InsertObjTrans(CsFuncionario_Preencher());

                MessageBox.Show("Cadastro Realizado");

                this.DialogResult = DialogResult.No;
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

        private void CsFuncao_Preencher()
        {
            csFuncaoCommand = new CsFuncaoCommand();
            CsCollectionFuncao csCollectionFuncao = csFuncaoCommand.SeacherNameFuncao(null, null);

            foreach (CsFuncao item in csCollectionFuncao)
            {
                CboxFuncao.Items.Add(item.Nome);
            }
        }

        private void FrmRegistroFuncionario_Load(object sender, EventArgs e)
        {
        }
        
    }
}
