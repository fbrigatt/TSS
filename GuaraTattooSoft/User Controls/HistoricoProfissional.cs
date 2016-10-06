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
    public partial class HistoricoProfissional : UserControl
    {
        public HistoricoProfissional()
        {
            InitializeComponent();

            dataGridServicos.AplicarPadroes();
            dataGridProfissionais.AplicarPadroes();

            this.AplicarPadroes();

            CarregaProfissionais();

            txDataFinal.Visible = false;
            txDataInicial.Visible = false;
            btExibir.Visible = false;
            lb_de.Visible = false;
            lb_ate.Visible = false;
        }

        private void CarregaProfissionais(Profissionais prof = null)
        {
            dataGridProfissionais.Rows.Clear();
            if (prof == null) prof = new Profissionais(true);

            for (int i = 0; i < prof.id_todos.Count; i++)
            {
                dataGridProfissionais.Rows.Add(prof.id_todos[i], prof.nome_todos[i]);
            }

        }

        private void CarregaServicos(Servicos serv = null)
        {
            lbTotalProf.Text = "Total do profissional: R$ ";
            if (!dataGridProfissionais.TemLinhas()) return;

            dataGridServicos.Rows.Clear();

            if (serv == null)
            {
                serv = new Servicos();
                int codProfissional = dataGridProfissionais.IdAtual(0);
                serv.ApenasProfissional(codProfissional);
            }

            decimal valorProf = 0;

            for (int i = 0; i < serv.id_todos.Count; i++)
            {
                Tipos_servico ts = new Tipos_servico(serv.tipos_servico_id_todos[i]);
                Clientes cliente = new Clientes(serv.clientes_id_todos[i]);
                Profissionais prof = new Profissionais(int.Parse(dataGridProfissionais.CurrentRow.Cells[0].Value.ToString()));

                decimal valorComissao = (decimal)prof.Comissao;
                decimal valorTotalComissao = serv.valor_servico_todos[i] / 100 * valorComissao;
                decimal total = serv.valor_servico_todos[i] - valorTotalComissao;

                dataGridServicos.Rows.Add(serv.id_todos[i], ts.Descricao, serv.data_servico_todos[i].ToShortDateString(), cliente.Nome, serv.valor_servico_todos[i], valorTotalComissao);

                valorProf += valorTotalComissao;
            }

            lbTotalProf.Text += valorProf.ToString("N2");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CarregaServicos();
            timer1.Stop();
        }

        private void dataGridProfissionais_SelectionChanged(object sender, EventArgs e)
        {
            CarregaServicos();
        }

        private void cbExibir_SelectedIndexChanged(object sender, EventArgs e)
        {
            Servicos serv = new Servicos();
            int codProfissional = dataGridProfissionais.IdAtual(0);

            if (cbExibir.Text == "Apenas este mês")
            {
                serv.ApenasProfissional(codProfissional);
                CarregaServicos(serv);

                txDataFinal.Visible = false;
                txDataInicial.Visible = false;
                btExibir.Visible = false;
                lb_de.Visible = false;
                lb_ate.Visible = false;
            }

            if (cbExibir.Text == "Por período")
            {
                txDataFinal.Visible = true;
                txDataInicial.Visible = true;
                btExibir.Visible = true;
                lb_de.Visible = true;
                lb_ate.Visible = true;

                txDataInicial.Value = DateTime.Now.Date;
                txDataFinal.Value = DateTime.Now.Date;
            }

            if (cbExibir.Text == "Tudo")
            {
                serv.ApenasProfissional(codProfissional, false);
                CarregaServicos(serv);

                txDataFinal.Visible = false;
                txDataInicial.Visible = false;
                btExibir.Visible = false;
                lb_de.Visible = false;
                lb_ate.Visible = false;
            }
        }

        private void txPesquisa_TextChanged(object sender, EventArgs e)
        {
            txPesquisa.Text = txPesquisa.Text.Replace("'", string.Empty);

            dataGridProfissionais.Rows.Clear();

            Profissionais prof = new Profissionais();
            prof.Pesquisar("nome", txPesquisa.Text);

            for (int i = 0; i < prof.id_todos.Count; i++)
            {
                dataGridProfissionais.Rows.Add(prof.id_todos[i], prof.nome_todos[i]);
            }
        }

        private void CarregaServicosPorPeriodo(Servicos serv = null)
        {
            lbTotalProf.Text = "Total do profissional: R$ ";
            if (!dataGridProfissionais.TemLinhas()) return;

            dataGridServicos.Rows.Clear();

            if (serv == null)
            {
                serv = new Servicos();
                int codProfissional = dataGridProfissionais.IdAtual(0);
                serv.ApenasProfissional(codProfissional, txDataInicial.Value, txDataFinal.Value);
            }

            decimal valorProf = 0;

            for (int i = 0; i < serv.id_todos.Count; i++)
            {
                if (serv.data_servico_todos[i].Date >= txDataInicial.Value && serv.data_servico_todos[i].Date <= txDataFinal.Value)
                {
                    Tipos_servico ts = new Tipos_servico(serv.tipos_servico_id_todos[i]);
                    Clientes cliente = new Clientes(serv.clientes_id_todos[i]);
                    Profissionais prof = new Profissionais(int.Parse(dataGridProfissionais.CurrentRow.Cells[0].Value.ToString()));

                    decimal valorComissao = (decimal)prof.Comissao;
                    decimal valorTotalComissao = serv.valor_servico_todos[i] / 100 * valorComissao;
                    decimal total = serv.valor_servico_todos[i] - valorTotalComissao;

                    dataGridServicos.Rows.Add(serv.id_todos[i], ts.Descricao, serv.data_servico_todos[i].ToShortDateString(), cliente.Nome, serv.valor_servico_todos[i], valorTotalComissao);

                    valorProf += valorTotalComissao;
                }
            }

            lbTotalProf.Text += valorProf.ToString("N2");
        }

        private void btExibir_Click(object sender, EventArgs e)
        {
            CarregaServicosPorPeriodo();
        }
    }
}
