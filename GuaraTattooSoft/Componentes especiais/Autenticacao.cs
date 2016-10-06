using GuaraTattooSoft.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuaraTattooSoft.Componentes_especiais
{
    public partial class Autenticacao : Form
    {

        public bool autorizado = false;

        public Autenticacao()
        {
            InitializeComponent();

            this.ShowDialog();
        }

        private void Autenticar()
        {
            Usuarios usuarios = new Usuarios(true);

            for (int i = 0; i < usuarios.id_todos.Count; i++)
            {
                if(usuarios.admin_todos[i] && usuarios.senha_todos[i] == txSenha.Text)
                {
                    autorizado = true;
                    this.Close();
                }
            }

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autenticar();
        }

        private void txSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Autenticar();
            }
        }
    }
}
