namespace GuaraTattooSoft.User_Controls
{
    partial class HistoricoProfissional
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
            this.dataGridProfissionais = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridServicos = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbTotalProf = new System.Windows.Forms.Label();
            this.cbExibir = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txPesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txDataInicial = new System.Windows.Forms.DateTimePicker();
            this.txDataFinal = new System.Windows.Forms.DateTimePicker();
            this.btExibir = new System.Windows.Forms.Button();
            this.lb_de = new System.Windows.Forms.Label();
            this.lb_ate = new System.Windows.Forms.Label();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfissionais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServicos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridProfissionais
            // 
            this.dataGridProfissionais.AllowUserToAddRows = false;
            this.dataGridProfissionais.AllowUserToDeleteRows = false;
            this.dataGridProfissionais.AllowUserToOrderColumns = true;
            this.dataGridProfissionais.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridProfissionais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProfissionais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Nom});
            this.dataGridProfissionais.Location = new System.Drawing.Point(4, 47);
            this.dataGridProfissionais.Name = "dataGridProfissionais";
            this.dataGridProfissionais.Size = new System.Drawing.Size(286, 550);
            this.dataGridProfissionais.TabIndex = 0;
            this.dataGridProfissionais.SelectionChanged += new System.EventHandler(this.dataGridProfissionais_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cod";
            this.Column1.Name = "Column1";
            this.Column1.Width = 40;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Profissionais";
            this.Nom.Name = "Nom";
            this.Nom.Width = 240;
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
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column4,
            this.Valos,
            this.Column7});
            this.dataGridServicos.Location = new System.Drawing.Point(297, 47);
            this.dataGridServicos.Name = "dataGridServicos";
            this.dataGridServicos.ReadOnly = true;
            this.dataGridServicos.Size = new System.Drawing.Size(721, 521);
            this.dataGridServicos.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbTotalProf
            // 
            this.lbTotalProf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotalProf.AutoSize = true;
            this.lbTotalProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalProf.Location = new System.Drawing.Point(688, 571);
            this.lbTotalProf.Name = "lbTotalProf";
            this.lbTotalProf.Size = new System.Drawing.Size(215, 24);
            this.lbTotalProf.TabIndex = 2;
            this.lbTotalProf.Text = "Total do profissional: R$ ";
            // 
            // cbExibir
            // 
            this.cbExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExibir.FormattingEnabled = true;
            this.cbExibir.Items.AddRange(new object[] {
            "Apenas este mês",
            "Por período",
            "Tudo"});
            this.cbExibir.Location = new System.Drawing.Point(296, 21);
            this.cbExibir.Name = "cbExibir";
            this.cbExibir.Size = new System.Drawing.Size(177, 24);
            this.cbExibir.TabIndex = 3;
            this.cbExibir.Text = "Apenas este mês";
            this.cbExibir.SelectedIndexChanged += new System.EventHandler(this.cbExibir_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(293, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exibir";
            // 
            // txPesquisa
            // 
            this.txPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPesquisa.Location = new System.Drawing.Point(4, 21);
            this.txPesquisa.Name = "txPesquisa";
            this.txPesquisa.Size = new System.Drawing.Size(286, 22);
            this.txPesquisa.TabIndex = 4;
            this.txPesquisa.TextChanged += new System.EventHandler(this.txPesquisa_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pesquisar";
            // 
            // txDataInicial
            // 
            this.txDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txDataInicial.Location = new System.Drawing.Point(491, 24);
            this.txDataInicial.Name = "txDataInicial";
            this.txDataInicial.Size = new System.Drawing.Size(108, 22);
            this.txDataInicial.TabIndex = 6;
            // 
            // txDataFinal
            // 
            this.txDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txDataFinal.Location = new System.Drawing.Point(605, 23);
            this.txDataFinal.Name = "txDataFinal";
            this.txDataFinal.Size = new System.Drawing.Size(102, 22);
            this.txDataFinal.TabIndex = 7;
            // 
            // btExibir
            // 
            this.btExibir.Location = new System.Drawing.Point(714, 23);
            this.btExibir.Name = "btExibir";
            this.btExibir.Size = new System.Drawing.Size(75, 23);
            this.btExibir.TabIndex = 8;
            this.btExibir.Text = "&Exibir";
            this.btExibir.UseVisualStyleBackColor = true;
            this.btExibir.Click += new System.EventHandler(this.btExibir_Click);
            // 
            // lb_de
            // 
            this.lb_de.AutoSize = true;
            this.lb_de.Location = new System.Drawing.Point(491, 5);
            this.lb_de.Name = "lb_de";
            this.lb_de.Size = new System.Drawing.Size(21, 13);
            this.lb_de.TabIndex = 9;
            this.lb_de.Text = "De";
            // 
            // lb_ate
            // 
            this.lb_ate.AutoSize = true;
            this.lb_ate.Location = new System.Drawing.Point(602, 7);
            this.lb_ate.Name = "lb_ate";
            this.lb_ate.Size = new System.Drawing.Size(23, 13);
            this.lb_ate.TabIndex = 10;
            this.lb_ate.Text = "Até";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cod. Serviço";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Procedimento";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 180;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Data";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cliente";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Valos
            // 
            this.Valos.HeaderText = "Valor procedimento (R$)";
            this.Valos.Name = "Valos";
            this.Valos.ReadOnly = true;
            this.Valos.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Valor comissão (R$)";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // HistoricoProfissional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.lb_ate);
            this.Controls.Add(this.lb_de);
            this.Controls.Add(this.btExibir);
            this.Controls.Add(this.txDataFinal);
            this.Controls.Add(this.txDataInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbExibir);
            this.Controls.Add(this.lbTotalProf);
            this.Controls.Add(this.dataGridServicos);
            this.Controls.Add(this.dataGridProfissionais);
            this.Name = "HistoricoProfissional";
            this.Size = new System.Drawing.Size(1021, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfissionais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProfissionais;
        private System.Windows.Forms.DataGridView dataGridServicos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbTotalProf;
        private System.Windows.Forms.ComboBox cbExibir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DateTimePicker txDataInicial;
        private System.Windows.Forms.DateTimePicker txDataFinal;
        private System.Windows.Forms.Button btExibir;
        private System.Windows.Forms.Label lb_de;
        private System.Windows.Forms.Label lb_ate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}
