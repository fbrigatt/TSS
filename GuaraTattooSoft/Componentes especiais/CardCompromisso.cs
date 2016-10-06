using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuaraTattooSoft.Componentes_especiais
{
    public partial class CardCompromisso : UserControl
    {
        int id_agenda = 0;
        bool statePressed = false;
        int counter = 0;

        public CardCompromisso(int agenda_id, DateTime? data, string nomeCliente, string nomeProf, string tipoServico)
        {
            id_agenda = agenda_id;

            InitializeComponent();

            lbData.Text = data.ToString();
            lbCliente.Text = nomeCliente;
            lbTipoServ.Text = tipoServico;
            lbNomeP.Text = nomeProf;

            if (lbData.Text.Contains("00:00:00")) lbData.Text = lbData.Text.Replace("00:00:00", string.Empty);
        }

        public void Refresh(DateTime? data, string nomeCliente, string tipoServico)
        {
            lbData.Text = data.ToString();
            lbCliente.Text = nomeCliente;
            lbTipoServ.Text = tipoServico;

            if (lbData.Text.Contains("00:00:00")) lbData.Text = lbData.Text.Replace("00:00:00", string.Empty);
        }

        private void Up()
        {
            statePressed = false;
            this.BackColor = Color.Teal;
            this.Height = 120;
            this.Width = 686;
        }

        private void Down()
        {
            statePressed = true;
            this.BackColor = Color.LightSeaGreen;
            this.Height = 120;
            this.Width = 660;

            counter = 0;
        }

        private void onLongPress_Tick(object sender, EventArgs e)
        {
            if (statePressed == true)
            {
                counter++;
            }

            if (counter == 2)
            {
                AgendaOpcoes opcoes = new AgendaOpcoes(id_agenda, this);
                

                opcoes.SetDesktopLocation(MousePosition.X, MousePosition.Y);
                opcoes.ShowDialog();

                counter = 0;
                statePressed = false;

                this.BackColor = Color.Teal;
                this.Height = 120;
                this.Width = 686;
            }
        }


        #region Eventos
        private void CardCompromisso_MouseDown(object sender, MouseEventArgs e)
        {
            Down();
        }

        private void CardCompromisso_MouseUp(object sender, MouseEventArgs e)
        {
            Up();
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            Up();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            Down();
        }

        private void lbData_MouseUp(object sender, MouseEventArgs e)
        {
            Up();
        }

        private void lbData_MouseDown(object sender, MouseEventArgs e)
        {
            Down();
        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            Up();
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            Down();
        }

        private void lbTipoServ_MouseDown(object sender, MouseEventArgs e)
        {
            Down();
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            Down();
        }

        private void lbCliente_MouseDown(object sender, MouseEventArgs e)
        {
            Down();
        }
        #endregion
    }
}
