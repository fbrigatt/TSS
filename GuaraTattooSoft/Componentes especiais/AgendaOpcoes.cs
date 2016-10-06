using GuaraTattooSoft.Entidades;
using GuaraTattooSoft.Extencoes;
using GuaraTattooSoft.Forms;
using GuaraTattooSoft.Threads;
using GuaraTattooSoft.User_Controls;
using GuaraTattooSoft.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuaraTattooSoft.Componentes_especiais
{
    public partial class AgendaOpcoes : Form
    {
        int id_agenda = 0;
        CardCompromisso cardCompromisso = null;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public AgendaOpcoes(int agenda_id, CardCompromisso cardComp)
        {
            id_agenda = agenda_id;
            cardCompromisso = cardComp;

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        #region Eventos
        private void btExcluir_Click(object sender, EventArgs e)
        {

            this.Close();

            if (new Confirmacao("Deseja realmente excluir este agendamento?").selection == true)
            {
                Entidades.Agenda agenda = new Entidades.Agenda();
                agenda.Deletar(id_agenda);

                AgendaBackController.FlowLayoutPanel.Controls.Clear();
            }
        }

        private void btReagendar_Click(object sender, EventArgs e)
        {
            Reagendar reagendar = new Reagendar(id_agenda, cardCompromisso);
            Close();
            reagendar.ShowDialog();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btServico.BackColor = Color.Teal;
            btServico.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btServico.BackColor = Color.White;
            btServico.ForeColor = Color.Black;
        }

        private void btServico_Click(object sender, EventArgs e)
        {
            Trabalho trabalho = new Trabalho(id_agenda);

            Agenda agenda = new Agenda(id_agenda);
            Clientes cliente = new Clientes(agenda.Clientes_id);

            AbrePagina ap = new AbrePagina(trabalho, "Registro de Procedimentos (" + cliente.Nome + ")");
            trabalho.Focus();
            this.Close();
        }

        private void bt_notificar_MouseEnter(object sender, EventArgs e)
        {
            bt_notificar.BackColor = Color.Teal;
            bt_notificar.ForeColor = Color.White;
        }

        private void bt_notificar_MouseLeave(object sender, EventArgs e)
        {
            bt_notificar.BackColor = Color.White;
            bt_notificar.ForeColor = Color.Black;
        }

        private void btReagendar_MouseEnter(object sender, EventArgs e)
        {
            btReagendar.BackColor = Color.Teal;
            btReagendar.ForeColor = Color.White;
        }

        private void btReagendar_MouseLeave(object sender, EventArgs e)
        {
            btReagendar.BackColor = Color.White;
            btReagendar.ForeColor = Color.Black;
        }

        private void btExcluir_MouseEnter(object sender, EventArgs e)
        {
            btExcluir.BackColor = Color.Teal;
            btExcluir.ForeColor = Color.White;
        }

        private void btExcluir_MouseLeave(object sender, EventArgs e)
        {
            btExcluir.BackColor = Color.White;
            btExcluir.ForeColor = Color.Black;
        }

        private void btFechar_MouseEnter(object sender, EventArgs e)
        {
            btFechar.BackColor = Color.Teal;
            btFechar.ForeColor = Color.White;
        }

        private void btFechar_MouseLeave(object sender, EventArgs e)
        {
            btFechar.BackColor = Color.White;
            btFechar.ForeColor = Color.Black;
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void EnvioEmail()
        {
            try {
                Entidades.Config conf = new Entidades.Config(true);

                if (!string.IsNullOrWhiteSpace(conf.ModeloEmailAgend))
                {
                    StreamReader reader = new StreamReader(conf.ModeloEmailAgend);

                    Agenda agenda = new Agenda(id_agenda);

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

                    if (agenda.Data.Value.Hour == 0)
                    {
                        body = body.Replace(", às {hora}", string.Empty);
                    }
                    else
                    {
                        body = body.Replace("{hora}", agenda.Data.Value.ToShortTimeString() + "h");
                    }

                    body = body.Replace("{data}", agenda.Data.Value.ToShortDateString());
                    body = body.Replace("{nome_profissional}", new Profissionais(agenda.Profissionais_id).Nome);
                    body = body.Replace("{nome_fantasia}", new Loja(1).Nome_fantasia);

                    body = body.Replace("marcado", " marcada");

                    Loja loja = new Loja(1);

                    string enderecoLoja = loja.Logradouro + ", " + loja.Numero + " - " + loja.Bairro;

                    Email email = new Email();

                    Clientes cliente = new Clientes(agenda.Clientes_id);

                    if (string.IsNullOrWhiteSpace(cliente.Email))
                    {
                        Atencao.Show("O envio do email foi cancelado! \nO cliente não possui um endereço de email.");
                        return;
                    }

                    email.EnviaEmail(conf.EmailLoja, loja.Nome_fantasia, conf.SenhaEmail, cliente.Email, cliente.Nome, "Referente ao seu agendamento", body, nomeArquivoImagem, true);
                }
            }catch(Exception ex)
            {

            }
        }

        private void bt_notificar_Click(object sender, EventArgs e)
        {
            EnvioEmail();
            this.Close();
        }
    }
}
