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
    public partial class Parcelamento : Form
    {

        public bool contaPagar = false;
        public bool Efetuado { get; set; }

        public Parcelamento(double valor, double codTipoMov)
        {
            InitializeComponent();

            txValor.Value = valor;

            this.AplicarPadroes();
            dataGridParcelas.AplicarPadroes();

            CarregaOperadoras();
           
            Tipos_movimento tipos_mov = new Tipos_movimento(int.Parse(codTipoMov.ToString()));
            if(tipos_mov.Entrada_valor == (int)Tipos_movimento.EstadosMovimento.Saida)
            {
                txJuros.Enabled = true;
                contaPagar = true;
            }
        }
        
        private void CarregaOperadoras()
        {
            Operadoras_cartao oc = new Operadoras_cartao(true);

            List<KeyValuePair<int, string>> operadoras = new List<KeyValuePair<int, string>>();

            for (int i = 0; i < oc.id_todos.Count; i++)
            {
                if(oc.ativo_todos[i] == true) operadoras.Add(new KeyValuePair<int, string>(oc.id_todos[i], oc.descricao_todos[i]));
            }
            cbOperadoras.DataSource = new BindingSource(operadoras, null);
            cbOperadoras.DisplayMember = "value";
            cbOperadoras.ValueMember = "key";
        }

        private void txParcelas_ValueChanged(object sender, EventArgs e)
        {
            Inserir();   
        }

        private void Inserir()
        {
            if (cbOperacao.Text == "DÉBITO") { txParcelas.Value = 1; txParcelas.MaxValue = 1; } else { txParcelas.MaxValue = 48; }

            dataGridParcelas.Rows.Clear();

            Operadoras_cartao oc = new Operadoras_cartao(int.Parse(cbOperadoras.SelectedValue.ToString()));

            double taxa = txJuros.Enabled == true ? taxa = txJuros.Value : taxa = oc.Taxa;
            double numParcelas = txParcelas.Value;
            double valor = txValor.Value;

            double valorParcela = txJuros.Enabled == true ? valorParcela = valor / 100 * taxa + valor : valorParcela = valor / 100 * taxa - valor;

            DateTime dataBase = DateTime.Now.Date;

            valorParcela = Math.Abs(valorParcela);

            for(int i = 0; i < txParcelas.Value; i++)
            {
                dataBase =  cbOperacao.Text == "CRÉDITO" ? dataBase = dataBase.AddDays(oc.Credito_dias_pagamento) : dataBase = dataBase.AddHours(oc.Debito_horas_pagamento);
                dataGridParcelas.Rows.Add(dataBase.ToShortDateString(), decimal.Parse((valorParcela / numParcelas).ToString()));
            }
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            Efetuado = true;
            this.Hide();
        }

        private void cbOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Inserir();
        }

        private void Parcelamento_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Efetuado != true) Efetuado = false;
        }
    }
}
