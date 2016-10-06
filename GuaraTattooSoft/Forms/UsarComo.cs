using GuaraTattooSoft.Entidades;
using GuaraTattooSoft.Extencoes;
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
    public partial class UsarComo : Form
    {
        string path = string.Empty;

        public UsarComo(string caminho)
        {
            path = caminho;

            InitializeComponent();

            dataGridOpcoes.AplicarPadroes();
            this.AplicarPadroes();

            CarregaOpcoes();
        }

        private void CarregaOpcoes()
        {
            dataGridOpcoes.Rows.Add(1, "Envio do email após a sessão");
            dataGridOpcoes.Rows.Add(2, "Envio de email para parabenizar o cliente");
            dataGridOpcoes.Rows.Add(3, "Lembrete de agendamento do cliente");
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            Config config = new Config(true);

            int cod = dataGridOpcoes.IdAtual(0);

            switch (cod)
            {
                case 1:

                    config.ModeloEmailSessao = path;
                    break;

                case 2:

                    config.ModeloEmailAniv = path;
                    break;

                case 3:

                    config.ModeloEmailAgend = path;
                    break;
            }

            config.Atualizar();

            this.Close();
        }
    }
}
