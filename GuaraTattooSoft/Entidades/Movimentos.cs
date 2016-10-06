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
    public class Movimentos : IClasse_Persistencia
    {

        Conexao conn = new Conexao();
        string defaultError = "Erro em movimentos";

        public List<int> id_todos = new List<int>();
        public List<DateTime> data_movimento_todos = new List<DateTime>();
        public List<string> obs_todos = new List<string>();
        public List<int> tipos_movimento_id_todos = new List<int>();
        public List<int> caixas_id_todos = new List<int>();
        public List<int> usuarios_id_todos = new List<int>();
        public List<int> clientes_id_todos = new List<int>();
        public List<int> pagamentos_movimentos_id_todos = new List<int>();

        #region Variaveis
        private DateTime data_movimento;
        private string obs;
        private int tipos_movimento_id;
        private int caixas_id;
        private int usuarios_id;
        private int clientes_id;
        private int pagamentos_movimentos_id;
        #endregion

        #region Proriedades
        public DateTime Data_movimento
        {
            get
            {
                return data_movimento;
            }

            set
            {
                data_movimento = value;
            }
        }

        public string Obs
        {
            get
            {
                return obs;
            }

            set
            {
                obs = value;
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

        public int Pagamentos_movimentos_id
        {
            get
            {
                return pagamentos_movimentos_id;
            }

            set
            {
                pagamentos_movimentos_id = value;
            }
        }
        #endregion

        public Movimentos(bool loadData = false)
        {
            if (loadData == false) return;

            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from movimentos", conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_todos.Add(dr.GetInt32(0));
                        data_movimento_todos.Add(dr.GetDateTime(1));
                        string obs = dr.IsDBNull(2) ? obs = string.Empty : obs = dr.GetString(2);
                        obs_todos.Add(obs);
                        tipos_movimento_id_todos.Add(dr.GetInt32(3));
                        caixas_id_todos.Add(dr.GetInt32(4));
                        usuarios_id_todos.Add(dr.GetInt32(5));
                        clientes_id_todos.Add(dr.GetInt32(6));
                        pagamentos_movimentos_id_todos.Add(dr.GetInt32(7));
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

        public Movimentos(int id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from movimentos where id = " + id, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    Data_movimento = dr.GetDateTime(1);
                    Obs = dr.IsDBNull(2) ? Obs = string.Empty : obs = dr.GetString(2);
                    Tipos_movimento_id = dr.GetInt32(3);
                    Caixas_id = dr.GetInt32(4);
                    Usuarios_id = dr.GetInt32(5);
                    Clientes_id = dr.GetInt32(6);
                    Pagamentos_movimentos_id = dr.GetInt32(7);
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

        #region Persistencia
        public void Gravar()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("insert into movimentos(data_movimento, obs, tipos_movimento_id, caixas_id, usuarios_id, clientes_id, pagamentos_movimentos_id) values(@1, @2, @3, @4, @5, @6, @7)", conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Data_movimento);
                cmd.Parameters.AddWithValue("@2", Obs);
                cmd.Parameters.AddWithValue("@3", Tipos_movimento_id);
                cmd.Parameters.AddWithValue("@4", Caixas_id);
                cmd.Parameters.AddWithValue("@5", Usuarios_id);
                cmd.Parameters.AddWithValue("@6", Clientes_id);
                cmd.Parameters.AddWithValue("@7", Pagamentos_movimentos_id);

                cmd.ExecuteNonQuery();

                // Sucesso.Show("Movimento gravado!");

            }
            catch (MySqlException ex)
            {
                Erro.Show("Erro ao gravar movimento \n" + ex.Message, defaultError);
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
                MySqlCommand cmd = new MySqlCommand("update movimentos set data_movimento = @1, obs = @2, tipos_movimento_id = @3, caixas_id = @4, usuarios_id = @5, clientes_id = @6, pagamentos_movimentos_id = @7 where id = " + id, conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Data_movimento);
                cmd.Parameters.AddWithValue("@2", Obs);
                cmd.Parameters.AddWithValue("@3", Tipos_movimento_id);
                cmd.Parameters.AddWithValue("@4", Caixas_id);
                cmd.Parameters.AddWithValue("@5", Usuarios_id);
                cmd.Parameters.AddWithValue("@6", Clientes_id);
                cmd.Parameters.AddWithValue("@7", Pagamentos_movimentos_id);

                cmd.ExecuteNonQuery();

              //  Sucesso.Show("Movimento atualizado!");

            }
            catch (MySqlException ex)
            {
                Erro.Show("Erro ao atualizar movimento \n" + ex.Message, defaultError);
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
                MySqlCommand cmd = new MySqlCommand("delete from movimentos where id = " + id, conn.GetConexao());
                cmd.ExecuteNonQuery();

              //  Sucesso.Show("Movimento excluido!");

            }
            catch (MySqlException ex)
            {
                Erro.Show("Erro ao deletar movimento \n" + ex.Message, defaultError);
            }
            finally
            {
                conn.Fechar();
            }
        }

        public int LastID()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select max(id) from movimentos", conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    return dr.GetInt32(0);
                }

                dr.Close();

            }
            catch (MySqlException ex)
            {
                Erro.Show("Erro ao recuperar id para movimentos \n" + ex.Message, defaultError);
            }
            finally
            {
                conn.Fechar();
            }

            return 0;
        }

        public void Pesquisar(string field, string searchTerm, int exibicao = 0)
        {
            string sql = "select*from movimentos where " + field + " LIKE '%" + searchTerm + "%'";

            if (exibicao == (int)Exibicao.Mes)
            {
                string dataInicial = "01-";
                dataInicial += DateTime.Now.Month + "-" + DateTime.Now.Year + " 00:00:00";

                string dataFinal = "30-";
                dataFinal += DateTime.Now.Month + "-" + DateTime.Now.Year + " 23:59:59";

                DateTime dtInicial = Convert.ToDateTime(dataInicial);
                dtInicial.ToString("yyyy-MM-dd HH:mm:ss");

                DateTime dtFinal = Convert.ToDateTime(dataFinal);
                dtFinal.ToString("yyyy-MM-dd HH:mm:ss");

                sql += " AND data_movimento > '" + dtInicial.ToString("yyyy-MM-dd HH:mm:ss") + "' AND data_movimento < '" + dtFinal.ToString("yyyy-MM-dd HH:mm:ss") + "'";
            }

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_todos.Add(dr.GetInt32(0));
                        data_movimento_todos.Add(dr.GetDateTime(1));
                        string obs = dr.IsDBNull(2) ? obs = string.Empty : obs = dr.GetString(2);
                        obs_todos.Add(obs);
                        tipos_movimento_id_todos.Add(dr.GetInt32(3));
                        caixas_id_todos.Add(dr.GetInt32(4));
                        usuarios_id_todos.Add(dr.GetInt32(5));
                        clientes_id_todos.Add(dr.GetInt32(6));
                        pagamentos_movimentos_id_todos.Add(dr.GetInt32(7));
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

        public void Filtrar(string dataInicio, string dataFinal)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from movimentos where data_movimento > '" + dataInicio + "' AND data_movimento < '" + dataFinal + "'", conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_todos.Add(dr.GetInt32(0));
                        data_movimento_todos.Add(dr.GetDateTime(1));
                        string obs = dr.IsDBNull(2) ? obs = string.Empty : obs = dr.GetString(2);
                        obs_todos.Add(obs);
                        tipos_movimento_id_todos.Add(dr.GetInt32(3));
                        caixas_id_todos.Add(dr.GetInt32(4));
                        usuarios_id_todos.Add(dr.GetInt32(5));
                        clientes_id_todos.Add(dr.GetInt32(6));
                        pagamentos_movimentos_id_todos.Add(dr.GetInt32(7));
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

        public Movimentos UltimoPorCliente(int id_cliente)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select max(id) from movimentos where clientes_id = " + id_cliente, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                int id = 0;

                if (dr.HasRows)
                {
                   id =  dr.GetInt32(0);
                }

                dr.Close();
                conn.Fechar();
                return new Movimentos(id);
            }
            catch (MySqlException ex)
            {
                conn.Fechar();
                Erro.Show("Erro ao recuperar id para movimentos \n" + ex.Message, defaultError);
            }

            return new Movimentos();
        }
        #endregion

        #region enumn's
        public enum Exibicao
        {
            Mes = 1,
            Semana = 2,
            Ano = 3,
            Todos = 4
        }
        #endregion
    }
}
