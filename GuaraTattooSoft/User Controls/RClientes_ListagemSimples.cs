using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GuaraTattooSoft.Entidades;
using GuaraTattooSoft.Relatorios;
using GuaraTattooSoft.Relatorios.DataSets;
using Microsoft.Reporting.WinForms;
using GuaraTattooSoft.Forms;

namespace GuaraTattooSoft.User_Controls
{
    public partial class RClientes_ListagemSimples : UserControl
    {
        public RClientes_ListagemSimples()
        {
            InitializeComponent();

            cbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btVisualizar_Click(object sender, EventArgs e)
        {
            Clientes clientes;
            switch (cbFiltro.SelectedIndex)
            {
                case (int)Filtro.Todos:

                    clientes = new Clientes(true);
                    Carregar(clientes, "descricaoModelo: ");
                    break;

                case (int)Filtro.Aniversariantes:

                    clientes = new Clientes();
                    clientes.Aniversariantes();
                    Carregar(clientes, "descricaoModelo:Aniversáriantes do mês");
                    break;

                case (int)Filtro.Profissional:

                    clientes = new Clientes();
                    clientes.ProfissionalAtendido(txCod_profissional.Value, txData_inicio.Value, txData_fim.Value);
                    Carregar(clientes, "descricaoModelo:Atendidos por profissional - Período de " + txData_inicio.Value.ToShortDateString() + " até " + txData_fim.Value.ToShortDateString() + ", profissional " + txNome.Text);
                    break;

                case (int)Filtro.Data_cadastro:

                    clientes = new Clientes();
                    clientes.ListarPorDataCadastro(txData_inicio.Value, txData_fim.Value);
                    Carregar(clientes, "descricaoModelo:Por data de cadastro - Período de " + txData_inicio.Value.ToShortDateString() + " até " + txData_fim.Value.ToShortDateString());
                    break;
            }
        }

        private void Carregar(Clientes clientes, string descricaoModelo)
        {
            DataSet ds = new DataSetClientes();

            for (int i = 0; i < clientes.id_todos.Count; i++)
            {
                ds.Tables["clientes"].Rows.Add
                    (
                        clientes.nome_todos[i],
                        clientes.telefone_todos[i],
                        clientes.celular_todos[i],
                        clientes.dataCadastro_todos[i].ToShortDateString(),
                        clientes.email_todos[i],
                        clientes.UltimoMovimento(clientes.id_todos[i]).Data_movimento.ToShortDateString()
                    );
            }

            Loja loja = new Loja(1);
            ds.Tables["loja"].Rows.Add(loja.Razao_social, loja.Cnpj, (loja.Logradouro + ", " + loja.Numero + " - " + loja.Bairro));

            ReportDataSource rds_loja = new ReportDataSource();
            rds_loja.Name = "loja";
            rds_loja.Value = ds.Tables["loja"];

            ReportDataSource rds_clientes = new ReportDataSource();
            rds_clientes.Name = "clientes";
            rds_clientes.Value = ds.Tables["clientes"];

            new ExibeRelatorio("Relatorios/reports/ListagemClientes.rdlc", new List<ReportDataSource>() { rds_clientes, rds_loja }, new string[] { descricaoModelo });

        }

        enum Filtro
        {
            Todos = 0,
            Aniversariantes = 1,
            Data_cadastro = 2,
            Profissional = 3,
            Valor = 4
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbFiltro.SelectedIndex)
            {
                case (int)Filtro.Todos:

                    txData_inicio.Enabled = false;
                    txData_fim.Enabled = false;
                    txCod_profissional.Enabled = false;
                    break;

                case (int)Filtro.Aniversariantes:

                    txData_inicio.Enabled = false;
                    txData_fim.Enabled = false;
                    txCod_profissional.Enabled = false;
                    break;

                case (int)Filtro.Profissional:

                    txData_inicio.Enabled = true;
                    txData_fim.Enabled = true;
                    txCod_profissional.Enabled = true;
                    break;

                case (int)Filtro.Data_cadastro:

                    txData_inicio.Enabled = true;
                    txData_fim.Enabled = true;
                    txCod_profissional.Enabled = false;
                    break;
            }
        }

        private void txCod_profissional_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                SelecionarProfissional sp = new SelecionarProfissional();
                txCod_profissional.Value = sp.Cod_profissional;
                txNome.Text = sp.Nome_prodissional;
            }
        }
    }
}
