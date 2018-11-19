using System;
using System.Data;
using DataBase;
using Objects;
namespace Treatment
{
    public class CsEmpresaParametro
    {
        CsEmpresa csEmpresa;
        CsCollectionEmpresa csCollectionEmpresa;
        CsCommand csCommand;

        public void CsEmpresaParemetroColecao(CommandType commandType, string oleDbCommand, CsEmpresa csEmpresa)
        {
            csCommand = new CsCommand();

            csCommand.ParameterCollection_Clear();

            csCommand.ParameterCollection_Add("@Nome", csEmpresa.Nome);
            csCommand.ParameterCollection_Add("@Cnpj", csEmpresa.Cnpj);
            csCommand.ParameterCollection_Add("@Telefone", csEmpresa.Telefone);
            csCommand.ParameterCollection_Add("@Endereco", csEmpresa.Endereco);
            csCommand.ParameterCollection_Add("@Id", csEmpresa.Id);

            csCommand.ExecuteCommandNonQuery(commandType, oleDbCommand);
        }


        public CsCollectionEmpresa CsEmpresaParametroColecao_Returno(CommandType commandType, string oleDbCommand, string where, string name)
        {
            csEmpresa = new CsEmpresa();
            csCollectionEmpresa = new CsCollectionEmpresa();
            csCommand = new CsCommand();

            csCommand.ParameterCollection_Clear();

            if (!(String.IsNullOrEmpty(name)))
            {
                csCommand.ParameterCollection_Add("@Name", name);
            }

            DataTable dataTable = csCommand.ExecuteCommandConsult(commandType, oleDbCommand);

            foreach (DataRow linha in dataTable.Rows)
            {
                csCollectionEmpresa.Add(csEmpresa.CsEmpresaDataGridView(linha));
            }

            return csCollectionEmpresa;
        }


    }
}
