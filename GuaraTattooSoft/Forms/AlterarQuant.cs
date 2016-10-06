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
    public partial class AlterarQuant : Form
    {
        private int quantSelecionada;

        public AlterarQuant()
        {
            InitializeComponent();

            this.ShowDialog();
            this.AplicarPadroes();
        }

        public int QuantSelecionada
        {
            get
            {
                return quantSelecionada;
            }

            set
            {
                quantSelecionada = value;
            }
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            QuantSelecionada = txQuant.Value;
            this.Hide();
        }

        private void txQuant_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                QuantSelecionada = txQuant.Value;
                this.Hide();
            }
        }
    }
}
