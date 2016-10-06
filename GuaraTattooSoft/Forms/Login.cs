using CrystalDecisions.CrystalReports.Engine;
using GuaraTattooSoft.Assistente;
using GuaraTattooSoft.DBConnection;
using GuaraTattooSoft.Entidades;
using GuaraTattooSoft.Extencoes;
using GuaraTattooSoft.Forms;
using GuaraTattooSoft.Relatorios;
using GuaraTattooSoft.Relatorios.DataSets;
using GuaraTattooSoft.Threads;
using GuaraTattooSoft.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GuaraTattooSoft
{
    public partial class Login : Form
    {
        List<KeyValuePair<int, string>> listaUsuarios = new List<KeyValuePair<int, string>>();

        public Login()
        {
            InitializeComponent();

            this.AplicarPadroes();

            CarregaUsuarios();
        }

        private void CarregaUsuarios()
        {
            Usuarios usuarios = new Usuarios(true);

            for (int i = 0; i < usuarios.id_todos.Count; i++)
            {
                listaUsuarios.Add(new KeyValuePair<int, string>(usuarios.id_todos[i], usuarios.nome_todos[i]));
            }

            cbUsuario.DataSource = new BindingSource(listaUsuarios, null);
            cbUsuario.ValueMember = "key";
            cbUsuario.DisplayMember = "value";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<int, string> usuario in listaUsuarios)
            {
                Usuarios usuarios = new Usuarios(usuario.Key);
                if (usuarios.Nome == cbUsuario.Text && usuarios.Senha == txSenha.Text)
                {
                    Home home = new Home();
                    home.Show();
                    CarregarTemp(usuario.Key);
                    this.Hide();
                    return;
                }
            }

            //if (usuarios.Senha == txSenha.Text)
            //{
            //    Home home = new Home();
            //    home.Show();
            //    CarregarTemp();
            //    this.Hide();
            //    return;
            //}

            Atencao.Show("Usuário ou senha incorretos!");
            txSenha.SelectAll();
        }

        private void CarregarTemp(int id_usuario)
        {
            Usuarios usuarios = new Usuarios(id_usuario);
            Temp.Logado = usuarios;

            Caixas caixas = new Caixas(true);
            foreach (int id in caixas.id_todos)
            {
                Status_caixa sc = new Status_caixa(id);
                if (!sc.Data_fechamento.HasValue)
                {
                    Temp.Aberto.Add(new Caixas(id));
                }
            }

            MonitoraCaixa mc = new MonitoraCaixa();
            MonitoraAniversario ma = new MonitoraAniversario();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
               //Usuarios usuarios = new Usuarios(int.Parse(cbUsuario.SelectedValue.ToString()));

                foreach(KeyValuePair<int, string> usuario in listaUsuarios)
                {
                    Usuarios usuarios = new Usuarios(usuario.Key);
                    if(usuarios.Nome == cbUsuario.Text && usuarios.Senha == txSenha.Text)
                    {
                        Home home = new Home();
                        home.Show();
                        CarregarTemp(usuario.Key);
                        this.Hide();
                        return;
                    }
                }

                //if (usuarios.Senha == txSenha.Text)
                //{
                //    Home home = new Home();
                //    home.Show();
                //    CarregarTemp();
                //    this.Hide();
                //    return;
                //}

                Atencao.Show("Usuário ou senha incorretos!");
                txSenha.SelectAll();
            }
        }

        private void cbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            txSenha.Focus();
        }

        private void cbUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txSenha.Focus();
            }
        }
    }
}
