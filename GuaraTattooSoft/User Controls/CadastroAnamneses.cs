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
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace GuaraTattooSoft.User_Controls
{
    public partial class CadastroAnamneses : UserControl
    {
        bool modoEdicao = false;
        CadastroClientes cadastroCliente;

        public CadastroAnamneses(CadastroClientes cadCli = null)
        {
            cadastroCliente = cadCli;

            InitializeComponent();

            this.AplicarPadroes();
            dataGridAnamneses.AplicarPadroes();

            AtualizaDataGrid();
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            Gravar();
            btGravar.BackgroundImage = null;
        }

        private void Gravar()
        {
            if (string.IsNullOrWhiteSpace(txDescricao.Text)) return;

            Anamneses anam = new Anamneses();

            anam.Descricao = txDescricao.Text;

            if (modoEdicao == true)
            {
                int id = int.Parse(dataGridAnamneses.CurrentRow.Cells[0].Value.ToString());
                anam.Atualizar(id);
            }
            else
            {
                anam.Gravar();
            }

            AtualizaDataGrid();

        }

        private void AtualizaDataGrid()
        {
            dataGridAnamneses.Rows.Clear();

            Anamneses anam = new Anamneses(true);

            for (int i = 0; i < anam.id_todos.Count; i++)
            {
                dataGridAnamneses.Rows.Add(anam.id_todos[i], anam.descricao_todos[i]);
            }

            modoEdicao = false;
            this.LimparCampos();
            if (cadastroCliente != null) cadastroCliente.CarregaAnamneses();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (!dataGridAnamneses.TemLinhas()) return;

            int id = dataGridAnamneses.IdAtual(0);

            Anamneses anam = new Anamneses();
            anam.Deletar(id);

            AtualizaDataGrid();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (!dataGridAnamneses.TemLinhas()) return;

            txDescricao.Text = dataGridAnamneses.CurrentRow.Cells[1].Value.ToString();

            modoEdicao = true;
        }

        private void btGravar_MouseDown(object sender, MouseEventArgs e)
        {
            btGravar.BackgroundImage = ((System.Drawing.Image)Properties.Resources.button);
        }
    }
}
