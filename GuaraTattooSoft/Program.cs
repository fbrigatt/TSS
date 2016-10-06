using GuaraTattooSoft.Assistente;
using GuaraTattooSoft.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuaraTattooSoft
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Loja loja = new Loja(1);

                if (string.IsNullOrEmpty(loja.Razao_social))
                {
                    Application.Run(new Apresentacao());
                }
                else
                {
                    Application.Run(new Login());
                }
            }
            catch (Exception ex)
            {
                GuaraTattooSoft.Util.Erro.Show(ex.Message, "Erro");
            }
        }
    }
}
