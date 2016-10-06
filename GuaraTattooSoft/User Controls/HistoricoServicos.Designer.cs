namespace GuaraTattooSoft.User_Controls
{
    partial class HistoricoServicos
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
            this.components = new System.ComponentModel.Container();
            this.dataGridServicos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbExibicao = new System.Windows.Forms.ComboBox();
            this.btExibir = new System.Windows.Forms.Button();
            this.gatilho = new System.Windows.Forms.Timer(this.components);
            this.lb_ate = new System.Windows.Forms.Label();
            this.lb_de = new System.Windows.Forms.Label();
            this.txDataFinal = new System.Windows.Forms.DateTimePicker();
            this.txDataInicial = new System.Windows.Forms.DateTimePicker();
            this.txPesquisa = new System.Windows.Forms.TextBox();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRofi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServicos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridServicos
            // 
            this.dataGridServicos.AllowUserToAddRows = false;
            this.dataGridServicos.AllowUserToDeleteRows = false;
            this.dataGridServicos.AllowUserToOrderColumns = true;
            this.dataGridServicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridServicos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridServicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.porf,
            this.Column2,
            this.PRofi,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridServicos.Location = new System.Drawing.Point(4, 57);
            this.dataGridServicos.Name = "dataGridServicos";
            this.dataGridServicos.ReadOnly = true;
            this.dataGridServicos.Size = new System.Drawing.Size(1213, 505);
            this.dataGridServicos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exibir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(690, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pesquisa";
            // 
            // cbExibicao
            // 
            this.cbExibicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExibicao.FormattingEnabled = true;
            this.cbExibicao.Items.AddRange(new object[] {
            "Apenas Hoje",
            "Apenas Este Mês",
            "Por Período",
            "Todos"});
            this.cbExibicao.Location = new System.Drawing.Point(5, 30);
            this.cbExibicao.Name = "cbExibicao";
            this.cbExibicao.Size = new System.Drawing.Size(227, 24);
            this.cbExibicao.TabIndex = 3;
            this.cbExibicao.Text = "Apenas Este Mês";
            this.cbExibicao.SelectedIndexChanged += new System.EventHandler(this.cbExibicao_SelectedIndexChanged);
            // 
            // btExibir
            // 
            this.btExibir.Location = new System.Drawing.Point(458, 30);
            this.btExibir.Name = "btExibir";
            this.btExibir.Size = new System.Drawing.Size(75, 24);
            this.btExibir.TabIndex = 4;
            this.btExibir.Text = "&EXIBIR";
            this.btExibir.UseVisualStyleBackColor = true;
            this.btExibir.Click += new System.EventHandler(this.button1_Click);
            // 
            // gatilho
            // 
            this.gatilho.Enabled = true;
            this.gatilho.Interval = 1000;
            this.gatilho.Tick += new System.EventHandler(this.gatilho_Tick);
            // 
            // lb_ate
            // 
            this.lb_ate.AutoSize = true;
            this.lb_ate.Location = new System.Drawing.Point(347, 16);
            this.lb_ate.Name = "lb_ate";
            this.lb_ate.Size = new System.Drawing.Size(23, 13);
            this.lb_ate.TabIndex = 14;
            this.lb_ate.Text = "Até";
            // 
            // lb_de
            // 
            this.lb_de.AutoSize = true;
            this.lb_de.Location = new System.Drawing.Point(236, 14);
            this.lb_de.Name = "lb_de";
            this.lb_de.Size = new System.Drawing.Size(21, 13);
            this.lb_de.TabIndex = 13;
            this.lb_de.Text = "De";
            // 
            // txDataFinal
            // 
            this.txDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txDataFinal.Location = new System.Drawing.Point(350, 32);
            this.txDataFinal.Name = "txDataFinal";
            this.txDataFinal.Size = new System.Drawing.Size(102, 22);
            this.txDataFinal.TabIndex = 12;
            // 
            // txDataInicial
            // 
            this.txDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txDataInicial.Location = new System.Drawing.Point(236, 32);
            this.txDataInicial.Name = "txDataInicial";
            this.txDataInicial.Size = new System.Drawing.Size(108, 22);
            this.txDataInicial.TabIndex = 11;
            // 
            // txPesquisa
            // 
            this.txPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPesquisa.Location = new System.Drawing.Point(693, 32);
            this.txPesquisa.Name = "txPesquisa";
            this.txPesquisa.Size = new System.Drawing.Size(304, 22);
            this.txPesquisa.TabIndex = 15;
            this.txPesquisa.TextChanged += new System.EventHandler(this.txPesquisa_TextChanged);
            // 
            // cbFiltro
            // 
            this.cbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "Data",
            "Cliente",
            "Profissional",
            "Tipo Serviço",
            "Forma Pagamento"});
            this.cbFiltro.Location = new System.Drawing.Point(539, 30);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(148, 24);
            this.cbFiltro.TabIndex = 16;
            this.cbFiltro.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Filtro";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cod.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // porf
            // 
            this.porf.HeaderText = "Data do Serviço";
            this.porf.Name = "porf";
            this.porf.ReadOnly = true;
            this.porf.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cliente";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // PRofi
            // 
            this.PRofi.HeaderText = "Profissional";
            this.PRofi.Name = "PRofi";
            this.PRofi.ReadOnly = true;
            this.PRofi.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tipo de Serviço";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Forma de Pagamento";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Valor Serviço (R$)";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 130;
            // 
            // HistoricoServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.txPesquisa);
            this.Controls.Add(this.lb_ate);
            this.Controls.Add(this.lb_de);
            this.Controls.Add(this.txDataFinal);
            this.Controls.Add(this.txDataInicial);
            this.Controls.Add(this.btExibir);
            this.Controls.Add(this.cbExibicao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridServicos);
            this.Name = "HistoricoServicos";
            this.Size = new System.Drawing.Size(1220, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridServicos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbExibicao;
        private System.Windows.Forms.Button btExibir;
        private System.Windows.Forms.Timer gatilho;
        private System.Windows.Forms.Label lb_ate;
        private System.Windows.Forms.Label lb_de;
        private System.Windows.Forms.DateTimePicker txDataFinal;
        private System.Windows.Forms.DateTimePicker txDataInicial;
        private System.Windows.Forms.TextBox txPesquisa;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn porf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRofi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
