using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataBase;
using System.Data;
using Objects;

namespace Treatment
{
    public class CsFuncaoParametro
    {
        // Objetos que serão utilizados para o envio do pacote de transferência para o banco de dados.
        CsFuncao csFuncao;
        CsCollectionFuncao csCollectionFuncao;
        CsCommand csCommand;
        
        #region Empacotamento de Dados
        public void CsFuncaoParemetroColecao(CommandType commandType, string oleDbCommand,CsFuncao csFuncao)
        {
            csCommand = new CsCommand();

            csCommand.ParameterCollection_Clear();

            csCommand.ParameterCollection_Add("@Id", csFuncao.Id);
            csCommand.ParameterCollection_Add("@Nome", csFuncao.Nome);
            csCommand.ParameterCollection_Add("@Descricao", csFuncao.Descricao);

            csCommand.ExecuteCommandNonQuery(commandType, oleDbCommand);
        }
        public CsCollectionFuncao CsFuncaoParametroColecao_Returno(CommandType commandType, string oleDbCommand, string where, string name)
        {
            csFuncao = new CsFuncao();
            csCollectionFuncao = new CsCollectionFuncao();
            csCommand = new CsCommand();

            csCommand.ParameterCollection_Clear();

            if (!(String.IsNullOrEmpty(name)))
            {
                csCommand.ParameterCollection_Add("@Nome", name);
            }

            DataTable dataTable = csCommand.ExecuteCommandConsult(commandType, oleDbCommand);

            foreach (DataRow linha in dataTable.Rows)
            {
                csCollectionFuncao.Add(csFuncao.CsFuncaoDataGridView(linha));
            }

            return csCollectionFuncao;
        }
        #endregion

    }
}
