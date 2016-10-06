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
    public partial class SelecionarTipoMov : Form
    {
        private int cod_tipo_mov;
        private string descricao_mov;

        public SelecionarTipoMov()
        {
            InitializeComponent();

            this.AplicarPadroes();
            dataGridTiposMov.AplicarPadroes();

            CarregaTiposMov();

            this.ShowDialog();
            
        }

        public int Cod_tipo_mov
        {
            get
            {
                return cod_tipo_mov;
            }

            set
            {
                cod_tipo_mov = value;
            }
        }

        public string Descricao_mov
        {
            get
            {
                return descricao_mov;
            }

            set
            {
                descricao_mov = value;
            }
        }

        private void CarregaTiposMov(Tipos_movimento tipos_mov = null)
        {
            dataGridTiposMov.Rows.Clear();

            if (tipos_mov == null) tipos_mov = new Tipos_movimento(true);

            for(int i = 0; i < tipos_mov.id_todos.Count; i++)
            {
                dataGridTiposMov.Rows.Add(tipos_mov.id_todos[i], tipos_mov.descricao_todos[i]);
            }
        }

        private void txPesquisa_TextChanged(object sender, EventArgs e)
        {
            Tipos_movimento tipos_mov = new Tipos_movimento();
            tipos_mov.Pesquisar(txPesquisa.Text);
            CarregaTiposMov(tipos_mov);
        }

        private void txPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (!dataGridTiposMov.TemLinhas()) return;

                Cod_tipo_mov = dataGridTiposMov.IdAtual(0);
                Descricao_mov = dataGridTiposMov.CurrentRow.Cells[1].Value.ToString();
                this.Close();
            }
        }

        private void dataGridTiposMov_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!dataGridTiposMov.TemLinhas()) return;

            Cod_tipo_mov = dataGridTiposMov.IdAtual(0);
            Descricao_mov = dataGridTiposMov.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            if (!dataGridTiposMov.TemLinhas()) return;

            Cod_tipo_mov = dataGridTiposMov.IdAtual(0);
            Descricao_mov = dataGridTiposMov.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }

        private void dataGridTiposMov_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!dataGridTiposMov.TemLinhas()) return;

                Cod_tipo_mov = dataGridTiposMov.IdAtual(0);
                Descricao_mov = dataGridTiposMov.CurrentRow.Cells[1].Value.ToString();
                this.Close();
            }
        }
    }
}
