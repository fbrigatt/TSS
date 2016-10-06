using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuaraTattooSoft.Assistente
{
    public partial class Apresentacao : Form
    {
        public Apresentacao()
        {
            InitializeComponent();
        }

        private void Apresentacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroLoja cj = new CadastroLoja();
            cj.Show();
            this.Hide();
        }

        private void Apresentacao_Load(object sender, EventArgs e)
        {

        }
    }
}
