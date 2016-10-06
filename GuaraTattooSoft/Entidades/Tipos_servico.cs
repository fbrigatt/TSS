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
    class Tipos_servico : IClasse_Persistencia
    {
        Conexao conn = new Conexao();
        string defaultError = "Erro em tipos_servico";

        public List<int> id_todos = new List<int>();
        public List<string> descricao_todos = new List<string>();
        public List<bool> ativo_todos = new List<bool>();

        private string descricao;
        private bool ativo;

        #region Propriedades
        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

        public bool Ativo
        {
            get
            {
                return ativo;
            }

            set
            {
                ativo = value;
            }
        }
        #endregion

        public Tipos_servico(bool loadData = false)
        {
            if (loadData == false) return;
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from tipos_servico", conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_todos.Add(dr.GetInt32(0));
                        descricao_todos.Add(dr.GetString(1));
                        ativo_todos.Add(dr.GetBoolean(2));
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

        public Tipos_servico(int id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from tipos_servico where id = " + id, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    Descricao = dr.GetString(1);
                    Ativo = dr.GetBoolean(2);
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
        public void Atualizar(int id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("update tipos_servico set descricao = @1, ativo = @2 where id = " + id, conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Descricao);
                cmd.Parameters.AddWithValue("@2", Ativo);

                cmd.ExecuteNonQuery();

              //  Sucesso.Show("Tipo de serviço atualizado!");

            }catch(MySqlException ex)
            {
                Erro.Show("Erro ao atualizar tipos_servico \n" + ex.Message, defaultError);
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
                MySqlCommand cmd = new MySqlCommand("delete from tipos_servico where id = " + id, conn.GetConexao());
                cmd.ExecuteNonQuery();
            //    Sucesso.Show("Tipo de serviço excluido!");
            }catch(MySqlException ex)
            {
                Erro.Show("Não é possivel deletar este Tipo de serviço. \nO mesmo está relacionado a um ou mais serviços e/ou movimentos. \n" + ex.Message, defaultError);
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
                MySqlCommand cmd = new MySqlCommand("insert into tipos_servico(descricao, ativo) values(@1,@2)", conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Descricao);
                cmd.Parameters.AddWithValue("@2", Ativo);

                cmd.ExecuteNonQuery();


            }
            catch(MySqlException ex)
            {
                Erro.Show("Erro ao gravar tipo de serviço\n" + ex.Message, defaultError);
            }
            finally
            {
                conn.Fechar();
            }
        }

        public void Pesquisar(string field, string searchTerm)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from tipos_servico where " + field + " LIKE '%" + searchTerm + "%'", conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_todos.Add(dr.GetInt32(0));
                        descricao_todos.Add(dr.GetString(1));
                        ativo_todos.Add(dr.GetBoolean(2));
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

        public int LastID()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
