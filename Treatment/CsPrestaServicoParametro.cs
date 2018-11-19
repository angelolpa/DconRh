using System;
//Utilizados
using System.Data;
using DataBase;
using Objects;

namespace Treatment
{
    public class CsPrestaServicoParametro
    {
        // Objetos que serão utilizados para o envio do pacote de transferência para o banco de dados.
        CsPrestaServico csPrestaServico;
        CsCollectionPrestaServico csCollectionPrestaServico;
        CsCommand csCommand;

        #region Empacotamento de Dados
        public void CsPrestaServicoParemetroColecao(CommandType commandType, string oleDbCommand, CsPrestaServico csPrestaServico)
        {
            csCommand = new CsCommand();

            csCommand.ParameterCollection_Clear();

            csCommand.ParameterCollection_Add("@FkEmpresa", csPrestaServico.FkEmpresa.Id);
            csCommand.ParameterCollection_Add("@FkFuncionario", csPrestaServico.FkFuncionario.Id);
            csCommand.ParameterCollection_Add("@DataDeRegistro", csPrestaServico.DataRegistro);
            csCommand.ParameterCollection_Add("@Entrada", csPrestaServico.Entrada);
            csCommand.ParameterCollection_Add("@Intervalo", csPrestaServico.Intervalo);
            csCommand.ParameterCollection_Add("@Saida", csPrestaServico.Saida);
            csCommand.ParameterCollection_Add("@HorasTrabalhadas", csPrestaServico.HorasTrabalhadas);
            csCommand.ParameterCollection_Add("@HorasExtras", csPrestaServico.HorasExtras);
            csCommand.ParameterCollection_Add("@TotalHoras", csPrestaServico.TotalHoras);
            csCommand.ParameterCollection_Add("@Id", csPrestaServico.Id);

            csCommand.ExecuteCommandNonQuery(commandType, oleDbCommand);
        }
        public CsCollectionPrestaServico CsPrestaServicoParametroColecao_Returno(CommandType commandType, string oleDbCommand, string where, string name)
        {
            csPrestaServico = new CsPrestaServico();
            csCollectionPrestaServico = new CsCollectionPrestaServico();
            csCommand = new CsCommand();

            csCommand.ParameterCollection_Clear();

            if (!(String.IsNullOrEmpty(name)))
            {
                csCommand.ParameterCollection_Add("@Name", name);
            }

            DataTable dataTable = csCommand.ExecuteCommandConsult(commandType, oleDbCommand);

            foreach (DataRow linha in dataTable.Rows)
            {
                csCollectionPrestaServico.Add(csPrestaServico.CsPrestaServicoDataGridView(linha));
            }

            return csCollectionPrestaServico;
        }
        #endregion
    }
}
