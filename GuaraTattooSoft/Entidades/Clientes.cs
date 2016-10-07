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
    public class Clientes : IClasse_Persistencia
    {
        Conexao conn = new Conexao();
        string defaultError = "Erro em Clientes";

        public List<int> id_todos = new List<int>();
        public List<string> nome_todos = new List<string>();
        public List<string> telefone_todos = new List<string>();
        public List<string> celular_todos = new List<string>();
        public List<string> email_todos = new List<string>();
        public List<string> CPF_todos = new List<string>();
        public List<string> RG_todos = new List<string>();
        public List<string> dataNasc_todos = new List<string>();
        public List<string> CEP_todos = new List<string>();
        public List<string> cidade_todos = new List<string>();
        public List<string> bairro_todos = new List<string>();
        public List<string> logradouro_todos = new List<string>();
        public List<int> numero_todos = new List<int>();
        public List<string> UF_todos = new List<string>();
        public List<string> referencia_todos = new List<string>();
        public List<string> obs_todos = new List<string>();
        public List<DateTime> dataCadastro_todos = new List<DateTime>();
        public List<int> campanha_id_todos = new List<int>();

        #region Variaveis
        string nome;
        string telefone;
        string celular;
        string email;
        string cpf;
        string rg;
        string dataNasc;
        string cep;
        string cidade;
        string bairro;
        string logradouro;
        int numero;
        string uf;
        string referencia;
        string obs;
        DateTime dataCadastro;
        int campanha_id;
        #endregion

        #region Propriedades
        public int Campanha_id
        {
            get
            {
                return campanha_id;
            }
            set
            {
                this.campanha_id = value;
            }
        }
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

        public string Celular
        {
            get
            {
                return celular;
            }

            set
            {
                celular = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
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

        public string Rg
        {
            get
            {
                return rg;
            }

            set
            {
                rg = value;
            }
        }

        public string DataNasc
        {
            get
            {
                return dataNasc;
            }

            set
            {
                dataNasc = value;
            }
        }

        public string Cep
        {
            get
            {
                return cep;
            }

            set
            {
                cep = value;
            }
        }

        public string Cidade
        {
            get
            {
                return cidade;
            }

            set
            {
                cidade = value;
            }
        }

        public string Bairro
        {
            get
            {
                return bairro;
            }

            set
            {
                bairro = value;
            }
        }

        public string Logradouro
        {
            get
            {
                return logradouro;
            }

            set
            {
                logradouro = value;
            }
        }

        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public string Uf
        {
            get
            {
                return uf;
            }

            set
            {
                uf = value;
            }
        }

        public string Referencia
        {
            get
            {
                return referencia;
            }

            set
            {
                referencia = value;
            }
        }

        public string Obs
        {
            get
            {
                return obs;
            }

            set
            {
                obs = value;
            }
        }

        public DateTime DataCadastro
        {
            get
            {
                return dataCadastro;
            }

            set
            {
                dataCadastro = value;
            }
        }
        #endregion

        public Clientes(bool loadData = false)
        {
            if (loadData == false) return;
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from clientes", conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_todos.Add(dr.GetInt32(0));
                        nome_todos.Add(dr.GetString(1));
                        telefone_todos.Add(dr.GetString(2));
                        celular_todos.Add(dr.GetString(3));
                        email_todos.Add(dr.GetString(4));
                        CPF_todos.Add(dr.GetString(5));
                        RG_todos.Add(dr.GetString(6));
                        dataNasc_todos.Add(dr.GetString(7));
                        CEP_todos.Add(dr.GetString(8));
                        cidade_todos.Add(dr.GetString(9));
                        bairro_todos.Add(dr.GetString(10));
                        logradouro_todos.Add(dr.GetString(11));
                        numero_todos.Add(dr.GetInt32(12));
                        UF_todos.Add(dr.GetString(13));
                        referencia_todos.Add(dr.GetString(14));
                        obs_todos.Add(dr.GetString(15));
                        dataCadastro_todos.Add(dr.GetDateTime(16));
                        campanha_id_todos.Add(dr.GetInt32(17));
                    }
                }
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

        public Clientes(int id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from clientes where id = " + id, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    Nome = dr.GetString(1);
                    Telefone = dr.GetString(2);
                    Celular = dr.GetString(3);
                    Email = dr.GetString(4);
                    Cpf = dr.GetString(5);
                    Rg = dr.GetString(6);
                    dataNasc = dr.GetString(7);
                    Cep = dr.GetString(8);
                    Cidade = dr.GetString(9);
                    Bairro = dr.GetString(10);
                    Logradouro = dr.GetString(11);
                    Numero = dr.GetInt32(12);
                    Uf = dr.GetString(13);
                    Referencia = dr.GetString(14);
                    Obs = dr.GetString(15);
                    DataCadastro = dr.GetDateTime(16);
                    Campanha_id = dr.GetInt32(0);
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
                MySqlCommand cmd = new MySqlCommand(@"update clientes set 
                                                        nome = @1,
                                                        telefone = @2, 
                                                        celular = @3,
                                                        email = @4,
                                                        CPF = @5, 
                                                        RG = @6,
                                                        dataNasc = @7,
                                                        CEP = @8, 
                                                        cidade = @9,
                                                        bairro = @10,
                                                        logradouro = @11,
                                                        numero = @12,
                                                        UF = @13, 
                                                        referencia = @14,
                                                        obs = @15,
                                                        campanha_id = @16 where id = " + id, conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Nome);
                cmd.Parameters.AddWithValue("@2", Telefone);
                cmd.Parameters.AddWithValue("@3", Celular);
                cmd.Parameters.AddWithValue("@4", Email);
                cmd.Parameters.AddWithValue("@5", Cpf);
                cmd.Parameters.AddWithValue("@6", Rg);
                cmd.Parameters.AddWithValue("@7", DataNasc);
                cmd.Parameters.AddWithValue("@8", Cep);
                cmd.Parameters.AddWithValue("@9", Cidade);
                cmd.Parameters.AddWithValue("@10", Bairro);
                cmd.Parameters.AddWithValue("@11", Logradouro);
                cmd.Parameters.AddWithValue("@12", Numero);
                cmd.Parameters.AddWithValue("@13", Uf);
                cmd.Parameters.AddWithValue("@14", Referencia);
                cmd.Parameters.AddWithValue("@15", Obs);
                cmd.Parameters.AddWithValue("@16", Campanha_id);

                cmd.ExecuteNonQuery();

                //   Sucesso.Show("Cadastro do cliente atualizado!");

            }
            catch (MySqlException ex)
            {
                Erro.Show("Erro ao atualizar clinte \n" + ex.Message, defaultError);
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
                MySqlCommand cmd = new MySqlCommand("delete from clientes where id = " + id, conn.GetConexao());
                cmd.ExecuteNonQuery();
                //  Sucesso.Show("Cliente excluido");

            }
            catch (MySqlException ex)
            {
                Erro.Show("Erro ao deletar cliente \n" + ex.Message, defaultError);
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
                MySqlCommand cmd = new MySqlCommand("insert into clientes(nome, telefone, celular, email, CPF, RG, dataNasc, CEP, cidade, bairro, logradouro, numero, UF, referencia, obs, dataCadastro, campanha_id) values(@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17)", conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Nome);
                cmd.Parameters.AddWithValue("@2", Telefone);
                cmd.Parameters.AddWithValue("@3", Celular);
                cmd.Parameters.AddWithValue("@4", Email);
                cmd.Parameters.AddWithValue("@5", Cpf);
                cmd.Parameters.AddWithValue("@6", Rg);
                cmd.Parameters.AddWithValue("@7", DataNasc);
                cmd.Parameters.AddWithValue("@8", Cep);
                cmd.Parameters.AddWithValue("@9", Cidade);
                cmd.Parameters.AddWithValue("@10", Bairro);
                cmd.Parameters.AddWithValue("@11", Logradouro);
                cmd.Parameters.AddWithValue("@12", Numero);
                cmd.Parameters.AddWithValue("@13", Uf);
                cmd.Parameters.AddWithValue("@14", Referencia);
                cmd.Parameters.AddWithValue("@15", Obs);
                cmd.Parameters.AddWithValue("@16", DataCadastro);
                cmd.Parameters.AddWithValue("@17", Campanha_id);

                cmd.ExecuteNonQuery();

                //    Sucesso.Show("Cliente gravado!");

            }
            catch (MySqlException ex)
            {
                Erro.Show("Erro ao gravar cliente \n" + ex.Message, defaultError);
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
                MySqlCommand cmd = new MySqlCommand("select max(id) from clientes", conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    return dr.GetInt32(0);
                }

            }
            catch (MySqlException ex)
            {
                Erro.Show("Erro ao recuperar id para clientes \n" + ex.Message, defaultError);
            }
            finally
            {
                conn.Fechar();
            }

            return 0;
        }

        public void Pesquisar(string termo)
        {
            try
            {
                termo = "%" + termo + "%";
                string sql = @"select * from clientes where nome LIKE @1 OR telefone LIKE @2 OR celular LIKE @3 OR email LIKE @4 OR CPF LIKE @5 OR RG LIKE @6";


                MySqlCommand cmd = new MySqlCommand(sql, conn.GetConexao());
                cmd.Parameters.AddWithValue("@1", termo);
                cmd.Parameters.AddWithValue("@2", termo);
                cmd.Parameters.AddWithValue("@3", termo);
                cmd.Parameters.AddWithValue("@4", termo);
                cmd.Parameters.AddWithValue("@5", termo);
                cmd.Parameters.AddWithValue("@6", termo);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_todos.Add(dr.GetInt32(0));
                        nome_todos.Add(dr.GetString(1));
                        telefone_todos.Add(dr.GetString(2));
                        celular_todos.Add(dr.GetString(3));
                        email_todos.Add(dr.GetString(4));
                        CPF_todos.Add(dr.GetString(5));
                        RG_todos.Add(dr.GetString(6));
                        dataNasc_todos.Add(dr.GetString(7));
                        CEP_todos.Add(dr.GetString(8));
                        cidade_todos.Add(dr.GetString(9));
                        bairro_todos.Add(dr.GetString(10));
                        logradouro_todos.Add(dr.GetString(11));
                        numero_todos.Add(dr.GetInt32(12));
                        UF_todos.Add(dr.GetString(13));
                        referencia_todos.Add(dr.GetString(14));
                        obs_todos.Add(dr.GetString(15));
                        dataCadastro_todos.Add(dr.GetDateTime(16));
                        campanha_id_todos.Add(dr.GetInt32(17));
                    }
                }
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

        public void Aniversariantes()
        {
            try
            {
                string mesAtual = DateTime.Now.Month < 10 ? "0" + DateTime.Now.Month : DateTime.Now.Month.ToString();
                string sql = "select * from clientes where dataNasc LIKE '%/" + mesAtual + "/%'";

                MySqlCommand cmd = new MySqlCommand(sql, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_todos.Add(dr.GetInt32(0));
                        nome_todos.Add(dr.GetString(1));
                        telefone_todos.Add(dr.GetString(2));
                        celular_todos.Add(dr.GetString(3));
                        email_todos.Add(dr.GetString(4));
                        CPF_todos.Add(dr.GetString(5));
                        RG_todos.Add(dr.GetString(6));
                        dataNasc_todos.Add(dr.GetString(7));
                        CEP_todos.Add(dr.GetString(8));
                        cidade_todos.Add(dr.GetString(9));
                        bairro_todos.Add(dr.GetString(10));
                        logradouro_todos.Add(dr.GetString(11));
                        numero_todos.Add(dr.GetInt32(12));
                        UF_todos.Add(dr.GetString(13));
                        referencia_todos.Add(dr.GetString(14));
                        obs_todos.Add(dr.GetString(15));
                        dataCadastro_todos.Add(dr.GetDateTime(16));
                        campanha_id_todos.Add(dr.GetInt32(17));
                    }
                }

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

        public void ProfissionalAtendido(int profissional_id, DateTime data_inicio, DateTime data_fim)
        {
            try
            {
                Servicos serv = new Servicos();
                serv.ApenasProfissional(profissional_id, data_inicio, data_fim, true);

                for(int i = 0; i < serv.id_todos.Count; i++)
                {
                    Clientes cliente = new Clientes(serv.clientes_id_todos[i]);

                    id_todos.Add(serv.clientes_id_todos[i]);
                    nome_todos.Add(cliente.Nome);
                    telefone_todos.Add(cliente.Telefone);
                    celular_todos.Add(cliente.Celular);
                    email_todos.Add(cliente.Email);
                    CPF_todos.Add(cliente.Cpf);
                    RG_todos.Add(cliente.Rg);
                    dataNasc_todos.Add(cliente.DataNasc);
                    CEP_todos.Add(cliente.Cep);
                    cidade_todos.Add(cliente.Cidade);
                    bairro_todos.Add(cliente.Bairro);
                    logradouro_todos.Add(cliente.Logradouro);
                    numero_todos.Add(cliente.Numero);
                    UF_todos.Add(cliente.Uf);
                    referencia_todos.Add(cliente.Referencia);
                    obs_todos.Add(cliente.Obs);
                    dataCadastro_todos.Add(cliente.DataCadastro);
                    campanha_id_todos.Add(cliente.Campanha_id);
                }

            }
            catch(Exception ex)
            {

            }
        }

        public Movimentos UltimoMovimento(int id)
        {
            return new Movimentos().UltimoPorCliente(id);
        }

        public void ListarPorDataCadastro(DateTime data_inicio, DateTime data_fim) // data de cadastro inicial e final
        {
            try
            {
                data_inicio = Convert.ToDateTime(data_inicio.ToShortDateString());
                data_fim = Convert.ToDateTime(data_fim.ToShortDateString());

                data_fim = data_fim.AddHours(23);
                data_fim = data_fim.AddMinutes(59);

                string sql = "select * from clientes where dataCadastro BETWEEN '" + data_inicio.ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + data_fim.ToString("yyyy-MM-dd HH:mm:ss") + "' ";

                MySqlCommand cmd = new MySqlCommand(sql, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_todos.Add(dr.GetInt32(0));
                        nome_todos.Add(dr.GetString(1));
                        telefone_todos.Add(dr.GetString(2));
                        celular_todos.Add(dr.GetString(3));
                        email_todos.Add(dr.GetString(4));
                        CPF_todos.Add(dr.GetString(5));
                        RG_todos.Add(dr.GetString(6));
                        dataNasc_todos.Add(dr.GetString(7));
                        CEP_todos.Add(dr.GetString(8));
                        cidade_todos.Add(dr.GetString(9));
                        bairro_todos.Add(dr.GetString(10));
                        logradouro_todos.Add(dr.GetString(11));
                        numero_todos.Add(dr.GetInt32(12));
                        UF_todos.Add(dr.GetString(13));
                        referencia_todos.Add(dr.GetString(14));
                        obs_todos.Add(dr.GetString(15));
                        dataCadastro_todos.Add(dr.GetDateTime(16));
                        campanha_id_todos.Add(dr.GetInt32(17));
                    }

                }
            }
            catch (Exception ex)
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
