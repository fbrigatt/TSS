using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuaraTattooSoft.Util;
using MySql.Data.MySqlClient;
using GuaraTattooSoft.DBConnection;

namespace GuaraTattooSoft.Entidades
{
    class Caixas : IClasse_Persistencia
    {
        Conexao conn = new Conexao();
        string defaultError = "Erro em caixas";

        public List<int> id_todos = new List<int>();
        public List<string> nome_todos = new List<string>();
        public List<string> nome_micro_todos = new List<string>();
        public List<bool> notificar_usuario_fechamento_todos = new List<bool>();
        public List<string> hora_fechamento_todos = new List<string>();

        int id;
        string nome;
        string nome_micro;
        bool notificar_usuario_fechamento;
        string hora_fechamento;

        #region Propriedades
        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Nome_micro
        {
            get
            {
                return nome_micro;
            }

            set
            {
                nome_micro = value;
            }
        }

        public bool Notificar_usuario_fechamento
        {
            get
            {
                return notificar_usuario_fechamento;
            }

            set
            {
                notificar_usuario_fechamento = value;
            }
        }

        public string Hora_fechamento
        {
            get
            {
                return hora_fechamento;
            }

            set
            {
                hora_fechamento = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        #endregion

        public Caixas(bool loadData = false)
        {
            if (loadData == false) return;
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from caixas", conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Id = dr.GetInt32(0);
                        id_todos.Add(dr.GetInt32(0));
                        nome_todos.Add(dr.GetString(1));
                        nome_micro_todos.Add(dr.GetString(2));
                        notificar_usuario_fechamento_todos.Add(dr.GetBoolean(3));
                        hora_fechamento_todos.Add(dr.GetString(4));
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

        public Caixas(int id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from caixas where id = " + id, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    Id = dr.GetInt32(0);
                    Nome = dr.GetString(1);
                    Nome_micro = dr.GetString(2);
                    Notificar_usuario_fechamento = dr.GetBoolean(3);
                    Hora_fechamento = dr.GetString(4);
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
        public void Atualizar(int id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("update caixas set nome = @1, nome_micro = @2, notificar_usuario_fechamento = @3, hora_fechamento = @4 where id = " + id, conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Nome);
                cmd.Parameters.AddWithValue("@2", Nome_micro);
                cmd.Parameters.AddWithValue("@3", Notificar_usuario_fechamento);
                cmd.Parameters.AddWithValue("@4", Hora_fechamento);

                cmd.ExecuteNonQuery();
              //  Sucesso.Show("Caixa Atualizado!");

            }
            catch (MySqlException ex)
            {
                Erro.Show("Erro ao atualizar caixas \n " + ex.Message, defaultError);
            }
            finally
            {
                conn.Fechar();
            }
        }

        public bool Aberto()
        {
            int idStatus_caixa = new Status_caixa().LastID(this.Id);
            Status_caixa sc = new Status_caixa(idStatus_caixa);
            if (sc.Data_fechamento == null)
            {
                return true;
            }
            return false;
        }
        public void Deletar(int id)
        {
            MySqlConnection conn = new Conexao().GetConexao();
            MySqlTransaction transaction = conn.BeginTransaction();

            try
            {

                MySqlCommand cmdSC = new MySqlCommand("delete from status_caixa where caixas_id = " + id, conn);
                cmdSC.ExecuteNonQuery();

                MySqlCommand cmdC = new MySqlCommand("delete from caixas where id = " + id, conn);
                cmdC.ExecuteNonQuery();

                transaction.Commit();

             //   Sucesso.Show("Caixa excluido!");


            }
            catch (MySqlException ex)
            {
                transaction.Rollback();
                Atencao.Show("Não é possível excluir este caixa");
            }
            finally
            {
                transaction.Dispose();
                conn.Close();
            }
        }

        public void Gravar()
        {
            try
            {

                MySqlCommand cmd = new MySqlCommand("insert into caixas(nome, nome_micro, notificar_usuario_fechamento, hora_fechamento) values(@1, @2, @3, @4)", conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Nome);
                cmd.Parameters.AddWithValue("@2", Nome_micro);
                cmd.Parameters.AddWithValue("@3", Notificar_usuario_fechamento);
                cmd.Parameters.AddWithValue("@4", Hora_fechamento);

                cmd.ExecuteNonQuery();
            //    Sucesso.Show("Caixa gravado!");

            }
            catch (MySqlException ex)
            {
                Erro.Show("Erro ao gravar caixa \n" + ex.Message, defaultError);
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
                MySqlCommand cmd = new MySqlCommand("select max(id) from caixas", conn.GetConexao());
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
                Erro.Show("Erro ao recuperar id para caixas \n" + ex.Message, defaultError);
            }
            finally
            {
                conn.Fechar();
            }

            return 0;
        }

        public void Pesquisar(string nomeCaixa)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from caixas where nome LIKE '%" + nomeCaixa + "%'", conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_todos.Add(dr.GetInt32(0));
                        nome_todos.Add(dr.GetString(1));
                        nome_micro_todos.Add(dr.GetString(2));
                        notificar_usuario_fechamento_todos.Add(dr.GetBoolean(3));
                        hora_fechamento_todos.Add(dr.GetString(4));
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
        #endregion
    }
}
