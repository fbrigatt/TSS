using GuaraTattooSoft.DBConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using GuaraTattooSoft.Util;

namespace GuaraTattooSoft.Entidades
{
    class Anamneses : IClasse_Persistencia
    {
        Conexao conn = new Conexao();
        string defaultError = "Erro em anamneses";

        public List<int> id_todos = new List<int>();
        public List<string> descricao_todos = new List<string>();

        private string descricao;

        public Anamneses(bool loadData = false)
        {
            if (loadData == false) return;

            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from anamneses", conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_todos.Add(dr.GetInt32(0));
                        string descricao = dr.IsDBNull(1) ? descricao = string.Empty : descricao = dr.GetString(1);
                        descricao_todos.Add(descricao);
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

        public Anamneses(int id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from anamneses where id = " + id, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    Descricao = dr.GetString(1);
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


        #region Persistencia
        public void Atualizar(int id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("update anamneses set descricao = @1 where id = " + id, conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Descricao);

                cmd.ExecuteNonQuery();
            //    Sucesso.Show("Anamnese atualizada!");

            }catch(MySqlException ex)
            {
                Erro.Show("Erro ao atualizar anamnese \n" + ex.Message, defaultError);
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
                MySqlCommand cmd = new MySqlCommand("delete from anamneses where id = " + id, conn.GetConexao());
                cmd.ExecuteNonQuery();

            }catch(MySqlException ex)
            {
                Atencao.Show("Não é possivel excluir esta anamnese. Ela está relacionada a um ou mais clientes \n");
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
                MySqlCommand cmd = new MySqlCommand("insert into anamneses(descricao) values(@1)", conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Descricao);
                cmd.ExecuteNonQuery();

            }catch(MySqlException ex)
            {
                Erro.Show("Erro ao gravar anamnese \n" + ex.Message, defaultError);
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

        public int IdByFieldName(string searchTerm)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select id from anamneses where descricao = '" + searchTerm + "'", conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    return dr.GetInt32(0);
                }

                dr.Close();

            }catch(MySqlException ex)
            {
                Erro.Show("Erro ao recuperar idField para anamneses \n" + ex.Message, defaultError);
            }
            finally
            {
                conn.Fechar();
            }

            return 0;
        }
        #endregion
    }
}
