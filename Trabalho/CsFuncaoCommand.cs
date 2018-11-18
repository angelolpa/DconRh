using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Objects;
using Treatment;
using System.Data;

namespace Trabalho
{
    public class CsFuncaoCommand : CsAbstrata
    {
        CsFuncaoParametro csFuncaoParametro = new CsFuncaoParametro();

        public override void InsertObjTrans(object objTrans)
        {
            SqlCommand = "INSERT INTO funcao(nome, descricao) VALUES (@Nome, @Descricao)";

            csFuncaoParametro.CsFuncaoParemetroColecao(CommandType.Text, SqlCommand, (objTrans as CsFuncao));
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
            throw new NotImplementedException();
        }
    }
}
