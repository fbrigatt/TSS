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
using GuaraTattooSoft.Util;

namespace GuaraTattooSoft.User_Controls
{
    public partial class CadastroTiposMov : UserControl
    {
        bool modoEdicao = false;

        public CadastroTiposMov()
        {
            InitializeComponent();

            this.AplicarPadroes();
            dataGridTiposMov.AplicarPadroes();

            AtualizaDataGrid();
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        private void Gravar()
        {
            if (string.IsNullOrWhiteSpace(txDescricao.Text)) return;

            Tipos_movimento tm = new Tipos_movimento();

            tm.Descricao = txDescricao.Text;

            if (cbValores.Text == "Entrada") tm.Entrada_valor = (int)Tipos_movimento.EstadosMovimento.Entrada;
            if (cbValores.Text == "Saída") tm.Entrada_valor = (int)Tipos_movimento.EstadosMovimento.Saida;
            if (cbValores.Text == "Nenhum") tm.Entrada_valor = (int)Tipos_movimento.EstadosMovimento.Nenhum;

            if (cbMaterial.Text == "Entrada") tm.Entrada_material = (int)Tipos_movimento.EstadosMovimento.Entrada;
            if (cbMaterial.Text == "Saída") tm.Entrada_material = (int)Tipos_movimento.EstadosMovimento.Saida;
            if (cbMaterial.Text == "Nenhum") tm.Entrada_material = (int)Tipos_movimento.EstadosMovimento.Nenhum;

            tm.Ativo = ckAtivo.Checked == true ? tm.Ativo = true : tm.Ativo = false;

            if (modoEdicao == true)
            {
                int id = dataGridTiposMov.IdAtual(0);
                tm.Atualizar(id);
            }
            else
            {
                tm.Gravar();
            }

            AtualizaDataGrid();
        }

        private void AtualizaDataGrid(Tipos_movimento tm = null)
        {
            if (tm == null) tm = new Tipos_movimento(true);

            dataGridTiposMov.Rows.Clear();

            for (int i = 0; i < tm.id_todos.Count; i++)
            {
                string entradaValor = string.Empty;
                if (tm.entrada_valor_todos[i] == (int)Tipos_movimento.EstadosMovimento.Entrada) entradaValor = "Entrada";
                if (tm.entrada_valor_todos[i] == (int)Tipos_movimento.EstadosMovimento.Saida) entradaValor = "Saída";
                if (tm.entrada_valor_todos[i] == (int)Tipos_movimento.EstadosMovimento.Nenhum) entradaValor = "Nenhum";

                string entradaMaterial = string.Empty;
                if (tm.entrada_material_todos[i] == (int)Tipos_movimento.EstadosMovimento.Entrada) entradaMaterial = "Entrada";
                if (tm.entrada_material_todos[i] == (int)Tipos_movimento.EstadosMovimento.Saida) entradaMaterial = "Saída";
                if (tm.entrada_material_todos[i] == (int)Tipos_movimento.EstadosMovimento.Nenhum) entradaMaterial = "Nenhum";


                string ativo = tm.ativo_todos[i] == true ? ativo = "SIM" : ativo = "NÃO";

                dataGridTiposMov.Rows.Add(tm.id_todos[i], tm.descricao_todos[i], entradaValor, entradaMaterial, ativo);
            }

            modoEdicao = false;
            this.LimparCampos();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (!dataGridTiposMov.TemLinhas()) return;

            int id = dataGridTiposMov.IdAtual(0);

            if (id == (int)Tipos_movimento.Fixos.PrestacaoServ) { Atencao.Show("Este é um tipo de movimento fixo. Não é possivel alterá-lo ou exclui-lo."); return; }
            if (id == (int)Tipos_movimento.Fixos.CompraMaterial) { Atencao.Show("Este é um tipo de movimento fixo. Não é possivel alterá-lo ou exclui-lo."); return; }
            if (id == (int)Tipos_movimento.Fixos.PagamentoConta) { Atencao.Show("Este é um tipo de movimento fixo. Não é possivel alterá-lo ou exclui-lo."); return; }
            if (id == (int)Tipos_movimento.Fixos.Perda) { Atencao.Show("Este é um tipo de movimento fixo. Não é possivel alterá-lo ou exclui-lo."); return; }
            if (id == (int)Tipos_movimento.Fixos.RecebConta) { Atencao.Show("Este é um tipo de movimento fixo. Não é possivel alterá-lo ou exclui-lo."); return; }
            if (id == (int)Tipos_movimento.Fixos.RetiradaCaixa) { Atencao.Show("Este é um tipo de movimento fixo. Não é possivel alterá-lo ou exclui-lo."); return; }
            if (id == (int)Tipos_movimento.Fixos.VendaMaterial) { Atencao.Show("Este é um tipo de movimento fixo. Não é possivel alterá-lo ou exclui-lo."); return; }

            Tipos_movimento tm = new Tipos_movimento(id);

            txDescricao.Text = tm.Descricao;

            if (tm.Entrada_valor == (int)Tipos_movimento.EstadosMovimento.Entrada) cbValores.Text = "Entrada";
            if (tm.Entrada_valor == (int)Tipos_movimento.EstadosMovimento.Saida) cbValores.Text = "Saída";
            if (tm.Entrada_valor == (int)Tipos_movimento.EstadosMovimento.Nenhum) cbValores.Text = "Nenhum";

            if (tm.Entrada_material == (int)Tipos_movimento.EstadosMovimento.Entrada) cbMaterial.Text = "Entrada";
            if (tm.Entrada_material == (int)Tipos_movimento.EstadosMovimento.Saida) cbMaterial.Text = "Saída";
            if (tm.Entrada_material == (int)Tipos_movimento.EstadosMovimento.Nenhum) cbMaterial.Text = "Nenhum";

            tm.Ativo = tm.Ativo == true ? ckAtivo.Checked = true : ckAtivo.Checked = false;

            modoEdicao = true;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (!dataGridTiposMov.TemLinhas()) return;

            int id = dataGridTiposMov.IdAtual(0);
            
            if(id == (int)Tipos_movimento.Fixos.PrestacaoServ) { Atencao.Show("Este é um tipo de movimento fixo. Não é possivel alterá-lo ou exclui-lo."); return; }
            if (id == (int)Tipos_movimento.Fixos.CompraMaterial) { Atencao.Show("Este é um tipo de movimento fixo. Não é possivel alterá-lo ou exclui-lo."); return; }
            if (id == (int)Tipos_movimento.Fixos.PagamentoConta) { Atencao.Show("Este é um tipo de movimento fixo. Não é possivel alterá-lo ou exclui-lo."); return; }
            if (id == (int)Tipos_movimento.Fixos.Perda) { Atencao.Show("Este é um tipo de movimento fixo. Não é possivel alterá-lo ou exclui-lo."); return; }
            if (id == (int)Tipos_movimento.Fixos.RecebConta) { Atencao.Show("Este é um tipo de movimento fixo. Não é possivel alterá-lo ou exclui-lo."); return; }
            if (id == (int)Tipos_movimento.Fixos.RetiradaCaixa) { Atencao.Show("Este é um tipo de movimento fixo. Não é possivel alterá-lo ou exclui-lo."); return; }
            if (id == (int)Tipos_movimento.Fixos.VendaMaterial) { Atencao.Show("Este é um tipo de movimento fixo. Não é possivel alterá-lo ou exclui-lo."); return; }


            Tipos_movimento tm = new Tipos_movimento();
            tm.Deletar(id);

            AtualizaDataGrid();
        }
    }
}
