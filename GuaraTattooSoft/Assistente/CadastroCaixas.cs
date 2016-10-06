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

namespace GuaraTattooSoft.Assistente
{
    public partial class CadastroCaixas : Form
    {
        bool modoEdicao = false;

        public CadastroCaixas()
        {
            InitializeComponent();

            this.AplicarPadroes();
            dataGridCaixas.AplicarPadroes();

            txHoraAviso.Text = DateTime.Now.ToLongTimeString();
            txNomeComputador.Text = Environment.MachineName;

            AtualizaDataGrid();
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        private void Gravar()
        {
            if (string.IsNullOrWhiteSpace(txNome.Text)) return;

            Caixas caixas = new Caixas();

            caixas.Nome = txNome.Text;
            caixas.Nome_micro = txNomeComputador.Text;
            caixas.Notificar_usuario_fechamento = ckNotificarFechamento.Checked == true ? caixas.Notificar_usuario_fechamento = true : caixas.Notificar_usuario_fechamento = false;
            caixas.Hora_fechamento = txHoraAviso.Text != "  :  :  " ? caixas.Hora_fechamento = txHoraAviso.Text : caixas.Hora_fechamento = string.Empty;

            Status_caixa sc;


            if(modoEdicao == true)
            {
                int id = int.Parse(dataGridCaixas.CurrentRow.Cells[0].Value.ToString());
                caixas.Atualizar(id);

                modoEdicao = false;
            }
            else
            {
                caixas.Gravar();

                int idCaixa = caixas.LastID();
                sc = new Status_caixa();
                sc.Caixas_id = idCaixa;
                sc.Data_abertura = DateTime.Now;
                sc.Gravar();
            }

            txNome.Text = string.Empty;
            AtualizaDataGrid();
        }

        private void AtualizaDataGrid()
        {
            dataGridCaixas.Rows.Clear();
            Caixas caixas = new Caixas(true);

            for(int i = 0; i < caixas.id_todos.Count; i++)
            {
                string aviso = caixas.notificar_usuario_fechamento_todos[i] == true ? aviso = "SIM" : aviso = "NÃO";
                string horaFecham = caixas.notificar_usuario_fechamento_todos[i] == true ? horaFecham = caixas.hora_fechamento_todos[i] : horaFecham = string.Empty;

                dataGridCaixas.Rows.Add(caixas.id_todos[i], caixas.nome_todos[i], caixas.nome_micro_todos[i], aviso, horaFecham);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridCaixas.Rows.Count == 0) return;
            int id = int.Parse(dataGridCaixas.CurrentRow.Cells[0].Value.ToString());

            Status_caixa sc = new Status_caixa();
            sc.Deletar(id);

            Caixas caixas = new Caixas();
            caixas.Deletar(id);

            txNome.Text = string.Empty;
            modoEdicao = false;

            AtualizaDataGrid();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridCaixas.Rows.Count == 0) return;

            modoEdicao = true;

            txNome.Text = dataGridCaixas.CurrentRow.Cells[1].Value.ToString();
            if (dataGridCaixas.CurrentRow.Cells[3].Value.ToString().Equals("SIM"))
            {
                ckNotificarFechamento.Checked = true;
                txHoraAviso.Text = dataGridCaixas.CurrentRow.Cells[4].Value.ToString();
                txHoraAviso.Enabled = true;
                ckNotificarFechamento.Checked = true;
            }
            else
            {
                txHoraAviso.Text = DateTime.Now.ToLongTimeString();
                txHoraAviso.Enabled = false;
                ckNotificarFechamento.Checked = false;
            }
        }

        private void ckNotificarFechamento_CheckedChanged(object sender, EventArgs e)
        {
            if (ckNotificarFechamento.Checked == true) txHoraAviso.Enabled = true;
            if (ckNotificarFechamento.Checked == false) txHoraAviso.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CadastroTipoServico cts = new CadastroTipoServico();
            cts.Show();
            this.Hide();
        }

        private void CadastroCaixas_Load(object sender, EventArgs e)
        {

        }
    }
}
