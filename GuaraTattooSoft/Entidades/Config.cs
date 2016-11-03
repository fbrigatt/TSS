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
    class Config
    {
        static string defaultError = "Erro ao carregar configurações";

        static Conexao conn = new Conexao();

        private string emailLoja;
        private string senhaEmail;
        private string imagemLogo;
        private string modeloEmailSessao;
        private string modeloEmailAniv;
        private string modeloEmailAgend;
        private string host;
        private int porta;
        private int diasRetorno_cliente;
        private int tipos_servico_id;
        private int versao;

        #region Propriedades
        public int Versao
        {
            get
            {
                return this.versao;
            }
            set
            {
                this.versao = value;
            }
        }

        public string EmailLoja
        {
            get
            {
                return emailLoja;
            }

            set
            {
                emailLoja = value;
            }
        }

        public string SenhaEmail
        {
            get
            {
                return senhaEmail;
            }

            set
            {
                senhaEmail = value;
            }
        }

        public string ImagemLogo
        {
            get
            {
                return imagemLogo;
            }

            set
            {
                imagemLogo = value;
            }
        }

        public string ModeloEmailSessao
        {
            get
            {
                return modeloEmailSessao;
            }

            set
            {
                modeloEmailSessao = value;
            }
        }

        public string ModeloEmailAniv
        {
            get
            {
                return modeloEmailAniv;
            }

            set
            {
                modeloEmailAniv = value;
            }
        }

        public string ModeloEmailAgend
        {
            get
            {
                return modeloEmailAgend;
            }

            set
            {
                modeloEmailAgend = value;
            }
        }

        public string Host
        {
            get
            {
                return host;
            }

            set
            {
                host = value;
            }
        }

        public int Porta
        {
            get
            {
                return porta;
            }

            set
            {
                porta = value;
            }
        }

        public int DiasRetorno_cliente
        {
            get
            {
                return diasRetorno_cliente;
            }

            set
            {
                diasRetorno_cliente = value;
            }
        }

        public int Tipos_servico_id
        {
            get
            {
                return tipos_servico_id;
            }

            set
            {
                tipos_servico_id = value;
            }
        }
        #endregion

        public Config(bool loadData = false)
        {
            if (loadData == false) return;

            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from config where id = 1", conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    EmailLoja = dr.GetString(1);
                    SenhaEmail = dr.GetString(2);
                    ImagemLogo = dr.IsDBNull(3) ? imagemLogo = string.Empty : imagemLogo = dr.GetString(3);
                    ModeloEmailSessao = dr.IsDBNull(4) ? ModeloEmailSessao = string.Empty : ModeloEmailSessao = dr.GetString(4);
                    ModeloEmailAniv = dr.IsDBNull(5) ? ModeloEmailAniv = string.Empty : ModeloEmailAniv = dr.GetString(5);
                    ModeloEmailAgend = dr.IsDBNull(6) ? ModeloEmailAgend = string.Empty : ModeloEmailAgend = dr.GetString(6);
                    Host = dr.GetString(7);
                    Porta = dr.GetInt32(8);
                    DiasRetorno_cliente = dr.GetInt32(9);
                    Tipos_servico_id = dr.GetInt32(10);
                    Versao = dr.GetInt32(11);
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

        public void Gravar()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("insert into config(id, emailLoja, senhaEmail, imagemLogo, modeloEmailSessao, modeloEmailAniv, modeloEmailAgend, host, porta, diasRetorno_cliente, tipos_servico_id, versao) values(1, @1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11)", conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", EmailLoja);
                cmd.Parameters.AddWithValue("@2", SenhaEmail);
                cmd.Parameters.AddWithValue("@3", ImagemLogo);
                cmd.Parameters.AddWithValue("@4", ModeloEmailSessao);
                cmd.Parameters.AddWithValue("@5", ModeloEmailAniv);
                cmd.Parameters.AddWithValue("@6", ModeloEmailAgend);
                cmd.Parameters.AddWithValue("@7", Host);
                cmd.Parameters.AddWithValue("@8", Porta);
                cmd.Parameters.AddWithValue("@9", DiasRetorno_cliente);
                cmd.Parameters.AddWithValue("@10", Tipos_servico_id);
                cmd.Parameters.AddWithValue("@11", Versao);

                cmd.ExecuteNonQuery();

                //  Sucesso.Show("Configurações salvas!");

            }
            catch (MySqlException ex)
            {
                Erro.Show("Erro ao gravar config \n" + ex.Message, defaultError);
            }
            finally
            {
                conn.Fechar();
            }
        }

        public void Atualizar()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("update config set id = 1, emailLoja = @1, senhaEmail = @2, imagemLogo = @3, modeloEmailSessao = @4, modeloEmailAniv = @5, modeloEmailAgend = @6, host = @7, porta = @8, diasRetorno_cliente = @9, tipos_servico_id = @10, versao = @11 where id = 1", conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", EmailLoja);
                cmd.Parameters.AddWithValue("@2", SenhaEmail);
                cmd.Parameters.AddWithValue("@3", ImagemLogo);
                cmd.Parameters.AddWithValue("@4", ModeloEmailSessao);
                cmd.Parameters.AddWithValue("@5", ModeloEmailAniv);
                cmd.Parameters.AddWithValue("@6", ModeloEmailAgend);
                cmd.Parameters.AddWithValue("@7", Host);
                cmd.Parameters.AddWithValue("@8", Porta);
                cmd.Parameters.AddWithValue("@9", DiasRetorno_cliente);
                cmd.Parameters.AddWithValue("@10", Tipos_servico_id);
                cmd.Parameters.AddWithValue("@11", Versao);

                cmd.ExecuteNonQuery();

                Sucesso.Show("Configurações atualizadas!");

            }
            catch (MySqlException ex)
            {
                Erro.Show("Erro ao atualizar configs \n" + ex.Message, defaultError);
            }
            finally
            {
                conn.Fechar();
            }
        }

        public void Deletar()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("delete from config", conn.GetConexao());
                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                Erro.Show("Erro ao deletar config \n " + ex.Message, defaultError);
            }
            finally
            {
                conn.Fechar();
            }
        }

        public int LastID()
        {
            return 0;
        }

        #endregion
    }
}
