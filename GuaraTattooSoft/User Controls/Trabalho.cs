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
using GuaraTattooSoft.Forms;
using GuaraTattooSoft.Util;
using GuaraTattooSoft.Entidades;
using System.IO;
using GuaraTattooSoft.Threads;
using GuaraTattooSoft.Relatorios.DataSets;
using CrystalDecisions.CrystalReports.Engine;
using GuaraTattooSoft.Relatorios;
using GuaraTattooSoft.Componentes_especiais;

namespace GuaraTattooSoft.User_Controls
{
    public partial class Trabalho : UserControl
    {
        HashSet<KeyValuePair<decimal, double>> bkpTotalServ = new HashSet<KeyValuePair<decimal, double>>();

        public Trabalho(int id_agenda = 0)
        {
            InitializeComponent();

            dataGridMateriais.AplicarPadroes();
            this.AplicarPadroes();

            txCod_usuario.Value = Temp.Logado.Id;
            txNome_usuario.Text = Temp.Logado.Nome;

            txDataServico.Value = DateTime.Now;

            PreparaInterface();

            if (id_agenda != 0) CarregaDadosAgenda(id_agenda);
        }

        private void PreparaInterface()
        {
            Caixas caixas = new Caixas(true);
            for (int i = 0; i < caixas.id_todos.Count; i++)
            {
                int idSc = new Status_caixa().LastID(caixas.id_todos[i]);
                Status_caixa sc = new Status_caixa(idSc);

                if(sc.Data_fechamento == null)
                {
                    txCod_caixa.Value = caixas.id_todos[i];
                    txNome_caixa.Text = caixas.nome_todos[i];
                    continue;
                }
            }

            Tipos_servico ts = new Tipos_servico(true);
            for (int i = 0; i < ts.id_todos.Count; i++)
            {
                txCodtipo_servico.Value = ts.id_todos[i];
                txDescricaoTipo_servico.Text = ts.descricao_todos[i];
                break;
            }

            Formas_pagamento fp = new Formas_pagamento(true);
            for (int i = 0; i < fp.id_todos.Count; i++)
            {
                txCodforma_pag.Value = fp.id_todos[i];
                txDescricaoForma_pag.Text = fp.descricao_todos[i];
                break;
            }
        }

        private void CarregaDadosAgenda(int id_agenda)
        {
            Entidades.Agenda agenda = new Entidades.Agenda(id_agenda);

            txCod_profissional.Value = agenda.Profissionais_id;
            txCod_cliente.Value = agenda.Clientes_id;
            txCodtipo_servico.Value = agenda.Tipos_servico_id;

            txNome_profissional.Text = new Profissionais(agenda.Profissionais_id).Nome;
            txNome_cliente.Text = new Clientes(agenda.Clientes_id).Nome;
            txDescricaoTipo_servico.Text = new Tipos_servico(agenda.Tipos_servico_id).Descricao;

        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {
            if (txCod_usuario.Value == 0) { Atencao.Show("Selecione o Usuário!"); return; }
            if (txCod_caixa.Value == 0) { Atencao.Show("Selecione o Caixa!"); return; }
            if (txCodtipo_servico.Value == 0) { Atencao.Show("Selecione o Tipo de Serviço!"); return; }
            if (txCod_profissional.Value == 0) { Atencao.Show("Selecione o Profissional!"); return; }
            if (txCod_cliente.Value == 0) { Atencao.Show("Selecione o Cliente!"); return; }
            if (txCodforma_pag.Value == 0) { Atencao.Show("Selecione a Forma de Pagamento!"); return; }

            Gravar();
        }

        private void Gravar()
        {
            Servicos servico = new Servicos();
            Parcelamento parcelamento = new Parcelamento(txValor_total.Value, (int)Tipos_movimento.Fixos.PrestacaoServ);

            Formas_pagamento forma_pag = new Formas_pagamento(txCodforma_pag.Value);

            if (forma_pag.Permitir_parcel == true)
            {
                parcelamento.ShowDialog();
                if (!parcelamento.Efetuado) return;
            }

            servico.Data_servico = txDataServico.Value;
            servico.Servico_realizado = txObs.Text;
            servico.Valor_servico = (decimal)txValor_trabalho.Value;
            servico.Valor_total = (decimal)txValor_total.Value;
            servico.Tipos_servico_id = txCodtipo_servico.Value;
            servico.Clientes_id = txCod_cliente.Value;
            servico.Profissionais_id = txCod_profissional.Value;
            servico.Usuarios_id = txCod_usuario.Value;

            servico.Gravar();

            int idServico = servico.LastID();

            Pagamentos_movimentos pg_mov = new Pagamentos_movimentos();

            pg_mov.Valor = forma_pag.Permitir_parcel == true ? pg_mov.Valor = 0 : pg_mov.Valor = (decimal)txValor_total.Value;
            pg_mov.Desconto = txDesconto.Value;
            pg_mov.Formas_pagamento_id = txCodforma_pag.Value;

            pg_mov.Gravar();

            int idPg_mov = pg_mov.LastID();

            Movimentos mov = new Movimentos();

            mov.Data_movimento = txDataServico.Value;
            mov.Tipos_movimento_id = (int)Tipos_movimento.Fixos.PrestacaoServ;
            mov.Caixas_id = txCod_caixa.Value;
            mov.Usuarios_id = txCod_usuario.Value;
            mov.Clientes_id = txCod_cliente.Value;
            mov.Pagamentos_movimentos_id = idPg_mov;

            mov.Gravar();

            int idMov = mov.LastID();

            Itens_movimento itens_mov = new Itens_movimento();
            Movimentos_itens_movimento mim = new Movimentos_itens_movimento();

            foreach (DataGridViewRow row in dataGridMateriais.Rows)
            {
                itens_mov.Servico_material = (int)Itens_movimento.Tipo_Item.material;
                itens_mov.Cod_servico_material = (int)row.Cells[0].Value;
                itens_mov.Qntd = double.Parse(row.Cells[6].Value.ToString());

                Materiais material = new Materiais(itens_mov.Cod_servico_material);
                material.Estoque -= (decimal) itens_mov.Qntd;
                material.Atualizar(itens_mov.Cod_servico_material);

                itens_mov.Gravar();

                int idItem = itens_mov.LastID();

                mim.Movimentos_id = idMov;
                mim.Itens_movimentos_id = idItem;

                mim.Gravar();
            }

            itens_mov.Servico_material = (int)Itens_movimento.Tipo_Item.servico;
            itens_mov.Cod_servico_material = idServico;
            itens_mov.Qntd = 1;

            itens_mov.Gravar();

            int itemId = itens_mov.LastID();

            mim.Movimentos_id = idMov;
            mim.Itens_movimentos_id = itemId;

            mim.Gravar();

            if (parcelamento.dataGridParcelas.Rows.Count != 0)
            {
                if (parcelamento.contaPagar == true)
                {
                    Contas_pagar cp = new Contas_pagar();

                    foreach (DataGridViewRow row in parcelamento.dataGridParcelas.Rows)
                    {

                        cp.Movimentos_id = idMov;
                        cp.Formas_pagamento_id = txCodforma_pag.Value;
                        cp.Emitente = parcelamento.cbOperadoras.Text;
                        cp.Destinatario = new Loja(1).Nome_fantasia;
                        cp.Descricao = new Tipos_movimento((int)Tipos_movimento.Fixos.PrestacaoServ).Descricao;
                        cp.Valor = (decimal)row.Cells[1].Value;
                        cp.Vencimento = Convert.ToDateTime(row.Cells[0].Value.ToString());
                        cp.Juros = parcelamento.txJuros.Value;
                        cp.Pago = false;

                        cp.Gravar();
                    }
                }

                if (parcelamento.contaPagar == false)
                {
                    Contas_receber cr = new Contas_receber();

                    foreach (DataGridViewRow row in parcelamento.dataGridParcelas.Rows)
                    {

                        cr.Movimentos_id = idMov;
                        cr.Formas_pagamento_id = txCodforma_pag.Value;
                        cr.Emitente = new Loja(1).Nome_fantasia;
                        cr.Destinatario = new Formas_pagamento(txCodforma_pag.Value).Permitir_parcel ? cr.Destinatario = parcelamento.cbOperadoras.Text : cr.Destinatario = txNome_cliente.Text;
                        cr.Descricao = new Tipos_movimento((int)Tipos_movimento.Fixos.PrestacaoServ).Descricao;
                        cr.Valor = (decimal)row.Cells[1].Value;
                        cr.Vencimento = Convert.ToDateTime(row.Cells[0].Value.ToString());
                        cr.Juros = 0;
                        cr.Pago = false;

                        cr.Gravar();
                    }
                }

                foreach (DataGridViewRow row in dataGridMateriais.Rows)
                {

                    Materiais materiais = new Materiais(int.Parse(row.Cells[0].Value.ToString()));

                    materiais.Estoque -= decimal.Parse(row.Cells[6].Value.ToString());

                    materiais.Atualizar(int.Parse(row.Cells[0].Value.ToString()));
                }
            }

            if (forma_pag.Permitir_parcel == false)
            {
                Totais_caixa tc = new Totais_caixa();

                tc.Caixas_id = txCod_caixa.Value;
                tc.Valor = decimal.Parse(txValor_total.Value.ToString());
                tc.Data = DateTime.Now;

                tc.Gravar();
            }

            CriarAgendamento();
            ExibirTCLE();

            int cod_usuario = txCod_usuario.Value;
            string nome_usuario = txNome_usuario.Text;
            
            dataGridMateriais.Rows.Clear();

            txCod_usuario.Value = cod_usuario;
            txNome_usuario.Text = nome_usuario;
        }

        private void CriarAgendamento()
        {
            Config conf = new Config(true);

            if (conf.DiasRetorno_cliente != 0)
            {
                if (new Confirmacao("Confirmar agendamento para retorno do cliente?").selection)
                {
                    Agenda agenda = new Agenda();

                    if (agenda.ClienteJaAgendado(txCod_cliente.Value))
                    {
                        int idAgenda = agenda.IdByCliente(txCod_cliente.Value);
                        agenda.Deletar(idAgenda);
                    }
                    DateTime data = DateTime.Now.AddDays(conf.DiasRetorno_cliente);

                    agenda.Data = data.Date;
                    agenda.Profissionais_id = txCod_profissional.Value;
                    agenda.Clientes_id = txCod_cliente.Value;
                    agenda.Tipos_servico_id = conf.Tipos_servico_id;

                    agenda.Gravar();
                }
            }
        }

        private void ExibirTCLE()
        {
            try
            {
                DataSet dataSetRelatorio = new DsComprovanteServico();

                Clientes_anamneses ca = new Clientes_anamneses(txCod_cliente.Value);

                for (int i = 0; i < ca.anamneses_id_todos.Count; i++)
                {
                    Anamneses anamneses = new Anamneses(ca.anamneses_id_todos[i]);
                    dataSetRelatorio.Tables["Anamneses"].Rows.Add(anamneses.Descricao);
                }

                Loja loja = new Loja(1);

                string enderecoLoja = loja.Logradouro + ", " + loja.Numero + " - " + loja.Bairro + " - " + loja.Uf;

                Profissionais profissional = new Profissionais(txCod_profissional.Value);
                Clientes cliente = new Clientes(txCod_cliente.Value);

                string enderecoCliente = cliente.Logradouro + ", " + cliente.Numero + " " + cliente.Referencia;

                ReportDocument document = new ReportDocument();
                string caminhoRPT = Directory.GetCurrentDirectory() + @"\Relatorios\ComprovanteServico.rpt";
                document.Load(caminhoRPT);
                document.SetDataSource(dataSetRelatorio);

                string telefoneCelularLoja = loja.Telefone != "( )    -    " ? telefoneCelularLoja = loja.Telefone : telefoneCelularLoja = loja.Celular;

                //PARAMETROS DO RELATORIO
                document.SetParameterValue("LOJA_NOME_FANTASIA", loja.Nome_fantasia);
                document.SetParameterValue("LOJA_ENDERECO", enderecoLoja);
                document.SetParameterValue("LOJA_CEP", loja.Cep.Replace(",", "."));
                document.SetParameterValue("LOJA_TELEFONE", telefoneCelularLoja);
                document.SetParameterValue("LOJA_CNPJ", loja.Cnpj.Replace(",", "."));
                document.SetParameterValue("LOJA_PROFISSIONAL", profissional.Nome);
                document.SetParameterValue("CLIENTE_NOME", cliente.Nome);
                document.SetParameterValue("CLIENTE_DATA_NASC", cliente.DataNasc);
                document.SetParameterValue("CLIENTE_RG", cliente.Rg.Replace(",", "."));
                document.SetParameterValue("CLIENTE_CPF", cliente.Cpf.Replace(",", "."));
                document.SetParameterValue("CLIENTE_ENDERECO", enderecoCliente);
                document.SetParameterValue("CLIENTE_BAIRRO", cliente.Bairro);
                document.SetParameterValue("CLIENTE_CEP", cliente.Cep.Replace(",", "."));
                document.SetParameterValue("CLIENTE_TELEFONE", cliente.Telefone);
                document.SetParameterValue("CLIENTE_CELULAR", cliente.Celular);
                document.SetParameterValue("CLIENTE_EMAIL", cliente.Email);
                
                txObs.Text = string.Empty;
                txNome_cliente.Text = string.Empty;
                txCod_cliente.Value = 0;
                txTotal_materiais.Value = 0;
                txDesconto.Value = 0;
                txValor_trabalho.Value = 0;
                txValor_total.Value = 0;

                VisualizaRelatorios vsr = new VisualizaRelatorios(document);

            }
            catch (Exception ex)
            {
                Erro.Show(ex.Message, "Erro ao gerar documento");
            }
        }

        private void EnvioEmail()
        {
            Config conf = new Config(true);

            if (!string.IsNullOrWhiteSpace(conf.ModeloEmailSessao))
            {
                StreamReader reader = new StreamReader(conf.ModeloEmailSessao);

                string body = string.Empty;

                string linha = string.Empty;

                string nomeArquivoImagem = string.Empty;

                while ((linha = reader.ReadLine()) != null)
                {
                    if (linha.Contains("<img"))
                    {
                        nomeArquivoImagem = linha.Replace("<img src=\"", string.Empty);
                        nomeArquivoImagem = nomeArquivoImagem.Replace("\"", string.Empty);
                        nomeArquivoImagem = nomeArquivoImagem.Replace("height=\"300\" width=\"300\">", string.Empty);
                        nomeArquivoImagem = nomeArquivoImagem.Replace("height =300", string.Empty);
                        nomeArquivoImagem = nomeArquivoImagem.Replace("width=300>", string.Empty);
                        continue;
                    }
                    body += linha;
                }

                Loja loja = new Loja(1);

                string enderecoLoja = loja.Logradouro + ", " + loja.Numero + " - " + loja.Bairro;

                body = body.Replace("{NOME_CLIENTE}", new Clientes(txCod_cliente.Value).Nome);
                body = body.Replace("{NOME_FANTASIA}", loja.Nome_fantasia);
                body = body.Replace("{ENDERECO_LOJA}", enderecoLoja);
                body = body.Replace("{NOME_PROFISSIONAL}", new Profissionais(txCod_profissional.Value).Nome);
                body = body.Replace("{DATA}", txDataServico.Value.ToShortDateString());
                body = body.Replace("{HORA}", txDataServico.Value.ToShortTimeString());
                body = body.Replace("{DATA_SERVICO}", txDataServico.Value.ToShortDateString());
                body = body.Replace("{DETALHES_SERVICO}", txObs.Text);

                Email email = new Email();

                Clientes cliente = new Clientes(txCod_cliente.Value);

                if (string.IsNullOrWhiteSpace(cliente.Email))
                {
                    Atencao.Show("O envio do email foi cancelado! \nO cliente não possui um endereço de email.");
                    return;
                }

                email.EnviaEmail(conf.EmailLoja, loja.Nome_fantasia, conf.SenhaEmail, cliente.Email, cliente.Nome, "Referente á sua tatuagem", body, nomeArquivoImagem);
            }
        }

        #region Eventos
        private void txCodforma_pag_ValueChanged(object sender, EventArgs e)
        {
            Formas_pagamento fp = new Formas_pagamento(txCodforma_pag.Value);

            if (fp.Permitir_parcel == true)
            {
                Operadoras_cartao oc = new Operadoras_cartao(true);
                if (oc.id_todos.Count == 0)
                {
                    Atencao.Show("Não é possivel utilizar esta forma de pagamento. \nNão existem operadoras de cartão cadastradas!");
                    txCodforma_pag.Value = 0;
                    txDescricaoForma_pag.Text = string.Empty;
                    return;
                }
            }
        }

        public DataTable GetDataTableFromDGV()
        {

            DataTable dt = new DataTable();

            foreach (DataGridViewColumn coluna in dataGridMateriais.Columns)
            {
                dt.Columns.Add(coluna.HeaderText);
            }

            for (int i = 0; i < dataGridMateriais.Rows.Count; i++)
            {
                dt.Rows.Add(dataGridMateriais[0, i].Value, dataGridMateriais[1, i].Value, dataGridMateriais[2, i].Value, dataGridMateriais[3, i].Value, dataGridMateriais[4, i].Value, dataGridMateriais[5, i].Value, dataGridMateriais[6, i].Value, dataGridMateriais[7, i].Value);
            }

            return dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!dataGridMateriais.TemLinhas()) return;

            dataGridMateriais.Rows.Remove(dataGridMateriais.CurrentRow);

            txTotal_materiais.Value = 0;
            txValor_total.Value = 0;

            for (int i = 0; i < dataGridMateriais.Rows.Count; i++)
            {
                txValor_total.Value += double.Parse(dataGridMateriais.Rows[i].Cells[5].Value.ToString()) * double.Parse(dataGridMateriais.Rows[i].Cells[6].Value.ToString());
                txTotal_materiais.Value += double.Parse(dataGridMateriais.Rows[i].Cells[5].Value.ToString()) * double.Parse(dataGridMateriais.Rows[i].Cells[6].Value.ToString());
            }
        }

        private void integerInput4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                SelecionarCaixa sc = new SelecionarCaixa();
                txCod_caixa.Value = sc.Cod_caixa;
                txNome_caixa.Text = sc.Nome_caixa;
            }
        }

        private void txCodtipo_servico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                SelecionarTipoServico sts = new SelecionarTipoServico();

                txCodtipo_servico.Value = sts.Cod_tipo_serv;
                txDescricaoTipo_servico.Text = sts.Descricao_tipo_serv;
            }
        }

        private void txCod_cliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                SelecionarCliente sc = new SelecionarCliente();

                txCod_cliente.Value = sc.Cod_cliente;
                txNome_cliente.Text = sc.Nome_cliente;
            }
        }

        private void txCod_profissional_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                SelecionarProfissional sp = new SelecionarProfissional();

                txCod_profissional.Value = sp.Cod_profissional;
                txNome_profissional.Text = sp.Nome_prodissional;
            }
        }

        private void txCodforma_pag_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                SelecionarFormaPag sfp = new SelecionarFormaPag();

                txCodforma_pag.Value = sfp.Cod_forma_pag;
                txDescricaoForma_pag.Text = sfp.Descricao_forma_pag;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdicionarItensMov aim = new AdicionarItensMov(this);
            aim.ShowDialog();
        }

        private void txValor_trabalho_Leave(object sender, EventArgs e)
        {
            txValor_total.Value = txValor_trabalho.Value + txTotal_materiais.Value;
        }

        private void txDesconto_Enter(object sender, EventArgs e)
        {
            bkpTotalServ.Clear();
        }

        private void txDesconto_Leave(object sender, EventArgs e)
        {
            double valorDesconto = txValor_total.Value / 100 * txDesconto.Value;
            txValor_total.Value -= valorDesconto;
        }

        private void txDesconto_ValueChanged(object sender, EventArgs e)
        {
            if (txDesconto.Value == 0)
            {
                txValor_total.Value = txValor_trabalho.Value + txTotal_materiais.Value;
            }
        }

        private void txTotal_materiais_Leave(object sender, EventArgs e)
        {
            txValor_total.Value = txValor_trabalho.Value + txTotal_materiais.Value;
        }
        #endregion
    }
}
