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
    public partial class CadastroTiposServico : UserControl
    {

        bool modoEdicao = false;

        public CadastroTiposServico()
        {
            InitializeComponent();

            this.AplicarPadroes();
            dataGridTiposServ.AplicarPadroes();

            AtualizaDataGrid();
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        private void Gravar()
        {
            if (string.IsNullOrEmpty(txDescricao.Text)) return;

            Tipos_servico ts = new Tipos_servico();

            ts.Descricao = txDescricao.Text;
            ts.Ativo = ckAtivo.Checked == true ? ts.Ativo = true : ts.Ativo = false;


            if (modoEdicao == true)
            {
                int id = dataGridTiposServ.IdAtual(0);
                ts.Atualizar(id);
            }
            else
            {
                ts.Gravar();
            }
            
            AtualizaDataGrid();
        }

        private void AtualizaDataGrid()
        {
            dataGridTiposServ.Rows.Clear();

            Tipos_servico ts = new Tipos_servico(true);

            for(int i = 0; i < ts.id_todos.Count; i++)
            {
                string ativo = ts.ativo_todos[i] == true ? ativo = "SIM" : ativo = "NÃO";
                dataGridTiposServ.Rows.Add(ts.id_todos[i], ts.descricao_todos[i], ativo);
            }

            modoEdicao = false;
            this.LimparCampos();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (!dataGridTiposServ.TemLinhas()) return;

            int id = dataGridTiposServ.IdAtual(0);

            Tipos_servico tipos_servico = new Tipos_servico();
            tipos_servico.Deletar(id);

            AtualizaDataGrid();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (!dataGridTiposServ.TemLinhas()) return;

            int id = dataGridTiposServ.IdAtual(0);
            Tipos_servico ts = new Tipos_servico(id);

            txDescricao.Text = ts.Descricao;
            if(ts.Ativo == true) { ckAtivo.Checked = true; } else { ckAtivo.Checked = false; }

            modoEdicao = true;
        }
    }
}
