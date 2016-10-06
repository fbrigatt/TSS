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

namespace GuaraTattooSoft.User_Controls
{
    public partial class CadastroProfissionais : UserControl
    {

        bool modoEdicao = false;

        public CadastroProfissionais()
        {
            InitializeComponent();

            this.AplicarPadroes();
            dataGridProfissionais.AplicarPadroes();

            AtualizaDataGrid();
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        private void Gravar()
        {
            if (string.IsNullOrWhiteSpace(txNome.Text)) return;

            Profissionais profissionais = new Profissionais();

            profissionais.Nome = txNome.Text;
            profissionais.Telefone = txTel_Cel.Text;
            profissionais.Cpf = txCPF.Text;
            profissionais.Data_entrada = txDataEntrada.Text;
            profissionais.Comissao = txComissao.Value;
            profissionais.Ativo = ckAtivo.Checked == true ? profissionais.Ativo = true : profissionais.Ativo = false;

            if (modoEdicao == true)
            {
                int id = dataGridProfissionais.IdAtual(0);
                profissionais.Atualizar(id);
            }
            else
            {
                profissionais.Gravar();
            }

            AtualizaDataGrid();
        }

        private void AtualizaDataGrid()
        {
            dataGridProfissionais.Rows.Clear();
            Profissionais prof = new Profissionais(true);

            for(int i = 0; i < prof.id_todos.Count; i++)
            {
                string ativo = prof.ativo_todos[i] == true ? ativo = "SIM" : ativo = "NÃO";
                dataGridProfissionais.Rows.Add(prof.id_todos[i], prof.nome_todos[i], prof.telefone_todos[i], prof.CPF_todos[i], prof.data_entrada_todos[i],  prof.comissao_todos[i], ativo);
            }

            modoEdicao = false;
            this.LimparCampos();
            ckAtivo.Checked = true;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (!dataGridProfissionais.TemLinhas()) return;

            int id = dataGridProfissionais.IdAtual(0);

            Profissionais profissionais = new Profissionais();
            profissionais.Deletar(id);

            AtualizaDataGrid();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (!dataGridProfissionais.TemLinhas()) return;

            int id = dataGridProfissionais.IdAtual(0);

            Profissionais profissionais = new Profissionais(id);

            txNome.Text = profissionais.Nome;
            txTel_Cel.Text = profissionais.Telefone;
            txCPF.Text = profissionais.Cpf;
            txDataEntrada.Text = profissionais.Data_entrada;
            txComissao.Value = profissionais.Comissao;
            if (profissionais.Ativo == true) { ckAtivo.Checked = true; } else { ckAtivo.Checked = false; }

            modoEdicao = true;

        }
    }
}
