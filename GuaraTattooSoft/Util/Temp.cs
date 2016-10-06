using GuaraTattooSoft.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuaraTattooSoft.Util
{
    class Temp
    {
        private static Usuarios logado;
        private static List<Caixas> aberto = new List<Caixas>();

        public static Usuarios Logado
        {
            get
            {
                return logado;
            }

            set
            {
                logado = value;
            }
        }

        public static List<Caixas> Aberto
        {
            get
            {
                return aberto;
            }

            set
            {
                aberto = value;
            }
        }
    }
}
