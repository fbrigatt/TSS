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
    public partial class SelecionarProfissional : Form
    {

        private int cod_profissional;
        private string nome_prodissional;

        #region Propriedades
        public int Cod_profissional
        {
            get
            {
                return cod_profissional;
            }

            set
            {
                cod_profissional = value;
            }
        }

        public string Nome_prodissional
        {
            get
            {
                return nome_prodissional;
            }

            set
            {
                nome_prodissional = value;
            }
        }
        #endregion

        public SelecionarProfissional()
        {
            InitializeComponent();

            dataGridProfissionais.AplicarPadroes();
            this.AplicarPadroes();

            AtualizadaDataGrid();

            this.ShowDialog();
        }

        private void AtualizadaDataGrid(Profissionais prof = null)
        {
            dataGridProfissionais.Rows.Clear();
            if (prof == null) prof = new Profissionais(true);

            for (int i = 0; i < prof.id_todos.Count; i++)
            {
                if(prof.ativo_todos[i])
                dataGridProfissionais.Rows.Add(prof.id_todos[i], prof.nome_todos[i]);
            }
        }

        private void txPesquisa_TextChanged(object sender, EventArgs e)
        {
            Profissionais prof = new Profissionais();
            prof.Pesquisar("nome", txPesquisa.Text);
            AtualizadaDataGrid(prof);
        }

        private void dataGridProfissionais_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!dataGridProfissionais.TemLinhas()) return;

            Cod_profissional = dataGridProfissionais.IdAtual(0);
            Nome_prodissional = dataGridProfissionais.CurrentRow.Cells[1].Value.ToString();

            this.Close();
        }

        private void txPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (!dataGridProfissionais.TemLinhas()) return;

                Cod_profissional = dataGridProfissionais.IdAtual(0);
                Nome_prodissional = dataGridProfissionais.CurrentRow.Cells[1].Value.ToString();

                this.Close();
            }
        }

        private void dataGridProfissionais_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!dataGridProfissionais.TemLinhas()) return;

                Cod_profissional = dataGridProfissionais.IdAtual(0);
                Nome_prodissional = dataGridProfissionais.CurrentRow.Cells[1].Value.ToString();

                this.Close();
            }
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            if (!dataGridProfissionais.TemLinhas()) return;

            Cod_profissional = dataGridProfissionais.IdAtual(0);
            Nome_prodissional = dataGridProfissionais.CurrentRow.Cells[1].Value.ToString();

            this.Close();
        }
    }
}
