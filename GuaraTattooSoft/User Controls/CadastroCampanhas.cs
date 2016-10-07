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
using GuaraTattooSoft.Componentes_especiais;

namespace GuaraTattooSoft.User_Controls
{
    public partial class CadastroCampanhas : UserControl
    {
        bool modoEdicao = false;

        public CadastroCampanhas()
        {
            InitializeComponent();

            this.AplicarPadroes();
            txDescricao.CharacterCasing = CharacterCasing.Normal;
            dataGridCampanhas.AplicarPadroes();
            CarregaCampanhas();
        }

        private void CarregaCampanhas(string termo = "")
        {
            txDescricao.Text = string.Empty;
            dataGridCampanhas.Rows.Clear();
            Campanhas campanha = new Campanhas(termo);

            for (int i = 0; i < campanha.id_todos.Count; i++)
            {
                dataGridCampanhas.Rows.Add(campanha.id_todos[i], campanha.descricao_todos[i]);
            }
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txDescricao.Text)) return;

            Campanhas campanha = new Campanhas(false);
            campanha.Descricao = txDescricao.Text;
            if (modoEdicao)
            {
                int id = int.Parse(dataGridCampanhas.CurrentRow.Cells[0].Value.ToString());
                campanha.Atualizar(id);
                modoEdicao = false;
            }
            else
            {
                campanha.Gravar();
            }
            
            CarregaCampanhas();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (!dataGridCampanhas.TemLinhas()) return;

            txDescricao.Text = dataGridCampanhas.CurrentRow.Cells[1].Value.ToString();
            modoEdicao = true;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (!dataGridCampanhas.TemLinhas()) return;
            if (new Confirmacao("Deseja excluir a campanha?").selection)
            {
                int id = int.Parse(dataGridCampanhas.CurrentRow.Cells[0].Value.ToString());
                Campanhas camp = new Campanhas(id);
                camp.Deletar(id);
                CarregaCampanhas();
            }
        }
    }
}
