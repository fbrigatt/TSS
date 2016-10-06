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
    public partial class SelecionarCaixa : Form
    {
        int cod_caixa;
        string nome_caixa;

        public int Cod_caixa
        {
            get
            {
                return cod_caixa;
            }

            set
            {
                cod_caixa = value;
            }
        }

        public string Nome_caixa
        {
            get
            {
                return nome_caixa;
            }

            set
            {
                nome_caixa = value;
            }
        }

        public SelecionarCaixa()
        {
            InitializeComponent();

            this.AplicarPadroes();
            dataGridCaixas.AplicarPadroes();
            CarregaCaixas();

            this.ShowDialog();
        }

        private void CarregaCaixas(Caixas caixas = null)
        {
            dataGridCaixas.Rows.Clear();

            if (caixas == null) caixas = new Caixas(true);

            for(int i = 0; i < caixas.id_todos.Count; i++)
            {
                int idStatus = new Status_caixa().LastID(caixas.id_todos[i]);
                Status_caixa sc = new Status_caixa(idStatus);

                if(!sc.Data_fechamento.HasValue)
                dataGridCaixas.Rows.Add(caixas.id_todos[i], caixas.nome_todos[i], caixas.nome_micro_todos[i]);
            }
        }

        private void txPesquisa_TextChanged(object sender, EventArgs e)
        {
            Caixas caixas = new Caixas();
            caixas.Pesquisar(txPesquisa.Text);
            CarregaCaixas(caixas);
        }

        private void dataGridCaixas_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (!dataGridCaixas.TemLinhas()) return;

                Cod_caixa = dataGridCaixas.IdAtual(0);
                Nome_caixa = dataGridCaixas.CurrentRow.Cells[1].Value.ToString();
                this.Close();
            }
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            if (!dataGridCaixas.TemLinhas()) return;

            Cod_caixa = dataGridCaixas.IdAtual(0);
            Nome_caixa = dataGridCaixas.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }

        private void dataGridCaixas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!dataGridCaixas.TemLinhas()) return;

            Cod_caixa = dataGridCaixas.IdAtual(0);
            Nome_caixa = dataGridCaixas.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }

        private void txPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!dataGridCaixas.TemLinhas()) return;

                Cod_caixa = dataGridCaixas.IdAtual(0);
                Nome_caixa = dataGridCaixas.CurrentRow.Cells[1].Value.ToString();
                this.Close();
            }
        }
    }
}
