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
    class Profissionais : IClasse_Persistencia
    {
        Conexao conn = new Conexao();
        string defaultError = "Erro em profissionais";

        public List<int> id_todos = new List<int>();
        public List<string> nome_todos = new List<string>();
        public List<string> telefone_todos = new List<string>();
        public List<string> CPF_todos = new List<string>();
        public List<string> data_entrada_todos = new List<string>();
        public List<decimal> salario_todos = new List<decimal>();
        public List<double> comissao_todos = new List<double>();
        public List<bool> ativo_todos = new List<bool>();

        private string nome;
        private string telefone;
        private string cpf;
        private string data_entrada;
        private decimal salario;
        private double comissao;
        private bool ativo;

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

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public string Data_entrada
        {
            get
            {
                return data_entrada;
            }

            set
            {
                data_entrada = value;
            }
        }

        public decimal Salario
        {
            get
            {
                return salario;
            }

            set
            {
                salario = value;
            }
        }

        public double Comissao
        {
            get
            {
                return comissao;
            }

            set
            {
                comissao = value;
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

        public Profissionais(bool loadData = false)
        {
            if (loadData == false) return;
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from profissionais", conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_todos.Add(dr.GetInt32(0));
                        nome_todos.Add(dr.GetString(1));
                        telefone_todos.Add(dr.GetString(2));
                        CPF_todos.Add(dr.GetString(3));
                        data_entrada_todos.Add(dr.GetString(4));
                        salario_todos.Add(dr.GetDecimal(5));
                        comissao_todos.Add(dr.GetDouble(6));
                        ativo_todos.Add(dr.GetBoolean(7));
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

        public Profissionais(int id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from profissionais where id = " + id, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    Nome = dr.GetString(1);
                    Telefone = dr.GetString(2);
                    Cpf = dr.GetString(3);
                    Data_entrada = dr.GetString(4);
                    Salario = dr.GetDecimal(5);
                    Comissao = dr.GetDouble(6);
                    Ativo = dr.GetBoolean(7);
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
                MySqlCommand cmd = new MySqlCommand("update profissionais set nome = @1, telefone = @2, CPF = @3, data_entrada = @4, salario = @5, comissao = @6, ativo = @7 where id = " + id, conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Nome);
                cmd.Parameters.AddWithValue("@2", Telefone);
                cmd.Parameters.AddWithValue("@3", Cpf);
                cmd.Parameters.AddWithValue("@4", Data_entrada);
                cmd.Parameters.AddWithValue("@5", Salario);
                cmd.Parameters.AddWithValue("@6", Comissao);
                cmd.Parameters.AddWithValue("@7", Ativo);

                cmd.ExecuteNonQuery();

            //    Sucesso.Show("Cadastro do Profissional atualizado!");

            }
            catch(MySqlException ex)
            {
                Erro.Show("Erro ao atualizar profissional \n" + ex.Message, defaultError);
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
                MySqlCommand cmd = new MySqlCommand("delete from profissionais where id = " + id, conn.GetConexao());
                cmd.ExecuteNonQuery();
             //   Sucesso.Show("Profissional excluido!");
            }catch(MySqlException ex)
            {
                Atencao.Show("Não foi possível deletar o profissional. \nO mesmo está relacionado a algum movimento e/ou serviço.");
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
                MySqlCommand cmd = new MySqlCommand("insert into profissionais(nome, telefone, CPF, data_entrada, salario, comissao, ativo) values(@1, @2, @3, @4, @5, @6, @7)", conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Nome);
                cmd.Parameters.AddWithValue("@2", Telefone);
                cmd.Parameters.AddWithValue("@3", Cpf);
                cmd.Parameters.AddWithValue("@4", Data_entrada);
                cmd.Parameters.AddWithValue("@5", Salario);
                cmd.Parameters.AddWithValue("@6", Comissao);
                cmd.Parameters.AddWithValue("@7", Ativo);

                cmd.ExecuteNonQuery();

            }
            catch(MySqlException ex)
            {
                Erro.Show("Erro ao gravar profissional \n" + ex.Message, defaultError);
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

        public void Pesquisar(string field, string searchTerm)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from profissionais where " + field + " LIKE '%" + searchTerm + "%'", conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_todos.Add(dr.GetInt32(0));
                        nome_todos.Add(dr.GetString(1));
                        telefone_todos.Add(dr.GetString(2));
                        CPF_todos.Add(dr.GetString(3));
                        data_entrada_todos.Add(dr.GetString(4));
                        salario_todos.Add(dr.GetDecimal(5));
                        comissao_todos.Add(dr.GetDouble(6));
                        ativo_todos.Add(dr.GetBoolean(7));
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
