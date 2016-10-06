using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuaraTattooSoft.Componentes_especiais
{
    public partial class Confirmacao : Form
    {

        public bool selection = false;

        public Confirmacao(string msg)
        {
            InitializeComponent();

            lbMsg.Text = msg;
            lbMsg.Update();

            //this.Width = lbMsg.Width;
            this.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selection = true;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selection = false;
            Close();
        }
    }
}
