using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuaraTattooSoft.Relatorios
{
    public partial class ExibeRelatorio : Form
    {
        public ExibeRelatorio(string reportPath, List<ReportDataSource> rds)
        {
            InitializeComponent();
            
            RV.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            LocalReport localReport = RV.LocalReport;
            localReport.ReportPath = reportPath;

            foreach (ReportDataSource rd in rds)
            {
                localReport.DataSources.Add(rd);
            }

            RV.RefreshReport();
            this.WindowState = FormWindowState.Maximized;
            this.ShowDialog();
        }

        public ExibeRelatorio(string reportPath, List<ReportDataSource> rds, string[] parameters)
        {
            InitializeComponent();

            RV.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            LocalReport localReport = RV.LocalReport;
            localReport.ReportPath = reportPath;

            foreach (ReportDataSource rd in rds)
            {
                localReport.DataSources.Add(rd);
            }
            
            foreach(string parameter in parameters)
            {
                string str = parameter;
                string name = str.Split(':')[0];
                string value = str.Split(':')[1];

                ReportParameter reportParameter = new ReportParameter();
                reportParameter.Name = name;
                reportParameter.Values.Add(value);
                
                localReport.SetParameters(reportParameter);
            }

            RV.RefreshReport();
            this.WindowState = FormWindowState.Maximized;
            this.ShowDialog();
        }

        private void ExibeRelatorio_Load(object sender, EventArgs e)
        {
        }
    }
}
