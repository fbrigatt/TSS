using DiscUtils.Iso9660;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Update
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Exibir();
        }

        private void Exibir()
        {
            try
            {
                recursos.Items.Clear();
                StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + @"\info.txt", Encoding.Default);
                string line = string.Empty;

                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("versao"))
                    {
                        recursos.Items.Add("Versão da atualização: " + line.Split(':')[1]);
                        continue;
                    }

                    recursos.Items.Add(line);
                }

                reader.Close();
            }
            catch (Exception ex)
            {

            }
        }
        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Instalar()
        {
            if (!txDiretorio.Text.EndsWith(@"\")) txDiretorio.Text += @"\";
            try
            {
                new Thread(() =>
                {

                    string diretorioAtual = Directory.GetCurrentDirectory();
                    DirectoryInfo diretorio = new DirectoryInfo(diretorioAtual);
                    //Executa função GetFile(Lista os arquivos desejados de acordo com o parametro)
                    FileInfo[] Arquivos = diretorio.GetFiles("*.*");
                    DirectoryInfo[] dir = diretorio.GetDirectories("*.*");

                    int count = Arquivos.Length;

                    foreach (DirectoryInfo di in dir)
                    {
                        count += di.GetFiles().Length;
                    }

                    progresso.Invoke(new Action<ProgressBar>(maximo => progresso.Maximum = count), progresso);

                    //Começamos a listar os arquivos
                    foreach (FileInfo fileinfo in Arquivos)
                    {
                        fileinfo.CopyTo(txDiretorio.Text + fileinfo.Name, true);
                        progresso.Invoke(new Action<ProgressBar>(incr => progresso.Value++), progresso);
                    }

                    foreach (DirectoryInfo di in dir)
                    {
                        if (!Directory.Exists(txDiretorio + di.Name)) Directory.CreateDirectory(txDiretorio.Text + di.Name);

                        foreach (FileInfo file in di.GetFiles())
                        {
                            string dName = txDiretorio.Text + di.Name + @"\" + file.Name;
                            file.CopyTo(dName, true);
                            progresso.Invoke(new Action<ProgressBar>(incr => progresso.Value++), progresso);
                        }
                    }
                    MessageBox.Show("Sucesso", "Atualização concluída com exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                ).Start();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro", "Ocorreu um problema ao instalar a nova versão: \n\n" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Instalar();
        }

        private void btUpDB_Click(object sender, EventArgs e)
        {
            new UpdateDB().ShowDialog();
        }
    }
}
