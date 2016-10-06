using GuaraTattooSoft.Entidades;
using GuaraTattooSoft.Threads;
using GuaraTattooSoft.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuaraTattooSoft.Assistente
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        private void btProximo_Click(object sender, EventArgs e)
        {
            Loja loja = new Loja(1);

            GuaraTattooSoft.Entidades.Config config = new Entidades.Config();

            config.EmailLoja = txEmail.Text;
            config.SenhaEmail = txSenha.Text;
            config.Host = txHost.Text;
            config.Porta = txPorta.Value;

            config.Gravar();

            try
            {
                Email email = new Email();
                email.EnviaEmail(txEmail.Text, "Tattoo Smart Soft", txSenha.Text, txEmail.Text, loja.Nome_fantasia, "Teste de envio de email", "Este é um teste de envio de email gerado pelo software Tattoo Smart Soft. \nSe você está vendo esta mensagem, está tudo ok. \nNão responda este email.");

            } catch(Exception ex)
            {
                Erro.Show("A configuração foi interrompida pelo servidor de email. \nPara corrigir este problema, você será direcionado para uma página de configuração. \nSelecione a opção \"Ativar\" e volte para este assistente.", "Configuração interrompida");
                System.Diagnostics.Process.Start("https://www.google.com/settings/security/lesssecureapps?pli=1");

                config.Deletar();

                return;
            }

            CadastroUsuarios cadastroUsu = new CadastroUsuarios();
            cadastroUsu.Show();
            this.Hide();
        }
    }
}
