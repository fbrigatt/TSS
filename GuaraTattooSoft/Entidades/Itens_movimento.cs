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
    class Itens_movimento : IClasse_Persistencia
    {
        Conexao conn = new Conexao();
        string defaultError = "Erro em itens_movimento";
        

        public List<int> id_todos = new List<int>();
        public List<int> servico_material_todos = new List<int>();
        public List<int> cod_servico_material_todos = new List<int>();
        public List<double> QNTD_todos = new List<double>();

        private int servico_material;
        private int cod_servico_material;
        private double qntd;
        
        #region Propriedades

        public int Cod_servico_material
        {
            get
            {
                return cod_servico_material;
            }

            set
            {
                cod_servico_material = value;
            }
        }

        public double Qntd
        {
            get
            {
                return qntd;
            }

            set
            {
                qntd = value;
            }
        }

        public int Servico_material
        {
            get
            {
                return servico_material;
            }

            set
            {
                servico_material = value;
            }
        }
        #endregion

        public enum Tipo_Item
        {
            servico = 0,
            material = 1
        }

        public Itens_movimento(bool loadData = false)
        {
            if (loadData == false) return;

            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from itens_movimento", conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_todos.Add(dr.GetInt32(0));
                        servico_material_todos.Add(dr.GetInt32(1));
                        cod_servico_material_todos.Add(dr.GetInt32(2));
                        QNTD_todos.Add(dr.GetDouble(3));
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

        public Itens_movimento(int id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from itens_movimento where id = " + id, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    Servico_material = dr.GetInt32(1);
                    Cod_servico_material = dr.GetInt32(2);
                    Qntd = dr.GetDouble(3);
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
               
            }catch(MySqlException ex)
            {
                
            }
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public void Gravar()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("insert into itens_movimento(servico_material, cod_servico_material, QNTD) values(@1, @2, @3)", conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Servico_material);
                cmd.Parameters.AddWithValue("@2", Cod_servico_material);
                cmd.Parameters.AddWithValue("@3", Qntd);

                cmd.ExecuteNonQuery();

            }catch(MySqlException ex)
            {
                Erro.Show("Erro ao gravar Itens_movimento \n" + ex.Message, defaultError);
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
                MySqlCommand cmd = new MySqlCommand("select max(id) from itens_movimento", conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    return dr.GetInt32(0);
                }

                dr.Close();

            }catch(MySqlException ex)
            {
                Erro.Show("Erro ao recuperar id para itens_movimento \n" + ex.Message, defaultError);
            }
            finally
            {
                conn.Fechar();
            }

            return 0;
        }
        #endregion
    }
}
