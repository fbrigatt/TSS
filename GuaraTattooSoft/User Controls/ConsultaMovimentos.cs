using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GuaraTattooSoft.Entidades;
using GuaraTattooSoft.Extencoes;
using System.Threading;
using GuaraTattooSoft.Forms;

namespace GuaraTattooSoft.User_Controls
{
    public partial class ConsultaMovimentos : UserControl
    {

        Movimentos mov = null;
        Thread tarefa;

        public ConsultaMovimentos()
        {
            InitializeComponent();

            dataGridMovimentos.AplicarPadroes();
            this.AplicarPadroes();
            
            if (cbExibir.Text == "Apenas este mês")
            {
                mov = new Movimentos();
                mov.Pesquisar("id", "%", 1);
            }

            AtualizaDataGrid();
        }

        //private void ExecuteThread()
        //{
        //    tarefa = new Thread(AtualizaDataGrid);
        //    if (cbExibir.Text == "Apenas este mês")
        //    {
        //        mov = new Movimentos();
        //        mov.Pesquisar("id", "%", 1);
        //    }
        //    tarefa.Start();
        //}

        private void AtualizaDataGrid()
        {
            if (mov == null) mov = new Movimentos(true);

            cbExibir.Enabled = false;
            lbTotal.Text = "0,00";
            dataGridMovimentos.Rows.Clear();
            notif.Text = "Aguarde...";

            for (int i = 0; i < mov.id_todos.Count; i++)
            {
                Tipos_movimento tm = new Tipos_movimento(mov.tipos_movimento_id_todos[i]);
                Caixas caixa = new Caixas(mov.caixas_id_todos[i]);
                Usuarios usuarios = new Usuarios(mov.usuarios_id_todos[i]);
                Clientes clientes = new Clientes(mov.clientes_id_todos[i]);
                Pagamentos_movimentos pg_mov = new Pagamentos_movimentos(mov.pagamentos_movimentos_id_todos[i]);
                Formas_pagamento fp = new Formas_pagamento(pg_mov.Formas_pagamento_id);
                string parcelado = fp.Permitir_parcel == true ? parcelado = "SIM" : parcelado = "NÃO";

                dataGridMovimentos.Rows.Add(mov.id_todos[i], mov.data_movimento_todos[i], tm.Descricao, caixa.Nome, usuarios.Nome, clientes.Nome, pg_mov.Valor, pg_mov.Desconto, fp.Descricao, parcelado);

                decimal total = 0;
                foreach (DataGridViewRow row in dataGridMovimentos.Rows)
                {
                    decimal valor = (decimal)row.Cells[6].Value;
                    total += valor;
                }

                lbTotal.Text = total.ToString("N2");
            }

            notif.Text = "Carregamento concluido.";
            cbExibir.Enabled = true;
        }

        private void cbExibir_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbExibir.Text == "Apenas este mês")
            {
                mov = new Movimentos();
                mov.Pesquisar("id", "%", 1);
            }
            else {
                mov = new Movimentos(true);
            }
              AtualizaDataGrid();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AtualizaDataGrid();
            timer1.Stop();
        }

        private void txPesquisa_TextChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridMovimentos.Rows)
            {
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

            foreach (DataGridViewRow row in dataGridMovimentos.Rows)
            {
                if (row.Visible)
                {
                    total += decimal.Parse(row.Cells[6].Value.ToString());
                    lbTotal.Text = total.ToString();
                }
            }
        }

        private int Coluna()
        {
            switch (cbFiltro.Text)
            {
                case "Cod":
                    return 0;
                case "Data":
                    return 1;
                case "Tipo de movimento":
                    return 2;
                case "Caixa":
                    return 3;
                case "Usuário":
                    return 4;
                case "Cliente":
                    return 5;
                case "Forma de pagamento":
                    return 8;
            }
            return 0;
        }

        private void dataGridMovimentos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!dataGridMovimentos.TemLinhas()) return;

            int id = dataGridMovimentos.IdAtual(0);
            DetalhesMovimento dm = new DetalhesMovimento(id);
            dm.ShowDialog();
        }
    }
}
