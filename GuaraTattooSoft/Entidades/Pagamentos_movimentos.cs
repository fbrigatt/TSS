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
    class Pagamentos_movimentos : IClasse_Persistencia
    {
        Conexao conn = new Conexao();
        string defaultError = "Erro em pagamentos_movimentos";

        public List<int> id_todos = new List<int>();
        public List<decimal> valor_todos = new List<decimal>();
        public List<double> desconto_todos = new List<double>();
        public List<int> formas_pagamento_id_todos = new List<int>();

        private decimal valor;
        private double desconto;
        private int formas_pagamento_id;

        #region Propriedades
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

        public double Desconto
        {
            get
            {
                return desconto;
            }

            set
            {
                desconto = value;
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
        #endregion

        public Pagamentos_movimentos(bool loadData = false)
        {
            if (loadData == false) return;
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from pagamentos_movimentos", conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_todos.Add(dr.GetInt32(0));
                        valor_todos.Add(dr.GetDecimal(1));
                        desconto_todos.Add(dr.GetDouble(2));
                        formas_pagamento_id_todos.Add(dr.GetInt32(3));
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

        public Pagamentos_movimentos(int id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from pagamentos_movimentos where id = " + id, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    Valor = dr.GetDecimal(1);
                    Desconto = dr.GetDouble(2);
                    Formas_pagamento_id = dr.GetInt32(3);
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
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("delete from pagamentos_movimentos where id = " + id, conn.GetConexao());
                cmd.ExecuteNonQuery();

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

        public void Gravar()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("insert into pagamentos_movimentos(valor, desconto, formas_pagamento_id) values(@1, @2, @3)", conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Valor);
                cmd.Parameters.AddWithValue("@2", Desconto);
                cmd.Parameters.AddWithValue("@3", Formas_pagamento_id);

                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                Erro.Show("Erro ao gravar pagamentos_movimentos \n" + ex.Message, defaultError);
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
                MySqlCommand cmd = new MySqlCommand("select max(id) from pagamentos_movimentos", conn.GetConexao());
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
                Erro.Show("Erro ao recuperar id para pagamentos_movimentos \n" + ex.Message, defaultError);
            }
            finally
            {
                conn.Fechar();
            }

            return 1;
        }
        #endregion
    }
}
