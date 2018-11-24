using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Objects;
using Trabalho;
using Microsoft.Reporting.WinForms;

namespace DconRh.relatório
{
    public partial class Form1 : Form
    {

        ReportDataSource reportDataSource = new ReportDataSource();

        CsCollectionPrestaServico csCollectionPrestaServico = new CsCollectionPrestaServico();
        CsPrestaServicoCommand csPrestaServicoCommand = new CsPrestaServicoCommand();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Configuracao();
            this.reportViewer1.RefreshReport();
        }

        private CsCollectionPrestaServico CsCollectionPresta_Preencher()
        {
            return csPrestaServicoCommand.SeacherNameFuncionario(null, null); ;
        }

        private void Configuracao()
        {
            ReportDataSource reportDataSource = new ReportDataSource
            {
                Name = "DataSetPrestaServico",
                Value = CsCollectionPresta_Preencher()
            };

            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;
            this.reportViewer1.Update();
        }
    }
}
