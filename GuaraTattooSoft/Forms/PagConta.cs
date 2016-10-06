using GuaraTattooSoft.Entidades;
using GuaraTattooSoft.Extencoes;
using GuaraTattooSoft.User_Controls;
using GuaraTattooSoft.Util;
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
    public partial class PagConta : Form
    {
        private int TipoConta;

        Object objt;

        public PagConta(int codConta, Object obj, int tipoConta)
        {
            objt = obj;

            this.TipoConta = tipoConta;

            InitializeComponent();

            CarregaInfoConta(codConta);

            this.AplicarPadroes();
        }

        private void CarregaInfoConta(int id)
        {

            if (TipoConta == (int)PagConta.TiposConta.pagar)
            {
                Contas_pagar cp = new Contas_pagar(id);

                txEmitente.Text = cp.Emitente;
                txDestinatario.Text = cp.Destinatario;
                txCod_mov.Value = cp.Movimentos_id;
                txCod_conta.Value = id;
                txVencimento.Text = cp.Vencimento.ToShortDateString();
                txValor.Value = -(double)cp.Valor;
                txValorPago.Value = txValor.Value;

                Caixas caixas = new Caixas(true);
                List<KeyValuePair<int, string>> nomes_caixas = new List<KeyValuePair<int, string>>();

                for (int i = 0; i < caixas.id_todos.Count; i++)
                {
                    int idStatus_Caixa = new Status_caixa().LastID(caixas.id_todos[i]);
                    Status_caixa sc = new Status_caixa(idStatus_Caixa);

                    if (!sc.Data_fechamento.HasValue)
                    {
                        nomes_caixas.Add(new KeyValuePair<int, string>(caixas.id_todos[i], caixas.nome_todos[i]));
                    }
                }

                cbCaixas.DataSource = new BindingSource(nomes_caixas, null);
                cbCaixas.DisplayMember = "value";
                cbCaixas.ValueMember = "key";
            }

            if (TipoConta == (int)PagConta.TiposConta.receber)
            {
                Contas_receber cr = new Contas_receber(id);

                txEmitente.Text = cr.Emitente;
                txDestinatario.Text = cr.Destinatario;
                txCod_mov.Value = cr.Movimentos_id;
                txCod_conta.Value = id;
                txVencimento.Text = cr.Vencimento.ToShortDateString();
                txValor.Value = (double)cr.Valor;
                txValorPago.Value = txValor.Value;

                Caixas caixas = new Caixas(true);
                List<KeyValuePair<int, string>> nomes_caixas = new List<KeyValuePair<int, string>>();

                for (int i = 0; i < caixas.id_todos.Count; i++)
                {
                    int idStatus_Caixa = new Status_caixa().LastID(caixas.id_todos[i]);
                    Status_caixa sc = new Status_caixa(idStatus_Caixa);

                    if (!sc.Data_fechamento.HasValue)
                    {
                        nomes_caixas.Add(new KeyValuePair<int, string>(caixas.id_todos[i], caixas.nome_todos[i]));
                    }
                }

                cbCaixas.DataSource = new BindingSource(nomes_caixas, null);
                cbCaixas.DisplayMember = "value";
                cbCaixas.ValueMember = "key";

                //if (cbCaixas.Items[0] != null) { cbCaixas.SelectedItem = cbCaixas.Items[0].ToString(); }
            }
        }

        private void Gravar()
        {
            Movimentos mov = new Movimentos();

            mov.Data_movimento = DateTime.Now;
            mov.Obs = txObs.Text;
            mov.Tipos_movimento_id = TipoConta == (int)PagConta.TiposConta.pagar ? mov.Tipos_movimento_id = (int)Tipos_movimento.Fixos.PagamentoConta : mov.Tipos_movimento_id = (int)Tipos_movimento.Fixos.RecebConta;
            mov.Caixas_id = (int)cbCaixas.SelectedValue;
            mov.Usuarios_id = Temp.Logado.Id;

            Pagamentos_movimentos pag_mov = new Pagamentos_movimentos();
            pag_mov.Valor = (decimal)txValorPago.Value;
            pag_mov.Formas_pagamento_id = (int)Formas_pagamento.Fixas.DINHEIRO;
            pag_mov.Gravar();

            mov.Pagamentos_movimentos_id = pag_mov.LastID();
            mov.Gravar();

            if (TipoConta == (int)PagConta.TiposConta.pagar) { Contas_pagar cp = new Contas_pagar(txCod_conta.Value); cp.Pago = true; cp.Atualizar(txCod_conta.Value); }
            if (TipoConta == (int)PagConta.TiposConta.receber) { Contas_receber cr = new Contas_receber(txCod_conta.Value); cr.Pago = true; cr.Atualizar(txCod_conta.Value); }

            if (objt.GetType() == typeof(ContasAPagar))
            {
                ContasAPagar cap = (ContasAPagar)objt;
                cap.Atualizar();

                Totais_caixa tc = new Totais_caixa();


                tc.Caixas_id = int.Parse(cbCaixas.SelectedValue.ToString());
                tc.Valor = decimal.Parse(txValorPago.Value.ToString());
                tc.Data = DateTime.Now;

                tc.Gravar();
            }

            if (objt.GetType() == typeof(ContasAReceber))
            {
                ContasAReceber car = (ContasAReceber)objt;
                car.Atualizar();

                Totais_caixa tc = new Totais_caixa();

                tc.Caixas_id = int.Parse(cbCaixas.SelectedValue.ToString());
                tc.Valor = decimal.Parse(txValorPago.Value.ToString());
                tc.Data = DateTime.Now;

                tc.Gravar();
            }

            this.Hide();
        }

        public enum TiposConta
        {
            pagar = 0,
            receber = 1
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            Gravar();
        }
    }
}
