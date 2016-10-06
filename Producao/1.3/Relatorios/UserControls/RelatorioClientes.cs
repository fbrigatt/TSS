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
using GuaraTattooSoft.Relatorios.DataSets;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;
using GuaraTattooSoft.Forms;
using GuaraTattooSoft.Util;

namespace GuaraTattooSoft.Relatorios.UserControls
{
    public partial class RelatorioClientes : UserControl
    {
        public RelatorioClientes()
        {
            InitializeComponent();

            this.AplicarPadroes();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbModelo.Text.Contains("01")) Modelo01();
            if (cbModelo.Text.Contains("02")) Modelo02();
            if (cbModelo.Text.Contains("03")) Modelo03();
            if (cbModelo.Text.Contains("04")) Modelo04();
            if (cbModelo.Text.Contains("05")) Modelo05();
            if (cbModelo.Text.Contains("06")) Modelo06();
        }

        private void Modelo01()
        {
            DataSet dataSetRelatorio = new DataSetClientes();
            dataSetRelatorio.DataSetName = "DataSetClientes";

            DataTable dtClientes = dataSetRelatorio.Tables["clientes"];
            dtClientes.TableName = "clientes";

            DataTable dtLoja = dataSetRelatorio.Tables["loja"];
            dtLoja.TableName = "loja";

            Clientes clientes = new Clientes(true);
            Loja loja = new Loja(1);

            string enderecoLoja = loja.Logradouro + ", " + loja.Numero + ", " + loja.Bairro + ", " + loja.Cidade + " - " + loja.Uf;
            dtLoja.Rows.Add(loja.Nome_fantasia, loja.Cnpj.Replace(",", "."), enderecoLoja, loja.Cep.Replace(",", "."));

            for (int i = 0; i < clientes.id_todos.Count; i++)
            {
                dtClientes.Rows.Add(clientes.nome_todos[i], clientes.telefone_todos[i], clientes.celular_todos[i], clientes.dataCadastro_todos[i].ToShortDateString(), clientes.email_todos[i]);
            }

            ReportDocument document = new ReportDocument();
            document.Load(Directory.GetCurrentDirectory() + @"\Relatorios\RelatorioClientes_listagem.rpt");
            document.SetDataSource(dataSetRelatorio);

            VisualizaRelatorios vr = new VisualizaRelatorios(document);

        }

        private void Modelo02()
        {
            if(txCod_Cliente.Value == 0)
            {
                Atencao.Show("Selecione o Cliente!");
                return;
            }

            DataSet dataSetRelatorio  = new DsFichaCompletaCliente();

            DataTable dtLoja = dataSetRelatorio.Tables["loja"];
            DataTable dtCliente = dataSetRelatorio.Tables["clientes"];
            DataTable dtServicos = dataSetRelatorio.Tables["servicos"];

            Loja loja = new Loja(1);

            string enderecoLoja = loja.Logradouro + ", " + loja.Numero + ", " + loja.Bairro + " - " + loja.Cidade + " - " + loja.Uf;
            dtLoja.Rows.Add(loja.Nome_fantasia, loja.Cnpj.Replace(",", "."), enderecoLoja, loja.Cep.Replace(",", "."));

            Clientes cliente = new Clientes(txCod_Cliente.Value);

            if (string.IsNullOrEmpty(cliente.Nome))
            {
                Atencao.Show("Selecione o Cliente!");
                return;
            }

            string enderecoCliente = cliente.Logradouro + ", " + cliente.Numero + ", " + cliente.Bairro + " - " + cliente.Cidade + " - " + cliente.Uf;
            dtCliente.Rows.Add(cliente.Nome, cliente.Telefone, cliente.Celular, cliente.DataCadastro, cliente.Email, enderecoCliente, cliente.Cep.Replace(",", "."), cliente.Cpf.Replace(",", "."), cliente.Rg.Replace(",", "."));

            string anamneseCliente = string.Empty;

            Clientes_anamneses cli_anam = new Clientes_anamneses(txCod_Cliente.Value);

            for (int i = 0; i < cli_anam.anamneses_id_todos.Count; i++)
            {
                Anamneses anam = new Anamneses(cli_anam.anamneses_id_todos[i]);
                anamneseCliente += anam.Descricao + ", ";
            }

            Movimentos mov = new Movimentos();
            mov.Pesquisar("clientes_id", txCod_Cliente.Value.ToString());

            for (int i = 0; i < mov.id_todos.Count; i++)
            {
                Movimentos_itens_movimento mim = new Movimentos_itens_movimento(mov.id_todos[i]);

                for (int im = 0; im < mim.movimentos_id_todos.Count; im++)
                {
                    Itens_movimento imv = new Itens_movimento(mim.itens_movimentos_id_todos[im]);

                    if(imv.Servico_material == (int) Itens_movimento.Tipo_Item.servico)
                    {
                        Servicos servicos = new Servicos(imv.Cod_servico_material);

                        Profissionais prof = new Profissionais(servicos.Profissionais_id);
                        Tipos_servico ts = new Tipos_servico(servicos.Tipos_servico_id);
                        Pagamentos_movimentos pg_mov = new Pagamentos_movimentos(mov.Pagamentos_movimentos_id);
                        Formas_pagamento fp = new Formas_pagamento(pg_mov.Formas_pagamento_id);
                        dtServicos.Rows.Add(servicos.Data_servico, prof.Nome, ts.Descricao, servicos.Valor_servico, fp.Descricao, servicos.Servico_realizado);
                    }
                }
            }

            ReportDocument document = new ReportDocument();
            document.Load(Directory.GetCurrentDirectory() + @"\Relatorios\FichaCompletaCliente.rpt");
            document.SetDataSource(dataSetRelatorio);
            document.SetParameterValue("anamneseCliente", anamneseCliente);

            VisualizaRelatorios vr = new VisualizaRelatorios(document);
        }

        private void Modelo03()
        {

        }

        private void Modelo04()
        {

        }

        private void Modelo05()
        {

        }

        private void Modelo06()
        {

        }

        private void txCod_Cliente_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F3)
            {
                SelecionarCliente sc = new SelecionarCliente();
                txCod_Cliente.Value = sc.Cod_cliente;
                txNome_cliente.Text = sc.Nome_cliente;
            }
        }
    }
}
