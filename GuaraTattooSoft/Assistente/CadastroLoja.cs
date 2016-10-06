using Correios.Net;
using GuaraTattooSoft.Entidades;
using GuaraTattooSoft.Extencoes;
using GuaraTattooSoft.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuaraTattooSoft.Assistente
{
    public partial class CadastroLoja : Form
    {
        private bool editando = false;

        public CadastroLoja(bool modoEdicao = false)
        {
            InitializeComponent();

            this.AplicarPadroes();
            editando = modoEdicao;

            if (modoEdicao)
            {
                Carregar();
                btProximo.Text = "&SALVAR";
            }
        }

        private void Carregar()
        {
            Loja loja = new Loja(1);

            txRazao_social.Text = loja.Razao_social;
            txNome_fantasia.Text = loja.Nome_fantasia;
            txCNPJ.Text = loja.Cnpj;
            txResponsavel.Text = loja.Responsavel;
            txTelefone.Text = loja.Telefone;
            txCelular.Text = loja.Celular;
            txCidade.Text = loja.Cidade;
            txLogradouro.Text = loja.Logradouro;
            txBairro.Text = loja.Bairro;
            txUF.Text = loja.Uf;
            txNumero.Value = loja.Numero;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuscaCep();
        }

        private void BuscaCep()
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

        private void txCEP_Leave(object sender, EventArgs e)
        {
            BuscaCep();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        private void Gravar()
        {
            Loja loja = new Loja();

            loja.Razao_social = txRazao_social.Text;
            loja.Nome_fantasia = txNome_fantasia.Text;
            loja.Cnpj = txCNPJ.Text;
            loja.Cep = txCEP.Text;
            loja.Cidade = txCidade.Text;
            loja.Bairro = txBairro.Text;
            loja.Numero = txNumero.Value;
            loja.Logradouro = txLogradouro.Text;
            loja.Uf = txUF.Text;
            loja.Responsavel = txResponsavel.Text;
            loja.Telefone = txTelefone.Text;
            loja.Celular = txCelular.Text;

            if (editando)
                loja.Atualizar(1);
            else
                loja.Gravar();

            if (!editando)
            {
                Config config = new Config();
                config.ShowDialog();
            }

            this.Hide();
        }
    }
}
