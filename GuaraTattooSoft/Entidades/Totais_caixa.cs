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
    class Totais_caixa
    {
        Conexao conn = new Conexao();
        string defaultError = "Erro em totais_caixa";

        public List<int> id_todos = new List<int>();
        public List<int> caixas_id_todos = new List<int>();
        public List<decimal> valor_todos = new List<decimal>();
        public List<DateTime> data_todos = new List<DateTime>();

        int caixas_id;
        decimal valor;
        DateTime data;

        #region Propriedades
        public int Caixas_id
        {
            get
            {
                return caixas_id;
            }

            set
            {
                caixas_id = value;
            }
        }

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

        public DateTime Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }
        #endregion

        public Totais_caixa(bool loadData = false)
        {
            if (loadData == false) return;
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from totais_caixa", conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_todos.Add(dr.GetInt32(0));
                        caixas_id_todos.Add(dr.GetInt32(1));
                        valor_todos.Add(dr.GetDecimal(2));
                        data_todos.Add(dr.GetDateTime(3));
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

        public Totais_caixa(int id_caixas)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from totais_caixa where caixas_id = " + id_caixas, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_todos.Add(dr.GetInt32(0));
                        caixas_id_todos.Add(dr.GetInt32(1));
                        valor_todos.Add(dr.GetDecimal(2));
                        data_todos.Add(dr.GetDateTime(3));
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

        public void Atualizar(int id_caixas)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id_caixas)
        {
            throw new NotImplementedException();
        }

        public void Gravar()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("insert into totais_caixa(caixas_id, valor, data) values(@1, @2, @3)", conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Caixas_id);
                cmd.Parameters.AddWithValue("@2", Valor);
                cmd.Parameters.AddWithValue("@3", Data);

                cmd.ExecuteNonQuery();

            }catch(MySqlException ex)
            {
                Erro.Show("Erro ao gravar Totais_caixa \n" + ex.Message, defaultError);
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
       
        public decimal Total(int caixas_id, bool apenasHoje = false)
        {
            int diaHoje;
            int mesAtual;
            int anoAtual;
            string sql = "select valor from totais_caixa where caixas_id = " + caixas_id;
            decimal retorno = 0;

            if (apenasHoje)
            {
                diaHoje = DateTime.Now.Day;
                mesAtual = DateTime.Now.Month;
                anoAtual = DateTime.Now.Year;

                string mes = mesAtual < 10 ? mes = "0" + mesAtual : mes = mesAtual.ToString(); ;
                string dia = diaHoje < 10 ? dia = "0" + diaHoje : dia = diaHoje.ToString();

                sql = "select valor from totais_caixa where data LIKE '%" + anoAtual + "-" + mes + "-" + dia + "%' AND caixas_id = " + caixas_id;
            }

            if (!apenasHoje)
            {
                diaHoje = DateTime.Now.Day;
                mesAtual = DateTime.Now.Month;
                anoAtual = DateTime.Now.Year;

                string mes = mesAtual < 10 ? mes = "0" + mesAtual : mes = mesAtual.ToString(); ;
                string dia = diaHoje < 10 ? dia = "0" + diaHoje : dia = diaHoje.ToString();

                sql = "select valor from totais_caixa where data LIKE '%-" + mes + "-%' AND caixas_id = " + caixas_id;
            }

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        retorno += dr.GetDecimal(0);
                    }
                }

                dr.Close();

            }catch(MySqlException ex)
            {
                Erro.Show("Erro ao calcular valor para caixa \n" + ex.Message, defaultError);
            }
            finally
            {
                conn.Fechar();
            }
            return retorno;
        }

    }
}
