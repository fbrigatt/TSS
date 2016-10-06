using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuaraTattooSoft.Extencoes
{
    public static class AgendaBackController
    {
        private static int clientes_id;
        private static FlowLayoutPanel flowLayoutPanel;

        public static void Load(FlowLayoutPanel flp)
        {
            flowLayoutPanel = flp;
        }

        public static int Clientes_id
        {
            get
            {
                return clientes_id;
            }

            set
            {
                clientes_id = value;
            }
        }

        public static FlowLayoutPanel FlowLayoutPanel
        {
            get
            {
                return flowLayoutPanel;
            }

            set
            {
                flowLayoutPanel = value;
            }
        }
    }
}
