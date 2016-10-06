using GuaraTattooSoft.Entidades;
using GuaraTattooSoft.Extencoes;
using GuaraTattooSoft.User_Controls;
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
    public partial class AdicionarItensMov : Form
    {
        DataTable dataTable;

        private Object ob;

        public AdicionarItensMov(Object obj)
        {
            ob = obj;

            InitializeComponent();

            this.AplicarPadroes();
            dataGridItens.AplicarPadroes();
            dataGridMateriais.AplicarPadroes();

            if(obj.GetType() == typeof(LancamentoMovimentos)) dataTable = (obj as LancamentoMovimentos).GetDataTableFromDGV();
            if (obj.GetType() == typeof(Trabalho)) dataTable = (obj as Trabalho).GetDataTableFromDGV();

            dataGridItens.DataSource = dataTable.DefaultView;

            CarregaMateriais();
            this.Icon = new Icon(this.Icon, new Size(this.Icon.Width * 5, this.Icon.Height * 5));
        }

        private void CarregaMateriais(Materiais materiais = null)
        {
            dataGridMateriais.Rows.Clear();
            if (materiais == null) materiais = new Materiais(true);

            for (int i = 0; i < materiais.id_todos.Count; i++)
            {
                //    if(materiais.venda_todos[i] == true)
                //   {
                dataGridMateriais.Rows.Add(materiais.id_todos[i], materiais.descricao_todos[i], materiais.marca_todos[i], materiais.modelo_todos[i], materiais.tipo_todos[i], materiais.tamanho_todos[i], materiais.preco_venda_todos[i]);
                //    }
            }
        }

        private void dataGridMateriais_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txQNTD.Text = "1";
            txQNTD.Focus();
        }

        private void AdicionaItem()
        {
            int id = dataGridMateriais.IdAtual(0);
            Materiais mat = new Materiais(id);

            dataTable.Rows.Add(id, mat.Descricao, mat.Marca, mat.Modelo, mat.Tamanho, mat.Preco_venda, txQNTD.Text, mat.Preco_venda * decimal.Parse(txQNTD.Text));

            dataGridItens.DataSource = dataTable.DefaultView;

            if (ob.GetType() == typeof(LancamentoMovimentos))
            {
                (ob as LancamentoMovimentos).dataGridItensMov.Rows.Add(id, mat.Descricao, mat.Marca, mat.Modelo, mat.Tamanho, mat.Preco_venda, txQNTD.Text, mat.Preco_venda * decimal.Parse(txQNTD.Text));
                (ob as LancamentoMovimentos).txTotalMov.Value += double.Parse((mat.Preco_venda * decimal.Parse(txQNTD.Text)).ToString());
            }

            if (ob.GetType() == typeof(Trabalho))
            {
                (ob as Trabalho).dataGridMateriais.Rows.Add(id, mat.Descricao, mat.Marca, mat.Modelo, mat.Tamanho, mat.Preco_venda, txQNTD.Text, mat.Preco_venda * decimal.Parse(txQNTD.Text));
                (ob as Trabalho).txTotal_materiais.Value += double.Parse((mat.Preco_venda * decimal.Parse(txQNTD.Text)).ToString());
                (ob as Trabalho).txValor_total.Value += double.Parse((mat.Preco_venda * decimal.Parse(txQNTD.Text)).ToString());
            }

            txQNTD.Text = "0";
            dataGridMateriais.Focus();
        }

        private void txQNTD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AdicionaItem();
            }
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (!dataGridItens.TemLinhas()) return;

            if (ob.GetType() == typeof(LancamentoMovimentos))
            {
                (ob as LancamentoMovimentos).dataGridItensMov.Rows.Remove((ob as LancamentoMovimentos).dataGridItensMov.Rows[dataGridItens.CurrentRow.Index]);
                dataTable = (ob as LancamentoMovimentos).GetDataTableFromDGV();
                dataGridItens.DataSource = dataTable.DefaultView;

                (ob as LancamentoMovimentos).txTotalMov.Value = 0;
                for (int i = 0; i < dataGridItens.Rows.Count; i++)
                {
                    (ob as LancamentoMovimentos).txTotalMov.Value += double.Parse(dataGridItens.Rows[i].Cells[5].Value.ToString()) * double.Parse(dataGridItens.Rows[i].Cells[6].Value.ToString());
                }
            }

            if (ob.GetType() == typeof(Trabalho))
            {
                (ob as Trabalho).dataGridMateriais.Rows.Remove((ob as Trabalho).dataGridMateriais.Rows[dataGridItens.CurrentRow.Index]);
                dataTable = (ob as Trabalho).GetDataTableFromDGV();
                dataGridItens.DataSource = dataTable.DefaultView;

                (ob as Trabalho).txTotal_materiais.Value = 0;
                (ob as Trabalho).txValor_total.Value = 0;
                for (int i = 0; i < dataGridItens.Rows.Count; i++)
                {
                    (ob as Trabalho).txTotal_materiais.Value += double.Parse(dataGridItens.Rows[i].Cells[5].Value.ToString()) * double.Parse(dataGridItens.Rows[i].Cells[6].Value.ToString());
                    (ob as Trabalho).txValor_total.Value += double.Parse(dataGridItens.Rows[i].Cells[5].Value.ToString()) * double.Parse(dataGridItens.Rows[i].Cells[6].Value.ToString());
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridMateriais.Rows)
            {
                if (row.Cells[1].Value.ToString().Contains(txPesquisa.Text))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void txQNTD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
                txQNTD.SelectAll();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txQNTD.Focus();
            txQNTD.Text = "1";
            txQNTD.SelectAll();
        }

        private void txQNTD_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(txQNTD.Text))
                {
                    AdicionaItem();
                }
            }
        }
    }
}
