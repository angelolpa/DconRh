using System;

using Objects;
using Treatment;
using System.Data;

namespace Trabalho
{
    public class CsFuncionarioCommand : CsAbstrata
    {
        private CsFuncionarioParametro csFuncionarioParametro = new CsFuncionarioParametro();

        public override void InsertObjTrans(object objTrans)
        {
            SqlCommand = "INSERT INTO funcionario(matricula, nome, fk_funcao, data_admissao, carga_horaria) VALUES (@Matricula, @Nome, @FkFuncao, @DataAdmissao, @CargaHoraria) ";

            csFuncionarioParametro.FuncionarioParametroColecao(CommandType.Text, SqlCommand, (objTrans as CsFuncionario));
        }
        public override void UpdateObjTrans(object objTrans)
        {
            throw new NotImplementedException();
        }
        public override void DeleteObjTrans(object objTrans)
        {
            throw new NotImplementedException();
        }
        public override void SeacherObjTrans(string where)
        {
            SqlCommand = "SELECT * FROM funcionario " + where;
        }
        public CsCollectionFuncionario SeacherNameFuncionario(string where, string name)
        {
            SeacherObjTrans(where);
            return csFuncionarioParametro.FuncionarioParametroColecao_Returno(CommandType.Text, SqlCommand, where, name);
        }
    }
}
