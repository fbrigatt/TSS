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
    class Materiais : IClasse_Persistencia
    {
        Conexao conn = new Conexao();
        string defaultError = "Erro em materiais";

        public List<int> id_todos = new List<int>();
        public List<string> descricao_todos = new List<string>();
        public List<string> marca_todos = new List<string>();
        public List<string> modelo_todos = new List<string>();
        public List<string> tipo_todos = new List<string>();
        public List<string> tamanho_todos = new List<string>();
        public List<decimal> preco_custo_todos = new List<decimal>();
        public List<double> margem_lucro_todos = new List<double>();
        public List<decimal> preco_venda_todos = new List<decimal>();
        public List<bool> insumo_todos = new List<bool>();
        public List<bool> venda_todos = new List<bool>();
        public List<decimal> estoque_todos = new List<decimal>();
        public List<decimal> pedCompra_todos = new List<decimal>();
        public List<string> foto_todos = new List<string>();

        string descricao;
        string marca;
        string modelo;
        string tipo;
        string tamanho;
        decimal preco_custo;
        double margem_lucro;
        decimal preco_venda;
        bool insumo;
        bool venda;
        decimal estoque;
        decimal pedCompra;
        string foto;
        #region
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

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public string Tamanho
        {
            get
            {
                return tamanho;
            }

            set
            {
                tamanho = value;
            }
        }

        public decimal Preco_custo
        {
            get
            {
                return preco_custo;
            }

            set
            {
                preco_custo = value;
            }
        }

        public double Margem_lucro
        {
            get
            {
                return margem_lucro;
            }

            set
            {
                margem_lucro = value;
            }
        }

        public decimal Preco_venda
        {
            get
            {
                return preco_venda;
            }

            set
            {
                preco_venda = value;
            }
        }

        public bool Insumo
        {
            get
            {
                return insumo;
            }

            set
            {
                insumo = value;
            }
        }

        public bool Venda
        {
            get
            {
                return venda;
            }

            set
            {
                venda = value;
            }
        }

        public decimal Estoque
        {
            get
            {
                return estoque;
            }

            set
            {
                estoque = value;
            }
        }

        public decimal PedCompra
        {
            get
            {
                return pedCompra;
            }

            set
            {
                pedCompra = value;
            }
        }

        public string Foto
        {
            get
            {
                return foto;
            }

            set
            {
                foto = value;
            }
        }
        #endregion

        public Materiais(bool loadData = false)
        {
            if (loadData == false) return;
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from materiais", conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id_todos.Add(dr.GetInt32(0));
                        descricao_todos.Add(dr.GetString(1));
                        marca_todos.Add(dr.GetString(2));
                        modelo_todos.Add(dr.GetString(3));
                        tipo_todos.Add(dr.GetString(4));
                        tamanho_todos.Add(dr.GetString(5));
                        preco_custo_todos.Add(dr.GetDecimal(6));
                        margem_lucro_todos.Add(dr.GetDouble(7));
                        preco_venda_todos.Add(dr.GetDecimal(8));
                        insumo_todos.Add(dr.GetBoolean(9));
                        venda_todos.Add(dr.GetBoolean(10));
                        estoque_todos.Add(dr.GetDecimal(11));
                        pedCompra_todos.Add(dr.GetDecimal(12));
                        //foto_todos.Add(dr.GetString(13));
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

        public Materiais(int id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from materiais where id = " + id, conn.GetConexao());
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    Descricao = dr.GetString(1);
                    Marca = dr.GetString(2);
                    Modelo = dr.GetString(3);
                    Tipo = dr.GetString(4);
                    Tamanho = dr.GetString(5);
                    Preco_custo = dr.GetDecimal(6);
                    Margem_lucro = dr.GetDouble(7);
                    Preco_venda = dr.GetDecimal(8);
                    Insumo = dr.GetBoolean(9);
                    Venda = dr.GetBoolean(10);
                    Estoque = dr.GetDecimal(11);
                    PedCompra = dr.GetDecimal(12);
                //    Foto = dr.GetString(13);
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
                MySqlCommand cmd = new MySqlCommand("update materiais set descricao = @1, marca = @2, modelo = @3, tipo = @4, tamanho = @5, preco_custo = @6, margem_lucro = @7, preco_venda = @8, insumo = @9, venda = @10, estoque = @11, pedCompra = @12, foto = @13 where id = " + id, conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Descricao);
                cmd.Parameters.AddWithValue("@2", Marca);
                cmd.Parameters.AddWithValue("@3", Modelo);
                cmd.Parameters.AddWithValue("@4", Tipo);
                cmd.Parameters.AddWithValue("@5", Tamanho);
                cmd.Parameters.AddWithValue("@6", Preco_custo);
                cmd.Parameters.AddWithValue("@7", Margem_lucro);
                cmd.Parameters.AddWithValue("@8", Preco_venda);
                cmd.Parameters.AddWithValue("@9", Insumo);
                cmd.Parameters.AddWithValue("@10", Venda);
                cmd.Parameters.AddWithValue("@11", Estoque);
                cmd.Parameters.AddWithValue("@12", PedCompra);
                cmd.Parameters.AddWithValue("@13", Foto);

                cmd.ExecuteNonQuery();
                //Sucesso.Show("Material atualizado!");

            }
            catch(MySqlException ex)
            {
                Erro.Show("Erro ao atualizar material \n" + ex.Message, defaultError);
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
                MySqlCommand cmd = new MySqlCommand("delete from materiais where id = " + id, conn.GetConexao());
                cmd.ExecuteNonQuery();
             //   Sucesso.Show("Material excluido!");

            }catch(MySqlException ex)
            {
                Erro.Show("Não é possível deletar este material. O mesmo está relacionado a algum serviço e/ou movimento! \n" + ex.Message, defaultError);
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
                MySqlCommand cmd = new MySqlCommand("insert into materiais(descricao, marca, modelo, tipo, tamanho, preco_custo, margem_lucro, preco_venda, insumo, venda, estoque, pedCompra, foto) values(@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13)", conn.GetConexao());

                cmd.Parameters.AddWithValue("@1", Descricao);
                cmd.Parameters.AddWithValue("@2", Marca);
                cmd.Parameters.AddWithValue("@3", Modelo);
                cmd.Parameters.AddWithValue("@4", Tipo);
                cmd.Parameters.AddWithValue("@5", Tamanho);
                cmd.Parameters.AddWithValue("@6", Preco_custo);
                cmd.Parameters.AddWithValue("@7", Margem_lucro);
                cmd.Parameters.AddWithValue("@8", Preco_venda);
                cmd.Parameters.AddWithValue("@9", Insumo);
                cmd.Parameters.AddWithValue("@10", Venda);
                cmd.Parameters.AddWithValue("@11", Estoque);
                cmd.Parameters.AddWithValue("@12", PedCompra);
                cmd.Parameters.AddWithValue("@13", Foto);

                cmd.ExecuteNonQuery();
               // Sucesso.Show("Material gravado!");

            } catch(MySqlException ex)
            {
                Erro.Show("Erro ao gravar material \n" + ex.Message, defaultError);
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
        #endregion
    }
}
