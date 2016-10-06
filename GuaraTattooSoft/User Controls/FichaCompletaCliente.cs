using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GuaraTattooSoft.Forms;

namespace GuaraTattooSoft.User_Controls
{
    public partial class FichaCompletaCliente : UserControl
    {
        public FichaCompletaCliente()
        {
            InitializeComponent();
        }

        private void txCod_Cliente_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F3)
            {
                SelecionarCliente sc = new SelecionarCliente();
                txCod_Cliente.Value = sc.Cod_cliente;
                txNome.Text = sc.Nome_cliente;
            }
        }
    }
}
