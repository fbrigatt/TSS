using GuaraTattooSoft.Extencoes;
using GuaraTattooSoft.Forms;
using GuaraTattooSoft.User_Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuaraTattooSoft.Util
{
    class AbrePagina
    {
        CadastroClientes cadastroClientes;

        public AbrePagina(Control control, string tabPageTitle, CadastroClientes cadastroCli = null)
        {
            cadastroClientes = cadastroCli;
               
            TabPage tabPage = new TabPage(tabPageTitle);
            tabPage.Controls.Add(control);
            Home.tabControl.Adicionar(tabPage);

            if (cadastroClientes != null) cadastroClientes.CarregaAnamneses();
        }
    }
}
