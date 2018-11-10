using System;

namespace Objects
{
    public class CsPrestaServico
    {
        #region Atributos
        private int id;
        private int fkEmpresa;
        private int fkFuncionario;
        private DateTime dataRegistro;
        private DateTime entrada;
        private DateTime intervalo;
        private DateTime saida;
        private DateTime horasTrabalhadas;
        private DateTime horasExtras;
        private DateTime totalHoras;

        public int Id { get => id; set => id = value; }
        public int FkEmpresa { get => fkEmpresa; set => fkEmpresa = value; }
        public int FkFuncionario { get => fkFuncionario; set => fkFuncionario = value; }
        public DateTime DataRegistro { get => dataRegistro; set => dataRegistro = value; }
        public DateTime Entrada { get => entrada; set => entrada = value; }
        public DateTime Intervalo { get => intervalo; set => intervalo = value; }
        public DateTime Saida { get => saida; set => saida = value; }
        public DateTime HorasTrabalhadas { get => horasTrabalhadas; set => horasTrabalhadas = value; }
        public DateTime HorasExtras { get => horasExtras; set => horasExtras = value; }
        public DateTime TotalHoras { get => totalHoras; set => totalHoras = value; }
        #endregion

        #region Auxiliar
        public CsPrestaServico CsPrestaServicoDataGridView(System.Data.DataRow line)
        {
            CsPrestaServico csPrestaServico = new CsPrestaServico
            {
                Id = Convert.ToInt32(line["id"]),
                FkEmpresa = Convert.ToInt32(line["fk_empresa"]),
                FkFuncionario = Convert.ToInt32(line["fk_funcionario"]),
                DataRegistro = Convert.ToDateTime(line["data_registro"]),
                Entrada = Convert.ToDateTime(line["entrada"]),
                Intervalo = Convert.ToDateTime(line["intervalo"]),
                Saida = Convert.ToDateTime(line["saida"]),
                HorasTrabalhadas = Convert.ToDateTime(line["horas_trabalhadas"]),
                HorasExtras = Convert.ToDateTime(line["horas_extras"]),
                TotalHoras = Convert.ToDateTime(line["total_horas"])
            };

            return csPrestaServico;
        }

        #endregion
    }
}
