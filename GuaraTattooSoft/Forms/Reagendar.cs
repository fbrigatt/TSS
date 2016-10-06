using GuaraTattooSoft.Componentes_especiais;
using GuaraTattooSoft.Entidades;
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
    public partial class Reagendar : Form
    {
        int id_agenda = 0;
        CardCompromisso cardCompromisso = null;

        public Reagendar(int agenda_id, CardCompromisso cardComp)
        {
            id_agenda = agenda_id;
            cardCompromisso = cardComp;

            InitializeComponent();

            CarregaInfoAgendamento();
        }

        private void CarregaInfoAgendamento()
        {
            Agenda agenda = new Agenda(id_agenda);
            Tipos_servico ts = new Tipos_servico(agenda.Tipos_servico_id);

            txCod_Profissional.Value = agenda.Profissionais_id;
            txNome_profissional.Text = new Profissionais(agenda.Profissionais_id).Nome;
            txNome_cliente.Text = new Clientes(agenda.Clientes_id).Nome;
            txCodTipo_serv.Value = agenda.Tipos_servico_id;
            txDescricao_serv.Text = ts.Descricao;

            DateTime data = agenda.Data.HasValue ? agenda.Data.Value.Date : data = DateTime.Now.Date;
            string hora = agenda.Data.HasValue ? agenda.Data.Value.ToShortTimeString() : hora = DateTime.Now.ToShortTimeString();

            txData.Value = data;
            txHora.Text = hora;

        }

        private void Gravar()
        {
            Agenda agenda = new Agenda(id_agenda);

            agenda.Profissionais_id = txCod_Profissional.Value;
            agenda.Tipos_servico_id = txCodTipo_serv.Value;

            if (txHora.Text == "  :") txHora.Text = "00:00";

            string dataHora = txData.Value.ToShortDateString() + " " + txHora.Text + ":00";

            DateTime dt = Convert.ToDateTime(dataHora);

            agenda.Data = dt;

            agenda.Atualizar(id_agenda);

            this.Close();

            cardCompromisso.Refresh(dt, txNome_cliente.Text, txDescricao_serv.Text);
        }

        #region Eventos
        private void txCod_Profissional_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F3)
            {
                SelecionarProfissional sp = new SelecionarProfissional();

                txCod_Profissional.Value = sp.Cod_profissional;
                txNome_profissional.Text = sp.Nome_prodissional;
            }
        }

        private void txCodTipo_serv_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F3)
            {
                SelecionarTipoServico sts = new SelecionarTipoServico();
                txCodTipo_serv.Value = sts.Cod_tipo_serv;
                txDescricao_serv.Text = sts.Descricao_tipo_serv;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Gravar();
        }
    }
}
