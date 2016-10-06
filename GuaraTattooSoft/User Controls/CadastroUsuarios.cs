using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GuaraTattooSoft.Forms;
using GuaraTattooSoft.Extencoes;
using GuaraTattooSoft.Entidades;
using GuaraTattooSoft.Util;

namespace GuaraTattooSoft.User_Controls
{
    public partial class CadastroUsuarios : UserControl
    {
        bool modoEdicao = false;

        public CadastroUsuarios()
        {
            InitializeComponent();

            this.AplicarPadroes();
            dataGridUsuarios.AplicarPadroes();
            dataGridTiposMov.AplicarPadroes();

            AtualizaTiposMovimento();

            this.AtualizaDataGrid();
        }

        private void AtualizaTiposMovimento()
        {
            dataGridTiposMov.Rows.Clear();
            Tipos_movimento tm = new Tipos_movimento(true);

            for(int i = 0; i < tm.id_todos.Count; i++)
            {
                dataGridTiposMov.Rows.Add(tm.id_todos[i], false, tm.descricao_todos[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InputUsuarioSenha ius = new InputUsuarioSenha();
            ius.ShowDialog();
            txNome.Text = ius.Usuario;
            txSenha.Text = ius.Senha;
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        private void Gravar()
        {
            if (string.IsNullOrWhiteSpace(txNome.Text)) return;

            Usuarios usuarios = modoEdicao ? new Usuarios(dataGridUsuarios.IdAtual(0)) : new Usuarios();
            Usuarios_tipos_movimentos utm;

            usuarios.Nome = txNome.Text;
            usuarios.Senha = txSenha.Text;
            usuarios.Cadastro_clientes = ckCadCli.Checked == true ? usuarios.Cadastro_clientes = true : usuarios.Cadastro_clientes = false;
            usuarios.Cadastro_profissionais = ckCadProf.Checked == true ? usuarios.Cadastro_profissionais = true : usuarios.Cadastro_profissionais = false;
            usuarios.Lancamento_servicos = ckLancaServ.Checked == true ? usuarios.Lancamento_servicos = true : usuarios.Lancamento_servicos = false;
            
            if(modoEdicao == true)
            {
                 int id = dataGridUsuarios.IdAtual(0);
                utm = new Usuarios_tipos_movimentos(id);

                for (int i = 0; i < utm.usuarios_id_todos.Count; i++)
                {
                    utm.Deletar(utm.usuarios_id_todos[i], utm.tipos_movimento_id_todos[i]);
                }

                for (int i = 0; i < dataGridTiposMov.Rows.Count; i++)
                {
                    if ((bool)dataGridTiposMov.Rows[i].Cells[1].Value == true)
                    {
                        utm.Usuarios_id = id;
                        utm.Tipos_movimento_id = int.Parse(dataGridTiposMov.Rows[i].Cells[0].Value.ToString());
                        utm.Gravar();
                    }
                }

                usuarios.Atualizar(id);
            }
            else
            {
                usuarios.Gravar();

                int idUsuario = usuarios.LastID();

                utm = new Usuarios_tipos_movimentos();

                for (int i = 0; i < dataGridTiposMov.Rows.Count; i++)
                {
                    if ((bool)dataGridTiposMov.Rows[i].Cells[1].Value == true)
                    {
                        utm.Usuarios_id = idUsuario;
                        utm.Tipos_movimento_id = int.Parse(dataGridTiposMov.Rows[i].Cells[0].Value.ToString());
                        utm.Gravar();
                    }
                }
            }

            AtualizaDataGrid();
        }

        private void AtualizaDataGrid()
        {
            dataGridUsuarios.Rows.Clear();

            Usuarios usuarios = new Usuarios(true);

            for(int i = 0; i < usuarios.id_todos.Count; i++)
            {
                string cadCli = usuarios.cadastro_clientes_todos[i] == true ? cadCli = "SIM" : cadCli = "NÃO";
                string cadProf = usuarios.cadastro_profissionais_todos[i] == true ? cadProf = "SIM" : cadProf = "NÃO";
                string lancaServ = usuarios.lancamento_servicos_todos[i] == true ? lancaServ = "SIM" : lancaServ = "NÃO";

                dataGridUsuarios.Rows.Add(usuarios.id_todos[i], usuarios.nome_todos[i], "!@#$%¨&*()_+", cadCli, cadProf, lancaServ);
            }

            modoEdicao = false;
            this.LimparCampos();
            this.AtualizaTiposMovimento();
        }

        private void dataGridTiposMov_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataGridTiposMov.Columns[1].Index)
            {
                if ((bool)dataGridTiposMov.CurrentRow.Cells[1].Value == false) { dataGridTiposMov.CurrentRow.Cells[1].Value = true; return; }
                if ((bool)dataGridTiposMov.CurrentRow.Cells[1].Value == true) { dataGridTiposMov.CurrentRow.Cells[1].Value = false; return; }
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (!dataGridUsuarios.TemLinhas()) return;

            int id = dataGridUsuarios.IdAtual(0);

            Usuarios_tipos_movimentos utm = new Usuarios_tipos_movimentos(id);

            for (int i = 0; i < utm.usuarios_id_todos.Count; i++)
            {
                utm.Deletar(utm.usuarios_id_todos[i], utm.tipos_movimento_id_todos[i]);
            }

            Usuarios usuarios = new Usuarios();
            if (usuarios.Admin == true) { Atencao.Show("Não é possível excluir este usuário.\nO mesmo é o administrador do sistema."); } else { usuarios.Deletar(id); }

            AtualizaDataGrid();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (!dataGridUsuarios.TemLinhas()) return;

            int id = dataGridUsuarios.IdAtual(0);

            Usuarios usuarios = new Usuarios(id);
            txNome.Text = usuarios.Nome;
            txSenha.Text = usuarios.Senha;
            if(usuarios.Cadastro_clientes == true) { ckCadCli.Checked = true; } else { ckCadCli.Checked = false; }
            if(usuarios.Cadastro_profissionais == true) { ckCadProf.Checked = true; } else { ckCadProf.Checked = false; }
            if(usuarios.Lancamento_servicos == true) { ckLancaServ.Checked = true; } else { ckLancaServ.Checked = false; }

            Usuarios_tipos_movimentos utm = new Usuarios_tipos_movimentos(id);

            for(int i = 0; i < utm.usuarios_id_todos.Count; i++)
            {
                int idTipo_mov = utm.tipos_movimento_id_todos[i];
                
                for(int tm = 0; tm < dataGridTiposMov.Rows.Count; tm++)
                {
                    if (int.Parse(dataGridTiposMov.Rows[tm].Cells[0].Value.ToString()) == idTipo_mov)
                    {
                        dataGridTiposMov.Rows[tm].Cells[1].Value = true;
                    }
                }
            }

            modoEdicao = true;
        }
    }
}
