using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GuaraTattooSoft.Extencoes;
using System.IO;
using GuaraTattooSoft.Util;
using GuaraTattooSoft.Forms;

namespace GuaraTattooSoft.User_Controls
{
    public partial class ModelosEmail : UserControl
    {
        static string diretorioAtual = Directory.GetCurrentDirectory();
        DirectoryInfo diretorio = new DirectoryInfo(diretorioAtual + "/Modelos de Email/");

        public ModelosEmail()
        {
            InitializeComponent();

            dataGridModelos.AplicarPadroes();
            this.AplicarPadroes();

            CarregaModelos();
        }

        private void CarregaModelos()
        {
            dataGridModelos.Rows.Clear();

            try
            {
                string diretorioAtual = Directory.GetCurrentDirectory(); ;
                DirectoryInfo diretorio = new DirectoryInfo(diretorioAtual + "/Modelos de Email/");
                //Executa função GetFile(Lista os arquivos desejados de acordo com o parametro)
                FileInfo[] Arquivos = diretorio.GetFiles("*.*");

                //Começamos a listar os arquivos
                foreach (FileInfo fileinfo in Arquivos)
                {
                    if (fileinfo.Extension == ".html")
                        dataGridModelos.Rows.Add(fileinfo.Name.Replace(".html", string.Empty));
                }
            }
            catch (Exception ex)
            {
                Erro.Show(ex.Message, "Erro ao carregar arquivos");
            }
        }

        private void dataGridModelos_SelectionChanged(object sender, EventArgs e)
        {
            if (!dataGridModelos.TemLinhas()) return;

            string curDir = Directory.GetCurrentDirectory();
            string nomeArquivo = dataGridModelos.CurrentRow.Cells[0].Value.ToString();
            string full = curDir + "/Modelos de Email/" + nomeArquivo + ".html";
            visualizar.Url = new Uri(String.Format(full, curDir));
        }

        private void btCriar_Click(object sender, EventArgs e)
        {
            CriaModeloEmail cme = new CriaModeloEmail();
            cme.ShowDialog();
            CarregaModelos();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (!dataGridModelos.TemLinhas()) return;

            string nomeArquivo = dataGridModelos.CurrentRow.Cells[0].Value.ToString() + ".html";

            File.Delete(diretorio + nomeArquivo);

            Sucesso.Show("Modelo excluido!");

            CarregaModelos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!dataGridModelos.TemLinhas()) return;

            string nomeArquivo = dataGridModelos.CurrentRow.Cells[0].Value.ToString() + ".html";

            UsarComo usarComo = new UsarComo(diretorio + nomeArquivo);
            usarComo.ShowDialog();
        }
    }
}
