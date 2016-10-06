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
using System.Threading;

namespace GuaraTattooSoft.User_Controls
{
    public partial class HistoricoServicos : UserControl
    {
        Movimentos mov = null;
        Thread tarefa;

        public HistoricoServicos()
        {
            InitializeComponent();

            dataGridServicos.AplicarPadroes();
            this.AplicarPadroes();

            txDataFinal.Visible = false;
            txDataInicial.Visible = false;
            btExibir.Visible = false;
            lb_de.Visible = false;
            lb_ate.Visible = false;
        }

        private void ExecuteThread()
        {
            tarefa = new Thread(AtualizaDataGrid);
            if (cbExibicao.Text == "Apenas Este Mês")
            {
                mov = new Movimentos();
                mov.Pesquisar("id", "%", 1);
            }
            AtualizaDataGrid();
        }

        private void AtualizaDataGrid()
        {
            cbExibicao.Invoke(new Action<ComboBox>(enabled => cbExibicao.Enabled = false), cbExibicao);
            dataGridServicos.Invoke(new Action<DataGridView>(limparLinhas => dataGridServicos.Rows.Clear()), dataGridServicos);
            if (mov == null) mov = new Movimentos(true);

            for (int i = 0; i < mov.id_todos.Count; i++)
            {
                Clientes clientes = new Clientes(mov.clientes_id_todos[i]);
                Pagamentos_movimentos pg_mov = new Pagamentos_movimentos(mov.pagamentos_movimentos_id_todos[i]);
                Formas_pagamento fp = new Formas_pagamento(pg_mov.Formas_pagamento_id);
                string parcelado = fp.Permitir_parcel == true ? parcelado = "SIM" : parcelado = "NÃO";

                Movimentos_itens_movimento mim = new Movimentos_itens_movimento(mov.id_todos[i]);

                for (int imv = 0; imv < mim.itens_movimentos_id_todos.Count; imv++)
                {
                    Itens_movimento itens_mov = new Itens_movimento(mim.itens_movimentos_id_todos[imv]);
                    if (itens_mov.Servico_material == (int)Itens_movimento.Tipo_Item.servico)
                    {
                        Servicos serv = new Servicos(itens_mov.Cod_servico_material);
                        Profissionais prof = new Profissionais(serv.Profissionais_id);
                        Tipos_servico ts = new Tipos_servico(serv.Tipos_servico_id);

                        dataGridServicos.Invoke(new Action<DataGridView>(adicionarLinha =>
                        dataGridServicos.Rows.Add(itens_mov.Cod_servico_material, serv.Data_servico, clientes.Nome, prof.Nome, ts.Descricao, fp.Descricao, serv.Valor_servico)
                        ), dataGridServicos);
                    }
                }
            }
            cbExibicao.Invoke(new Action<ComboBox>(enabled => cbExibicao.Enabled = true), cbExibicao);
        }

        private void gatilho_Tick(object sender, EventArgs e)
        {
            ExecuteThread();
            gatilho.Stop();
        }

        private void cbExibicao_TextChanged(object sender, EventArgs e)
        {

        }

        private void AtivarFiltro()
        {
            txDataFinal.Visible = true;
            txDataInicial.Visible = true;
            btExibir.Visible = true;
            lb_de.Visible = true;
            lb_ate.Visible = true;
        }

        private void DesativarFiltro()
        {
            txDataFinal.Visible = false;
            txDataInicial.Visible = false;
            btExibir.Visible = false;
            lb_de.Visible = false;
            lb_ate.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] dataInicio = txDataInicial.Text.Split('/');
            string[] dataFinal = txDataFinal.Text.Split('/');

            string diaInicio_fb = dataInicio[2] + "-" + dataInicio[1] + "-" + dataInicio[0] + " 00:00:00";
            string diaFinal_fb = dataFinal[2] + "-" + dataFinal[1] + "-" + dataFinal[0] + " 23:59:59";

            mov = new Movimentos();
            mov.Filtrar(diaInicio_fb, diaFinal_fb);

            tarefa = new Thread(AtualizaDataGrid);
            tarefa.Start();
        }

        private void txPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (cbFiltro.Text == "Cliente")
            {
                foreach (DataGridViewRow row in dataGridServicos.Rows)
                {
                    if (row.Cells[2].Value.ToString().Contains(txPesquisa.Text))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }

            if (cbFiltro.Text == "Profissional")
            {
                foreach (DataGridViewRow row in dataGridServicos.Rows)
                {
                    if (row.Cells[3].Value.ToString().Contains(txPesquisa.Text))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }

            if (cbFiltro.Text == "Data")
            {
                foreach (DataGridViewRow row in dataGridServicos.Rows)
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

            if (cbFiltro.Text == "Tipo Serviço")
            {
                foreach (DataGridViewRow row in dataGridServicos.Rows)
                {
                    if (row.Cells[4].Value.ToString().Contains(txPesquisa.Text))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }

            if (cbFiltro.Text == "Forma Pagamento")
            {
                foreach (DataGridViewRow row in dataGridServicos.Rows)
                {
                    if (row.Cells[5].Value.ToString().Contains(txPesquisa.Text))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void cbExibicao_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbExibicao.Text)
            {
                case "Por Período":

                    AtivarFiltro();

                    break;

                case "Apenas Hoje":

                    AtivarFiltro();

                    txDataInicial.Value = DateTime.Now.Date;
                    txDataFinal.Value = DateTime.Now.Date;

                    string[] dataInicio = txDataInicial.Text.Split('/');
                    string[] dataFinal = txDataFinal.Text.Split('/');

                    string diaInicio_fb = dataInicio[2] + "-" + dataInicio[1] + "-" + dataInicio[0] + " 00:00:00";
                    string diaFinal_fb = dataFinal[2] + "-" + dataFinal[1] + "-" + dataFinal[0] + " 23:59:59";

                    mov = new Movimentos();
                    mov.Filtrar(diaInicio_fb, diaFinal_fb);

                    tarefa = new Thread(AtualizaDataGrid);
                    tarefa.Start();

                    DesativarFiltro();
                    break;

                case "Apenas Este Mês":

                    mov = new Movimentos();
                    mov.Pesquisar("clientes_id", "%", 1);

                    tarefa = new Thread(AtualizaDataGrid);
                    tarefa.Start();
                    break;

                case "Todos":

                    DesativarFiltro();
                    mov = new Movimentos(true);

                    tarefa = new Thread(AtualizaDataGrid);
                    tarefa.Start();

                    break;
            }
        }
    }
}