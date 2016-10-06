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
    class Status_caixa
    {
        Conexao conn = new Conexao();
        string defaultError = "Erro em status_caixa";

        public List<int> id_todos = new List<int>();
        public List<int> caixas_id_todos = new List<int>();
        public List<DateTime?> data_abertura_todos = new List<DateTime?>();
        public List<DateTime?> data_fechamento_todos = new List<DateTime?>();

        int caixas_id;
        DateTime? data_abertura;
        DateTime? data_fechamento;

        #region Propriedades
        public int Caixas_id
        {
            get
            {
                return caixas_id;
            }

            set
            {
                caixas_id = value;
            }
        }

        public DateTime? Data_abertura
        {
            get
            {
                return data_abertura;
            }

            set
            {
                data_abertura = value;
            }
        }

        public DateTime? Data_fechamento
        {
            get
            {
                return data_fechamento;
            }

            set
            {
                data_fechamento = value;
            }
        }
        #endregion

        public Status_caixa(bool loadData = false)
        {
            if (loadData == false) return;
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from status_caixa", conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_todos.Add(dr.GetInt32(0));
                        caixas_id_todos.Add(dr.GetInt32(1));

                        DateTime? dtAbertura = dr.IsDBNull(2) ? dtAbertura = null : dtAbertura = dr.GetDateTime(2);
                        DateTime? dtFechamento = dr.IsDBNull(3) ? dtFechamento = null : dtFechamento = dr.GetDateTime(3);

                        data_abertura_todos.Add(dtAbertura);
                        data_fechamento_todos.Add(dtFechamento);
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

        public Status_caixa(int id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from status_caixa where id = " + id, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    Caixas_id = dr.GetInt32(1);
                    Data_abertura = dr.IsDBNull(2) ? Data_abertura = null : dr.GetDateTime(2);
                    Data_fechamento = dr.IsDBNull(3) ? Data_fechamento = null : dr.GetDateTime(3);
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
                MySqlCommand cmd = new MySqlCommand("update status_caixa set data_abertura = @1, data_fechamento = @2 where id = " + id, conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Data_abertura);
                cmd.Parameters.AddWithValue("@2", Data_fechamento);

                cmd.ExecuteNonQuery();

            }catch(MySqlException ex)
            {
                Erro.Show("Erro ao atualizar Status_caixa \n" + ex.Message, defaultError);
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
                MySqlCommand cmd = new MySqlCommand("delete from status_caixa where id = " + id, conn.GetConexao());
                cmd.ExecuteNonQuery();
            }catch(MySqlException ex)
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
                MySqlCommand cmd = new MySqlCommand("insert into status_caixa(caixas_id, data_abertura, data_fechamento) values(@1, @2, @3)", conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Caixas_id);
                cmd.Parameters.AddWithValue("@2", Data_abertura);
                cmd.Parameters.AddWithValue("@3", Data_fechamento);

                cmd.ExecuteNonQuery();

            }
            catch(MySqlException ex)
            {
                Erro.Show("Erro ao gravar status_caixa \n" + ex.Message, defaultError);
            }
            finally
            {
                conn.Fechar();
            }
        }

        public int LastID(int id_caixa)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select max(id) from status_caixa where caixas_id = " + id_caixa, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    return dr.GetInt32(0);
                }

                dr.Close();

            }catch(MySqlException ex)
            {
                Erro.Show("Erro ao recuperar id para status_caixa \n" + ex.Message, defaultError);
            }
            finally
            {
                conn.Fechar();
            }

            return 0;
        }
    }
    #endregion
}
