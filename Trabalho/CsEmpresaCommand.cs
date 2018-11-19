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
    public class CsEmpresaCommand : CsAbstrata
    {
        CsEmpresaParametro csEmpresaParametro = new CsEmpresaParametro();

        public override void InsertObjTrans(object objTrans)
        {
            SqlCommand = "INSERT INTO empresa(nome, cnpj, telefone, endereco) VALUES (@Nome, @Cnpj, @Telefone, @Endereco)";
            csEmpresaParametro.CsEmpresaParemetroColecao(CommandType.Text, SqlCommand, (objTrans as CsEmpresa));
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
            SqlCommand = "SELECT * FROM empresa " + where;
        }

        public CsCollectionEmpresa SeacherNameEmpresa(string where, string name)
        {
            SeacherObjTrans(where);
            return csEmpresaParametro.CsEmpresaParametroColecao_Returno(CommandType.Text, SqlCommand, where, name);

        }
    }
}
