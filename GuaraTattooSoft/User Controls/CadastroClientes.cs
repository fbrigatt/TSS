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
using GuaraTattooSoft.Assistente;
using Correios.Net;
using GuaraTattooSoft.Extencoes;
using GuaraTattooSoft.Forms;
using DevComponents.DotNetBar;
using GuaraTattooSoft.Componentes_especiais;
using GuaraTattooSoft.Util;
using System.IO;
using GuaraTattooSoft.Threads;
using DevComponents.Editors;

namespace GuaraTattooSoft.User_Controls
{
    public partial class CadastroClientes : UserControl
    {
        bool modoEdicao = false;

        public CadastroClientes()
        {
            InitializeComponent();

            CarregaAnamneses();

            this.AplicarPadroes();
            dataGridClientes.AplicarPadroes();

            AtualizaDataGrid();

            txNumero.BackgroundStyle.Border = eStyleBorderType.Solid;
            txNumero.BackgroundStyle.BorderColor = Color.Gray;
        }

        public void CarregaAnamneses()
        {
            listaAnamneses.Items.Clear();

            Anamneses anamneses = new Anamneses(true);

            for (int i = 0; i < anamneses.id_todos.Count; i++)
            {
                listaAnamneses.Items.Add(anamneses.descricao_todos[i]);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CadastroAnamneses ca = new CadastroAnamneses(this);
            new Util.AbrePagina(ca, "Cadastro de Anamneses", this);
        }

        private void Gravar()
        {
            if (string.IsNullOrWhiteSpace(txNome.Text)) return;

            Clientes cliente = new Clientes();

            cliente.Nome = txNome.Text;
            cliente.Telefone = txTelefone.Text;
            cliente.Celular = txCelular.Text;
            cliente.Email = txEmail.Text;
            cliente.Cpf = txCPF.Text;
            cliente.Rg = txRG.Text;
            cliente.DataNasc = txDataNasc.Text;
            cliente.Cep = txCEP.Text;
            cliente.Cidade = txCidade.Text;
            cliente.Bairro = txBairro.Text;
            cliente.Logradouro = txLogradouro.Text;
            cliente.Numero = txNumero.Value;
            cliente.Uf = txUF.Text;
            cliente.Referencia = txReferencia.Text;
            cliente.Obs = txObs.Text;
            cliente.DataCadastro = DateTime.Now;

            if (modoEdicao == true)
            {
                int id = id_edicao;

                Clientes_anamneses ca = new Clientes_anamneses(id);

                for (int i = 0; i < ca.clientes_id_todos.Count; i++)
                {
                    ca.Deletar(ca.anamneses_id_todos[i], ca.clientes_id_todos[i]);
                }

                cliente.Atualizar(id);

                for (int i = 0; i < listaAnamneses.CheckedItems.Count; i++)
                {
                    Anamneses anam = new Anamneses();
                    int idAnamnese = anam.IdByFieldName(listaAnamneses.CheckedItems[i].ToString());

                    ca.Clientes_id = id;
                    ca.Anamneses_id = idAnamnese;

                    ca.Gravar();
                }

                modoEdicao = false;
                id_edicao = 0;
            }
            else
            {
                cliente.Gravar();

                string nomeProf = string.Empty;

                if (new Confirmacao("A seguir, será enviado um email para o cliente. \nDeseja incluir um artista no corpo do email?").selection)
                {
                    SelecionarProfissional sp = new SelecionarProfissional();
                    nomeProf = sp.Nome_prodissional;
                }

                EnvioEmail(nomeProf);

                int idCliente = cliente.LastID();

                for (int i = 0; i < listaAnamneses.CheckedItems.Count; i++)
                {
                    Anamneses anam = new Anamneses();
                    int idAnamnese = anam.IdByFieldName(listaAnamneses.CheckedItems[i].ToString());

                    Clientes_anamneses ca = new Clientes_anamneses();

                    ca.Clientes_id = idCliente;
                    ca.Anamneses_id = idAnamnese;

                    ca.Gravar();
                }
            }

            LimparCampos();
            txNome.Focus();

            AtualizaDataGrid();

            CarregaAnamneses();
        }

        private void LimparCampos()
        {
            foreach (Control control in splitContainer1.Panel1.Controls)
            {
                if (control.GetType() == typeof(TextBox)) (control as TextBox).Text = string.Empty;
                if (control.GetType() == typeof(IntegerInput)) (control as IntegerInput).Value = 0;
                if (control.GetType() == typeof(MaskedTextBox)) (control as MaskedTextBox).Text = string.Empty;
            }
        }

        private void EnvioEmail(string nomeProf = null)
        {
            Entidades.Config conf = new Entidades.Config(true);

            if (!string.IsNullOrWhiteSpace(conf.ModeloEmailSessao))
            {


                StreamReader reader = new StreamReader(conf.ModeloEmailSessao);

                string body = string.Empty;

                string linha = string.Empty;

                string nomeArquivoImagem = string.Empty;

                Loja loja = new Loja(1);

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

                body = body.Replace("{nome_cliente}", txNome.Text);
                body = body.Replace("{nome_fantasia}", loja.Nome_fantasia);
                body = body.Replace("{data}", DateTime.Now.ToShortDateString());
                body = body.Replace("{hora}", DateTime.Now.ToShortTimeString());
                body = body.Replace("{nome_profissional}", nomeProf);

                string enderecoLoja = loja.Logradouro + ", " + loja.Numero + " - " + loja.Bairro;

                Email email = new Email();

                if (string.IsNullOrWhiteSpace(txEmail.Text))
                {
                    Atencao.Show("O envio do email foi cancelado! \nO cliente não possui um endereço de email.");
                    return;
                }

                email.EnviaEmail(conf.EmailLoja, loja.Nome_fantasia, conf.SenhaEmail, txEmail.Text, txNome.Text, "Referente á sua tatuagem", body, nomeArquivoImagem);
            }
        }

        private void AtualizaDataGrid(Clientes clientes = null)
        {
            dataGridClientes.Rows.Clear();

            if (clientes == null) clientes = new Clientes(true);

            for (int i = 0; i < clientes.id_todos.Count; i++)
            {
                dataGridClientes.Rows.Add(clientes.id_todos[i], clientes.nome_todos[i], clientes.telefone_todos[i], clientes.celular_todos[i], clientes.email_todos[i], clientes.CPF_todos[i], clientes.RG_todos[i], clientes.dataNasc_todos[i], clientes.CEP_todos[i], clientes.cidade_todos[i], clientes.bairro_todos[i], clientes.logradouro_todos[i], clientes.numero_todos[i], clientes.UF_todos[i], clientes.dataCadastro_todos[i]);
            }

        }

        private void CEP_Leave(object sender, EventArgs e)
        {
            try
            {
                Address address = SearchZip.GetAddress(txCEP.Text.Replace(",", string.Empty).Replace("-", string.Empty));

                txLogradouro.Text = address.Street;
                txBairro.Text = address.District;
                txCidade.Text = address.City;
                txUF.Text = address.State;
                txNumero.Focus();
            }
            catch (Exception ex)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!dataGridClientes.TemLinhas()) return;

            string nomeCliente = string.Empty;

            if (dataGridClientes.SelectedRows.Count > 0) { nomeCliente = dataGridClientes.CurrentRow.Cells[1].Value.ToString(); } else { return; }

            if (new Confirmacao("Deseja realmente excluir o cliente " + nomeCliente + "? \nEsta ação não pode ser revertida!").selection == true)
            {
                int id = int.Parse(dataGridClientes.CurrentRow.Cells[0].Value.ToString());

                Servicos serv = new Servicos();
                serv.ApenasCliente(id);
                if (serv.id_todos.Count >= 1)
                {
                    Atencao.Show("Não é possível excluir este cliente. \nEle está relacionado a um ou mais serviços.");
                    return;
                }

                Agenda agenda = new Agenda();
                if (agenda.ClienteJaAgendado(id))
                {
                    Atencao.Show("Não é possível excluir este cliente. \nEle está relacionado a um ou mais agendamentos.");
                    return;
                }

                Clientes_anamneses ca = new Clientes_anamneses(id);

                for (int i = 0; i < ca.clientes_id_todos.Count; i++)
                {
                    ca.Deletar(ca.anamneses_id_todos[i], ca.clientes_id_todos[i]);
                }

                Clientes c = new Clientes();
                c.Deletar(id);

                this.LimparCampos();

                AtualizaDataGrid();

                modoEdicao = false;
            }
        }

        int id_edicao = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            if (!dataGridClientes.TemLinhas()) return;

            modoEdicao = true;

            int id = dataGridClientes.IdAtual(0);
            id_edicao = id;

            Clientes c = new Clientes(id);

            txNome.Text = c.Nome;
            txTelefone.Text = c.Telefone;
            txCelular.Text = c.Celular;
            txEmail.Text = c.Email;
            txCPF.Text = c.Cpf;
            txRG.Text = c.Rg;
            txDataNasc.Text = c.DataNasc;
            txCEP.Text = c.Cep;
            txCidade.Text = c.Cidade;
            txBairro.Text = c.Bairro;
            txLogradouro.Text = c.Logradouro;
            txNumero.Value = c.Numero;
            txUF.Text = c.Uf;
            txReferencia.Text = c.Referencia;
            txObs.Text = c.Obs;

            Clientes_anamneses ca = new Clientes_anamneses(id);

            for (int i = 0; i < listaAnamneses.Items.Count; i++)
            {

                listaAnamneses.SetItemChecked(i, false);
            }

            foreach (int idAnam in ca.anamneses_id_todos)
            {
                Anamneses anam = new Anamneses(idAnam);

                for (int i = 0; i < listaAnamneses.Items.Count; i++)
                {
                    if (listaAnamneses.Items[i].ToString() == anam.Descricao)
                    {
                        listaAnamneses.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void txPesquisa_TextChanged(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Pesquisar(txPesquisa.Text);
            AtualizaDataGrid(clientes);
        }
    }
}
