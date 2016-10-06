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

namespace GuaraTattooSoft.Forms
{
   
    public partial class SelecionarUsuario : Form
    {

        private int codUsuario;
        private string nomeUsuario;

        public int CodUsuario
        {
            get
            {
                return codUsuario;
            }

            set
            {
                codUsuario = value;
            }
        }

        public string NomeUsuario
        {
            get
            {
                return nomeUsuario;
            }

            set
            {
                nomeUsuario = value;
            }
        }

        public SelecionarUsuario()
        {
            InitializeComponent();
            
            CarregaUsuarios();

            this.AplicarPadroes();
            dataGridUsuarios.AplicarPadroes();

            this.ShowDialog();
        }

        private void CarregaUsuarios(Usuarios usuario = null)
        {
            dataGridUsuarios.Rows.Clear();

            if (usuario == null) usuario = new Usuarios(true);

            for(int i = 0; i < usuario.id_todos.Count; i++)
            {
                dataGridUsuarios.Rows.Add(usuario.id_todos[i], usuario.nome_todos[i]);
            }
        }

        private void txPesquisa_TextChanged(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Pesquisar(txPesquisa.Text);
            CarregaUsuarios(usuarios);
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            if (!dataGridUsuarios.TemLinhas()) return;

            CodUsuario = dataGridUsuarios.IdAtual(0);
            NomeUsuario = dataGridUsuarios.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }

        private void txPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (!dataGridUsuarios.TemLinhas()) return;

                CodUsuario = dataGridUsuarios.IdAtual(0);
                NomeUsuario = dataGridUsuarios.CurrentRow.Cells[1].Value.ToString();

                this.Close();
            }
        }

        private void dataGridUsuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!dataGridUsuarios.TemLinhas()) return;

            CodUsuario = dataGridUsuarios.IdAtual(0);
            NomeUsuario = dataGridUsuarios.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }
    }
}
