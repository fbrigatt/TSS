using GuaraTattooSoft.DBConnection;
using GuaraTattooSoft.Util;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuaraTattooSoft.Entidades
{
    class Movimentos_itens_movimento : IClasse_Persistencia
    {
        Conexao conn = new Conexao();
        string defaultError = "Erro em movimentos_itens_movimento";

        public List<int> movimentos_id_todos = new List<int>();
        public List<int> itens_movimentos_id_todos = new List<int>();

        private int movimentos_id;
        private int itens_movimentos_id;

        #region Propriedades
        public int Movimentos_id
        {
            get
            {
                return movimentos_id;
            }

            set
            {
                movimentos_id = value;
            }
        }

        public int Itens_movimentos_id
        {
            get
            {
                return itens_movimentos_id;
            }

            set
            {
                itens_movimentos_id = value;
            }
        }
        #endregion

        public Movimentos_itens_movimento(bool loadData = false)
        {
            if (loadData == false) return;
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from movimentos_itens_movimento", conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    movimentos_id_todos.Add(dr.GetInt32(0));
                    itens_movimentos_id_todos.Add(dr.GetInt32(1));
                }

                dr.Close();

            }
            catch (MySqlException ex)
            {
                Erro.Show(ex.Message, defaultError);
            }
            finally
            {
                conn.Fechar();
            }
        }

        public Movimentos_itens_movimento(int movimentos_id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from movimentos_itens_movimento where movimentos_id = " + movimentos_id, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        movimentos_id_todos.Add(dr.GetInt32(0));
                        itens_movimentos_id_todos.Add(dr.GetInt32(1));
                    }
                }

                dr.Close();

            }
            catch (MySqlException ex)
            {
                Erro.Show(ex.Message, defaultError);
            }
            finally
            {
                conn.Fechar();
            }
        }

        public void Atualizar(int id)
        {

        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public void Gravar()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("insert into movimentos_itens_movimento(movimentos_id, itens_movimento_id) values(@1, @2)", conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Movimentos_id);
                cmd.Parameters.AddWithValue("@2", Itens_movimentos_id);

                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                Erro.Show("Erro ao gravar movimentos_itens_movimento \n" + ex.Message, defaultError);
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
