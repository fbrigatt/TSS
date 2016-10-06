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

namespace GuaraTattooSoft.User_Controls
{
    public partial class AlterarComissao : UserControl
    {
        double comissaoAtual = 0;

        public AlterarComissao()
        {
            InitializeComponent();

            dataGridProfissionais.AplicarPadroes();
            this.AplicarPadroes();

            AtualizaDataGrid();
        }

        private void AtualizaDataGrid(Profissionais prof = null)
        {
            dataGridProfissionais.Rows.Clear();

            if (prof == null) prof = new Profissionais(true);

            for (int i = 0; i < prof.id_todos.Count; i++)
            {
                string ativo = prof.ativo_todos[i] == true ? ativo = "SIM" : ativo = "NÃO";
                dataGridProfissionais.Rows.Add(prof.id_todos[i], prof.nome_todos[i], prof.telefone_todos[i], prof.CPF_todos[i], prof.salario_todos[i], prof.comissao_todos[i], ativo);
            }
        }

        private void btAplicar_Click(object sender, EventArgs e)
        {
            if (rdApenasProfs.Checked) Gravar((int)ModoAlteracao.ApenasProfs);
            if (rdApenasSel.Checked) Gravar((int)ModoAlteracao.ApenasSel);
            if (rdTodos.Checked) Gravar((int)ModoAlteracao.Todos);

            AtualizaDataGrid();
        }

        private void Gravar(int modoAlt)
        {
            if (!dataGridProfissionais.TemLinhas()) return;

            int id = dataGridProfissionais.IdAtual(0);

            if (modoAlt == (int)ModoAlteracao.ApenasProfs)
            {
                foreach (DataGridViewRow row in dataGridProfissionais.Rows)
                {
                    Profissionais prof = new Profissionais((int)row.Cells[0].Value);
                    if (prof.Comissao == comissaoAtual)
                    {
                        prof.Comissao = txComissao.Value;
                        prof.Atualizar((int)row.Cells[0].Value);
                    }
                }

                return;
            }

            if(modoAlt == (int)ModoAlteracao.ApenasSel)
            {
                id = (int)dataGridProfissionais.CurrentRow.Cells[0].Value;
                Profissionais prof = new Profissionais(id);
                prof.Comissao = txComissao.Value;
                prof.Atualizar(id);

                return;
            }

            if(modoAlt == (int)ModoAlteracao.Todos)
            {
                foreach(DataGridViewRow row in dataGridProfissionais.Rows)
                {
                    Profissionais prof = new Profissionais((int)row.Cells[0].Value);
                    prof.Comissao = txComissao.Value;
                    prof.Atualizar((int)row.Cells[0].Value);
                }

                return;
            }
        }

        private void dataGridProfissionais_SelectionChanged(object sender, EventArgs e)
        {
            txComissao.Value = (double)dataGridProfissionais.CurrentRow.Cells[5].Value;
            comissaoAtual = txComissao.Value;
        }
    }

    public enum ModoAlteracao
    {
        ApenasProfs = 1,
        ApenasSel = 2,
        Todos = 3
    }
}
