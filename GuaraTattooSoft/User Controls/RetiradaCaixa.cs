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
using GuaraTattooSoft.Util;
using GuaraTattooSoft.Entidades;
using GuaraTattooSoft.Forms;

namespace GuaraTattooSoft.User_Controls
{
    public partial class RetiradaCaixa : UserControl
    {
        int start = 0;

        public RetiradaCaixa()
        {
            InitializeComponent();

            this.AplicarPadroes();

            CarregaCaixas();

            if (!string.IsNullOrWhiteSpace(cbCaixas.Text))
            {
                Totais_caixa tc = new Totais_caixa();
                txValorDisponivel.Value = (double)tc.Total((int)cbCaixas.SelectedValue, true);
            }

            txCod_usuario.Value = Temp.Logado.Id;
            txNome_usuario.Text = Temp.Logado.Nome;
        }

        private void CarregaCaixas()
        {
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
            cbCaixas.ValueMember = "key";
            cbCaixas.DisplayMember = "value";
        }

        private void rdApenasHoje_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbCaixas.Text)) return;
            Totais_caixa tc = new Totais_caixa();
            txValorDisponivel.Value = (double)tc.Total((int)cbCaixas.SelectedValue, true);
        }

        private void rdMes_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbCaixas.Text)) return;
            Totais_caixa tc = new Totais_caixa();
            txValorDisponivel.Value = (double)tc.Total((int)cbCaixas.SelectedValue, false);
        }

        private void cbCaixas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (start == 0)
            {
                start++; return;
            }

            Totais_caixa tc = new Totais_caixa();

            if (rdApenasHoje.Checked)
            {
                txValorDisponivel.Value = (double)tc.Total((int)cbCaixas.SelectedValue, true);
            }
            else
            {
                txValorDisponivel.Value = (double)tc.Total((int)cbCaixas.SelectedValue, false);
            }
        }

        private void Gravar()
        {
            Caixas caixa = new Caixas((int)cbCaixas.SelectedValue);
            if (!caixa.Aberto())
            {
                Atencao.Show("O caixa selecionado não está aberto. Selecione outro caixa!");
                CarregaCaixas();
                return;
            }

            Pagamentos_movimentos pag_mov = new Pagamentos_movimentos();

            pag_mov.Valor = -(decimal)txValorRetirar.Value;
            pag_mov.Desconto = 0;
            pag_mov.Formas_pagamento_id = (int)Formas_pagamento.Fixas.DINHEIRO;

            pag_mov.Gravar();

            int id_pg_mov = pag_mov.LastID();

            Movimentos mov = new Movimentos();

            mov.Data_movimento = txData.Value;
            mov.Obs = txObs.Text;
            mov.Tipos_movimento_id = (int)Tipos_movimento.Fixos.RetiradaCaixa;
            mov.Caixas_id = (int)cbCaixas.SelectedValue;
            mov.Usuarios_id = txCod_usuario.Value;
            mov.Pagamentos_movimentos_id = id_pg_mov;

            mov.Gravar();

            Totais_caixa tc = new Totais_caixa();

            tc.Caixas_id = (int)cbCaixas.SelectedValue;
            tc.Valor = -(decimal)txValorRetirar.Value;
            tc.Data = txData.Value;

            tc.Gravar();

            this.LimparCampos();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            if (txCod_usuario.Value == 0) { Atencao.Show("Selecione o usuário!"); return; }
            if(txValorRetirar.Value == 0) { Atencao.Show("Insira o valor da retirada!"); return; }
            if (string.IsNullOrWhiteSpace(cbCaixas.Text)) { Atencao.Show("Nenhum caixa está selecionado. \nTalvez não exista nenhum caixa aberto ou não existem caixas cadastrados. \nVerifique a situação dos caixas e tente novamente."); return; }

            Gravar();
        }

        private void txCod_usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F3)
            {
                SelecionarUsuario su = new SelecionarUsuario();
                txCod_usuario.Value = su.CodUsuario;
                txNome_usuario.Text = su.NomeUsuario;
            }
        }

        private void cbCaixas_MouseClick(object sender, MouseEventArgs e)
        {
            CarregaCaixas();
        }
    }
}
