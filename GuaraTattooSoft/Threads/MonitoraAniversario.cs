using GuaraTattooSoft.Entidades;
using GuaraTattooSoft.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuaraTattooSoft.Threads
{
    class MonitoraAniversario
    {
        public Clientes cliente = null;

        System.Timers.Timer timer = new System.Timers.Timer();

        public MonitoraAniversario()
        {
            timer.Interval = 10000;
            timer.Elapsed += Timer_Elapsed;
            timer.Enabled = true;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            timer.Enabled = false;

            cliente = new Clientes(true);

            for (int i = 0; i < cliente.id_todos.Count; i++)
            {

                if (cliente.dataNasc_todos[i] == "  /  /") continue;

                string dataNasc = cliente.dataNasc_todos[i].Remove(5, 5);
             
                string dia = DateTime.Now.Day.ToString();
                string mes = DateTime.Now.Month.ToString();
                
                if (int.Parse(dia) < 10) dia = "0" + dia;
                if (int.Parse(mes) < 10) mes = "0" + mes;

                string mesAtual = dia + "/" + mes;

                if (dataNasc == mesAtual)
                {
                    if (JaEnviado(cliente.id_todos[i]))
                    {
                        continue;
                    }
                    else
                    {
                        Config conf = new Config(true);

                        if (!string.IsNullOrWhiteSpace(conf.ModeloEmailAniv))
                        {
                            StreamReader reader = new StreamReader(conf.ModeloEmailAniv);

                            string body = string.Empty;

                            string linha = string.Empty;

                            string nomeArquivoImagem = string.Empty;

                            while ((linha = reader.ReadLine()) != null)
                            {
                                if (linha.Contains("<img"))
                                {
                                    nomeArquivoImagem = linha.Replace("<img src=\"", string.Empty);
                                    nomeArquivoImagem = nomeArquivoImagem.Replace("\"", string.Empty);
                                    nomeArquivoImagem = nomeArquivoImagem.Replace("height=\"300\" width=\"300\">", string.Empty);
                                    nomeArquivoImagem = nomeArquivoImagem.Replace("height =300", string.Empty);
                                    nomeArquivoImagem = nomeArquivoImagem.Replace("width=300>", string.Empty);
                                    continue;
                                }
                                body += linha;
                            }

                            Loja loja = new Loja(1);

                            string enderecoLoja = loja.Logradouro + ", " + loja.Numero + " - " + loja.Bairro;

                            body = body.ToLower();

                            body = body.Replace("{nome_cliente}", cliente.nome_todos[i]);
                            body = body.Replace("{nome_fantasia}", loja.Nome_fantasia);
                            body = body.Replace("{endereco_loja}", enderecoLoja);
                            body = body.Replace("{data}", DateTime.Now.ToShortDateString());
                            body = body.Replace("{hora}", DateTime.Now.ToShortTimeString());

                            Email email = new Email();

                            if (string.IsNullOrWhiteSpace(cliente.email_todos[i]))
                            {
                                //timer.Enabled = true;
                                continue;
                            }

                            string[] primeiroNome = cliente.nome_todos[i].Split(' ');
                            email.EnviaEmail(conf.EmailLoja, loja.Nome_fantasia, conf.SenhaEmail, cliente.email_todos[i], cliente.nome_todos[i], "Feliz aniversário, " + primeiroNome[0], body, nomeArquivoImagem);

                            string diretorio = Directory.GetCurrentDirectory() + @"\Temp\";
                            string arquivo = "C_ANVDA";

                            StreamWriter writer = File.AppendText(diretorio + arquivo);
                            writer.Write("\n" + cliente.id_todos[i]);
                            writer.Close();
                        }
                    }
                }
            }
            timer.Enabled = true;
        }

        private bool JaEnviado(int clientes_id)
        {
            string diretorio = Directory.GetCurrentDirectory() + @"\Temp\";
            string arquivo = "C_ANVDA";

            StreamReader reader = new StreamReader(diretorio + arquivo);

            try
            {
                if (File.Exists(diretorio + arquivo))
                {
                    string linha = string.Empty;

                    while ((linha = reader.ReadLine()) != null)
                    {
                        if (linha == clientes_id.ToString()) return true;
                    }
                }
                else
                {
                    File.Create(diretorio + arquivo);
                }
            }
            catch (Exception ex)
            {
                Erro.Show(ex.Message, "Erro");
            }
            finally
            {
                reader.Close();
            }

            return false;
        }
    }
}
