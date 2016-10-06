using GuaraTattooSoft.Entidades;
using GuaraTattooSoft.Extencoes;
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
    public partial class DetalhesMovimento : Form
    {
        int idMovimento;
        decimal totalMov = 0;

        public DetalhesMovimento(int idMov)
        {
            idMovimento = idMov;

            InitializeComponent();

            this.AplicarPadroes();
            dataGridItensMov.AplicarPadroes();
            dataGridParcelas.AplicarPadroes();

            CarregaMovimento();
        }

        private void CarregaMovimento()
        {
            lbCodMov.Text = idMovimento.ToString();
            Movimentos mov = new Movimentos(idMovimento);
            Pagamentos_movimentos pg_mov = new Pagamentos_movimentos(mov.Pagamentos_movimentos_id);

            lbData.Text = mov.Data_movimento.ToString();
            lbCaixa.Text = new Caixas(mov.Caixas_id).Nome;
            lbTipoMov.Text = new Tipos_movimento(mov.Tipos_movimento_id).Descricao;
            lbUsuario.Text = new Usuarios(mov.Usuarios_id).Nome;
            lbCliente.Text = new Clientes(mov.Clientes_id).Nome;
            lbDesc.Text = pg_mov.Desconto.ToString();
            txObsMov.Text = mov.Obs;

            Movimentos_itens_movimento mim = new Movimentos_itens_movimento(idMovimento);

            for (int i = 0; i < mim.itens_movimentos_id_todos.Count; i++)
            {
                Itens_movimento im = new Itens_movimento(mim.itens_movimentos_id_todos[i]);

                if (im.Servico_material == (int)Itens_movimento.Tipo_Item.material)
                {
                    Materiais mat = new Materiais(im.Cod_servico_material);

                    dataGridItensMov.Rows.Add(im.Cod_servico_material, mat.Descricao, mat.Marca, mat.Modelo, mat.Tamanho, mat.Preco_venda, im.Qntd, ((double)mat.Preco_venda * im.Qntd));
                }
                if (im.Servico_material == (int)Itens_movimento.Tipo_Item.servico) CarregaServico(im.Cod_servico_material);
            }
            totalMov = pg_mov.Valor;
            lbTotal.Text = "Total: R$" + totalMov.ToString("N2");

            if (new Contas_pagar(idMovimento, false).id_todos.Count != 0) CarregaContasPagar();
            if (new Contas_receber(idMovimento, false).id_todos.Count != 0) CarregaContasReceber();

            this.Text = lbTipoMov.Text + " - Detalhes do movimento";
        }

        private void CarregaContasPagar()
        {
            Contas_pagar cp = new Contas_pagar(idMovimento, false);

            for (int i = 0; i < cp.id_todos.Count; i++)
            {
                string pago = cp.pago_todos[i] == true ? pago = "SIM" : pago = "NÃO";
                dataGridParcelas.Rows.Add(cp.vencimento_todos[i].ToShortDateString(), cp.valor_todos[i], pago);
            }
        }

        private void CarregaContasReceber()
        {
            Contas_receber cr = new Contas_receber(idMovimento, false);

            for (int i = 0; i < cr.id_todos.Count; i++)
            {
                string pago = cr.pago_todos[i] == true ? pago = "SIM" : pago = "NÃO";
                dataGridParcelas.Rows.Add(cr.vencimento_todos[i].ToShortDateString(), cr.valor_todos[i], pago);
            }
        }

        private void CarregaServico(int idServico)
        {
            Servicos servico = new Servicos(idServico);

            lbDataServico.Text = servico.Data_servico.ToShortDateString();
            lbTipoServ.Text = new Tipos_servico(servico.Tipos_servico_id).Descricao;
            lbClienteServico.Text = new Clientes(servico.Clientes_id).Nome;
            lbProfissional.Text = new Profissionais(servico.Profissionais_id).Nome;
            lbValorTrabalho.Text = servico.Valor_servico.ToString("N2");

            Pagamentos_movimentos pg_mov = new Pagamentos_movimentos(new Movimentos(idMovimento).Pagamentos_movimentos_id);

            lbFormaPagamento.Text = new Formas_pagamento(pg_mov.Formas_pagamento_id).Descricao;
            txObs.Text = servico.Servico_realizado;
        }
    }
}
