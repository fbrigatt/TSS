using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Xml;

namespace GuaraTattooSoft.DBConnection
{
    class Conexao
    {
         MySqlConnection conn = null;

        public MySqlConnection GetConexao()
        {
            try
            {
                XmlDocument DBConfig = new XmlDocument();
                DBConfig.Load("DBConfig.xml");
                conn = new MySqlConnection("host = " + DBConfig.SelectSingleNode("config").ChildNodes[0].InnerText + "; database = " + DBConfig.SelectSingleNode("config").ChildNodes[1].InnerText + "; UID = " + DBConfig.SelectSingleNode("config").ChildNodes[2].InnerText + "; Password = " + DBConfig.SelectSingleNode("config").ChildNodes[3].InnerText + ";");

                conn.Open();
                return conn;

            }
            catch (MySqlException es)
            {
           //     Erro.Show("Não foi possível conectar-se com o servidor de banco de dados. \nVerifique as configurações do ambiente, ou mesmo se você possui uma conexão ativa com a internet \n" + es.Message, "Erro ao conectar-se com o servidor de banco de dados");
                Application.Exit();
                return null;
            }

            catch (XmlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void Fechar()
        {
            try
            {
                conn.Close();
            }
            catch { }
        }

    }
}
