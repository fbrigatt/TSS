using GuaraTattooSoft.Assistente;
using GuaraTattooSoft.Componentes_especiais;
using GuaraTattooSoft.Extencoes;
using GuaraTattooSoft.User_Controls;
using GuaraTattooSoft.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuaraTattooSoft.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            this.AplicarPadroes();
            tabControl.AplicarPadroes();

            this.Text = "Tattoo Smart Soft - Versão 1.3 - Final";

            try
            {
                Entidades.Config c = new Entidades.Config(true);
                imgLogo.BackgroundImage = Image.FromFile(c.ImagemLogo);
            }
            catch { }
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void menu_DoubleClick(object sender, EventArgs e)
        {
            CapturarSelecao(menu.SelectedNode.Text);
        }

        public void CapturarSelecao(string nome)
        {
            TabPage tabPage;
            switch (nome)
            {
                

                case "Cadastro de Materiais":

                    CadastroMateriais cadastroMateriais = new CadastroMateriais();
                    tabPage = new TabPage("Cadastro de materiais");
                    tabPage.Controls.Add(cadastroMateriais);
                    tabControl.Adicionar(tabPage);

                    break;

                case "Cadastro de Clientes":

                    if (Temp.Logado.Cadastro_clientes || Temp.Logado.Admin)
                    {
                        CadastroClientes cadastroCli = new CadastroClientes();
                        tabPage = new TabPage("Cadastro de clientes");
                        tabPage.Controls.Add(cadastroCli);
                        tabControl.Adicionar(tabPage);
                    }
                    else
                    {
                        Atencao.Show("Usuário sem permissão para acessar o cadastro de clientes!");
                    }
                    break;

                case "Cadastro de Caixas":

                    CadastroCaixa cadastroCaixa = new CadastroCaixa();
                    tabPage = new TabPage("Cadastro de Caixas");
                    tabPage.Controls.Add(cadastroCaixa);
                    tabControl.Adicionar(tabPage);
                    break;

                case "Cadastro de Formas de Pagamento":

                    CadastroFormasPag cfp = new CadastroFormasPag();
                    tabPage = new TabPage("Cadastro de Formas de Pagamento");
                    tabPage.Controls.Add(cfp);
                    tabControl.Adicionar(tabPage);
                    break;

                case "Cadastros de Tipos de Movimentos":

                    CadastroTiposMov ctm = new CadastroTiposMov();
                    tabPage = new TabPage("Cadastros de Tipos de Movimentos");
                    tabPage.Controls.Add(ctm);
                    tabControl.Adicionar(tabPage);
                    break;

                case "Cadastro de Usuários":

                    if (Temp.Logado.Admin)
                    {
                        User_Controls.CadastroUsuarios cadUsu = new User_Controls.CadastroUsuarios();
                        tabPage = new TabPage("Cadastro de Usuários");
                        tabPage.Controls.Add(cadUsu);
                        tabControl.Adicionar(tabPage);
                    }
                    else
                    {
                        Atencao.Show("Esta área é reservada aos administradores do sistema.");
                    }
                    break;

                case "Cadastro de Anamneses":

                    User_Controls.CadastroAnamneses ca = new User_Controls.CadastroAnamneses();
                    tabPage = new TabPage("Cadastro de Anamneses");
                    tabPage.Controls.Add(ca);
                    tabControl.Adicionar(tabPage);
                    break;

                case "Cadastro de Operadoras de Cartão":

                    CadastroOperadorasCartao coc = new CadastroOperadorasCartao();
                    tabPage = new TabPage("Cadastro de Operadoras de Cartão");
                    tabPage.Controls.Add(coc);
                    tabControl.Adicionar(tabPage);
                    break;

                case "Cadastro de Profissionais":

                    if (Temp.Logado.Cadastro_profissionais || Temp.Logado.Admin)
                    {
                        User_Controls.CadastroProfissionais cp = new User_Controls.CadastroProfissionais();
                        tabPage = new TabPage("Cadastro de Profissionais");
                        tabPage.Controls.Add(cp);
                        tabControl.Adicionar(tabPage);
                    }
                    else
                    {
                        Atencao.Show("Usuário sem permissão para visualizar/alterar informações sobre profissionais");
                    }

                    break;

                case "Cadastro de Tipos de Serviços":

                    CadastroTiposServico cts = new CadastroTiposServico();
                    tabPage = new TabPage("Cadastro de Tipos de Serviço");
                    tabPage.Controls.Add(cts);
                    tabControl.Adicionar(tabPage);
                    break;

                case "Cadastro de Campanhas de Marketing":

                    CadastroCampanhas cadCamp = new CadastroCampanhas();
                    tabPage = new TabPage("Campanhas de marketing");
                    tabPage.Controls.Add(cadCamp);
                    tabControl.Adicionar(tabPage);
                    break;

                case "Lançamento de Movimentos":

                    LancamentoMovimentos lm = new LancamentoMovimentos();
                    tabPage = new TabPage("Lançamento de Movimentos");
                    tabPage.Controls.Add(lm);
                    tabControl.Adicionar(tabPage);
                    break;

                case "Contas a Pagar":

                    ContasAPagar cap = new ContasAPagar();
                    tabPage = new TabPage("Contas a Pagar");
                    tabPage.Controls.Add(cap);
                    tabControl.Adicionar(tabPage);
                    break;

                case "Contas a Receber":

                    ContasAReceber car = new ContasAReceber();
                    tabPage = new TabPage("Contas a Receber");
                    tabPage.Controls.Add(car);
                    tabControl.Adicionar(tabPage);
                    break;

                case "Consulta de movimentos":

                    if (Temp.Logado.Admin)
                    {
                        ConsultaMovimentos cm = new ConsultaMovimentos();
                        tabPage = new TabPage("Consulta de movimentos");
                        tabPage.Controls.Add(cm);
                        tabControl.Adicionar(tabPage);
                    }
                    else
                    {
                        if(new Autenticacao().autorizado)
                        {
                            ConsultaMovimentos cm = new ConsultaMovimentos();
                            tabPage = new TabPage("Consulta de movimentos");
                            tabPage.Controls.Add(cm);
                            tabControl.Adicionar(tabPage);
                        }
                        else
                        {
                            Atencao.Show("Não autorizado.");
                        }
                    }
                    break;

                case "Abertura / Fechamento de Caixa":

                    AberturaFechamentoCaixa afc = new AberturaFechamentoCaixa();
                    tabPage = new TabPage("Abertura / Fechamento de caixa");
                    tabPage.Controls.Add(afc);
                    tabControl.Adicionar(tabPage);
                    break;

                case "Consulta de valores em caixa":

                    ConsultaValorCaixa cvc = new ConsultaValorCaixa();
                    tabPage = new TabPage("Consulta de valores em caixa");
                    tabPage.Controls.Add(cvc);
                    tabControl.Adicionar(tabPage);
                    break;

                case "Alterar Comissão de Profissionais":

                    if (Temp.Logado.Cadastro_profissionais || Temp.Logado.Admin)
                    {
                        AlterarComissao ac = new AlterarComissao();
                        tabPage = new TabPage("Alterar Comissão de Profissionais");
                        tabPage.Controls.Add(ac);
                        tabControl.Adicionar(tabPage);
                    }
                    else
                    {
                        if (new Autenticacao().autorizado)
                        {
                            ConsultaMovimentos cm = new ConsultaMovimentos();
                            tabPage = new TabPage("Consulta de movimentos");
                            tabPage.Controls.Add(cm);
                            tabControl.Adicionar(tabPage);
                        }
                        else
                        {
                            Atencao.Show("Usuário sem permissão para visualizar/alterar informações sobre profissionais");
                        }
                    }

                    break;

                case "Registro de Procedimentos":

                    Trabalho trabalho = new Trabalho();
                    tabPage = new TabPage("Registro de Procedimentos");
                    tabPage.Controls.Add(trabalho);
                    tabControl.Adicionar(tabPage);
                    break;

                case "Totais em Comissões por profissional":

                    if (Temp.Logado.Cadastro_profissionais || Temp.Logado.Admin)
                    {
                        HistoricoProfissional hp = new HistoricoProfissional();
                        tabPage = new TabPage("Histórico do profissional / Total em comissões");
                        tabPage.Controls.Add(hp);
                        tabControl.Adicionar(tabPage);
                    }
                    else
                    {
                        if (new Autenticacao().autorizado)
                        {
                            ConsultaMovimentos cm = new ConsultaMovimentos();
                            tabPage = new TabPage("Consulta de movimentos");
                            tabPage.Controls.Add(cm);
                            tabControl.Adicionar(tabPage);
                        }
                        else
                        {
                            Atencao.Show("Usuário sem permissão para visualizar/alterar informações sobre profissionais");
                        }
                    }
                    break;

                case "Retirada de Valor no Caixa":

                    RetiradaCaixa rc = new RetiradaCaixa();
                    tabPage = new TabPage("Retirada de Valor no Caixa");
                    tabPage.Controls.Add(rc);
                    tabControl.Adicionar(tabPage);
                    break;

                case "Modelos de email":

                    ModelosEmail me = new ModelosEmail();
                    tabPage = new TabPage("Modelos de email");
                    tabPage.Controls.Add(me);
                    tabControl.Adicionar(tabPage);
                    break;

                case "Ajustes gerais":

                    AjustesGerais ag = new AjustesGerais();
                    tabPage = new TabPage("Ajustes gerais");
                    tabPage.Controls.Add(ag);
                    tabControl.Adicionar(tabPage);
                    break;

                case "Próximos Compromissos":

                    Agendamento agenda = new Agendamento();
                    tabPage = new TabPage("Agenda");
                    tabPage.Controls.Add(agenda);
                    tabControl.Adicionar(tabPage);
                    break;

                case "Relatório de Clientes":

                    RelatorioClientes rltcli = new RelatorioClientes();
                    rltcli.ShowDialog();
                    break;

                case "Histórico de Procedimentos":

                    HistoricoServicos hs = new HistoricoServicos();
                    tabPage = new TabPage("Histórico de Serviços");
                    tabPage.Controls.Add(hs);
                    tabControl.Adicionar(tabPage);
                    break;

                case "Alterar informações da loja":

                    CadastroLoja cadLoja = new CadastroLoja(true);
                    cadLoja.ShowDialog();
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            painelMenu.Width = 10;
            int w = Screen.PrimaryScreen.Bounds.Width;
            painelTab.Width = w;
            painelTab.Location = new Point(painelMenu.Location.X, painelMenu.Location.Y);
        }

        public static void FecharGuiaAtual()
        {
            if (tabControl.TabPages.Count == 0) return;
            tabControl.TabPages.Remove(tabControl.TabPages[tabControl.SelectedIndex]);

            if(tabControl.TabPages.Count == 0)
            {
                //PaginaInicial pg_ini = new PaginaInicial();
                TabPage page = new TabPage("Página inicial");
                //page.Controls.Add(pg_ini);
                tabControl.Adicionar(page);
            }
        }

        private void btMostrarMenu_Click(object sender, EventArgs e)
        {
            painelMenu.Width = 250;
            int w = this.Width - 22;
            painelTab.Width = w - painelMenu.Width - 5;
            painelTab.Location = new Point(painelMenu.Width + 5, painelMenu.Location.Y);
            painelMenu.Visible = true;
        }

        private void btEsconderMenu_Click(object sender, EventArgs e)
        {
            painelMenu.Width = 10;
            int w = this.Width - 15; //Screen.PrimaryScreen.Bounds.Width;
            painelTab.Width = w - 5;
            painelTab.Location = new Point(painelMenu.Location.X, painelMenu.Location.Y);
            painelMenu.Visible = false;
        }

        private void btFecharGuia_Click(object sender, EventArgs e)
        {
            FecharGuiaAtual();
        }

        private void btFecharTudo_Click(object sender, EventArgs e)
        {
            foreach (TabPage page in tabControl.TabPages)
            {
                tabControl.TabPages.Remove(page);
            }

            //PaginaInicial pg_ini = new PaginaInicial();
            TabPage tabPage = new TabPage("Página inicial");
            //tabPage.Controls.Add(pg_ini);
            tabControl.Adicionar(tabPage);
        }
    }
}
