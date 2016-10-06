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
    class Operadoras_cartao : IClasse_Persistencia
    {
        Conexao conn = new Conexao();
        string defaultError = "Erro em operadoras_cartao";

        public List<int> id_todos = new List<int>();
        public List<string> descricao_todos = new List<string>();
        public List<bool> ativo_todos = new List<bool>();
        public List<int> credito_dias_pagamento_todos = new List<int>();
        public List<int> debito_horas_pagamento_todos = new List<int>();
        public List<double> taxa_todos = new List<double>();

        private string descricao;
        private bool ativo;
        private int credito_dias_pagamento;
        private int debito_horas_pagamento;
        private double taxa;

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

        public int Credito_dias_pagamento
        {
            get
            {
                return credito_dias_pagamento;
            }

            set
            {
                credito_dias_pagamento = value;
            }
        }

        public int Debito_horas_pagamento
        {
            get
            {
                return debito_horas_pagamento;
            }

            set
            {
                debito_horas_pagamento = value;
            }
        }

        public double Taxa
        {
            get
            {
                return taxa;
            }

            set
            {
                taxa = value;
            }
        }
        #endregion

        public Operadoras_cartao(bool loadData = false)
        {
            if (loadData == false) return;

            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from operadoras_cartao", conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_todos.Add(dr.GetInt32(0));
                        descricao_todos.Add(dr.GetString(1));
                        ativo_todos.Add(dr.GetBoolean(2));
                        credito_dias_pagamento_todos.Add(dr.GetInt32(3));
                        debito_horas_pagamento_todos.Add(dr.GetInt32(4));
                        taxa_todos.Add(dr.GetDouble(5));
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

        public Operadoras_cartao(int id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from operadoras_cartao where id = " + id, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    Descricao = dr.GetString(1);
                    Ativo = dr.GetBoolean(2);
                    Credito_dias_pagamento = dr.GetInt32(3);
                    Debito_horas_pagamento = dr.GetInt32(4);
                    Taxa = dr.GetDouble(5);
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
                MySqlCommand cmd = new MySqlCommand("update operadoras_cartao set descricao = @1, ativo = @2, credito_dias_pagamento = @3, debito_horas_pagamento = @4, taxa = @5 where id = " + id, conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Descricao);
                cmd.Parameters.AddWithValue("@2", Ativo);
                cmd.Parameters.AddWithValue("@3", Credito_dias_pagamento);
                cmd.Parameters.AddWithValue("@4", Debito_horas_pagamento);
                cmd.Parameters.AddWithValue("@5", Taxa);

                cmd.ExecuteNonQuery();
             //   Sucesso.Show("Operadora atualizada!");
            }
            catch(MySqlException ex)
            {
                Erro.Show("Erro ao atualizar operadora_cartao \n" + ex.Message, defaultError);
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
                MySqlCommand cmd = new MySqlCommand("delete from operadoras_cartao where id = " + id, conn.GetConexao());
                cmd.ExecuteNonQuery();

            //    Sucesso.Show("Operadora excluida!");
            } catch(MySqlException ex)
            {
                Atencao.Show("Não foi possível deletar essa operadora de cartão. \nEla está relacionada a um ou mais movimentos! \n");
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
                MySqlCommand cmd = new MySqlCommand("insert into operadoras_cartao(descricao, ativo, credito_dias_pagamento, debito_horas_pagamento, taxa) values(@1, @2, @3, @4, @5)", conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Descricao);
                cmd.Parameters.AddWithValue("@2", Ativo);
                cmd.Parameters.AddWithValue("@3", Credito_dias_pagamento);
                cmd.Parameters.AddWithValue("@4", Debito_horas_pagamento);
                cmd.Parameters.AddWithValue("@5", Taxa);

                cmd.ExecuteNonQuery();

            }
            catch(MySqlException ex)
            {
                Erro.Show("Erro ao gravar operadoras_cartao \n" + ex.Message, defaultError);
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
