using GuaraTattooSoft.Extencoes;
using GuaraTattooSoft.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuaraTattooSoft.Forms
{
    public partial class CriaModeloEmail : Form
    {

        public CriaModeloEmail()
        {
            InitializeComponent();

           // this.AplicarPadroes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Arquivos de imagem (*.jpg)|*.jpg|Arquivos de imagem (*.png)|*.png";
            opf.FilterIndex = 0;
            opf.Multiselect = false;

            opf.ShowDialog();

            txCaminho_imagem.Text = opf.FileName;
        }

        private void txConteudo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txConteudo.Text)) return;

            char ch = txConteudo.Text[txConteudo.Text.Length - 1];

            if (ch == '{')
            {
                menu.Show();
            }
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = (e.ClickedItem as ToolStripItem);

            txConteudo.Text += item.Text.Replace("{", string.Empty);
            txConteudo.Text += " ";
            txConteudo.Select(txConteudo.Text.Length, 0);
        }

        private void GerarArquivo()
        {
            string diretorioAtual = Directory.GetCurrentDirectory(); ;
            DirectoryInfo diretorio = new DirectoryInfo(diretorioAtual + "/Modelos de Email/");
            string nomeArquivo = txNome_modelo.Text + ".html";

            StreamWriter arquivo = new StreamWriter(diretorio + nomeArquivo);

            arquivo.Write("<html> \n");
            arquivo.Write("<header>");
            arquivo.Write("<meta charset=\"utf-8\">");
            arquivo.Write("<meta name=\"viewport\" content=\"width = device - width, initial - scale = 1\">");
            arquivo.Write("</header>");
            arquivo.Write("\n\n");
            arquivo.Write("<body> \n");


            string[] strArray = txConteudo.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            for (int i = 0; i < strArray.Length; i++)
            {
                arquivo.Write("<p style=\"font-family:Arial, Helvetica, sans-serif;\">" + strArray[i] + "</p> \n");
            }

            if (!string.IsNullOrWhiteSpace(txCaminho_imagem.Text))
            {
                FileInfo imagemDiretorioExterno = new FileInfo(txCaminho_imagem.Text);
                string fileName = imagemDiretorioExterno.Name;

                FileInfo imagemDiretorioInterno = new FileInfo((diretorio + fileName));

                if (!imagemDiretorioInterno.Exists)
                {
                    File.Copy(txCaminho_imagem.Text, diretorio + fileName);

                    arquivo.Write("\n\n <img src=\"" + fileName + "\" height =\"300\" width=\"300\">");
                }
                else
                {
                    arquivo.Write("\n\n <img src=\"" + fileName + "\" height =\"300\" width=\"300\">");
                }
            }

            arquivo.Write("\n\n</body> \n\n");
            arquivo.Write("</html>");

            arquivo.Close();

            Sucesso.Show("Modelo " + txNome_modelo.Text + " criado com êxito!");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GerarArquivo();
        }
    }
}
