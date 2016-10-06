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
    public partial class SelecionarTipoServico : Form
    {

        private int cod_tipo_serv;
        private string descricao_tipo_serv;

        #region Propriedades
        public int Cod_tipo_serv
        {
            get
            {
                return cod_tipo_serv;
            }

            set
            {
                cod_tipo_serv = value;
            }
        }

        public string Descricao_tipo_serv
        {
            get
            {
                return descricao_tipo_serv;
            }

            set
            {
                descricao_tipo_serv = value;
            }
        }
        #endregion

        public SelecionarTipoServico()
        {
            InitializeComponent();

            dataGridTipos.AplicarPadroes();
            this.AplicarPadroes();

            AtualizaDataGrid();

            this.ShowDialog();
        }

        private void AtualizaDataGrid(Tipos_servico ts = null)
        {
            dataGridTipos.Rows.Clear();
            if (ts == null) ts = new Tipos_servico(true);

            for (int i = 0; i < ts.id_todos.Count; i++)
            {
                string ativo = ts.ativo_todos[i] == true ? ativo = "SIM" : ativo = "NÃO";
                dataGridTipos.Rows.Add(ts.id_todos[i], ts.descricao_todos[i], ativo);
            }
        }

        private void dataGridTipos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!dataGridTipos.TemLinhas()) return;

            Cod_tipo_serv = dataGridTipos.IdAtual(0);
            Descricao_tipo_serv = dataGridTipos.CurrentRow.Cells[1].Value.ToString();

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!dataGridTipos.TemLinhas()) return;

            Cod_tipo_serv = dataGridTipos.IdAtual(0);
            Descricao_tipo_serv = dataGridTipos.CurrentRow.Cells[1].Value.ToString();

            this.Close();
        }

        private void txPesquisa_TextChanged(object sender, EventArgs e)
        {
            Tipos_servico ts = new Tipos_servico();
            ts.Pesquisar("descricao", txPesquisa.Text);
            AtualizaDataGrid(ts);
        }

        private void txPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (!dataGridTipos.TemLinhas()) return;

                Cod_tipo_serv = dataGridTipos.IdAtual(0);
                Descricao_tipo_serv = dataGridTipos.CurrentRow.Cells[1].Value.ToString();

                this.Close();
            }
        }

        private void dataGridTipos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!dataGridTipos.TemLinhas()) return;

                Cod_tipo_serv = dataGridTipos.IdAtual(0);
                Descricao_tipo_serv = dataGridTipos.CurrentRow.Cells[1].Value.ToString();

                this.Close();
            }
        }
    }
}
