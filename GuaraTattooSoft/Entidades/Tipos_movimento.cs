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
    class Tipos_movimento : IClasse_Persistencia
    {
        Conexao conn = new Conexao();
        string defaultError = "Erro em tipos_movimento";

        public List<int> id_todos = new List<int>();
        public List<string> descricao_todos = new List<string>();
        public List<int> entrada_valor_todos = new List<int>();
        public List<int> entrada_material_todos = new List<int>();
        public List<bool> ativo_todos = new List<bool>();

        private string descricao;
        private int entrada_valor;
        private int entrada_material;
        private bool ativo;

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

        public int Entrada_valor
        {
            get
            {
                return entrada_valor;
            }

            set
            {
                entrada_valor = value;
            }
        }

        public int Entrada_material
        {
            get
            {
                return entrada_material;
            }

            set
            {
                entrada_material = value;
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
        #endregion



        public enum Fixos
        {
            PrestacaoServ = 1,
            RetiradaCaixa = 2,
            PagamentoConta = 3,
            RecebConta = 4,
            CompraMaterial = 5,
            VendaMaterial = 6,
            Perda = 7
        }

        public Tipos_movimento(bool loadData = false)
        {
            if (loadData == false) return;

            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from tipos_movimento", conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_todos.Add(dr.GetInt32(0));
                        descricao_todos.Add(dr.GetString(1));
                        entrada_valor_todos.Add(dr.GetInt32(2));
                        entrada_material_todos.Add(dr.GetInt32(3));
                        ativo_todos.Add(dr.GetBoolean(4));
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

        public Tipos_movimento(int id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from tipos_movimento where id = " + id, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    Descricao = dr.GetString(1);
                    Entrada_valor = dr.GetInt32(2);
                    Entrada_material = dr.GetInt32(3);
                    Ativo = dr.GetBoolean(4);
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
                MySqlCommand cmd = new MySqlCommand("update tipos_movimento set descricao = @1, entrada_valor = @2, entrada_material = @3, ativo = @4 where id = " + id, conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Descricao);
                cmd.Parameters.AddWithValue("@2", Entrada_valor);
                cmd.Parameters.AddWithValue("@3", Entrada_material);
                cmd.Parameters.AddWithValue("@4", Ativo);

                cmd.ExecuteNonQuery();

                //Sucesso.Show("Tipo de movimento atualizado");
                
            }
            catch(MySqlException ex)
            {
                Erro.Show(ex.Message, defaultError);
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
                MySqlCommand cmd = new MySqlCommand("delete from tipos_movimento where id = " + id, conn.GetConexao());

                cmd.ExecuteNonQuery();

              //  Sucesso.Show("Tipo de movimento excluido!");

            }catch(MySqlException ex)
            {
                Erro.Show("Não é possível excluir este tipo de movimento.\nO mesmo está relacionado a um ou mais movimentos.\n\n Ao inves de exclui-lo, é possivel inativa-lo.", defaultError);
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
                MySqlCommand cmd = new MySqlCommand("insert into tipos_movimento(descricao, entrada_valor, entrada_material, ativo) values(@1, @2, @3, @4)", conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Descricao);
                cmd.Parameters.AddWithValue("@2", Entrada_valor);
                cmd.Parameters.AddWithValue("@3", Entrada_material);
                cmd.Parameters.AddWithValue("@4", Ativo);

                cmd.ExecuteNonQuery();

            }
            catch(MySqlException ex)
            {
                Erro.Show("Erro ao gravar tipo_movimento \n" + ex.Message, defaultError);
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

        public void Pesquisar(string descricao)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from tipos_movimento where descricao LIKE '%" + descricao + "%'", conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_todos.Add(dr.GetInt32(0));
                        descricao_todos.Add(dr.GetString(1));
                        entrada_valor_todos.Add(dr.GetInt32(2));
                        entrada_material_todos.Add(dr.GetInt32(3));
                        ativo_todos.Add(dr.GetBoolean(4));
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

        #region Enums
        public enum EstadosMovimento
        {
            Entrada = 1,
            Saida = 0,
            Nenhum = 2
        }
        #endregion
    }
}
