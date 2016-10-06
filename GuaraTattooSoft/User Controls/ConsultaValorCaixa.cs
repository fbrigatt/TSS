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
    public partial class ConsultaValorCaixa : UserControl
    {
        public ConsultaValorCaixa()
        {
            InitializeComponent();

            dataGridTotais.AplicarPadroes();
            this.AplicarPadroes();

            AtualizaDataGrid();
        }

        private void AtualizaDataGrid(Totais_caixa tc = null)
        {
            
            dataGridTotais.Rows.Clear();
            if (tc == null) tc = new Totais_caixa(true);

            decimal total = 0;

            for (int i = 0; i < tc.id_todos.Count; i++)
            {
                Caixas caixas = new Caixas(tc.caixas_id_todos[i]);

                string nomeCaixa = caixas.Nome;
                string nomeMicro = caixas.Nome_micro;

                if(tc.data_todos[i].Date == DateTime.Now.Date)

                dataGridTotais.Rows.Add(tc.caixas_id_todos[i], nomeCaixa, nomeMicro, tc.valor_todos[i], tc.data_todos[i]);

                total += tc.valor_todos[i];
            }

            lbTotal.Text = total.ToString();

        }

        private void txPesquisa_TextChanged(object sender, EventArgs e)
        {

            lbTotal.Text = "Total: R$ ";
            
            foreach (DataGridViewRow row in dataGridTotais.Rows)
            {
                if(row.Visible == true)

                if (row.Cells[Coluna()].Value.ToString().Contains(txPesquisa.Text))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }

            decimal total = 0;

            foreach(DataGridViewRow row in dataGridTotais.Rows)
            {
                if(row.Visible == true) total += decimal.Parse(row.Cells[3].Value.ToString());
            }

            lbTotal.Text += string.Format("{0:N}", total);
        }

        private int Coluna()
        {
            switch (cbFiltro.Text)
            {
                case "Cod. Caixa":

                    return 0;

                case "Nome do caixa":

                    return 1;

                case "Nome do micro":

                    return 2;

                case "Data":

                    return 4;
            }

            return 0;
        }

        private void cbExibir_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaDataGrid();
        }
        }
    }

