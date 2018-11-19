using System;
using DataBase;
using Objects;
using System.Data;

namespace Treatment
{
    public class CsFuncionarioParametro
    {
        // Objetos que serão utilizados para o envio do pacote de transferência para o banco de dados.
        private CsFuncionario csFuncionario;
        private CsCollectionFuncionario csCollectionFuncionario;
        private CsCommand csCommand;

        #region Empacotamento de Dados
        public void FuncionarioParametroColecao(CommandType commandType, string oleDbCommand, CsFuncionario csFuncionario)
        {
            csCommand = new CsCommand();

            csCommand.ParameterCollection_Clear();

            csCommand.ParameterCollection_Add("@Matricula", csFuncionario.Matricula);
            csCommand.ParameterCollection_Add("@Nome", csFuncionario.Nome);
            csCommand.ParameterCollection_Add("@FkFuncao", csFuncionario.FkFuncao);
            csCommand.ParameterCollection_Add("@DataAdmissao", csFuncionario.DataAdmissao);
            csCommand.ParameterCollection_Add("@CargaHoraria", csFuncionario.CargaHoraria);
            csCommand.ParameterCollection_Add("@Id", csFuncionario.Id);

            csCommand.ExecuteCommandNonQuery(commandType, oleDbCommand);
        }
        public CsCollectionFuncionario FuncionarioParametroColecao_Returno(CommandType commandType, string oleDbCommand, string where, string name)
        {
            csFuncionario = new CsFuncionario();
            csCollectionFuncionario = new CsCollectionFuncionario();
            csCommand = new CsCommand();

            csCommand.ParameterCollection_Clear();

            if(!(String.IsNullOrEmpty(name)))
            {
                csCommand.ParameterCollection_Add("@Name", name);
            }

            DataTable dataTable = csCommand.ExecuteCommandConsult(commandType, oleDbCommand);

            foreach(DataRow linha in dataTable.Rows)
            {
                csCollectionFuncionario.Add(csFuncionario.CsFuncionarioDataGridView(linha));
            }
         
            return csCollectionFuncionario;
        }
        #endregion

    }
}
