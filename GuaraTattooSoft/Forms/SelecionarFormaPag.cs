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
    public partial class SelecionarFormaPag : Form
    {

        private int cod_forma_pag;
        private string descricao_forma_pag;

        public int Cod_forma_pag
        {
            get
            {
                return cod_forma_pag;
            }

            set
            {
                cod_forma_pag = value;
            }
        }

        public string Descricao_forma_pag
        {
            get
            {
                return descricao_forma_pag;
            }

            set
            {
                descricao_forma_pag = value;
            }
        }

        public SelecionarFormaPag()
        {
            InitializeComponent();

            this.AplicarPadroes();
            dataGridFormasPag.AplicarPadroes();

            CarregaFormasPag();

            this.ShowDialog();
        }

        private void CarregaFormasPag(Formas_pagamento fpg = null)
        {
            dataGridFormasPag.Rows.Clear();

            if (fpg == null) fpg = new Formas_pagamento(true);

            for(int i = 0; i < fpg.id_todos.Count; i++)
            {
                string parcelar = fpg.permitir_parcel_todos[i] == true ? parcelar = "SIM" : parcelar = "NÃO";
                dataGridFormasPag.Rows.Add(fpg.id_todos[i], fpg.descricao_todos[i], parcelar);
            }
        }

        private void txPesquisa_TextChanged(object sender, EventArgs e)
        {
            Formas_pagamento formas_pag = new Formas_pagamento();
            formas_pag.Pesquisar(txPesquisa.Text);
            CarregaFormasPag(formas_pag);
        }

        private void dataGridFormasPag_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!dataGridFormasPag.TemLinhas()) return;

            Cod_forma_pag = dataGridFormasPag.IdAtual(0);
            Descricao_forma_pag = dataGridFormasPag.CurrentRow.Cells[1].Value.ToString();

            this.Hide();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            if (!dataGridFormasPag.TemLinhas()) return;

            Cod_forma_pag = dataGridFormasPag.IdAtual(0);
            Descricao_forma_pag = dataGridFormasPag.CurrentRow.Cells[1].Value.ToString();

            this.Hide();
        }

        private void dataGridFormasPag_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (!dataGridFormasPag.TemLinhas()) return;

                Cod_forma_pag = dataGridFormasPag.IdAtual(0);
                Descricao_forma_pag = dataGridFormasPag.CurrentRow.Cells[1].Value.ToString();

                this.Hide();
            }
        }

        private void txPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!dataGridFormasPag.TemLinhas()) return;

                Cod_forma_pag = dataGridFormasPag.IdAtual(0);
                Descricao_forma_pag = dataGridFormasPag.CurrentRow.Cells[1].Value.ToString();

                this.Hide();
            }
        }
    }
}
