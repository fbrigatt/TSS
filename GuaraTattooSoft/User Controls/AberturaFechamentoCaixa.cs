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
using GuaraTattooSoft.Util;
using GuaraTattooSoft.Extencoes;
using GuaraTattooSoft.Relatorios.DataSets;
using Microsoft.Reporting.WinForms;
using GuaraTattooSoft.Relatorios;

namespace GuaraTattooSoft.User_Controls
{
    public partial class AberturaFechamentoCaixa : UserControl
    {

        int status;

        public AberturaFechamentoCaixa()
        {
            InitializeComponent();

            this.AplicarPadroes();

            CarregaCaixas();

            txCodUsuario.Text = Temp.Logado.Id.ToString();
            txNomeUsuario.Text = Temp.Logado.Nome;
        }

        private void CarregaCaixas()
        {
            Caixas cx = new Caixas(true);

            List<KeyValuePair<int, string>> caixas = new List<KeyValuePair<int, string>>();

            for (int i = 0; i < cx.id_todos.Count; i++)
            {
                caixas.Add(new KeyValuePair<int, string>(cx.id_todos[i], cx.nome_todos[i]));
            }

            cbCaixa.DisplayMember = "value";
            cbCaixa.ValueMember = "key";
            cbCaixa.DataSource = new BindingSource(caixas, null);
            //  if (cbCaixa.Items[0] != null) { cbCaixa.SelectedItem = cbCaixa.Items[0].ToString(); }
        }

        private void VerificaCaixa()
        {
            int id = int.Parse(cbCaixa.SelectedValue.ToString());
            Status_caixa sc = new Status_caixa(new Status_caixa().LastID(id));

            if (sc.Data_fechamento == null)
            {
                status = (int)Status.aberto;
                lbStatus.ForeColor = Color.Green;
                lbStatus.Text = "Caixa aberto";
                btAcao.Text = "&FECHAR CAIXA";

                txValor.Visible = false;
                lbValor.Visible = false;
            }

            else
            {
                status = (int)Status.fechado;
                lbStatus.ForeColor = Color.Red;
                lbStatus.Text = "Caixa fechado";
                btAcao.Text = "&ABRIR CAIXA";

                txValor.Visible = true;
                lbValor.Visible = true;
            }
        }

        private void GeraRelatorio(Status_caixa sc)
        {
            DataSet ds = new DsCaixa_1();

            string dataAbertura = ((DateTime)sc.Data_abertura).ToString("yyyy-MM-dd HH:mm:ss");
            string dataFechamento = ((DateTime)sc.Data_fechamento).ToString("yyyy-MM-dd HH:mm:ss");

            Movimentos m = new Movimentos();
            m.CarregarPorCaixa(sc.Caixas_id, dataAbertura, dataFechamento);

            for (int i = 0; i < m.id_todos.Count; i++)
            {
                Formas_pagamento fpg = new Formas_pagamento().GetByMovimento(m.id_todos[i]);

                ds.Tables["movimentos"].Rows.Add(m.data_movimento_todos[i],
                                                    new Tipos_movimento(m.tipos_movimento_id_todos[i]).Descricao,
                                                    new Usuarios(m.usuarios_id_todos[i]).Nome,
                                                    m.GetProfissional(sc.Caixas_id, dataAbertura, dataFechamento).Nome,
                                                    fpg.Descricao,
                                                    0,
                                                    m.Total(m.id_todos[i])

                    );
            }

            ReportDataSource rds_movimentos = new ReportDataSource();
            rds_movimentos.Name = "movimentos";
            rds_movimentos.Value = ds.Tables["movimentos"];
            new ExibeRelatorio("Relatorios/reports/RelatorioCaixa.rdlc", new List<ReportDataSource>() { rds_movimentos });
        }

        public enum Status
        {
            fechado = 0,
            aberto = 1
        }

        private void cbCaixa_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificaCaixa();
        }

        private void btAcao_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        private void Gravar()
        {
            int idCaixa = int.Parse(cbCaixa.SelectedValue.ToString());
            Status_caixa sc;

            if (status == (int)Status.aberto)
            {
                sc = new Status_caixa(new Status_caixa().LastID(idCaixa));
                sc.Data_fechamento = DateTime.Now;
                sc.Atualizar(new Status_caixa().LastID(idCaixa));

                GeraRelatorio(sc);
            }

            if (status == (int)Status.fechado)
            {
                sc = new Status_caixa();

                sc.Caixas_id = idCaixa;
                sc.Data_abertura = DateTime.Now;
                sc.Gravar();

                Totais_caixa tc = new Totais_caixa();
                tc.Caixas_id = idCaixa;
                tc.Valor = (decimal)txValor.Value;
                tc.Data = DateTime.Now;
                tc.Gravar();

                Sucesso.Show("Caixa aberto!");
            }

            txValor.Value = 0;

            VerificaCaixa();
        }
    }
}
