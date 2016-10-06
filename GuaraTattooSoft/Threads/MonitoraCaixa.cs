using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using GuaraTattooSoft.Entidades;
using GuaraTattooSoft.Util;

namespace GuaraTattooSoft.Threads
{
    class MonitoraCaixa
    {

        private System.Timers.Timer timer;

        public MonitoraCaixa()
        {
            timer = new System.Timers.Timer();
            timer.Interval = 30000;
            timer.Elapsed += Timer_Elapsed;
            timer.Enabled = true;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            timer.Enabled = false;

            if (timer.Enabled == false)
            {

                Caixas caixas = new Caixas(true);

                for (int i = 0; i < caixas.id_todos.Count; i++)
                {
                    int idStatus = new Status_caixa().LastID(caixas.id_todos[i]);
                    Status_caixa sc = new Status_caixa(idStatus);

                    if (caixas.notificar_usuario_fechamento_todos[i] == true)
                    {
                        string horaFechamento = caixas.hora_fechamento_todos[i];
                        string horaAgora = DateTime.Now.ToShortTimeString();

                        DateTime dtFech = Convert.ToDateTime(horaFechamento);
                        DateTime dtAg = Convert.ToDateTime(horaAgora);

                        if (dtAg >= dtFech)
                        {
                            if (!sc.Data_fechamento.HasValue)
                            {
                                string usuarioLogado = Temp.Logado.Nome;
                                Atencao.Show("Sr(a) " + usuarioLogado + ", FAVOR REALIZAR O FECHAMENTO DO CAIXA!");
                                break;
                            }
                        }
                    }
                }
            }
            timer.Enabled = true;
        }
    }
}
