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
    class Usuarios_tipos_movimentos
    {
        Conexao conn = new Conexao();
        string defaultError = "Erro em usuarios_tipos_movimento";

        public List<int> usuarios_id_todos = new List<int>();
        public List<int> tipos_movimento_id_todos = new List<int>();

        int usuarios_id;
        int tipos_movimento_id;

        #region Propriedades
        public int Usuarios_id
        {
            get
            {
                return usuarios_id;
            }

            set
            {
                usuarios_id = value;
            }
        }

        public int Tipos_movimento_id
        {
            get
            {
                return tipos_movimento_id;
            }

            set
            {
                tipos_movimento_id = value;
            }
        }
        #endregion

        public Usuarios_tipos_movimentos(bool loadData = false)
        {
            if (loadData == false) return;
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from usuarios_tipos_movimento", conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        usuarios_id_todos.Add(dr.GetInt32(0));
                        tipos_movimento_id_todos.Add(dr.GetInt32(1));
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

        public Usuarios_tipos_movimentos(int id_usuarios)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from usuarios_tipos_movimento where usuarios_id = " + id_usuarios, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        usuarios_id_todos.Add(dr.GetInt32(0));
                        tipos_movimento_id_todos.Add(dr.GetInt32(1));
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
        public void Atualizar(int id_usuarios, int id_tipos_movimento)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("update usuarios_tipos_movimento set tipos_movimento_id = @1 where usuarios_id = @2 AND tipos_movimento_id = @3", conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", tipos_movimento_id);
                cmd.Parameters.AddWithValue("@2", id_usuarios);
                cmd.Parameters.AddWithValue("@3", id_tipos_movimento);

                cmd.ExecuteNonQuery();

            }catch(MySqlException ex)
            {
                Erro.Show("Erro ao atualizar usuarios_tipos_movimentos \n" + ex.Message, defaultError);
            }
            finally
            {
                conn.Fechar();
            }
        }

        public void Deletar(int id_usuarios, int id_tipos_movimento)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("delete from usuarios_tipos_movimento where usuarios_id = @1 AND tipos_movimento_id = @2", conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", id_usuarios);
                cmd.Parameters.AddWithValue("@2", id_tipos_movimento);

                cmd.ExecuteNonQuery();


            }catch(MySqlException ex)
            {
                Erro.Show("Erro ao deletar usuarios_tipos_movimento \n" + ex.Message, defaultError);
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
                MySqlCommand cmd = new MySqlCommand("insert into usuarios_tipos_movimento(usuarios_id, tipos_movimento_id) values(@1, @2)", conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Usuarios_id);
                cmd.Parameters.AddWithValue("@2", Tipos_movimento_id);

                cmd.ExecuteNonQuery();

            }catch(MySqlException ex)
            {
                Erro.Show("Erro ao gravar usuarios_tipos_movimento \n" + ex.Message, defaultError);
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
        #endregion
    }
}
