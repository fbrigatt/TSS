using GuaraTattooSoft.Extencoes;
using GuaraTattooSoft.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuaraTattooSoft.Forms
{
    public partial class RelatorioClientes : Form
    {
        public RelatorioClientes()
        {
            InitializeComponent();

            dataGridModelos.AplicarPadroes();
            CarregaModelos();
        }

        private void CarregaModelos()
        {
            dataGridModelos.Rows.Add(1, "Listagem simples");
            dataGridModelos.Rows.Add(2, "Ficha completa");
            dataGridModelos.Rows.Add(3, "Ranking");
            dataGridModelos.Rows.Add(4, "Estilos mais requisitados");
        }

        private void dataGridModelos_SelectionChanged(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridModelos.CurrentRow.Cells[0].Value.ToString());
            painelVis.Controls.Clear();
            switch(id)
            {
                case (int)Modelo.Listagem:

                    painelVis.Controls.Add(new RClientes_ListagemSimples());
                    break;

                case (int)Modelo.FichaCompleta:

                    painelVis.Controls.Add(new RClientes_FichaCompleta());
                    break;
            }
        }

        public enum Modelo
        {
            Listagem = 1,
            FichaCompleta = 2,
            Ranking = 3,
            Estilos = 4
        }
    }
}
