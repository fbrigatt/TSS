using GuaraTattooSoft.Entidades;
using GuaraTattooSoft.Extencoes;
using GuaraTattooSoft.User_Controls;
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
    public partial class CadastroAnamneses : Form
    {
        bool modoEdicao;

        CadastroClientes cadastroCli;

        public CadastroAnamneses(bool desativaBtProximo = false, CadastroClientes cadastro = null)
        {
            InitializeComponent();

            this.AplicarPadroes();
            dataGridAnamneses.AplicarPadroes();

            AtualizaDataGrid();

            if(desativaBtProximo == true)
            {
                btProximo.Visible = false;
            }
            
            if(cadastro != null)
            {
                cadastroCli = cadastro;
            } 
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        private void Gravar()
        {
            if (string.IsNullOrWhiteSpace(txDescricao.Text)) return;

            Anamneses anamneses = new Anamneses();

            anamneses.Descricao = txDescricao.Text;

            if (modoEdicao == true)
            {
                int id = dataGridAnamneses.IdAtual(0);
                anamneses.Atualizar(id);
                modoEdicao = false;
            }
            else
            {
                anamneses.Gravar();
            }

            txDescricao.Text = string.Empty;
            AtualizaDataGrid();

            if(cadastroCli != null)
            {
                cadastroCli.CarregaAnamneses();
            }
        }

        private void AtualizaDataGrid()
        {
            dataGridAnamneses.Rows.Clear();
            Anamneses anam = new Anamneses(true);

            for(int i = 0; i < anam.id_todos.Count; i++)
            {
                dataGridAnamneses.Rows.Add(anam.id_todos[i], anam.descricao_todos[i]);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (!dataGridAnamneses.TemLinhas()) return;

            int id = dataGridAnamneses.IdAtual(0);

            Anamneses anam = new Anamneses();
            anam.Deletar(id);
            modoEdicao = false;
            txDescricao.Text = string.Empty;
            AtualizaDataGrid();

            if (cadastroCli != null)
            {
                cadastroCli.CarregaAnamneses();
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (!dataGridAnamneses.TemLinhas()) return;

            modoEdicao = true;

            txDescricao.Text = dataGridAnamneses.CurrentRow.Cells[1].Value.ToString();
        }

        private void btProximo_Click(object sender, EventArgs e)
        {
            CadastroProfissionais cp = new CadastroProfissionais();
            cp.Show();
            this.Close();
        }
    }
}
