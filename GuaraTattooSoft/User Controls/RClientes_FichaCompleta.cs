using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GuaraTattooSoft.Forms;
using GuaraTattooSoft.Relatorios.DataSets;
using GuaraTattooSoft.Entidades;
using Microsoft.Reporting.WinForms;
using GuaraTattooSoft.Relatorios;

namespace GuaraTattooSoft.User_Controls
{
    public partial class RClientes_FichaCompleta : UserControl
    {
        public RClientes_FichaCompleta()
        {
            InitializeComponent();
        }

        private void txCod_Cliente_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F3)
            {
                SelecionarCliente sc = new SelecionarCliente();
                txCod_Cliente.Value = sc.Cod_cliente;
                txNome.Text = sc.Nome_cliente;
            }
        }

        private void btVisualizar_Click(object sender, EventArgs e)
        {
            Carregar(txCod_Cliente.Value);
        }

        private void Carregar(int id_cliente)
        {
            Clientes cliente = new Clientes(id_cliente);

            /*** CLIENTE ***/
            DataSet ds = new DsFichaCompletaCliente();
            ds.DataSetName = "FichaCompletaCliente";
            string endereco = cliente.Logradouro + ", " + cliente.Numero + " - " + cliente.Bairro + ", " + cliente.Cidade + " - " + cliente.Uf;
            ds.Tables["clientes"].Rows.Add(cliente.Nome, 
                                            cliente.Telefone,
                                            cliente.Celular,
                                            cliente.DataCadastro.ToShortDateString(),
                                            cliente.Email,
                                            endereco, 
                                            cliente.Cep, 
                                            cliente.Cpf.Replace(",", "."),
                                            cliente.Rg);
            ReportDataSource rds_clientes = new ReportDataSource();
            rds_clientes.Name = "fichaCompleta";
            rds_clientes.Value = ds.Tables["clientes"];

            /*** LOJA ***/
            Loja loja = new Loja(1);
            ds.Tables["loja"].Rows.Add(loja.Nome_fantasia, loja.Cnpj, (loja.Logradouro + ", " + loja.Numero + " - " + loja.Bairro));
            ReportDataSource rds_loja = new ReportDataSource();
            rds_loja.Name = "loja";
            rds_loja.Value = ds.Tables["loja"];

            /*** SERVICOS ***/
            Servicos servicos = new Servicos();
            servicos.ApenasCliente(id_cliente);

            for(int i = 0; i < servicos.id_todos.Count; i++)
            {
                ds.Tables["servicos"].Rows.Add(servicos.data_servico_todos[i].ToShortDateString(),
                                                new Profissionais(servicos.profissionais_id_todos[i]).Nome,
                                                new Tipos_servico(servicos.tipos_servico_id_todos[i]).Descricao,
                                                servicos.valor_servico_todos[i],
                                                new Formas_pagamento().GetByServico(servicos.id_todos[i]).Descricao);
            }
            ReportDataSource rds_servicos = new ReportDataSource();
            rds_servicos.Name = "procedimentos";
            rds_servicos.Value = ds.Tables["servicos"];

            /*** ANAMNESES ***/
            Anamneses anamneses = new Anamneses();
            anamneses.LoadByCliente(id_cliente);

            for(int i = 0; i < anamneses.id_todos.Count; i++)
            {
                ds.Tables["anamneses"].Rows.Add(anamneses.descricao_todos[i]);
            }
            ReportDataSource rds_an = new ReportDataSource();
            rds_an.Name = "anamneses";
            rds_an.Value = ds.Tables["anamneses"];

            new ExibeRelatorio("Relatorios/reports/FichaCompletaCliente.rdlc", new List<ReportDataSource>() {rds_loja, rds_servicos, rds_clientes, rds_an });
        }
    }
}
