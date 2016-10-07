using GuaraTattooSoft.DBConnection;
using GuaraTattooSoft.Util;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuaraTattooSoft.Entidades
{
    class Campanhas : IClasse_Persistencia
    {
        Conexao conn = new Conexao();
        string defaultError = "Erro em campanhas";

        public List<int> id_todos = new List<int>();
        public List<string> descricao_todos = new List<string>();

        private int id;
        private string descricao;

        #region Propriedades
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                this.id = value;
            }
        }

        public string Descricao
        {
            get
            {
                return descricao;
            }
            set
            {
                this.descricao = value;
            }
        }
        #endregion

        public Campanhas(int id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from campanhas where id = " + id, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    Id = dr.GetInt32(0);
                    Descricao = dr.GetString(1);
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

        public Campanhas(string termo = "")
        {
            termo = "%" + termo + "%";

            try
            {
                MySqlCommand cmd = new MySqlCommand("select * from campanhas where descricao LIKE @1", conn.GetConexao());
                cmd.Parameters.AddWithValue("@1", termo);
                MySqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    while(dr.Read())
                    {
                        id_todos.Add(dr.GetInt32(0));
                        descricao_todos.Add(dr.GetString(1));
                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }

        public Campanhas(bool loadData = false)
        {
            if (!loadData) return;
            try
            {
                MySqlCommand cmd = new MySqlCommand("select * from campanhas", conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_todos.Add(dr.GetInt32(0));
                        descricao_todos.Add(dr.GetString(1));
                    }
                }
                dr.Close();
            }
            catch (Exception ex)
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
            try
            {
                MySqlCommand cmd = new MySqlCommand("update campanhas set descricao = @1 where id = " + id, conn.GetConexao());
                cmd.Parameters.AddWithValue("@1", Descricao);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Erro.Show(ex.Message, defaultError);
            }
            finally
            {
                conn.Fechar();
            }
        }

        public void Deletar(int id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("delete from campanhas where id = " + id, conn.GetConexao());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Erro.Show(ex.Message, defaultError);
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
                MySqlCommand cmd = new MySqlCommand("insert into campanhas(descricao) values (@1)", conn.GetConexao());
                cmd.Parameters.AddWithValue("@1", Descricao);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Erro.Show(ex.Message, defaultError);
            }
            finally
            {
                conn.Fechar();
            }
        }

        public int LastID()
        {
            return 0;
        }
    }
}
