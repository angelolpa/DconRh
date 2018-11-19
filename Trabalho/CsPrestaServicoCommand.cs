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
    class CsPrestaServicoCommand : CsAbstrata
    {
        public override void InsertObjTrans(object objTrans)
        {
            CsPrestaServicoParametro csPrestaServicoParametro = new CsPrestaServicoParametro();
            SqlCommand = "INSERT INTO presta_servico(fk_empresa, fk_funcionario, data_registro, entrada, intervalo, saida, horas_trabalhadas, horas_extras, total_horas) VALUES (@FkEmpresa, @FkFuncionario, @DataDeRegistro, @Entrada, @Intervalo, @Saida, @HorasTrabalhadas, @HorasExtras, @TotalHoras) ";
            csPrestaServicoParametro.CsPrestaServicoParemetroColecao(CommandType.Text, SqlCommand, (objTrans as CsPrestaServico));
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
