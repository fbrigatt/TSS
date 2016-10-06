using GuaraTattooSoft.Util;
using MySql.Data.MySqlClient;
using GuaraTattooSoft.DBConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuaraTattooSoft.Entidades
{
    class Usuarios : IClasse_Persistencia
    {
        Conexao conn = new Conexao();

        string defaultError = "Erro em usuarios";

        public List<int> id_todos = new List<int>();
        public List<string> nome_todos = new List<string>();
        public List<string> senha_todos = new List<string>();
        public List<bool> cadastro_clientes_todos = new List<bool>();
        public List<bool> cadastro_profissionais_todos = new List<bool>();
        public List<bool> lancamento_servicos_todos = new List<bool>();
        public List<bool> admin_todos = new List<bool>();

        #region Variaveis
        private int id;
        private string nome;
        private string senha;
        private bool cadastro_clientes;
        private bool cadastro_profissionais;
        private bool lancamento_servicos;
        private bool admin;
        #endregion

        public Usuarios(bool loadData = false)
        {
            if (loadData == false) return;

            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from usuarios", conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Id = dr.GetInt32(0);
                        id_todos.Add(dr.GetInt32(0));
                        nome_todos.Add(dr.GetString(1));
                        senha_todos.Add(dr.GetString(2));
                        cadastro_clientes_todos.Add(dr.GetBoolean(3));
                        cadastro_profissionais_todos.Add(dr.GetBoolean(4));
                        lancamento_servicos_todos.Add(dr.GetBoolean(5));
                        admin_todos.Add(dr.GetBoolean(6));
                    }
                }

                dr.Close();

            }
            catch (MySqlException ex)
            {
                Erro.Show(ex.Message, "Erro em Usuarios");
            }
            finally
            {
                conn.Fechar();
            }
        }

        public Usuarios(int id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from usuarios where id = " + id, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    Id = dr.GetInt32(0);
                    Nome = dr.GetString(1);
                    Senha = dr.GetString(2);
                    Cadastro_clientes = dr.GetBoolean(3);
                    Cadastro_profissionais = dr.GetBoolean(4);
                    Lancamento_servicos = dr.GetBoolean(5);
                    Admin = dr.GetBoolean(6);
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

        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }

        public bool Cadastro_clientes
        {
            get
            {
                return cadastro_clientes;
            }

            set
            {
                cadastro_clientes = value;
            }
        }

        public bool Cadastro_profissionais
        {
            get
            {
                return cadastro_profissionais;
            }

            set
            {
                cadastro_profissionais = value;
            }
        }

        public bool Lancamento_servicos
        {
            get
            {
                return lancamento_servicos;
            }

            set
            {
                lancamento_servicos = value;
            }
        }

        public bool Admin
        {
            get
            {
                return admin;
            }

            set
            {
                admin = value;
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

        #region Persistencia
        public void Gravar()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("insert into usuarios(nome, senha, cadastro_clientes, cadastro_profissionais, lancamento_servicos, admin) values(@1, @2, @3, @4, @5, @6)", conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Nome);
                cmd.Parameters.AddWithValue("@2", Senha);
                cmd.Parameters.AddWithValue("@3", Cadastro_clientes);
                cmd.Parameters.AddWithValue("@4", Cadastro_profissionais);
                cmd.Parameters.AddWithValue("@5", Lancamento_servicos);
                cmd.Parameters.AddWithValue("@6", Admin);

                cmd.ExecuteNonQuery();

           //     Sucesso.Show("Usuário gravado!");

            }
            catch (MySqlException ex)
            {
                Erro.Show("Erro ao gravar usuário \n" + ex.Message, defaultError);
            }
            finally
            {
                conn.Fechar();
            }
        }

        public void Atualizar(int id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("update usuarios set nome = @1, senha = @2, cadastro_clientes = @3, cadastro_profissionais = @4, lancamento_servicos = @5, admin = @6 where id = " + id, conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Nome);
                cmd.Parameters.AddWithValue("@2", Senha);
                cmd.Parameters.AddWithValue("@3", Cadastro_clientes);
                cmd.Parameters.AddWithValue("@4", Cadastro_profissionais);
                cmd.Parameters.AddWithValue("@5", Lancamento_servicos);
                cmd.Parameters.AddWithValue("@6", Admin);

                cmd.ExecuteNonQuery();

   //             Sucesso.Show("Usuário atualizado!");

            }
            catch (MySqlException ex)
            {
                Erro.Show("Erro ao atualizar usuário \n" + ex.Message, defaultError);
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
                MySqlCommand cmd = new MySqlCommand("delete from usuarios where id = " + id, conn.GetConexao());
                cmd.ExecuteNonQuery();
            //    Sucesso.Show("Usuário excluido!");

            }
            catch (MySqlException ex)
            {
                Atencao.Show("Não é possivel excluir este usuário.\nEle esta relacionado a um ou mais movimentos.");
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
                MySqlCommand cmd = new MySqlCommand("select max(id) from usuarios", conn.GetConexao());
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
                Erro.Show("Erro ao recuperar id para usuário \n" + ex.Message, defaultError);
            }
            finally
            {
                conn.Fechar();
            }

            return 0;
        }

        public void Pesquisar(string nomeUsuario)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from usuarios where nome LIKE '%" + nomeUsuario + "%'", conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_todos.Add(dr.GetInt32(0));
                        nome_todos.Add(dr.GetString(1));
                        senha_todos.Add(dr.GetString(2));
                        cadastro_clientes_todos.Add(dr.GetBoolean(3));
                        cadastro_profissionais_todos.Add(dr.GetBoolean(4));
                        lancamento_servicos_todos.Add(dr.GetBoolean(5));
                        admin_todos.Add(dr.GetBoolean(6));
                    }
                }

                dr.Close();

            }
            catch (MySqlException ex)
            {
                Erro.Show(ex.Message, "Erro em Usuarios");
            }
            finally
            {
                conn.Fechar();
            }
        }
        #endregion
    }
}
