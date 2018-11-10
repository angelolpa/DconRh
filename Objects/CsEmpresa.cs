using System;

namespace Objects
{
    public class CsEmpresa
    {
        #region Atributos
        private int id;
        private string nome;
        private string cnpj;
        private string telefone;
        private string endereco;
        #endregion

        #region Propriedades
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        #endregion

        #region Auxiliar
        public CsEmpresa CsEmpresaDataGridView(System.Data.DataRow line)
        {
            CsEmpresa csEmpresa = new CsEmpresa
            {
                Id = Convert.ToInt32(line["id"]),
                Nome = Convert.ToString(line["nome"]),
                Cnpj = Convert.ToString(line["cnpj"]),
                Telefone = Convert.ToString(line["telefone"]),
                endereco = Convert.ToString(line["endereco"])
            };

            return csEmpresa;
        }
        #endregion

    }
}
