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
    public class Servicos : IClasse_Persistencia
    {
        Conexao conn = new Conexao();
        string defaultError = "Erro em servicos";

        public List<int> id_todos = new List<int>();
        public List<DateTime> data_servico_todos = new List<DateTime>();
        public List<int> estilo_id_todos = new List<int>();
        public List<string> servico_realizado_todos = new List<string>();
        public List<decimal> valor_servico_todos = new List<decimal>();
        public List<decimal> valor_total_todos = new List<decimal>();
        public List<int> tipos_servico_id_todos = new List<int>();
        public List<int> clientes_id_todos = new List<int>();
        public List<int> profissionais_id_todos = new List<int>();
        public List<int> usuarios_id_todos = new List<int>();

        private DateTime data_servico;
        private int estilo_id;
        private string servico_realizado;
        private decimal valor_servico;
        private decimal valor_total;
        private int tipos_servico_id;
        private int clientes_id;
        private int profissionais_id;
        private int usuarios_id;

        #region Propriedades
        public int Estilo_id
        {
            get
            {
                return this.estilo_id;
            }
            set
            {
                this.estilo_id = value;
            }
        }
        public string Servico_realizado
        {
            get
            {
                return servico_realizado;
            }

            set
            {
                servico_realizado = value;
            }
        }

        public decimal Valor_servico
        {
            get
            {
                return valor_servico;
            }

            set
            {
                valor_servico = value;
            }
        }

        public decimal Valor_total
        {
            get
            {
                return valor_total;
            }

            set
            {
                valor_total = value;
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

        public DateTime Data_servico
        {
            get
            {
                return data_servico;
            }

            set
            {
                data_servico = value;
            }
        }
        #endregion

        public Servicos(bool loadData = false)
        {
            if (loadData == false) return;
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from servicos", conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_todos.Add(dr.GetInt32(0));
                        data_servico_todos.Add(dr.GetDateTime(1));
                        estilo_id_todos.Add(dr.GetInt32(2));
                        servico_realizado_todos.Add(dr.GetString(3));
                        valor_servico_todos.Add(dr.GetDecimal(4));
                        valor_total_todos.Add(dr.GetDecimal(5));
                        tipos_servico_id_todos.Add(dr.GetInt32(6));
                        clientes_id_todos.Add(dr.GetInt32(7));
                        profissionais_id_todos.Add(dr.GetInt32(8));
                        usuarios_id_todos.Add(dr.GetInt32(9));
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

        public Servicos(int id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from servicos where id = " + id, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    Data_servico = dr.GetDateTime(1);
                    Estilo_id = dr.GetInt32(2);
                    Servico_realizado = dr.GetString(3);
                    Valor_servico = dr.GetDecimal(4);
                    Valor_total = dr.GetDecimal(5);
                    Tipos_servico_id = dr.GetInt32(6);
                    Clientes_id = dr.GetInt32(7);
                    Profissionais_id = dr.GetInt32(8);
                    Usuarios_id = dr.GetInt32(9);
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

            }
            catch (MySqlException ex)
            {

            }
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public void Gravar()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("insert into servicos(data_servico, estilo_id, servico_realizado, valor_servico, valor_total, tipos_servico_id, clientes_id, profissionais_id, usuarios_id) values(@1, @2, @3, @4, @5, @6, @7, @8)", conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Data_servico);
                cmd.Parameters.AddWithValue("@2", Estilo_id);
                cmd.Parameters.AddWithValue("@3", Servico_realizado);
                cmd.Parameters.AddWithValue("@4", Valor_servico);
                cmd.Parameters.AddWithValue("@5", Valor_total);
                cmd.Parameters.AddWithValue("@6", Tipos_servico_id);
                cmd.Parameters.AddWithValue("@7", Clientes_id);
                cmd.Parameters.AddWithValue("@8", Profissionais_id);
                cmd.Parameters.AddWithValue("@9", Usuarios_id);

                cmd.ExecuteNonQuery();

                //  Sucesso.Show("Serviço gravado!");

            }
            catch (MySqlException ex)
            {
                Erro.Show("Erro ao gravar servico \n" + ex.Message, defaultError);
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
                MySqlCommand cmd = new MySqlCommand("select max(id) from servicos", conn.GetConexao());
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
                Erro.Show("Erro ao recuperar id para servicos \n" + ex.Message, defaultError);
            }
            finally
            {
                conn.Fechar();
            }

            return 0;
        }

        public void ApenasProfissional(int id, DateTime data_inicio, DateTime data_fim, bool distinct_clientes = false)
        {
            try
            {
                data_inicio = Convert.ToDateTime(data_inicio.ToShortDateString());
                data_fim = Convert.ToDateTime(data_fim.ToShortDateString());
                data_fim = data_fim.AddHours(23);
                data_fim = data_fim.AddMinutes(59);

                string sql = "select * from servicos where profissionais_id = " + id + " AND data_servico BETWEEN '" + data_inicio.ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + data_fim.ToString("yyyy-MM-dd HH:mm:ss") + "'";
                if (distinct_clientes) sql += "group by clientes_id";

                MySqlCommand cmd = new MySqlCommand(sql, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_todos.Add(dr.GetInt32(0));
                        data_servico_todos.Add(dr.GetDateTime(1));
                        estilo_id_todos.Add(dr.GetInt32(2));
                        servico_realizado_todos.Add(dr.GetString(3));
                        valor_servico_todos.Add(dr.GetDecimal(4));
                        valor_total_todos.Add(dr.GetDecimal(5));
                        tipos_servico_id_todos.Add(dr.GetInt32(6));
                        clientes_id_todos.Add(dr.GetInt32(7));
                        profissionais_id_todos.Add(dr.GetInt32(8));
                        usuarios_id_todos.Add(dr.GetInt32(9));
                    }
                }

                dr.Close();
            }
            catch (Exception ex)
            {

            }
        }

        public void ApenasProfissional(int profissionaisId, bool exibicaoMes = true)
        {
            string sql = "select*from servicos where profissionais_id = " + profissionaisId;

            if (exibicaoMes)
            {
                string dataInicial = "01-";
                dataInicial += (DateTime.Now.Month < 10 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString()) + "-" + DateTime.Now.Year + " 00:00:00";

                string dataFinal = "30-";
                dataFinal += (DateTime.Now.Month < 10 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString()) + "-" + DateTime.Now.Year + " 00:00:00";

                DateTime dtInicial = Convert.ToDateTime(dataInicial);
                dtInicial.ToString("yyyy-MM-dd HH:mm:ss");

                DateTime dtFinal = Convert.ToDateTime(dataFinal);
                dtFinal.ToString("yyyy-MM-dd HH:mm:ss");

                sql += " AND data_servico > '" + dtInicial.ToString("yyyy-MM-dd HH:mm:ss") + "' AND data_servico < '" + dtFinal.ToString("yyyy-MM-dd HH:mm:ss") + "'";
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
                        data_servico_todos.Add(dr.GetDateTime(1));
                        estilo_id_todos.Add(dr.GetInt32(2));
                        servico_realizado_todos.Add(dr.GetString(3));
                        valor_servico_todos.Add(dr.GetDecimal(4));
                        valor_total_todos.Add(dr.GetDecimal(5));
                        tipos_servico_id_todos.Add(dr.GetInt32(6));
                        clientes_id_todos.Add(dr.GetInt32(7));
                        profissionais_id_todos.Add(dr.GetInt32(8));
                        usuarios_id_todos.Add(dr.GetInt32(9));
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

        public void ApenasCliente(int clientes_id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from servicos where clientes_id = " + clientes_id, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_todos.Add(dr.GetInt32(0));
                        data_servico_todos.Add(dr.GetDateTime(1));
                        estilo_id_todos.Add(dr.GetInt32(2));
                        servico_realizado_todos.Add(dr.GetString(3));
                        valor_servico_todos.Add(dr.GetDecimal(4));
                        valor_total_todos.Add(dr.GetDecimal(5));
                        tipos_servico_id_todos.Add(dr.GetInt32(6));
                        clientes_id_todos.Add(dr.GetInt32(7));
                        profissionais_id_todos.Add(dr.GetInt32(8));
                        usuarios_id_todos.Add(dr.GetInt32(9));
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

        #region emuns
        public enum Exibicao
        {
            Mes = 0
        }
        #endregion
    }
}
