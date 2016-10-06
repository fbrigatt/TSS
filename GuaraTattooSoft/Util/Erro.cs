using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuaraTattooSoft.Util
{
    class Erro
    {
        public static void Show(string msg, string titulo)
        {
            MessageBox.Show(msg, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
