using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using GuaraTattooSoft.Util;

namespace GuaraTattooSoft.Entidades
{
    public interface IClasse_Persistencia
    {
        void Gravar();
        void Atualizar(int id);
        void Deletar(int id);
        int LastID();
    }
}
