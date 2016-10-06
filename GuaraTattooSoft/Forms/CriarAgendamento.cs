using GuaraTattooSoft.Entidades;
using GuaraTattooSoft.Extencoes;
using GuaraTattooSoft.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuaraTattooSoft.Forms
{
    public partial class CriarAgendamento : Form
    {
        public CriarAgendamento()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txCod_Profissional_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                SelecionarProfissional sp = new SelecionarProfissional();
                txCod_Profissional.Value = sp.Cod_profissional;
                txNome_profissional.Text = sp.Nome_prodissional;
            }
        }

        private void txCod_cliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                Agenda agenda = new Agenda();

                SelecionarCliente sc;
                sc = new SelecionarCliente();

                txCod_cliente.Value = sc.Cod_cliente;
                txNome_cliente.Text = sc.Nome_cliente;

            }
        }

        private void txCodTipo_serv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                SelecionarTipoServico sts = new SelecionarTipoServico();
                txCodTipo_serv.Value = sts.Cod_tipo_serv;
                txDescricao_serv.Text = sts.Descricao_tipo_serv;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txCod_Profissional.Value == 0) { Atencao.Show("Selecione o profissional!"); return; }
            if (txCod_cliente.Value == 0) { Atencao.Show("Selecione o cliente!"); return; }
            if (txCodTipo_serv.Value == 0) { Atencao.Show("Selecione o tipo de serviço!"); return; }

            Gravar();
        }

        private void Gravar()
        {
            Agenda agenda = new Agenda();

            agenda.Profissionais_id = txCod_Profissional.Value;
            agenda.Clientes_id = txCod_cliente.Value;
            agenda.Tipos_servico_id = txCodTipo_serv.Value;

            if (txHora.Text == "  :") txHora.Text = "00:00";

            string dataHora = txData.Value.ToShortDateString() + " " + txHora.Text + ":00";

            DateTime dt = Convert.ToDateTime(dataHora);

            agenda.Data = dt;

            agenda.Gravar();

            AgendaBackController.FlowLayoutPanel.Controls.Clear();

            this.Close();
        }

        private void txCod_cliente_ValueChanged(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda();

            if (agenda.ClienteJaAgendado(txCod_cliente.Value))
            {
                Atencao.Show("Este cliente já tem um agendamento!");
                txCod_cliente.Value = 0;

                SelecionarCliente sc = new SelecionarCliente();

                txCod_cliente.Value = sc.Cod_cliente;
                txNome_cliente.Text = sc.Nome_cliente;
            }
        }
    }
}
