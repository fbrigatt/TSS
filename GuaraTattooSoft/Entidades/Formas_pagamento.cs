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
    class Formas_pagamento : IClasse_Persistencia
    {
        Conexao conn = new Conexao();
        string defaultError = "Erro em formas_pagamento";

        public List<int> id_todos = new List<int>();
        public List<string> descricao_todos = new List<string>();
        public List<bool> permitir_parcel_todos = new List<bool>();

        private string descricao;
        private bool permitir_parcel;

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

        public bool Permitir_parcel
        {
            get
            {
                return permitir_parcel;
            }

            set
            {
                permitir_parcel = value;
            }
        }

        #endregion

        public enum Fixas
        {
            DINHEIRO = 1,
            CARTAO = 2
        }

        public Formas_pagamento(bool loadData = false)
        {
            if (loadData == false) return;

            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from formas_pagamento", conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_todos.Add(dr.GetInt32(0));
                        descricao_todos.Add(dr.GetString(1));
                        permitir_parcel_todos.Add(dr.GetBoolean(2));
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

        public Formas_pagamento(int id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from formas_pagamento where id = " + id, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    Descricao = dr.GetString(1);
                    Permitir_parcel = dr.GetBoolean(2);
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
                MySqlCommand cmd = new MySqlCommand("update formas_pagamento set descricao = @1, permitir_parcel = @2 where id = " + id, conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Descricao);
                cmd.Parameters.AddWithValue("@2", Permitir_parcel);

                cmd.ExecuteNonQuery();

           //     Sucesso.Show("Forma de pagamento atualizada!");
            }
            catch(MySqlException ex)
            {
                Erro.Show("Erro ao atualizar forma de pagamento \n" + ex.Message, defaultError);
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
                MySqlCommand cmd = new MySqlCommand("delete from formas_pagamento where id = " + id, conn.GetConexao());

                cmd.ExecuteNonQuery();

          //      Sucesso.Show("Forma de pagamento excluida!");

            }catch(MySqlException ex)
            {
                Erro.Show("Erro ao deletar forma de pagamento \n" + ex.Message, defaultError);
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
                MySqlCommand cmd = new MySqlCommand("insert into formas_pagamento(descricao, permitir_parcel) values(@1, @2)", conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Descricao);
                cmd.Parameters.AddWithValue("@2", Permitir_parcel);

                cmd.ExecuteNonQuery();

              //  Sucesso.Show("Forma de pagamento gravada!");

            } catch(MySqlException ex)
            {
                Erro.Show("Erro ao gravar forma de pagamento \n" + ex.Message, defaultError);
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

        public void Pesquisar(string pesquisa)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from formas_pagamento where descricao LIKE '%" + pesquisa + "%'", conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_todos.Add(dr.GetInt32(0));
                        descricao_todos.Add(dr.GetString(1));
                        permitir_parcel_todos.Add(dr.GetBoolean(2));
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
