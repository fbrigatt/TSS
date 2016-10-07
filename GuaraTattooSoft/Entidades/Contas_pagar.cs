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
    class Contas_pagar : IClasse_Persistencia
    {
        Conexao conn = new Conexao();
        string defaultError = "Erro em contas_pagar";

        public List<int> id_todos = new List<int>();
        public List<int> movimentos_id_todos = new List<int>();
        public List<string> parcelas_todos = new List<string>();
        public List<int> formas_pagamento_id_todos = new List<int>();
        public List<string> emitente_todos = new List<string>();
        public List<string> destinatario_todos = new List<string>();
        public List<string> descricao_todos = new List<string>();
        public List<decimal> valor_todos = new List<decimal>();
        public List<DateTime> vencimento_todos = new List<DateTime>();
        public List<double> juros_todos = new List<double>();
        public List<bool> pago_todos = new List<bool>();

        private int movimentos_id;
        private string parcela;
        private int formas_pagamento_id;
        private string emitente;
        private string destinatario;
        private string descricao;
        private decimal valor;
        private DateTime vencimento;
        private double juros;
        private bool pago;

        #region Propriedades
        public string Parcela { get; set; }

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

        public Contas_pagar()
        {

        }

        public Contas_pagar(bool apenasEsteMes, bool loadData = false, int filtro = 5)
        {
            if (loadData == false) return;

            string sql = "select*from contas_pagar";
            if (filtro == (int)Contas_pagar.Filtros.apenasNaoPagas) sql += " where pago = false";
            if (filtro == (int)Contas_pagar.Filtros.apenasPagas) sql += " where pago = true";
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
                        parcelas_todos.Add(dr.GetString(2));
                        formas_pagamento_id_todos.Add(dr.GetInt32(3));
                        emitente_todos.Add(dr.GetString(4));
                        destinatario_todos.Add(dr.GetString(5));
                        descricao_todos.Add(dr.GetString(6));
                        valor_todos.Add(dr.GetDecimal(7));
                        vencimento_todos.Add(dr.GetDateTime(8));
                        juros_todos.Add(dr.GetDouble(9));
                        pago_todos.Add(dr.GetBoolean(10));
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

        public Contas_pagar(int cod_mov, bool b = false)
        {
            string sql = "select*from contas_pagar where movimentos_id = " + cod_mov;

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
                        parcelas_todos.Add(dr.GetString(2));
                        formas_pagamento_id_todos.Add(dr.GetInt32(3));
                        emitente_todos.Add(dr.GetString(4));
                        destinatario_todos.Add(dr.GetString(5));
                        descricao_todos.Add(dr.GetString(6));
                        valor_todos.Add(dr.GetDecimal(7));
                        vencimento_todos.Add(dr.GetDateTime(8));
                        juros_todos.Add(dr.GetDouble(9));
                        pago_todos.Add(dr.GetBoolean(10));
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

        public Contas_pagar(int id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from contas_pagar where id = " + id, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    Movimentos_id = dr.GetInt32(1);
                    Parcela = dr.GetString(2);
                    Formas_pagamento_id = dr.GetInt32(3);
                    Emitente = dr.GetString(4);
                    Destinatario = dr.GetString(5);
                    Descricao = dr.GetString(6);
                    Valor = dr.GetDecimal(7);
                    Vencimento = dr.GetDateTime(8);
                    Juros = dr.GetDouble(9);
                    Pago = dr.GetBoolean(10);
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
                MySqlCommand cmd = new MySqlCommand(@"update contas_pagar set 
                                                        movimentos_id = @1, 
                                                        formas_pagamento_id = @2,
                                                        parcela = @3, 
                                                        emitente = @4, 
                                                        destinatario = @5,
                                                        descricao = @6,
                                                        valor = @7,
                                                        vencimento = @8,
                                                        juros = @9,
                                                        pago = @10 where id = " + id, conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Movimentos_id);
                cmd.Parameters.AddWithValue("@2", Formas_pagamento_id);
                cmd.Parameters.AddWithValue("@3", Parcela);
                cmd.Parameters.AddWithValue("@4", Emitente);
                cmd.Parameters.AddWithValue("@5", Destinatario);
                cmd.Parameters.AddWithValue("@6", Descricao);
                cmd.Parameters.AddWithValue("@7", Valor);
                cmd.Parameters.AddWithValue("@8", Vencimento);
                cmd.Parameters.AddWithValue("@9", Juros);
                cmd.Parameters.AddWithValue("@10", Pago);

                cmd.ExecuteNonQuery();

              //  Sucesso.Show("Conta atualizada!");

            } catch(MySqlException ex)
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
                MySqlCommand cmd = new MySqlCommand("delete from contas_pagar where id = " + id, conn.GetConexao());
                cmd.ExecuteNonQuery();
                //Sucesso.Show("Conta pagar excluida!");
            }catch(MySqlException ex)
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
                MySqlCommand cmd = new MySqlCommand(@"insert into contas_pagar
                    (movimentos_id, parcela, formas_pagamento_id, emitente, destinatario, descricao, valor, vencimento, juros, pago)
                    values(@1, @2, @3, @4, @5, @6, @7, @8, @9, @10)", conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Movimentos_id);
                cmd.Parameters.AddWithValue("@2", Parcela);
                cmd.Parameters.AddWithValue("@3", Formas_pagamento_id);
                cmd.Parameters.AddWithValue("@4", Emitente);
                cmd.Parameters.AddWithValue("@5", Destinatario);
                cmd.Parameters.AddWithValue("@6", Descricao);
                cmd.Parameters.AddWithValue("@7", Valor);
                cmd.Parameters.AddWithValue("@8", Vencimento);
                cmd.Parameters.AddWithValue("@9", Juros);
                cmd.Parameters.AddWithValue("@10", Pago);

                cmd.ExecuteNonQuery();

            } catch(MySqlException ex)
            {
                Erro.Show("Erro ao gravar contas_pagar \n" + ex.Message, defaultError);
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

            string sql = "select*from contas_pagar";
            if (filtro == (int)Contas_pagar.Filtros.apenasNaoPagas) sql += " where pago = false";
            if (filtro == (int)Contas_pagar.Filtros.apenasPagas) sql += " where pago = true";
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
                        parcelas_todos.Add(dr.GetString(2));
                        formas_pagamento_id_todos.Add(dr.GetInt32(3));
                        emitente_todos.Add(dr.GetString(4));
                        destinatario_todos.Add(dr.GetString(5));
                        descricao_todos.Add(dr.GetString(6));
                        valor_todos.Add(dr.GetDecimal(7));
                        vencimento_todos.Add(dr.GetDateTime(8));
                        juros_todos.Add(dr.GetDouble(9));
                        pago_todos.Add(dr.GetBoolean(10));
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
