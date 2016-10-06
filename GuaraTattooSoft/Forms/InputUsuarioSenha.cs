using GuaraTattooSoft.Extencoes;
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

namespace GuaraTattooSoft.Forms
{
    public partial class InputUsuarioSenha : Form
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public InputUsuarioSenha()
        {
            InitializeComponent();

            this.AplicarPadroes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txNomeUsuario.Text) || string.IsNullOrWhiteSpace(txSenha.Text)) { Atencao.Show("Insira o nome do usuário e senha!"); return; }
            Usuario = txNomeUsuario.Text;
            Senha = txRe_senha.Text;

            this.Close();
        }

        private void txRe_senha_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txNomeUsuario.Text) || string.IsNullOrWhiteSpace(txSenha.Text)) { Atencao.Show("Insira o nome do usuário e senha!"); return; }
                Usuario = txNomeUsuario.Text;
                Senha = txRe_senha.Text;

                this.Close();
            }
        }
    }
}
