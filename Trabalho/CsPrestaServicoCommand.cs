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
    public class CsPrestaServicoCommand : CsAbstrata
    {
        CsPrestaServicoParametro csPrestaServicoParametro = new CsPrestaServicoParametro();

        public override void InsertObjTrans(object objTrans)
        {
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
            SqlCommand = "SELECT presta_servico.id, fk_empresa, fk_funcionario, data_registro, entrada, intervalo, saida, horas_trabalhadas, horas_extras, total_horas, empresa.nome, funcionario.nome FROM((presta_servico INNER JOIN empresa ON empresa.id = presta_servico.fk_empresa) INNER JOIN funcionario ON funcionario.id = presta_servico.fk_funcionario)";
        }   
        public CsCollectionPrestaServico SeacherNameFuncionario(string where, string name)
        {
            SeacherObjTrans(where);
            return csPrestaServicoParametro.CsPrestaServicoParametroColecao_Returno(CommandType.Text, SqlCommand, where, name);
        }
    }
}
