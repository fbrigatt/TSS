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
using MySql.Data.MySqlClient;
using GuaraTattooSoft.DBConnection;

namespace GuaraTattooSoft.User_Controls
{
    public partial class CadastroCaixa : UserControl
    {
        bool modoEdicao = false;

        public CadastroCaixa()
        {
            InitializeComponent();

            AtualizaDataGrid();

            this.AplicarPadroes();
            dataGridCaixas.AplicarPadroes();

            txNomeComputador.Text = Environment.MachineName.ToString();
        }

        private void AtualizaDataGrid()
        {
            dataGridCaixas.Rows.Clear();

            Caixas caixas = new Caixas(true);

            for (int i = 0; i < caixas.id_todos.Count; i++)
            {
                string notificarUsuario = caixas.notificar_usuario_fechamento_todos[i] == true ? notificarUsuario = "SIM" : notificarUsuario = "NÃO";
                string horario = notificarUsuario == "SIM" ? horario = caixas.hora_fechamento_todos[i] : horario = string.Empty;
                dataGridCaixas.Rows.Add(caixas.id_todos[i], caixas.nome_todos[i], caixas.nome_micro_todos[i], notificarUsuario, horario);
            }

            modoEdicao = false;
            this.LimparCampos();

            txNomeComputador.Text = Environment.MachineName.ToString();
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        private void Gravar()
        {
            if (string.IsNullOrWhiteSpace(txNomeCaixa.Text)) return;

            Caixas caixas = new Caixas();

            caixas.Nome = txNomeCaixa.Text;
            caixas.Nome_micro = txNomeComputador.Text;

            if (ckAlertaUsuario.Checked == true)
            {
                caixas.Notificar_usuario_fechamento = true;
                caixas.Hora_fechamento = txHorario.Text;
            }
            else
            {
                caixas.Notificar_usuario_fechamento = false;
                caixas.Hora_fechamento = "00:00:00";
            }

            if (modoEdicao == true)
            {
                int id = dataGridCaixas.IdAtual(0);
                caixas.Atualizar(id);
            }
            else
            {
                caixas.Gravar();

                Status_caixa sc = new Status_caixa();

                sc.Caixas_id = caixas.LastID();
                sc.Data_abertura = null;
                sc.Data_fechamento = DateTime.Now;

                sc.Gravar();
            }

            AtualizaDataGrid();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (!dataGridCaixas.TemLinhas()) return;

            int id = dataGridCaixas.IdAtual(0);

            Caixas caixas = new Caixas();
            caixas.Deletar(id);

            AtualizaDataGrid();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (!dataGridCaixas.TemLinhas()) return;

            int id = dataGridCaixas.IdAtual(0);

            Caixas caixas = new Caixas(id);

            txNomeCaixa.Text = caixas.Nome;
            if (caixas.Notificar_usuario_fechamento == true) ckAlertaUsuario.Checked = true;
            if (ckAlertaUsuario.Checked == true) txHorario.Text = caixas.Hora_fechamento;

            modoEdicao = true;
        }
    }
}
