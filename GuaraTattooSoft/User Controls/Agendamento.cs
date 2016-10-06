using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GuaraTattooSoft.Componentes_especiais;
using GuaraTattooSoft.Util;
using GuaraTattooSoft.Extencoes;
using GuaraTattooSoft.Forms;

namespace GuaraTattooSoft.User_Controls
{
    public partial class Agendamento : UserControl
    {
        public Agendamento()
        {
            InitializeComponent();

            GuaraTattooSoft.Entidades.Agenda agenda = new Entidades.Agenda();
            List<KeyValueTriple<int, string, int>> lista = agenda.GetListaProfissionais();

            foreach(KeyValueTriple<int, string, int> item in lista)
            {
                listaProfissionais.Controls.Add(new CardProfissional(item.Key, item.PrimaryValue, item.SecondaryValue));
            }

            AgendaBackController.Load(painelAgenda);
            AgendaBackController.FlowLayoutPanel.ControlRemoved += FlowLayoutPanel_ControlRemoved;
            this.Dock = DockStyle.Fill;
        }

        private void FlowLayoutPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            GuaraTattooSoft.Entidades.Agenda agenda = new Entidades.Agenda();
            listaProfissionais.Controls.Clear();
            List<KeyValueTriple<int, string, int>> lista = agenda.GetListaProfissionais();

            foreach (KeyValueTriple<int, string, int> item in lista)
            {
                listaProfissionais.Controls.Add(new CardProfissional(item.Key, item.PrimaryValue, item.SecondaryValue));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CriarAgendamento ca = new CriarAgendamento();
            ca.ShowDialog();
        }
    }
}
