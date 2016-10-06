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
    public partial class CadastroMateriais : UserControl
    {

        bool modoEdicao = false;

        public CadastroMateriais()
        {
            InitializeComponent();

            this.AplicarPadroes();
            dataGridMateriais.AplicarPadroes();

            AtualizaDadaGrid();

            txPrecoCusto.Enabled = false;
            txMargemLucro.Enabled = false;
            txPrecoVenda.Enabled = false;
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        private void Gravar()
        {
            if (string.IsNullOrWhiteSpace(txDescricao.Text)) return;

            Materiais materiais = new Materiais();

            materiais.Descricao = txDescricao.Text;
            materiais.Marca = txMarca.Text;
            materiais.Modelo = txModelo.Text;
            materiais.Tipo = txTipo.Text;
            materiais.Tamanho = txTamanho.Text;
            materiais.Preco_custo = decimal.Parse(txPrecoCusto.Value.ToString());
            materiais.Margem_lucro = txMargemLucro.Value;
            materiais.Preco_venda = decimal.Parse(txPrecoVenda.Value.ToString());
            materiais.Estoque = decimal.Parse(txEstoque.Value.ToString());
            materiais.Insumo = rdInsumo.Checked == true ? materiais.Insumo = true : materiais.Insumo = false;
            materiais.Venda = rdVenda.Checked == true ? materiais.Venda = true : materiais.Venda = false;
            materiais.PedCompra = decimal.Parse(txPedCompra.Value.ToString());

            if (modoEdicao == true)
            {
                int id = dataGridMateriais.IdAtual(0);
                materiais.Atualizar(id);
            }
            else
            {
                materiais.Gravar();
            }

            AtualizaDadaGrid();
        }

        private void Pesquisar()
        {
            if (!dataGridMateriais.TemLinhas()) return;

            foreach(DataGridViewRow row in dataGridMateriais.Rows)
            {
                if(row.Cells[Coluna()].Value.ToString().Contains(txPesquisa.Text))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void AtualizaDadaGrid(Materiais materias = null)
        {
            dataGridMateriais.Rows.Clear();

            if (materias == null) materias = new Materiais(true);

            for (int i = 0; i < materias.id_todos.Count; i++)
            {
                string insumo = materias.insumo_todos[i] == true ? insumo = "SIM" : insumo = "NÃO";
                string venda = materias.venda_todos[i] == true ? venda = "SIM" : venda = "NÃO";
                dataGridMateriais.Rows.Add(materias.id_todos[i], materias.descricao_todos[i], materias.marca_todos[i], materias.modelo_todos[i], materias.tipo_todos[i], materias.tamanho_todos[i], materias.preco_custo_todos[i], materias.margem_lucro_todos[i], materias.preco_venda_todos[i], insumo, venda, materias.estoque_todos[i], materias.pedCompra_todos[i]);
            }

            modoEdicao = false;
            this.LimparCampos();

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (!dataGridMateriais.TemLinhas()) return;

            int id = dataGridMateriais.IdAtual(0);

            Materiais materiais = new Materiais();
            materiais.Deletar(id);

            AtualizaDadaGrid();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (!dataGridMateriais.TemLinhas()) return;

            int id = dataGridMateriais.IdAtual(0);

            Materiais materiais = new Materiais(id);

            txDescricao.Text = materiais.Descricao;
            txMarca.Text = materiais.Marca;
            txModelo.Text = materiais.Modelo;
            txTipo.Text = materiais.Tipo;
            txTamanho.Text = materiais.Tamanho;
            txPrecoCusto.Value = double.Parse(materiais.Preco_custo.ToString());
            txMargemLucro.Value = materiais.Margem_lucro;
            txPrecoVenda.Value = double.Parse(materiais.Preco_venda.ToString());
            if (materiais.Insumo == true) rdInsumo.Checked = true;
            if (materiais.Venda == true) rdVenda.Checked = true;
            txEstoque.Value = double.Parse(materiais.Estoque.ToString());
            txPedCompra.Value = double.Parse(materiais.PedCompra.ToString());

            modoEdicao = true;
        }

        private void txMargemLucro_Leave(object sender, EventArgs e)
        {
            txPrecoVenda.Value = txPrecoCusto.Value / 100 * txMargemLucro.Value + txPrecoCusto.Value;
        }

        private void rdInsumo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdInsumo.Checked == true)
            {
                txPrecoCusto.Enabled = false;
                txMargemLucro.Enabled = false;
                txPrecoVenda.Enabled = false;
            }
            else
            {
                txPrecoCusto.Enabled = true;
                txMargemLucro.Enabled = true;
                txPrecoVenda.Enabled = true;
            }
        }

        private int Coluna()
        {
            switch (cbFiltro.Text)
            {
                case "Descrição": return 1;
                case "Marca": return 2;
                case "Modelo": return 3;
                case "Tipo": return 4;
                case "Tamanho": return 5;
            }
            return 0;
        }

        private void txPesquisa_TextChanged(object sender, EventArgs e)
        {
            Pesquisar();
        }
    }
}
