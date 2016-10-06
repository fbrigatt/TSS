namespace GuaraTattooSoft.User_Controls
{
    partial class ContasAReceber
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridContas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txPesquisa = new System.Windows.Forms.TextBox();
            this.btRegistrarPag = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rdPagas = new System.Windows.Forms.RadioButton();
            this.rdTodas = new System.Windows.Forms.RadioButton();
            this.rdNaoPagas = new System.Windows.Forms.RadioButton();
            this.ckApenasEsteMes = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridContas
            // 
            this.dataGridContas.AllowUserToAddRows = false;
            this.dataGridContas.AllowUserToDeleteRows = false;
            this.dataGridContas.AllowUserToOrderColumns = true;
            this.dataGridContas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridContas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridContas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridContas.Location = new System.Drawing.Point(4, 53);
            this.dataGridContas.Name = "dataGridContas";
            this.dataGridContas.ReadOnly = true;
            this.dataGridContas.Size = new System.Drawing.Size(986, 504);
            this.dataGridContas.TabIndex = 0;
            this.dataGridContas.SelectionChanged += new System.EventHandler(this.dataGridContas_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cod";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Movimento";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Descrição";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Forma pag.";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Beneficiado";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Pagador";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Valor (R$)";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 80;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Vencimento";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Juros (%)";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Pago";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 50;
            // 
            // cbFiltro
            // 
            this.cbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "Descrição",
            "Data de vencimento",
            "Beneficiado",
            "Pagador",
            "Movimento"});
            this.cbFiltro.Location = new System.Drawing.Point(4, 27);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(243, 23);
            this.cbFiltro.TabIndex = 1;
            this.cbFiltro.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtro";
            // 
            // txPesquisa
            // 
            this.txPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPesquisa.Location = new System.Drawing.Point(253, 27);
            this.txPesquisa.Name = "txPesquisa";
            this.txPesquisa.Size = new System.Drawing.Size(397, 22);
            this.txPesquisa.TabIndex = 3;
            this.txPesquisa.TextChanged += new System.EventHandler(this.txPesquisa_TextChanged);
            // 
            // btRegistrarPag
            // 
            this.btRegistrarPag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btRegistrarPag.BackColor = System.Drawing.Color.Teal;
            this.btRegistrarPag.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btRegistrarPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegistrarPag.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btRegistrarPag.Location = new System.Drawing.Point(833, 563);
            this.btRegistrarPag.Name = "btRegistrarPag";
            this.btRegistrarPag.Size = new System.Drawing.Size(157, 23);
            this.btRegistrarPag.TabIndex = 4;
            this.btRegistrarPag.Text = "&REGISTRAR PAGAMENTO";
            this.btRegistrarPag.UseVisualStyleBackColor = false;
            this.btRegistrarPag.Click += new System.EventHandler(this.btRegistrarPag_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pesquisa";
            // 
            // rdPagas
            // 
            this.rdPagas.AutoSize = true;
            this.rdPagas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPagas.Location = new System.Drawing.Point(803, 27);
            this.rdPagas.Name = "rdPagas";
            this.rdPagas.Size = new System.Drawing.Size(115, 20);
            this.rdPagas.TabIndex = 6;
            this.rdPagas.Text = "Apenas pagas";
            this.rdPagas.UseVisualStyleBackColor = true;
            this.rdPagas.CheckedChanged += new System.EventHandler(this.rdPagas_CheckedChanged);
            // 
            // rdTodas
            // 
            this.rdTodas.AutoSize = true;
            this.rdTodas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTodas.Location = new System.Drawing.Point(924, 27);
            this.rdTodas.Name = "rdTodas";
            this.rdTodas.Size = new System.Drawing.Size(66, 20);
            this.rdTodas.TabIndex = 7;
            this.rdTodas.Text = "Todas";
            this.rdTodas.UseVisualStyleBackColor = true;
            this.rdTodas.CheckedChanged += new System.EventHandler(this.rdTodas_CheckedChanged);
            // 
            // rdNaoPagas
            // 
            this.rdNaoPagas.AutoSize = true;
            this.rdNaoPagas.Checked = true;
            this.rdNaoPagas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNaoPagas.Location = new System.Drawing.Point(656, 27);
            this.rdNaoPagas.Name = "rdNaoPagas";
            this.rdNaoPagas.Size = new System.Drawing.Size(141, 20);
            this.rdNaoPagas.TabIndex = 8;
            this.rdNaoPagas.TabStop = true;
            this.rdNaoPagas.Text = "Apenas não pagas";
            this.rdNaoPagas.UseVisualStyleBackColor = true;
            this.rdNaoPagas.CheckedChanged += new System.EventHandler(this.rdNaoPagas_CheckedChanged);
            // 
            // ckApenasEsteMes
            // 
            this.ckApenasEsteMes.AutoSize = true;
            this.ckApenasEsteMes.Checked = true;
            this.ckApenasEsteMes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckApenasEsteMes.Location = new System.Drawing.Point(656, 7);
            this.ckApenasEsteMes.Name = "ckApenasEsteMes";
            this.ckApenasEsteMes.Size = new System.Drawing.Size(175, 17);
            this.ckApenasEsteMes.TabIndex = 9;
            this.ckApenasEsteMes.Text = "Exibir apenas contas deste mês";
            this.ckApenasEsteMes.UseVisualStyleBackColor = true;
            this.ckApenasEsteMes.CheckedChanged += new System.EventHandler(this.ckApenasEsteMes_CheckedChanged);
            // 
            // ContasAReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.ckApenasEsteMes);
            this.Controls.Add(this.rdNaoPagas);
            this.Controls.Add(this.rdTodas);
            this.Controls.Add(this.rdPagas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btRegistrarPag);
            this.Controls.Add(this.txPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.dataGridContas);
            this.Name = "ContasAReceber";
            this.Size = new System.Drawing.Size(1006, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridContas;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txPesquisa;
        private System.Windows.Forms.Button btRegistrarPag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdPagas;
        private System.Windows.Forms.RadioButton rdTodas;
        private System.Windows.Forms.RadioButton rdNaoPagas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.CheckBox ckApenasEsteMes;
    }
}
