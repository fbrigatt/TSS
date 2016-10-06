using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GuaraTattooSoft.Entidades;
using GuaraTattooSoft.Extencoes;

namespace GuaraTattooSoft.User_Controls
{
    public partial class CadastroFormasPag : UserControl
    {
        bool modoEdicao = false;

        public CadastroFormasPag()
        {
            InitializeComponent();

            this.AplicarPadroes();
            dataGridFormasPag.AplicarPadroes();

            AtualizaDataGrid();
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        private void Gravar()
        {
            if (string.IsNullOrWhiteSpace(txDescricao.Text)) return;

            Formas_pagamento formas_pag = new Formas_pagamento();

            formas_pag.Descricao = txDescricao.Text;
            formas_pag.Permitir_parcel = ckParcelamento.Checked == true ? formas_pag.Permitir_parcel = true : formas_pag.Permitir_parcel = false;

            if (modoEdicao == true)
            {
                int id = dataGridFormasPag.IdAtual(0);
                formas_pag.Atualizar(id);
            }
            else
            {
                formas_pag.Gravar();
            }

            AtualizaDataGrid();
        }

        private void AtualizaDataGrid()
        {
            dataGridFormasPag.Rows.Clear();

            Formas_pagamento FP = new Formas_pagamento(true);

            for (int i = 0; i < FP.id_todos.Count; i++)
            {
                string permitirParc = FP.permitir_parcel_todos[i] == true ? permitirParc = "SIM" : "NÃO";
                dataGridFormasPag.Rows.Add(FP.id_todos[i], FP.descricao_todos[i], permitirParc);
            }

            modoEdicao = false;
            this.LimparCampos();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (!dataGridFormasPag.TemLinhas()) return;

            int id = dataGridFormasPag.IdAtual(0);

            Formas_pagamento fp = new Formas_pagamento(id);

            txDescricao.Text = fp.Descricao;
            if (fp.Permitir_parcel == true) ckParcelamento.Checked = true;

            modoEdicao = true;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (!dataGridFormasPag.TemLinhas()) return;

            int id = dataGridFormasPag.IdAtual(0);
            Formas_pagamento fp = new Formas_pagamento();
            fp.Deletar(id);
            AtualizaDataGrid();
        }
    }
}
