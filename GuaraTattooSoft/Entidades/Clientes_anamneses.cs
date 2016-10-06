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
    class Clientes_anamneses
    {
        Conexao conn = new Conexao();
        string defaultError = "Erro em Clientes_anamneses";

        public List<int> clientes_id_todos = new List<int>();
        public List<int> anamneses_id_todos = new List<int>();

        private int clientes_id;
        private int anamneses_id;

        #region Propriedades
        public int Clientes_id
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

        public int Anamneses_id
        {
            get
            {
                return anamneses_id;
            }

            set
            {
                anamneses_id = value;
            }
        }
        #endregion

        public Clientes_anamneses(bool loadData = false)
        {
            if (loadData == false) return;

            try
            {
                MySqlCommand cmd = new MySqlCommand("select*From anamneses_clientes", conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    clientes_id_todos.Add(dr.GetInt32(0));
                    anamneses_id_todos.Add(dr.GetInt32(1));
                }

                dr.Close();

            }catch(MySqlException ex)
            {
                Erro.Show(ex.Message, defaultError);
            }
            finally
            {
                conn.Fechar();
            }
        }

        public Clientes_anamneses(int id_clientes)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from clientes_anamneses where clientes_id = " + id_clientes, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        clientes_id_todos.Add(dr.GetInt32(0));
                        anamneses_id_todos.Add(dr.GetInt32(1));
                    }
                }

                dr.Close();

            }catch(MySqlException ex)
            {
                Erro.Show(ex.Message, defaultError);
            }
            finally
            {
                conn.Fechar();
            }
        }

        #region Persistencia
        public void Atualizar(int anamneses_id, int id_clientes)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("update clientes_anamneses set anamneses id = @1 where anamneses_id = " + anamneses_id + " AND clientes_id = " + id_clientes, conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Clientes_id);

                cmd.ExecuteNonQuery();
              
            }catch(MySqlException ex)
            {
                Erro.Show("Erro ao atualizar clientes_anamneses \n" + ex.Message, defaultError);
            }
            finally
            {
                conn.Fechar();
            }
        }

        public void Deletar(int id_anamneses, int id_clientes)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("delete from clientes_anamneses where anamneses_id = " + id_anamneses + " AND clientes_id = " + id_clientes, conn.GetConexao());
                cmd.ExecuteReader();
                
            }catch(MySqlException ex)
            {
                Erro.Show("Erro ao deletar clientes_anamneses \n" + ex.Message, defaultError);
            }
            finally
            {
                conn.Fechar();
            }
        }

        public void Gravar()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("insert into clientes_anamneses(clientes_id, anamneses_id) values(@1, @2)", conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Clientes_id);
                cmd.Parameters.AddWithValue("@2", Anamneses_id);

                cmd.ExecuteNonQuery();

            }catch(MySqlException ex)
            {
                Erro.Show("Erro ao deletar clientes_anamneses \n" + ex.Message, defaultError);
            }
            finally
            {
                conn.GetConexao();
            }
        }

        public int LastID()
        {
            throw new NotImplementedException();
        }
        #endregion 
    }
}
