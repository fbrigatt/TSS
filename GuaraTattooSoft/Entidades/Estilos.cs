using GuaraTattooSoft.DBConnection;
using GuaraTattooSoft.Util;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuaraTattooSoft.Entidades
{
    public class Estilos
    {
        Conexao conn = new Conexao();
        private string defaultError = "Erro em Estilos";

        public List<int> id_todos = new List<int>();
        public List<string> nome_todos = new List<string>();

        public int Id { get; set; }
        public string Nome { get; set; }

        public Estilos(bool loadData = false)
        {
            if (!loadData) return;
            try
            {
                MySqlCommand cmd = new MySqlCommand("select * from estilos", conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_todos.Add(dr.GetInt32(0));
                        nome_todos.Add(dr.GetString(1));
                    }
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                Erro.Show("Ocorreu um problema ao listar os estilos", defaultError);
                Log.Write(GetType().Name, "Estilos(bool loadData = false)", ex.Message);
            }
            finally
            {
                conn.Fechar();
            }
        }

        public Estilos(int id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select * from estilos where id = " + id, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    Id = dr.GetInt32(0);
                    Nome = dr.GetString(1);
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                Erro.Show("Ocorreum um problema ao carregar o estilo de codigo " + id, defaultError);
                Log.Write(GetType().FullName, "Estilos(int id)", ex.Message);
            }
            finally
            {
                conn.Fechar();
            }
        }

        #region Persistencia
        public void Gravar()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("insert into estilos(nome) values (@1)", conn.GetConexao());
                cmd.Parameters.AddWithValue("@1", Nome);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Erro.Show("Ocorreu um problema ao salvar o estilo", defaultError);
                Log.Write(GetType().FullName, "Gravar", ex.Message);
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
                MySqlCommand cmd = new MySqlCommand("update estilos set nome = @1 where id = " + id, conn.GetConexao());
                cmd.Parameters.AddWithValue("@1", Nome);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Erro.Show("Ocorreu um problema ao atualizar o estilo de codigo " + id, defaultError);
                Log.Write(GetType().FullName, "Atualizar(int id)", ex.Message);
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
                MySqlCommand cmd = new MySqlCommand("delete from estilos where id = " + id, conn.GetConexao());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Erro.Show("Ocorreu um problema ao excluir o estilo de codigo " + id, defaultError);
                Log.Write(GetType().FullName, "Deletar(int id)", ex.Message);
            }
            finally
            {
                conn.Fechar();
            }
        }
        #endregion

    }
}
