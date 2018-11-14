using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class CsFuncionario
    {
        #region Atributos
        private int id;
        private int matricula;
        private string nome;
        private int fkFuncao;
        private DateTime dataAdmissao;
        private int cargaHoraria;
        #endregion  

        #region Propriedades
        public int Id { get => id; set => id = value; }
        public int Matricula { get => matricula; set => matricula = value; }
        public string Nome { get => nome; set => nome = value; }
        public int FkFuncao { get => fkFuncao; set => fkFuncao = value; }
        public DateTime DataAdmissao { get => dataAdmissao; set => dataAdmissao = value; }
        public int CargaHoraria { get => cargaHoraria; set => cargaHoraria = value; }
        #endregion

        #region Auxiliar
        public CsFuncionario csFuncionarioDataGridView(System.Data.DataRow line)
        {
            CsFuncionario csFuncionario = new CsFuncionario
            {
                Id = Convert.ToInt32(line["id"]),
                Matricula = Convert.ToInt32(line["matricula"]),
                Nome = Convert.ToString(line["nome"]),
                FkFuncao = Convert.ToInt32(line["fk_funcao"]),
                DataAdmissao = Convert.ToDateTime(line["data_admissao"]),
                CargaHoraria = Convert.ToInt32(line["carga_horaria"])
            };
            return csFuncionario;
        }
        #endregion
    }
}
