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
    class Agenda
    {

        Conexao conn = new Conexao();
        string defaultError = "Erro em agenda";

        public List<int> id_todos = new List<int>();
        public List<DateTime?> data_todos = new List<DateTime?>();
        public List<int> clientes_id_todos = new List<int>();
        public List<int> profissionais_id_todos = new List<int>();
        public List<int> tipos_servicos_id_todos = new List<int>();

        private DateTime? data;
        private int clientes_id;
        private int profissionais_id;
        private int tipos_servico_id;

        #region Propriedades
        public DateTime? Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
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

        public int Profissionais_id
        {
            get
            {
                return profissionais_id;
            }

            set
            {
                profissionais_id = value;
            }
        }

        public int Tipos_servico_id
        {
            get
            {
                return tipos_servico_id;
            }

            set
            {
                tipos_servico_id = value;
            }
        }
        #endregion

        public Agenda(bool loadData = false)
        {
            if (loadData == false) return;

            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from agenda", conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_todos.Add(dr.GetInt32(0));
                        DateTime? dataComp = dr.IsDBNull(1) ? dataComp = null : dataComp = dr.GetDateTime(1);
                        data_todos.Add(dataComp);
                        clientes_id_todos.Add(dr.GetInt32(2));
                        profissionais_id_todos.Add(dr.GetInt32(3));
                        tipos_servicos_id_todos.Add(dr.GetInt32(4));
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

        public Agenda(int id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from agenda where id = " + id, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    DateTime? dataComp = dr.IsDBNull(1) ? dataComp = null : dataComp = dr.GetDateTime(1);
                    Data = dataComp;
                    Clientes_id = dr.GetInt32(2);
                    Profissionais_id = dr.GetInt32(3);
                    Tipos_servico_id = dr.GetInt32(4);
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
            if (Clientes_id == 0 || Profissionais_id == 0 || Tipos_servico_id == 0) return;
            try
            {
                MySqlCommand cmd = new MySqlCommand("update agenda set data = @1, clientes_id = @2, profissionais_id = @3, tipos_servico_id = @4 where id = " + id, conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Data);
                cmd.Parameters.AddWithValue("@2", Clientes_id);
                cmd.Parameters.AddWithValue("@3", Profissionais_id);
                cmd.Parameters.AddWithValue("@4", Tipos_servico_id);

                cmd.ExecuteNonQuery();

              //  Sucesso.Show("Agenda atualizada!");

            }
            catch (MySqlException ex)
            {
                Erro.Show("Erro ao atualizar agenda \n" + ex.Message, defaultError);
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
                MySqlCommand cmd = new MySqlCommand("delete from agenda where id = " + id, conn.GetConexao());

                cmd.ExecuteNonQuery();

               // Sucesso.Show("Agendamento excluido!");

            }
            catch (MySqlException ex)
            {
                Erro.Show("Erro ao deletar agendamento \n" + ex.Message, defaultError);
            }
            finally
            {
                conn.Fechar();
            }
        }

        public void Gravar()
        {

            if (Clientes_id == 0 || Profissionais_id == 0 || Tipos_servico_id == 0) return;

            try
            {
                MySqlCommand cmd = new MySqlCommand("insert into agenda(data, clientes_id, profissionais_id, tipos_servico_id) values(@1, @2, @3, @4)", conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Data);
                cmd.Parameters.AddWithValue("@2", Clientes_id);
                cmd.Parameters.AddWithValue("@3", Profissionais_id);
                cmd.Parameters.AddWithValue("@4", Tipos_servico_id);

                cmd.ExecuteNonQuery();

             //   Sucesso.Show("Agendamento criado!");

            }
            catch (MySqlException ex)
            {
                Erro.Show("Erro ao criar agendamento \n" + ex.Message, defaultError);
            }
            finally
            {
                conn.Fechar();
            }
        }

        public int NumeroCompromissosProfissional(int profissionais_id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select count(id) from agenda where profissionais_id = " + profissionais_id, conn.GetConexao());
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
                Erro.Show(ex.Message, defaultError);
            }
            finally
            {
                conn.Fechar();
            }
            return 0;
        }

        public void CompromissosProfissional(int profissionais_id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from agenda where profissionais_id  = " + profissionais_id, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_todos.Add(dr.GetInt32(0));

                        DateTime? dataComp = dr.IsDBNull(1) ? dataComp = null : dataComp = dr.GetDateTime(1);
                        data_todos.Add(dataComp);

                        clientes_id_todos.Add(dr.GetInt32(2));
                        profissionais_id_todos.Add(dr.GetInt32(3));
                        tipos_servicos_id_todos.Add(dr.GetInt32(4));
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

        public bool ClienteJaAgendado(int clientes_id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select clientes_id from agenda where clientes_id = " + clientes_id, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    if (dr.GetInt32(0) == clientes_id) return true;
                }

                dr.Close();

            }catch(MySqlException ex)
            {
                Erro.Show("Erro ao verificar agenda do cliente \n" + ex.Message, defaultError);
            }
            finally
            {
                conn.Fechar();
            }

            return false;
        }

        public int IdByCliente(int clientes_id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select id from agenda where clientes_id = " + clientes_id, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    return dr.GetInt32(0);
                }

                dr.Close();

            }catch(MySqlException ex)
            {
                Erro.Show(ex.Message, "Agenda - Erro ao recuperar id apartir do cliente");
            }
            finally
            {
                conn.Fechar();
            }

            return 0;
        }

        public int LastID()
        {
            throw new NotImplementedException();
        }

        public List<KeyValueTriple<int, string, int>> GetListaProfissionais()
        {

            List<KeyValueTriple<int, string, int>> listaProfissionais = new List<KeyValueTriple<int, string, int>>();

            Profissionais profissionais = new Profissionais(true);

            Agenda agenda = new Agenda();

            for (int i = 0; i < profissionais.id_todos.Count; i++)
            {
                int numCompromissos = agenda.NumeroCompromissosProfissional(profissionais.id_todos[i]);

                listaProfissionais.Add(new KeyValueTriple<int, string, int>(profissionais.id_todos[i], profissionais.nome_todos[i], numCompromissos));
            }

            return listaProfissionais;
        }
        
        #endregion
    }
}
