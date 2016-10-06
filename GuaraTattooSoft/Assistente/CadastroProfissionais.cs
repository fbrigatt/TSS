using GuaraTattooSoft.Entidades;
using GuaraTattooSoft.Extencoes;
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

namespace GuaraTattooSoft.Assistente
{
    public partial class CadastroProfissionais : Form
    {
        bool modoEdicao = false;

        public CadastroProfissionais()
        {
            InitializeComponent();

            this.AplicarPadroes();
            dataGridProfissionais.AplicarPadroes();

            AtualizaDataGrid();
        }

        private void btProximo_Click(object sender, EventArgs e)
        {
            Sucesso.Show("Configuração inicial concluida!");
            Sucesso.Show("Os próximos cadastros/alterações deverão ser feitos posteriormente \natravés do menu Cadastros");
           
            Caixas caixas = new Caixas(true);

            Tipos_movimento tm_aberturaCaixa = new Tipos_movimento();
            tm_aberturaCaixa.Descricao = "PRESTAÇÃO DE SERVIÇOS";
            tm_aberturaCaixa.Entrada_material = (int)Tipos_movimento.EstadosMovimento.Saida;
            tm_aberturaCaixa.Entrada_valor = (int)Tipos_movimento.EstadosMovimento.Entrada;
            tm_aberturaCaixa.Ativo = true;
            tm_aberturaCaixa.Gravar();

            Tipos_movimento tm_retiradaCaixa = new Tipos_movimento();
            tm_retiradaCaixa.Descricao = "RETIRADA DE VALOR EM CAIXA";
            tm_retiradaCaixa.Entrada_material = (int)Tipos_movimento.EstadosMovimento.Nenhum;
            tm_retiradaCaixa.Entrada_valor = (int)Tipos_movimento.EstadosMovimento.Saida;
            tm_retiradaCaixa.Ativo = true;
            tm_retiradaCaixa.Gravar();

            Tipos_movimento tm_PagamentoConta = new Tipos_movimento();
            tm_PagamentoConta.Descricao = "PAGAMENTO DE CONTA";
            tm_PagamentoConta.Entrada_material = (int)Tipos_movimento.EstadosMovimento.Nenhum;
            tm_PagamentoConta.Entrada_valor = (int)Tipos_movimento.EstadosMovimento.Saida;
            tm_PagamentoConta.Ativo = true;
            tm_PagamentoConta.Gravar();

            Tipos_movimento tm_recebimentoConta = new Tipos_movimento();
            tm_recebimentoConta.Descricao = "RECEBIMENTO DE CONTA";
            tm_recebimentoConta.Entrada_material = (int)Tipos_movimento.EstadosMovimento.Nenhum;
            tm_recebimentoConta.Entrada_valor = (int)Tipos_movimento.EstadosMovimento.Entrada;
            tm_recebimentoConta.Ativo = true;
            tm_recebimentoConta.Gravar();

            Tipos_movimento tm_compraMaterial = new Tipos_movimento();
            tm_compraMaterial.Descricao = "COMPRA DE MATERIAL";
            tm_compraMaterial.Entrada_material = (int)Tipos_movimento.EstadosMovimento.Entrada;
            tm_compraMaterial.Entrada_valor = (int)Tipos_movimento.EstadosMovimento.Saida;
            tm_compraMaterial.Ativo = true;
            tm_compraMaterial.Gravar();

            Tipos_movimento tm_vendaMaterial = new Tipos_movimento();
            tm_vendaMaterial.Descricao = "VENDA DE MATERIAL PARA CONSUMIDOR FINAL";
            tm_vendaMaterial.Entrada_material = (int)Tipos_movimento.EstadosMovimento.Saida;
            tm_vendaMaterial.Entrada_valor = (int)Tipos_movimento.EstadosMovimento.Entrada;
            tm_vendaMaterial.Ativo = true;
            tm_vendaMaterial.Gravar();

            Tipos_movimento tm_perda = new Tipos_movimento();
            tm_perda.Descricao = "PERDA";
            tm_perda.Entrada_material = (int)Tipos_movimento.EstadosMovimento.Saida;
            tm_perda.Entrada_valor = (int)Tipos_movimento.EstadosMovimento.Saida;
            tm_perda.Ativo = true;
            tm_perda.Gravar();

            Formas_pagamento a_vista = new Formas_pagamento();
            a_vista.Descricao = "DINHEIRO";
            a_vista.Permitir_parcel = false;
            a_vista.Gravar();

            Formas_pagamento a_prazo = new Formas_pagamento();
            a_prazo.Descricao = "CARTÃO";
            a_prazo.Permitir_parcel = true;
            a_prazo.Gravar();

            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Gravar()
        {
            Profissionais profissionais = new Profissionais();

            profissionais.Nome = txNome.Text;
            profissionais.Telefone = txTel_Cel.Text;
            profissionais.Cpf = txCPF.Text;
            profissionais.Data_entrada = txDataEntrada.Text;
            profissionais.Comissao = txComissao.Value;
            profissionais.Ativo = true;

            if (modoEdicao == true)
            {
                int id = dataGridProfissionais.IdAtual(0);
                profissionais.Atualizar(id);
                modoEdicao = false;
            }
            else
            {
                profissionais.Gravar();
            }

            this.LimparCampos();

            AtualizaDataGrid();
        }

        private void AtualizaDataGrid()
        {
            dataGridProfissionais.Rows.Clear();

            Profissionais profissionais = new Profissionais(true);

            for(int i = 0; i < profissionais.id_todos.Count; i++)
            {
                dataGridProfissionais.Rows.Add(profissionais.id_todos[i], profissionais.nome_todos[i], profissionais.telefone_todos[i], profissionais.CPF_todos[i], profissionais.data_entrada_todos[i], profissionais.comissao_todos[i]);
            }
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (!dataGridProfissionais.TemLinhas()) return;

            int id = dataGridProfissionais.IdAtual(0);
            Profissionais profissionais = new Profissionais();
            profissionais.Deletar(id);
            AtualizaDataGrid();

            modoEdicao = false;

            this.LimparCampos();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (!dataGridProfissionais.TemLinhas()) return;

            modoEdicao = true;
            int id = dataGridProfissionais.IdAtual(0);
            Profissionais profissionais = new Profissionais(id);

            txNome.Text = profissionais.Nome;
            txTel_Cel.Text = profissionais.Telefone;
            txCPF.Text = profissionais.Cpf;
            txDataEntrada.Text = profissionais.Data_entrada;
            txComissao.Value = profissionais.Comissao;
        }
    }
}
