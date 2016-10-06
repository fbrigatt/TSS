using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuaraTattooSoft.Relatorios
{
    public partial class VisualizaRelatorios : Form
    {
        public VisualizaRelatorios(ReportDocument rc)
        {
            InitializeComponent();

            crystalReportViewer.ReportSource = rc;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            this.ShowDialog(); 
        }
    }
}
