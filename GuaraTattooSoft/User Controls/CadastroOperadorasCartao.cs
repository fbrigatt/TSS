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
    
    public partial class CadastroOperadorasCartao : UserControl
    {

        bool modoEdicao = false;

        public CadastroOperadorasCartao()
        {
            InitializeComponent();

            this.AplicarPadroes();
            dataGridOperadoras.AplicarPadroes();

            AtualizaDataGrid();
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        private void Gravar()
        {
            if (string.IsNullOrWhiteSpace(txNome.Text)) return;

            Operadoras_cartao oc = new Operadoras_cartao();

            oc.Descricao = txNome.Text;
            oc.Ativo = ckAtivo.Checked == true ? oc.Ativo = true : oc.Ativo = false;
            oc.Credito_dias_pagamento = txCredito.Value;
            oc.Debito_horas_pagamento = txDebito.Value;
            oc.Taxa = txTaxa.Value;

            if(modoEdicao == true)
            {
                int id = dataGridOperadoras.IdAtual(0);

                oc.Atualizar(id);
            }
            else
            {
                oc.Gravar();
            }

            AtualizaDataGrid();

        }

        private void AtualizaDataGrid()
        {
            dataGridOperadoras.Rows.Clear();

            Operadoras_cartao oc = new Operadoras_cartao(true);

            for(int i = 0; i < oc.id_todos.Count; i++)
            {
                string ativo = oc.ativo_todos[i] == true ? ativo = "SIM" : ativo = "NÃO";
                dataGridOperadoras.Rows.Add(oc.id_todos[i], oc.descricao_todos[i], ativo, oc.credito_dias_pagamento_todos[i], oc.debito_horas_pagamento_todos[i], oc.taxa_todos[i]);
            }

            modoEdicao = false;
            this.LimparCampos();

            txCredito.Value = 0;
            txDebito.Value = 0;
            txTaxa.Value = 0;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (!dataGridOperadoras.TemLinhas()) return;

            int id = dataGridOperadoras.IdAtual(0);
            Operadoras_cartao oc = new Operadoras_cartao();
            oc.Deletar(id);

            AtualizaDataGrid();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (!dataGridOperadoras.TemLinhas()) return;

            int id = dataGridOperadoras.IdAtual(0);
            Operadoras_cartao oc = new Operadoras_cartao(id);

            txNome.Text = oc.Descricao;
            if (oc.Ativo == true) { ckAtivo.Checked = true; } else { ckAtivo.Checked = false; }
            txCredito.Value = oc.Credito_dias_pagamento;
            txDebito.Value = oc.Debito_horas_pagamento;
            txTaxa.Value = oc.Taxa;

            modoEdicao = true;
        }
    }
}
