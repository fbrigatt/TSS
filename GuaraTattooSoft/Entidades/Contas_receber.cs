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
    class Contas_receber
    {
        Conexao conn = new Conexao();
        string defaultError = "Erro em contas_pagar";

        public List<int> id_todos = new List<int>();
        public List<int> movimentos_id_todos = new List<int>();
        public List<int> formas_pagamento_id_todos = new List<int>();
        public List<string> emitente_todos = new List<string>();
        public List<string> destinatario_todos = new List<string>();
        public List<string> descricao_todos = new List<string>();
        public List<decimal> valor_todos = new List<decimal>();
        public List<DateTime> vencimento_todos = new List<DateTime>();
        public List<double> juros_todos = new List<double>();
        public List<bool> pago_todos = new List<bool>();

        private int movimentos_id;
        private int formas_pagamento_id;
        private string emitente;
        private string destinatario;
        private string descricao;
        private decimal valor;
        private DateTime vencimento;
        private double juros;
        private bool pago;

        #region Propriedades
        public int Movimentos_id
        {
            get
            {
                return movimentos_id;
            }

            set
            {
                movimentos_id = value;
            }
        }

        public int Formas_pagamento_id
        {
            get
            {
                return formas_pagamento_id;
            }

            set
            {
                formas_pagamento_id = value;
            }
        }

        public string Emitente
        {
            get
            {
                return emitente;
            }

            set
            {
                emitente = value;
            }
        }

        public string Destinatario
        {
            get
            {
                return destinatario;
            }

            set
            {
                destinatario = value;
            }
        }

        public decimal Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        public double Juros
        {
            get
            {
                return juros;
            }

            set
            {
                juros = value;
            }
        }

        public bool Pago
        {
            get
            {
                return pago;
            }

            set
            {
                pago = value;
            }
        }

        public DateTime Vencimento
        {
            get
            {
                return vencimento;
            }

            set
            {
                vencimento = value;
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
        #endregion

        public enum Filtros
        {
            apenasNaoPagas = 0,
            apenasPagas = 1,
        }

        public Contas_receber(bool loadData = false, int filtro = 5, bool apenasEsteMes = false)
        {
            if (loadData == false) return;

            string sql = "select*from contas_receber";
            if (filtro == (int)Contas_receber.Filtros.apenasNaoPagas) sql += " where pago = false";
            if (filtro == (int)Contas_receber.Filtros.apenasPagas) sql += " where pago = true";
            if (apenasEsteMes) sql += " AND vencimento LIKE '%-" + (DateTime.Now.Month < 10 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString()) + "-%'";

            if (!sql.Contains("where"))
            {
                sql = sql.Replace("AND", "where");
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
                        movimentos_id_todos.Add(dr.GetInt32(1));
                        formas_pagamento_id_todos.Add(dr.GetInt32(2));
                        emitente_todos.Add(dr.GetString(3));
                        destinatario_todos.Add(dr.GetString(4));
                        descricao_todos.Add(dr.GetString(5));
                        valor_todos.Add(dr.GetDecimal(6));
                        vencimento_todos.Add(dr.GetDateTime(7));
                        juros_todos.Add(dr.GetDouble(8));
                        pago_todos.Add(dr.GetBoolean(9));
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

        public Contas_receber(int cod_mov, bool b = false)
        {
            string sql = "select*from contas_receber where movimentos_id = " + cod_mov;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_todos.Add(dr.GetInt32(0));
                        movimentos_id_todos.Add(dr.GetInt32(1));
                        formas_pagamento_id_todos.Add(dr.GetInt32(2));
                        emitente_todos.Add(dr.GetString(3));
                        destinatario_todos.Add(dr.GetString(4));
                        descricao_todos.Add(dr.GetString(5));
                        valor_todos.Add(dr.GetDecimal(6));
                        vencimento_todos.Add(dr.GetDateTime(7));
                        juros_todos.Add(dr.GetDouble(8));
                        pago_todos.Add(dr.GetBoolean(9));
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

        public Contas_receber(int id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from contas_receber where id = " + id, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    Movimentos_id = dr.GetInt32(1);
                    Formas_pagamento_id = dr.GetInt32(2);
                    Emitente = dr.GetString(3);
                    Destinatario = dr.GetString(4);
                    Descricao = dr.GetString(5);
                    Valor = dr.GetDecimal(6);
                    Vencimento = dr.GetDateTime(7);
                    Juros = dr.GetDouble(8);
                    Pago = dr.GetBoolean(9);
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
                MySqlCommand cmd = new MySqlCommand("update contas_receber set movimentos_id = @1, formas_pagamento_id = @2, emitente = @3, destinatario = @4, descricao = @5, valor = @6, vencimento = @7, juros = @8, pago = @9 where id = " + id, conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Movimentos_id);
                cmd.Parameters.AddWithValue("@2", Formas_pagamento_id);
                cmd.Parameters.AddWithValue("@3", Emitente);
                cmd.Parameters.AddWithValue("@4", Destinatario);
                cmd.Parameters.AddWithValue("@5", Descricao);
                cmd.Parameters.AddWithValue("@6", Valor);
                cmd.Parameters.AddWithValue("@7", Vencimento);
                cmd.Parameters.AddWithValue("@8", Juros);
                cmd.Parameters.AddWithValue("@9", Pago);

                cmd.ExecuteNonQuery();

              //  Sucesso.Show("Conta atualizada!");

            }
            catch (MySqlException ex)
            {
                Erro.Show("Erro ao atualiar contas_pagar \n " + ex.Message, defaultError);
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
                MySqlCommand cmd = new MySqlCommand("delete from contas_receber where id = " + id, conn.GetConexao());
                cmd.ExecuteNonQuery();
             //   Sucesso.Show("Conta pagar excluida!");
            }
            catch (MySqlException ex)
            {
                Erro.Show("Erro ao deletar conta \nEla está relacionada com um ou mais movimentos e/ou formas de pagamento. \n" + ex.Message, defaultError);
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
                MySqlCommand cmd = new MySqlCommand("insert into contas_receber(movimentos_id, formas_pagamento_id, emitente, destinatario, descricao, valor, vencimento, juros, pago) values(@1, @2, @3, @4, @5, @6, @7, @8, @9)", conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Movimentos_id);
                cmd.Parameters.AddWithValue("@2", Formas_pagamento_id);
                cmd.Parameters.AddWithValue("@3", Emitente);
                cmd.Parameters.AddWithValue("@4", Destinatario);
                cmd.Parameters.AddWithValue("@5", Descricao);
                cmd.Parameters.AddWithValue("@6", Valor);
                cmd.Parameters.AddWithValue("@7", Vencimento);
                cmd.Parameters.AddWithValue("@8", Juros);
                cmd.Parameters.AddWithValue("@9", Pago);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Erro.Show("Erro ao gravar contas_receber \n" + ex.Message, defaultError);
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

        public void Pesquisar(string field, string searchTerm, int filtro = 5, bool apenasEsteMes = false)
        {

            string sql = "select*from contas_receber where " + field + " LIKE '%" + searchTerm + "%'";
            if (filtro == (int)Contas_receber.Filtros.apenasNaoPagas) sql += " AND pago = false";
            if (filtro == (int)Contas_receber.Filtros.apenasPagas) sql += " AND pago = true";
            if (apenasEsteMes) sql += " AND vencimento LIKE '%-" + (DateTime.Now.Month < 10 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString()) + "-%'";

            if (!sql.Contains("where"))
            {
                sql = sql.Replace("AND", "where");
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
                        movimentos_id_todos.Add(dr.GetInt32(1));
                        formas_pagamento_id_todos.Add(dr.GetInt32(2));
                        emitente_todos.Add(dr.GetString(3));
                        destinatario_todos.Add(dr.GetString(4));
                        descricao_todos.Add(dr.GetString(5));
                        valor_todos.Add(dr.GetDecimal(6));
                        vencimento_todos.Add(dr.GetDateTime(7));
                        juros_todos.Add(dr.GetDouble(8));
                        pago_todos.Add(dr.GetBoolean(9));
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
