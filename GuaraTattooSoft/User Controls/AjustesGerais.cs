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
using GuaraTattooSoft.Entidades;
using System.IO;
using GuaraTattooSoft.Util;
using GuaraTattooSoft.Forms;

namespace GuaraTattooSoft.User_Controls
{
    public partial class AjustesGerais : UserControl
    {
        Config config = new Config(true);

        public AjustesGerais()
        {
            InitializeComponent();

            CarregaConfig();

            this.Dock = DockStyle.Fill;
        }

        private void CarregaConfig()
        {
            txEmail.Text = config.EmailLoja;
            txSenha.Text = config.SenhaEmail;
            txProvedorEmail.Text = config.Host;
            txPorta.Value = config.Porta;
            txRetorno_cliente.Value = config.DiasRetorno_cliente;
            txCodTipo_serv.Value = config.Tipos_servico_id;
            txDescricaoTipoServ.Text = new Tipos_servico(config.Tipos_servico_id).Descricao;
            txImagemLogo.Text = config.ImagemLogo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        private void Gravar()
        {

            config.EmailLoja = txEmail.Text;
            config.SenhaEmail = txSenha.Text;
            config.Host = txProvedorEmail.Text;
            config.Porta = txPorta.Value;
            config.ImagemLogo = txImagemLogo.Text;
            config.DiasRetorno_cliente = txRetorno_cliente.Value;
            config.Tipos_servico_id = txCodTipo_serv.Value;

            config.Atualizar();
        }

        private void btEscolherImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Arquivos de imagem (*.jpg)|*.jpg|Arquivos de imagem (*.png)|*.png";
            opf.FilterIndex = 0;
            opf.Multiselect = false;

            opf.ShowDialog();

            txImagemLogo.Text = opf.FileName;
        }

        private void txCodTipo_serv_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F3)
            {
                SelecionarTipoServico sts = new SelecionarTipoServico();

                txCodTipo_serv.Value = sts.Cod_tipo_serv;
                txDescricaoTipoServ.Text = sts.Descricao_tipo_serv;
            }
        }
    }
}
