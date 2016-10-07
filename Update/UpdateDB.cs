using GuaraTattooSoft.DBConnection;
using MySql.Data.MySqlClient;
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
    public partial class UpdateDB : Form
    {
        public UpdateDB()
        {
            InitializeComponent();
        }
        private void UpdateDB_Load(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                MySqlConnection conn = null;
                MySqlTransaction transaction = null;
                string cmdAtual = string.Empty;
                try
                {
                    conn = new Conexao().GetConexao();
                    transaction = conn.BeginTransaction(IsolationLevel.ReadUncommitted);

                    string diretorio = Directory.GetCurrentDirectory() + @"\RC\scripts.sql";
                    byte[] bytes = File.ReadAllBytes(diretorio);
                    string sql = Encoding.UTF8.GetString(bytes);
                    string[] blocks = sql.Split(';');
                    progresso.Invoke(new Action<ProgressBar>(maximo => progresso.Maximum = blocks.Length), progresso);
                    for (int i = 0; i < blocks.Length; i++)
                    {

                        cmdAtual = blocks[i].TrimStart();
                        if (string.IsNullOrEmpty(cmdAtual)) continue;
                        MySqlCommand cmd = new MySqlCommand(cmdAtual, transaction.Connection);
                        cmd.ExecuteNonQuery();

                        progresso.Invoke(new Action<ProgressBar>(incr => progresso.Value++), progresso);

                        for(int w = 0; w < 10000000; w ++)
                        {

                        }
                    }
                    transaction.Commit();
                    this.Invoke(new Action<Form>(fechar => this.Close()), this);
                }
                catch (Exception ex)
                {
                    if (transaction != null) transaction.Rollback();
                    if (conn != null) conn.Close();
                    string msg = DateTime.Now.ToLongDateString();
                    msg += "\n Erro ao atualizar banco";
                    msg += "\n Comando: ";
                    msg += "\n " + cmdAtual;
                    msg += "\n\n";
                    msg += " Inner exception: ";
                    msg += "\n " + ex.Message;
                    Log.Write(msg);
                    MessageBox.Show("Ocorreu um problema durante a atualização do banco de dados. \nVerifique o arquivo de despejo gerado em C:/Temp/ para mais detalhes.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Invoke(new Action<Form>(fechar => this.Close()), this);
                }
            }).Start();
        }
    }
}
