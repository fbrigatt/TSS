using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GuaraTattooSoft.Entidades;
using GuaraTattooSoft.Extencoes;

namespace GuaraTattooSoft.User_Controls
{
    public partial class CadastroEstilos : UserControl
    {
        public CadastroEstilos()
        {
            InitializeComponent();

            this.dataGridEstilos.AplicarPadroes();
            this.AplicarPadroes();
            AtualizaDataGrid();
        }

        private void AtualizaDataGrid()
        {
            dataGridEstilos.Rows.Clear();
            Estilos estilos = new Estilos(true);

            for (int i = 0; i < estilos.id_todos.Count; i++)
                dataGridEstilos.Rows.Add(estilos.id_todos[i], estilos.nome_todos[i]);

            txNome.Text = string.Empty;
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txNome.Text)) return;
            Estilos estilo = new Estilos();
            estilo.Nome = txNome.Text;
            estilo.Gravar();
            AtualizaDataGrid();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridEstilos.CurrentRow == null || dataGridEstilos.Rows.Count == 0) return;

            int id = int.Parse(dataGridEstilos.CurrentRow.Cells[0].Value.ToString());
            Estilos estilo = new Estilos();
            estilo.Deletar(id);
        }
    }
}
