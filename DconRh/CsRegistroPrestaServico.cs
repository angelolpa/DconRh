using System;
using System.Windows.Forms;

using Objects;
using Trabalho;

namespace DconRh
{
    public partial class CsRegistroPrestaServico : Form
    {
        public CsRegistroPrestaServico()
        {
            InitializeComponent();
            CsEmpresa_Preencher();
            CsFuncionario_Preencher();
            DateTime_Atualizar();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
        }
        
        private CsPrestaServico CsPrestaServico()
        {
            try
            {
                CsPrestaServico csPrestaServico = new CsPrestaServico
                {
                    FkEmpresa = CsEmpresa_Fk_Preencher(),
                    FkFuncionario = CsFuncionario_Fk_Preencher(),
                    DataRegistro = DtDataRegistro.Value,
                    Entrada = Convert.ToDateTime(DtEntrada.Value.TimeOfDay.ToString()),
                    Intervalo = Convert.ToDateTime(DtIntervalo.Value.TimeOfDay.ToString()),
                    Saida = Convert.ToDateTime(DtSaida.Value.TimeOfDay.ToString()),
                    HorasTrabalhadas = Convert.ToDateTime(DtTotalHoras.Value.TimeOfDay.ToString()),
                    HorasExtras = Convert.ToDateTime(DtHoraExtra.Value.TimeOfDay.ToString()),
                    TotalHoras = Convert.ToDateTime(DtIntervalo.Value.TimeOfDay.ToString())
                };
                return csPrestaServico;
            }
            catch(Exception exception)
            {
                MessageBox.Show("Ocorreu um erro, detalhes:" + exception.Message);
            }
            return null;
        }

        private CsFuncionario CsFuncionario_Fk_Preencher()
        {
            CsFuncionarioCommand csFuncionarioCommand = new CsFuncionarioCommand();

            return csFuncionarioCommand.SeacherNameFuncionario(" WHERE nome = @Nome ", CboxFuncionario.Text)[0];
        }


        private CsEmpresa CsEmpresa_Fk_Preencher()
        {
            CsEmpresaCommand csEmpresaCommand = new CsEmpresaCommand();

            return csEmpresaCommand.SeacherNameEmpresa(" WHERE nome = @Nome ", CboxEmpresa.Text)[0];
        }

        #region ComboBox_Preencher
        private void CsEmpresa_Preencher()
        {
            CsEmpresaCommand csEmpresaCommand = new CsEmpresaCommand();
            CsCollectionEmpresa csCollectionEmpresa = csEmpresaCommand.SeacherNameEmpresa(null, null);

            try
            {
                foreach (CsEmpresa item in csCollectionEmpresa)
                {
                    CboxEmpresa.Items.Add(item.Nome);
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Não há dados registrados em empresa.");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possivel preencher empresa, detalhes: " + exception.Message);
            }
            finally
            {
                CboxEmpresa.SelectedIndex = 0;
            }
        }
        private void CsFuncionario_Preencher()
        {
            CsFuncionarioCommand csFuncionarioCommand = new CsFuncionarioCommand();
            CsCollectionFuncionario csCollectionFuncionario = csFuncionarioCommand.SeacherNameFuncionario(null, null);

            try
            {
                foreach (CsFuncionario item in csCollectionFuncionario)
                {
                    CboxFuncionario.Items.Add(item.Nome);
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Não há dados registrados em empresa.");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possivel preencher empresa, detalhes: " + exception.Message);
            }
            finally
            {
                CboxFuncionario.SelectedIndex = 0;
            }
        }
        #endregion

        #region DateTime
        private void DateTime_HorasExecutadas()
        {
            TimeSpan timeSpan;

            timeSpan = (DtSaida.Value.TimeOfDay - DtEntrada.Value.TimeOfDay) - DtIntervalo.Value.TimeOfDay;

            DtHExecutada.Value = Convert.ToDateTime(timeSpan.ToString());
        }
        private void DateTime_HorasExtras()
        {
            TimeSpan timeSpan = Convert.ToDateTime("08:00").TimeOfDay;
            TimeSpan.TryParse((DtHExecutada.Value.TimeOfDay - timeSpan).ToString(), out TimeSpan result);
            if (result.TotalHours > 0)
            {
                DtHoraExtra.Value = Convert.ToDateTime(result.ToString());
            }
            else
            {
                DtHoraExtra.Value = Convert.ToDateTime("00:00:00");
            }
        }
        private void DateTime_TotalHoras()
        {
            TimeSpan timeSpan;

            timeSpan = (DtHExecutada.Value.TimeOfDay + DtHoraExtra.Value.TimeOfDay);

            DtTotalHoras.Value = Convert.ToDateTime(timeSpan.ToString());
        }
        private void DateTime_Atualizar()
        {
            DateTime_HorasExecutadas();
            DateTime_HorasExtras();
            DateTime_TotalHoras();
        }
        #endregion

        private void DtSaida_ValueChanged(object sender, EventArgs e)
        {
            DateTime_Atualizar();
        }
        private void DtEntrada_ValueChanged(object sender, EventArgs e)
        {
            DateTime_Atualizar();
        }
        private void DtIntervalo_ValueChanged(object sender, EventArgs e)
        {
            DateTime_Atualizar();
        }
    }
}