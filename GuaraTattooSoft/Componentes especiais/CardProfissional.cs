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

namespace GuaraTattooSoft.Componentes_especiais
{
    public partial class CardProfissional : UserControl
    {

        private int idProf = 0;

        public CardProfissional(int idProfissional, string nomeProfissional, int numeroCompromissos)
        {
            idProf = idProfissional;

            InitializeComponent();

            lbNomeProdissional.Text = nomeProfissional;
            lbQuant.Text = numeroCompromissos.ToString();

            grupoQuant.Width = lbQuant.Width + 15;
        }

        private void AddToLayout()
        {
            Agenda agenda = new Agenda();
            agenda.CompromissosProfissional(idProf);

            AgendaBackController.FlowLayoutPanel.Controls.Clear();

            for (int i = 0; i < agenda.id_todos.Count; i++)
            {
                Tipos_servico ts = new Tipos_servico(agenda.tipos_servicos_id_todos[i]);
                Clientes cli = new Clientes(agenda.clientes_id_todos[i]);
                Profissionais prof = new Profissionais(agenda.profissionais_id_todos[i]);

                AgendaBackController.FlowLayoutPanel.Controls.Add(new CardCompromisso(agenda.id_todos[i], agenda.data_todos[i], cli.Nome, prof.Nome, ts.Descricao));
            }
        }

        private void CardProfissional_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.LightSeaGreen;
            AddToLayout();
        }

        private void CardProfissional_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Teal;
        }

        private void lbNomeProdissional_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.LightSeaGreen;
            AddToLayout();
        }

        private void lbNomeProdissional_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Teal;
        }
    }
}
