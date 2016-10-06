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
    public partial class CadastroTipoServico : Form
    {
        bool modoEdicao = false;

        public CadastroTipoServico()
        {
            InitializeComponent();

            this.AplicarPadroes();
            dataGridServicos.AplicarPadroes();

            AtualizaDataGrid();
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        private void Gravar()
        {
            Tipos_servico ts = new Tipos_servico();

            ts.Descricao = txDescricao.Text;
            ts.Ativo = ckAtivo.Checked == true ? ts.Ativo = true : ts.Ativo = false;

            if (modoEdicao == true)
            {
                int id = int.Parse(dataGridServicos.CurrentRow.Cells[0].Value.ToString());
                ts.Atualizar(id);
                modoEdicao = false;
            }
            else
            {
                ts.Gravar();
            }

            txDescricao.Text = string.Empty;

            AtualizaDataGrid();
        }

        private void AtualizaDataGrid()
        {
            dataGridServicos.Rows.Clear();

            Tipos_servico ts = new Tipos_servico(true);

            for(int i = 0; i < ts.id_todos.Count; i++)
            {
                string ativo = ts.ativo_todos[i] == true ? ativo = "SIM" : ativo = "NÃO";
                dataGridServicos.Rows.Add(ts.id_todos[i], ts.descricao_todos[i], ativo);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (!dataGridServicos.TemLinhas()) return;

            int id = dataGridServicos.IdAtual(0);

            Tipos_servico ts = new Tipos_servico();
            ts.Deletar(id);

            modoEdicao = false;

            AtualizaDataGrid();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (!dataGridServicos.TemLinhas()) return;

            modoEdicao = true;

            txDescricao.Text = dataGridServicos.CurrentRow.Cells[1].Value.ToString();
            if (dataGridServicos.CurrentRow.Cells[2].Value.ToString().Equals("SIM"))
            {
                ckAtivo.Checked = true;
            }
            else
            {
                ckAtivo.Checked = false;
            }
        }

        private void btProximo_Click(object sender, EventArgs e)
        {
            CadastroAnamneses ca = new CadastroAnamneses();
            ca.Show();
            this.Hide();
        }
    }
}
