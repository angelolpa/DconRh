using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class CsFuncao
    {
        #region Atributo
        private int id;
        private string nome;
        private string descricao;
        #endregion
        #region Propriedades
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        #endregion
        private CsFuncao CsFuncaoDataGridView(System.Data.DataRow line)
        {
            CsFuncao csFuncao = new CsFuncao
            {
                Id =  Convert.ToInt32(line["id"]),
                Nome = Convert.ToString(line["nome"]),
                Descricao = Convert.ToString(line["descricao"])
            };
            return csFuncao;

        }
    }
}
