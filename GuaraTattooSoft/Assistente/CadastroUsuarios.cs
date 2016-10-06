using GuaraTattooSoft.Entidades;
using GuaraTattooSoft.Extencoes;
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
    public partial class CadastroUsuarios : Form
    {
        bool modoEdicao = false;

        public CadastroUsuarios()
        {
            InitializeComponent();

            this.AplicarPadroes();
            
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();

            usuarios.Nome = txUsuario.Text;
            usuarios.Senha = txSenha.Text;
            usuarios.Cadastro_clientes = ckCadCli.Checked ? usuarios.Cadastro_clientes = true : usuarios.Cadastro_clientes = false;
            usuarios.Cadastro_profissionais = ckCadProf.Checked ? usuarios.Cadastro_profissionais = true : usuarios.Cadastro_profissionais = false;
            usuarios.Lancamento_servicos = ckLancServ.Checked ? usuarios.Lancamento_servicos = true : usuarios.Lancamento_servicos = false;
            usuarios.Admin = true;

            usuarios.Gravar();

            txUsuario.Text = string.Empty;
            txSenha.Text = string.Empty;
            ckCadCli.Checked = false;
            ckCadProf.Checked = false;
            ckLancServ.Checked = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Usuarios usuarios = new Usuarios();

            usuarios.Nome = txUsuario.Text;
            usuarios.Senha = txSenha.Text;
            usuarios.Cadastro_clientes = ckCadCli.Checked ? usuarios.Cadastro_clientes = true : usuarios.Cadastro_clientes = false;
            usuarios.Cadastro_profissionais = ckCadProf.Checked ? usuarios.Cadastro_profissionais = true : usuarios.Cadastro_profissionais = false;
            usuarios.Lancamento_servicos = ckLancServ.Checked ? usuarios.Lancamento_servicos = true : usuarios.Lancamento_servicos = false;
            usuarios.Admin = true;

            usuarios.Gravar();

            txUsuario.Text = string.Empty;
            txSenha.Text = string.Empty;
            ckCadCli.Checked = false;
            ckCadProf.Checked = false;
            ckLancServ.Checked = false;

            CadastroCaixas cc = new CadastroCaixas();
            cc.Show();
            this.Hide();
        }
    }
}
