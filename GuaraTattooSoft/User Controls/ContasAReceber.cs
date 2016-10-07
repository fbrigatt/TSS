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
    public partial class ContasAReceber : UserControl
    {
        public ContasAReceber()
        {
            InitializeComponent();

            this.AplicarPadroes();
            dataGridContas.AplicarPadroes();

            AtualizaDataGrid();

            btRegistrarPag.Visible = false;
        }

        public enum Filtros
        {
            apenasNaoPagas = 0,
            apenasPagas = 1,
        }

        private void AtualizaDataGrid(Contas_receber cr = null)
        {
            if (cr == null)
            {

                if (rdPagas.Checked) cr = new Contas_receber(true, (int)ContasAReceber.Filtros.apenasPagas, ckApenasEsteMes.Checked);
                if (rdNaoPagas.Checked) cr = new Contas_receber(true, (int)ContasAReceber.Filtros.apenasNaoPagas, ckApenasEsteMes.Checked);
                if (rdTodas.Checked) cr = new Contas_receber(true, 3, ckApenasEsteMes.Checked);
            }

            dataGridContas.Rows.Clear();

            for (int i = 0; i < cr.id_todos.Count; i++)
            {
                string pago = cr.pago_todos[i] == true ? pago = "SIM" : pago = "NÃO";
                Formas_pagamento forma_pag = new Formas_pagamento(cr.formas_pagamento_id_todos[i]);
                dataGridContas.Rows.Add(cr.id_todos[i], cr.movimentos_id_todos[i], cr.descricao_todos[i], cr.parcelas_todos[i], forma_pag.Descricao, cr.emitente_todos[i], cr.destinatario_todos[i], cr.valor_todos[i], cr.vencimento_todos[i].ToShortDateString(), cr.juros_todos[i], pago);
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
                case "Beneficiado": termo = "emitente"; break;
                case "Pagador": termo = "destinatario"; break;
                case "Movimento": termo = "movimentos_id"; break;
            }

            Contas_receber cr = new Contas_receber();

            if (rdNaoPagas.Checked) cr.Pesquisar(termo, txPesquisa.Text, (int)ContasAReceber.Filtros.apenasNaoPagas, ckApenasEsteMes.Checked);
            if (rdPagas.Checked) cr.Pesquisar(termo, txPesquisa.Text, (int)ContasAReceber.Filtros.apenasPagas, ckApenasEsteMes.Checked);
            if (rdTodas.Checked) cr.Pesquisar(termo, txPesquisa.Text, 3, ckApenasEsteMes.Checked);
            AtualizaDataGrid(cr);
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

        public void Atualizar()
        {
            AtualizaDataGrid();
        }

        private void btRegistrarPag_Click(object sender, EventArgs e)
        {
            if (!dataGridContas.TemLinhas()) return;
            int id = dataGridContas.IdAtual(0);
            PagConta pgConta = new PagConta(id, this, (int)PagConta.TiposConta.receber);
            pgConta.ShowDialog();
        }

        private void ckApenasEsteMes_CheckedChanged(object sender, EventArgs e)
        {
            AtualizaDataGrid();
        }
    }
}
