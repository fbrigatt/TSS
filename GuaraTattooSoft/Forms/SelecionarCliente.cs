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
    public partial class SelecionarCliente : Form
    {

        private int cod_cliente;
        private string nome_cliente;

        public int Cod_cliente
        {
            get
            {
                return cod_cliente;
            }

            set
            {
                cod_cliente = value;
            }
        }

        public string Nome_cliente
        {
            get
            {
                return nome_cliente;
            }

            set
            {
                nome_cliente = value;
            }
        }

        public SelecionarCliente()
        {
            InitializeComponent();

            this.AplicarPadroes();
            dataGridClientes.AplicarPadroes();

            CarregaClientes();

            this.ShowDialog();
        }

        private void CarregaClientes(Clientes clientes = null)
        {
            dataGridClientes.Rows.Clear();
            if (clientes == null) clientes = new Clientes(true);

            for(int i = 0; i < clientes.id_todos.Count; i++)
            {
                dataGridClientes.Rows.Add(clientes.id_todos[i], clientes.nome_todos[i], clientes.telefone_todos[i], clientes.celular_todos[i], clientes.email_todos[i]);
            }
        }

        private void txPesquisa_TextChanged(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Pesquisar(txPesquisa.Text);
            CarregaClientes(clientes);
        }

        private void txPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (!dataGridClientes.TemLinhas()) return;

                Cod_cliente = dataGridClientes.IdAtual(0);
                Nome_cliente = dataGridClientes.CurrentRow.Cells[1].Value.ToString();

                this.Hide();
            }
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            if (!dataGridClientes.TemLinhas()) return;

            Cod_cliente = dataGridClientes.IdAtual(0);
            Nome_cliente = dataGridClientes.CurrentRow.Cells[1].Value.ToString();

            this.Hide();
        }

        private void dataGridClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!dataGridClientes.TemLinhas()) return;

                Cod_cliente = dataGridClientes.IdAtual(0);
                Nome_cliente = dataGridClientes.CurrentRow.Cells[1].Value.ToString();

                this.Hide();
            }
        }

        private void dataGridClientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!dataGridClientes.TemLinhas()) return;

            Cod_cliente = dataGridClientes.IdAtual(0);
            Nome_cliente = dataGridClientes.CurrentRow.Cells[1].Value.ToString();

            this.Hide();
        }
    }
}
