using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GuaraTattooSoft.Forms;
using GuaraTattooSoft.Extencoes;
using GuaraTattooSoft.Entidades;
using GuaraTattooSoft.DBConnection;
using MySql.Data.MySqlClient;
using GuaraTattooSoft.Util;

namespace GuaraTattooSoft.User_Controls
{
    public partial class LancamentoMovimentos : UserControl
    {
        HashSet<KeyValuePair<decimal, double>> bkpTotalMov = new HashSet<KeyValuePair<decimal, double>>();

        public LancamentoMovimentos()
        {
            InitializeComponent();

            this.AplicarPadroes();
            dataGridItensMov.AplicarPadroes();
            lbProgresso.Visible = false;

            PreparaTela();
        }

        private void PreparaTela()
        {
            Caixas caixas = new Caixas(true);
            for (int i = 0; i < caixas.id_todos.Count; i++)
            {
                int idSc = new Status_caixa().LastID(caixas.id_todos[i]);
                Status_caixa sc = new Status_caixa(idSc);
                if (sc.Data_fechamento == null)
                {
                    txCodCaixa.Value = caixas.id_todos[i];
                    txNomeCaixa.Text = caixas.nome_todos[i];
                    break;
                }
            }

            txCodUsuario.Value = Temp.Logado.Id;
            txNomeUsuario.Text = Temp.Logado.Nome;

            Tipos_movimento tm = new Tipos_movimento(4);
            txCodTipoMov.Value = 4;
            txDescricaoMov.Text = tm.Descricao;

            Formas_pagamento fp = new Formas_pagamento((int)Formas_pagamento.Fixas.DINHEIRO);
            txCodFormaPag.Value = (int)Formas_pagamento.Fixas.DINHEIRO;
            txDescricaoFormaPag.Text = fp.Descricao;

        }

        private void txCodUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                SelecionarUsuario su = new SelecionarUsuario();
                txCodUsuario.Value = su.CodUsuario;
                txNomeUsuario.Text = su.NomeUsuario;
            }
        }

        private void txCodTipoMov_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                SelecionarTipoMov stm = new SelecionarTipoMov();
                txCodTipoMov.Value = stm.Cod_tipo_mov;
                txDescricaoMov.Text = stm.Descricao_mov;
            }
        }

        private void txCodCaixa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                SelecionarCaixa sc = new SelecionarCaixa();
                txCodCaixa.Value = sc.Cod_caixa;
                txNomeCaixa.Text = sc.Nome_caixa;
            }
        }

        private void txCodFormaPag_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                SelecionarFormaPag sfp = new SelecionarFormaPag();

                txCodFormaPag.Value = sfp.Cod_forma_pag;
                txDescricaoFormaPag.Text = sfp.Descricao_forma_pag;
            }
        }

        private void txCodCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                SelecionarCliente sc = new SelecionarCliente();

                txCodCliente.Value = sc.Cod_cliente;
                txNomeCliente.Text = sc.Nome_cliente;
            }
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarItensMov adItmv = new AdicionarItensMov(this);
            adItmv.ShowDialog();
        }

        public DataTable GetDataTableFromDGV()
        {

            DataTable dt = new DataTable();

            foreach (DataGridViewColumn coluna in dataGridItensMov.Columns)
            {
                dt.Columns.Add(coluna.HeaderText);
            }

            for (int i = 0; i < dataGridItensMov.Rows.Count; i++)
            {
                dt.Rows.Add(dataGridItensMov[0, i].Value, dataGridItensMov[1, i].Value, dataGridItensMov[2, i].Value, dataGridItensMov[3, i].Value, dataGridItensMov[4, i].Value, dataGridItensMov[5, i].Value, dataGridItensMov[6, i].Value, dataGridItensMov[7, i].Value);
            }

            return dt;
        }

        private void btLancarMov_Click(object sender, EventArgs e)
        {
            if (txDataMov.Value == null || string.IsNullOrWhiteSpace(txDataMov.Text)) { Atencao.Show("Informe uma data válida!"); return; }
            if (txCodUsuario.Value == 0) { Atencao.Show("Selecione o usuário!"); return; }
            if (txCodTipoMov.Value == 0) { Atencao.Show("Selecione o tipo de movimento!"); return; }
            if (txCodCaixa.Value == 0) { Atencao.Show("Selecione o caixa!"); return; }
            if (txCodFormaPag.Value == 0) { Atencao.Show("Selecione a forma de pagamento!"); return; }

            Gravar();
        }

        private void Gravar()
        {
            lbProgresso.Visible = true;
            Formas_pagamento formas_pag = new Formas_pagamento(txCodFormaPag.Value);
            Parcelamento parcelamento = new Parcelamento(txTotalMov.Value, txCodTipoMov.Value);

            if (formas_pag.Permitir_parcel == true)
            {
                parcelamento.ShowDialog();

                if (!parcelamento.Efetuado) return;
            }

            lbProgresso.Text = "Preparando-se...";

            MySqlConnection conn = new Conexao().GetConexao();

            MySqlTransaction transaction = conn.BeginTransaction();

            try
            {
                lbProgresso.Text = "Gravando pagamento do movimento...";

                Pagamentos_movimentos pg_mov = new Pagamentos_movimentos();

                pg_mov.Valor = formas_pag.Permitir_parcel == true ? pg_mov.Valor = 0 : pg_mov.Valor = new Tipos_movimento(txCodTipoMov.Value).Entrada_valor == (int)Tipos_movimento.EstadosMovimento.Entrada ? pg_mov.Valor = (decimal)txTotalMov.Value : pg_mov.Valor = -(decimal)txTotalMov.Value;
                pg_mov.Desconto = txDescontoMov.Value;
                pg_mov.Formas_pagamento_id = txCodFormaPag.Value;

                pg_mov.Gravar();

                lbProgresso.Text = "Preparando-se...";

                int idPg_mov = pg_mov.LastID();

                lbProgresso.Text = "Gravando movimento...";

                Movimentos mov = new Movimentos();

                mov.Data_movimento = txDataMov.Value;
                mov.Obs = txOBSMov.Text;
                mov.Tipos_movimento_id = txCodTipoMov.Value;
                mov.Caixas_id = txCodCaixa.Value;
                mov.Usuarios_id = txCodUsuario.Value;
                mov.Clientes_id = txCodCliente.Value;
                mov.Pagamentos_movimentos_id = idPg_mov;

                mov.Gravar();

                lbProgresso.Text = "Preparando-se...";
                int idMov = mov.LastID();

                Itens_movimento itens_mov = new Itens_movimento();

                foreach (DataGridViewRow row in dataGridItensMov.Rows)
                {
                    lbProgresso.Text = "Gravando itens movimento " + row.Index + " de " + dataGridItensMov.Rows.Count;

                    itens_mov.Servico_material = (int)Itens_movimento.Tipo_Item.material;
                    itens_mov.Cod_servico_material = (int)row.Cells[0].Value;
                    itens_mov.Qntd = double.Parse(row.Cells[6].Value.ToString());

                    itens_mov.Gravar();

                    int idItens_mov = itens_mov.LastID();

                    Movimentos_itens_movimento mov_itens_mov = new Movimentos_itens_movimento();

                    mov_itens_mov.Movimentos_id = idMov;
                    mov_itens_mov.Itens_movimentos_id = idItens_mov;

                    mov_itens_mov.Gravar();
                }

                if (parcelamento.dataGridParcelas.Rows.Count != 0)
                {
                    if (parcelamento.contaPagar == true)
                    {
                        Contas_pagar cp = new Contas_pagar();
                        int parcela = 1;
                        foreach (DataGridViewRow row in parcelamento.dataGridParcelas.Rows)
                        {
                            lbProgresso.Text = "Gerando contas a pagar " + row.Index + " de " + parcelamento.dataGridParcelas.Rows.Count;

                            cp.Movimentos_id = idMov;
                            cp.Parcela = parcela + "/" + parcelamento.dataGridParcelas.Rows.Count;
                            cp.Formas_pagamento_id = txCodFormaPag.Value;
                            cp.Emitente = parcelamento.cbOperadoras.Text;
                            cp.Destinatario = new Loja(1).Nome_fantasia;
                            cp.Descricao = new Tipos_movimento(txCodTipoMov.Value).Descricao;
                            cp.Valor = decimal.Parse(row.Cells[1].Value.ToString());
                            cp.Vencimento = Convert.ToDateTime(row.Cells[0].Value.ToString());
                            cp.Juros = parcelamento.txJuros.Value;
                            cp.Pago = false;

                            cp.Gravar();
                            parcela++;
                        }
                    }

                    if (parcelamento.contaPagar == false)
                    {
                        Contas_receber cr = new Contas_receber();
                        int parcela = 1;
                        foreach (DataGridViewRow row in parcelamento.dataGridParcelas.Rows)
                        {
                            lbProgresso.Text = "Gerando contas a receber " + row.Index + " de " + parcelamento.dataGridParcelas.Rows.Count;

                            cr.Movimentos_id = idMov;
                            cr.Formas_pagamento_id = txCodFormaPag.Value;
                            cr.Parcela = parcela + "/" + parcelamento.dataGridParcelas.Rows.Count;
                            cr.Emitente = new Loja(1).Nome_fantasia;
                            cr.Destinatario = new Formas_pagamento(txCodFormaPag.Value).Permitir_parcel ? cr.Destinatario = parcelamento.cbOperadoras.Text : cr.Destinatario = txNomeCliente.Text;
                            cr.Descricao = new Tipos_movimento(txCodTipoMov.Value).Descricao;
                            cr.Valor = decimal.Parse(row.Cells[1].Value.ToString());
                            cr.Vencimento = Convert.ToDateTime(row.Cells[0].Value.ToString());
                            cr.Juros = 0;
                            cr.Pago = false;

                            cr.Gravar();
                            parcela++;
                        }
                    }
                }

                Tipos_movimento tipos_mov = new Tipos_movimento(txCodTipoMov.Value);

                foreach (DataGridViewRow row in dataGridItensMov.Rows)
                {
                    lbProgresso.Text = ("Realizando baixa no estoque...");

                    Materiais materiais = new Materiais(int.Parse(row.Cells[0].Value.ToString()));

                    if (tipos_mov.Entrada_material == (int)Tipos_movimento.EstadosMovimento.Saida) materiais.Estoque -= decimal.Parse(row.Cells[6].Value.ToString());
                    if (tipos_mov.Entrada_material == (int)Tipos_movimento.EstadosMovimento.Entrada) materiais.Estoque += decimal.Parse(row.Cells[6].Value.ToString());

                    materiais.Atualizar(int.Parse(row.Cells[0].Value.ToString()));
                }

                if (formas_pag.Permitir_parcel == false)
                {
                    Totais_caixa tc = new Totais_caixa();

                    tc.Caixas_id = txCodCaixa.Value;

                    if (tipos_mov.Entrada_valor == (int)Tipos_movimento.EstadosMovimento.Entrada)
                    {
                        tc.Valor = decimal.Parse(txTotalMov.Value.ToString());
                    }
                    if (tipos_mov.Entrada_valor == (int)Tipos_movimento.EstadosMovimento.Saida)
                    {
                        tc.Valor = -decimal.Parse(txTotalMov.Value.ToString());
                    }

                    tc.Data = DateTime.Now;

                    tc.Gravar();
                }

                lbProgresso.Text = ("Concluindo...");
                transaction.Commit();

                dataGridItensMov.Rows.Clear();
                txOBSMov.Text = string.Empty;
                txTotalMov.Value = 0;
                txDescontoMov.Value = 0;

                lbProgresso.Text = ("Movimento gerado com sucesso! Cod " + idMov);
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Erro.Show("Erro ao gerar o movimento \n" + ex.Message, "Erro ao lançar movimento");
            }
            finally
            {
                conn.Close();
            }
        }

        private void txTotalMov_Leave(object sender, EventArgs e)
        {
            bkpTotalMov.Clear();
            bkpTotalMov.Add(new KeyValuePair<decimal, double>(1, txTotalMov.Value));
            txDescontoMov.Value = 0;
        }

        private void txDescontoMov_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double valorDesconto = txTotalMov.Value / 100 * txDescontoMov.Value;
                txTotalMov.Value -= valorDesconto;
            }
        }

        private void txDescontoMov_ValueChanged(object sender, EventArgs e)
        {
            if (txDescontoMov.Value == 0)
            {
                foreach (KeyValuePair<decimal, double> valorOriginal in bkpTotalMov)
                {
                    txTotalMov.Value = valorOriginal.Value;
                }
            }
        }

        private void txDescontoMov_Enter(object sender, EventArgs e)
        {
            bkpTotalMov.Clear();
            bkpTotalMov.Add(new KeyValuePair<decimal, double>(1, txTotalMov.Value));
            txDescontoMov.Value = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!dataGridItensMov.TemLinhas()) return;

            dataGridItensMov.Rows.Remove(dataGridItensMov.CurrentRow);

            txTotalMov.Value = 0;

            for (int i = 0; i < dataGridItensMov.Rows.Count; i++)
            {
                txTotalMov.Value += double.Parse(dataGridItensMov.Rows[i].Cells[5].Value.ToString()) * double.Parse(dataGridItensMov.Rows[i].Cells[6].Value.ToString());
                // txTotal_materiais.Value += double.Parse(dataGridMateriais.Rows[i].Cells[5].Value.ToString()) * double.Parse(dataGridMateriais.Rows[i].Cells[6].Value.ToString());
            }
        }

        private void txCodFormaPag_ValueChanged(object sender, EventArgs e)
        {
            if (txCodFormaPag.Value == 0) return;
            if (new Formas_pagamento(txCodFormaPag.Value).Permitir_parcel)
            {
                Operadoras_cartao op_c = new Operadoras_cartao(true);
                if (op_c.id_todos.Count == 0)
                {
                    Atencao.Show("Não é possivel utilizar esta forma de pagamento. \nNão existem operadoras de cartão cadastradas.");
                    txCodFormaPag.Value = 0;
                }
            }
        }

        private void txDescricaoFormaPag_TextChanged(object sender, EventArgs e)
        {
            if (txCodFormaPag.Value == 0) txDescricaoFormaPag.Text = string.Empty;
        }
    }
}
