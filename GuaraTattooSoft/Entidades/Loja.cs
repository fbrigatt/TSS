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
    class Loja : IClasse_Persistencia
    {
        Conexao conn = new Conexao();
        string defaultError = "Erro em lojas";

        string razao_social;
        string nome_fantasia;
        string cnpj;
        string cep;
        string cidade;
        string bairro;
        string logradouro;
        string uf;
        string responsavel;
        int numero;
        string telefone;
        string celular;

        #region Propriedades
        public string Razao_social
        {
            get
            {
                return razao_social;
            }

            set
            {
                razao_social = value;
            }
        }

        public string Nome_fantasia
        {
            get
            {
                return nome_fantasia;
            }

            set
            {
                nome_fantasia = value;
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

        public string Responsavel
        {
            get
            {
                return responsavel;
            }

            set
            {
                responsavel = value;
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

        public string Cnpj
        {
            get
            {
                return cnpj;
            }

            set
            {
                cnpj = value;
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
        #endregion

        public Loja(int id = 0)
        {
            if (id == 0) return;

            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from loja where id = " + id, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    Razao_social = dr.GetString(1);
                    Nome_fantasia = dr.GetString(2);
                    Cnpj = dr.GetString(3);
                    Cep = dr.GetString(4);
                    Cidade = dr.GetString(5);
                    Bairro = dr.GetString(6);
                    Numero = dr.GetInt32(7);
                    Logradouro = dr.GetString(8);
                    Uf = dr.GetString(9);
                    Responsavel = dr.GetString(10);
                    Telefone = dr.GetString(11);
                    Celular = dr.GetString(12);
                    
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

        public void Atualizar(int id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("update loja set razao_social = @1, nome_fantasia = @2, CNPJ = @3, CEP = @4, cidade = @5, bairro = @6, numero = @7, logradouro = @8, UF = @9, responsavel = @10, telefone = @11, celular = 12 where id = " + id, conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Razao_social);
                cmd.Parameters.AddWithValue("@2", Nome_fantasia);
                cmd.Parameters.AddWithValue("@3", Cnpj);
                cmd.Parameters.AddWithValue("@4", Cep);
                cmd.Parameters.AddWithValue("@5", Cidade);
                cmd.Parameters.AddWithValue("@6", Bairro);
                cmd.Parameters.AddWithValue("@7", Numero);
                cmd.Parameters.AddWithValue("@8", Logradouro);
                cmd.Parameters.AddWithValue("@9", Uf);
                cmd.Parameters.AddWithValue("@10", Responsavel);
                cmd.Parameters.AddWithValue("@11", Telefone);
                cmd.Parameters.AddWithValue("@12", Celular);

                cmd.ExecuteNonQuery();
             //   Sucesso.Show("Loja atualizada!");

            }
            catch(MySqlException ex)
            {
                Erro.Show("Erro ao atualizar loja \n" + ex.Message, defaultError);
            }
            finally
            {
                conn.Fechar();
            }
        }

        public void Deletar(int id)
        {
            //throw new NotImplementedException();
        }

        public void Gravar()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("insert into loja(razao_social, nome_fantasia, CNPJ, CEP, cidade, bairro, numero, logradouro, UF, responsavel, telefone, celular) values(@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12)", conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Razao_social);
                cmd.Parameters.AddWithValue("@2", Nome_fantasia);
                cmd.Parameters.AddWithValue("@3", Cnpj);
                cmd.Parameters.AddWithValue("@4", Cep);
                cmd.Parameters.AddWithValue("@5", Cidade);
                cmd.Parameters.AddWithValue("@6", Bairro);
                cmd.Parameters.AddWithValue("@7", Numero);
                cmd.Parameters.AddWithValue("@8", Logradouro);
                cmd.Parameters.AddWithValue("@9", Uf);
                cmd.Parameters.AddWithValue("@10", Responsavel);
                cmd.Parameters.AddWithValue("@11", Telefone);
                cmd.Parameters.AddWithValue("@12", Celular);

                cmd.ExecuteNonQuery();
              //  Sucesso.Show("Loja gravada!");

            }
            catch(MySqlException ex)
            {
                Erro.Show("Erro ao gravar loja \n" + ex.Message, defaultError);
            }finally
            {
                conn.Fechar();
            }
        }

        public int LastID()
        {
            throw new NotImplementedException();
        }
    }
}
