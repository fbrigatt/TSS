using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using GuaraTattooSoft.Util;
using GuaraTattooSoft.DBConnection;

namespace GuaraTattooSoft.Entidades
{
    class Servicos_materiais
    {
        Conexao conn = new Conexao();
        string defaultError = "Erro em servicos_materiais";

        public List<int> servicos_id_todos = new List<int>();
        public List<int> materiais_id_todos = new List<int>();

        int servicos_id;
        int materiais_id;

        #region Propriedades
        public int Servicos_id
        {
            get
            {
                return servicos_id;
            }

            set
            {
                servicos_id = value;
            }
        }

        public int Materiais_id
        {
            get
            {
                return materiais_id;
            }

            set
            {
                materiais_id = value;
            }
        }
        #endregion

        public void Atualizar(int id)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public void Gravar()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("insert into servicos_materiais(servicos_id, materiais_id) values(@1, @2)");

                cmd.Parameters.AddWithValue("@1", Servicos_id);
                cmd.Parameters.AddWithValue("@2", Materiais_id);

                cmd.ExecuteNonQuery();

            }catch(MySqlException ex)
            {
                Erro.Show("Erro ao gravar servicos_materiais \n" + ex.Message, defaultError);
            }
            finally
            {
                conn.Fechar();
            }
        }

        public int LastID()
        {
            throw new NotImplementedException();
        }
    }
}
