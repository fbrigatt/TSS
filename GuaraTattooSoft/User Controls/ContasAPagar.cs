using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GuaraTattooSoft.Entidades;
using GuaraTattooSoft.Extencoes;
using GuaraTattooSoft.Forms;

namespace GuaraTattooSoft.User_Controls
{
    public partial class ContasAPagar : UserControl
    {
        public ContasAPagar()
        {
            InitializeComponent();

            this.AplicarPadroes();
            dataGridContas.AplicarPadroes();

            AtualizaDataGrid();

            btRegistrarPag.Visible = false;
        }

        private void AtualizaDataGrid(Contas_pagar cp = null)
        {
            if (cp == null)
            {
                if (rdPagas.Checked) cp = new Contas_pagar(ckApenasEsteMes.Checked, true, (int)Contas_pagar.Filtros.apenasPagas);
                if (rdNaoPagas.Checked) cp = new Contas_pagar(ckApenasEsteMes.Checked, true, (int)Contas_pagar.Filtros.apenasNaoPagas);
                if (rdTodas.Checked) cp = new Contas_pagar(ckApenasEsteMes.Checked, true, 3);
            }

            dataGridContas.Rows.Clear();

            for (int i = 0; i < cp.id_todos.Count; i++)
            {
                string pago = cp.pago_todos[i] == true ? pago = "SIM" : pago = "NÃO";
                Formas_pagamento forma_pag = new Formas_pagamento(cp.formas_pagamento_id_todos[i]);
                dataGridContas.Rows.Add(cp.id_todos[i], cp.movimentos_id_todos[i], cp.descricao_todos[i], cp.parcelas_todos[i], forma_pag.Descricao, cp.emitente_todos[i], cp.destinatario_todos[i], cp.valor_todos[i], cp.vencimento_todos[i].ToShortDateString(), cp.juros_todos[i], pago);
            }

        }

        private void dataGridContas_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridContas.CurrentRow.Cells[10].Value.ToString() == "SIM") btRegistrarPag.Visible = false;
            if (dataGridContas.CurrentRow.Cells[10].Value.ToString() == "NÃO") btRegistrarPag.Visible = true;
        }

        private void txPesquisa_TextChanged(object sender, EventArgs e)
        {
            string termo = string.Empty;

            switch (cbFiltro.Text)
            {
                case "Descrição": termo = "descricao"; break;
                case "Data de vencimento": termo = "vencimento"; break;
                case "Emitente": termo = "emitente"; break;
                case "Destinatário": termo = "destinatario"; break;
                case "Movimento": termo = "movimentos_id"; break;
            }

            Contas_pagar cp = new Contas_pagar();

            if (rdNaoPagas.Checked) cp.Pesquisar(termo, txPesquisa.Text, (int)Contas_pagar.Filtros.apenasNaoPagas, ckApenasEsteMes.Checked);
            if (rdPagas.Checked) cp.Pesquisar(termo, txPesquisa.Text, (int)Contas_pagar.Filtros.apenasPagas, ckApenasEsteMes.Checked);
            if (rdTodas.Checked) cp.Pesquisar(termo, txPesquisa.Text, 3, ckApenasEsteMes.Checked);
            AtualizaDataGrid(cp);
        }

        private void rdNaoPagas_CheckedChanged(object sender, EventArgs e)
        {
            AtualizaDataGrid();
        }

        private void rdPagas_CheckedChanged(object sender, EventArgs e)
        {
            AtualizaDataGrid();
        }

        private void rdTodas_CheckedChanged(object sender, EventArgs e)
        {
            AtualizaDataGrid();
        }

        private void btRegistrarPag_Click(object sender, EventArgs e)
        {
            int id = dataGridContas.IdAtual(0);
            PagConta pgConta = new PagConta(id, this, (int)PagConta.TiposConta.pagar);
            pgConta.ShowDialog();
        }

        public void Atualizar()
        {
            AtualizaDataGrid();
        }

        private void ckApenasEsteMes_CheckedChanged(object sender, EventArgs e)
        {
            AtualizaDataGrid();
        }
    }
}
