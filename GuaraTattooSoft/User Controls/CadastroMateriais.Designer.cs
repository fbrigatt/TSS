namespace GuaraTattooSoft.User_Controls
{
    partial class CadastroMateriais
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
            this.label1 = new System.Windows.Forms.Label();
            this.txDescricao = new System.Windows.Forms.TextBox();
            this.txModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txTipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txTamanho = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txPrecoCusto = new DevComponents.Editors.DoubleInput();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txMargemLucro = new DevComponents.Editors.DoubleInput();
            this.label7 = new System.Windows.Forms.Label();
            this.txPrecoVenda = new DevComponents.Editors.DoubleInput();
            this.label8 = new System.Windows.Forms.Label();
            this.txEstoque = new DevComponents.Editors.DoubleInput();
            this.dataGridMateriais = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btGravar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.txMarca = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txPedCompra = new DevComponents.Editors.DoubleInput();
            this.label10 = new System.Windows.Forms.Label();
            this.rdInsumo = new System.Windows.Forms.RadioButton();
            this.rdVenda = new System.Windows.Forms.RadioButton();
            this.txPesquisa = new System.Windows.Forms.TextBox();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txPrecoCusto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txMargemLucro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txPrecoVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMateriais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txPedCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição do material";
            // 
            // txDescricao
            // 
            this.txDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDescricao.Location = new System.Drawing.Point(19, 28);
            this.txDescricao.Name = "txDescricao";
            this.txDescricao.Size = new System.Drawing.Size(328, 22);
            this.txDescricao.TabIndex = 1;
            // 
            // txModelo
            // 
            this.txModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txModelo.Location = new System.Drawing.Point(579, 28);
            this.txModelo.Name = "txModelo";
            this.txModelo.Size = new System.Drawing.Size(217, 22);
            this.txModelo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelo";
            // 
            // txTipo
            // 
            this.txTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTipo.Location = new System.Drawing.Point(801, 28);
            this.txTipo.Name = "txTipo";
            this.txTipo.Size = new System.Drawing.Size(154, 22);
            this.txTipo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(798, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo";
            // 
            // txTamanho
            // 
            this.txTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTamanho.Location = new System.Drawing.Point(21, 74);
            this.txTamanho.Name = "txTamanho";
            this.txTamanho.Size = new System.Drawing.Size(118, 22);
            this.txTamanho.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tamanho";
            // 
            // txPrecoCusto
            // 
            // 
            // 
            // 
            this.txPrecoCusto.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txPrecoCusto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txPrecoCusto.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txPrecoCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPrecoCusto.Increment = 1D;
            this.txPrecoCusto.Location = new System.Drawing.Point(145, 74);
            this.txPrecoCusto.Name = "txPrecoCusto";
            this.txPrecoCusto.Size = new System.Drawing.Size(92, 22);
            this.txPrecoCusto.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Preço custo(R$)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Margem lucro (%)";
            // 
            // txMargemLucro
            // 
            // 
            // 
            // 
            this.txMargemLucro.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txMargemLucro.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txMargemLucro.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txMargemLucro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txMargemLucro.Increment = 1D;
            this.txMargemLucro.Location = new System.Drawing.Point(243, 74);
            this.txMargemLucro.Name = "txMargemLucro";
            this.txMargemLucro.Size = new System.Drawing.Size(92, 22);
            this.txMargemLucro.TabIndex = 7;
            this.txMargemLucro.Leave += new System.EventHandler(this.txMargemLucro_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(338, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Preço venda(R$)";
            // 
            // txPrecoVenda
            // 
            // 
            // 
            // 
            this.txPrecoVenda.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txPrecoVenda.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txPrecoVenda.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txPrecoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPrecoVenda.Increment = 1D;
            this.txPrecoVenda.Location = new System.Drawing.Point(341, 74);
            this.txPrecoVenda.Name = "txPrecoVenda";
            this.txPrecoVenda.Size = new System.Drawing.Size(92, 22);
            this.txPrecoVenda.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(436, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Estoque";
            // 
            // txEstoque
            // 
            // 
            // 
            // 
            this.txEstoque.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txEstoque.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txEstoque.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txEstoque.Increment = 1D;
            this.txEstoque.Location = new System.Drawing.Point(439, 74);
            this.txEstoque.Name = "txEstoque";
            this.txEstoque.Size = new System.Drawing.Size(92, 22);
            this.txEstoque.TabIndex = 9;
            // 
            // dataGridMateriais
            // 
            this.dataGridMateriais.AllowUserToAddRows = false;
            this.dataGridMateriais.AllowUserToDeleteRows = false;
            this.dataGridMateriais.AllowUserToOrderColumns = true;
            this.dataGridMateriais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridMateriais.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridMateriais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMateriais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column11,
            this.Column4,
            this.Column5,
            this.p,
            this.Column6,
            this.Pre,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridMateriais.Location = new System.Drawing.Point(19, 149);
            this.dataGridMateriais.Name = "dataGridMateriais";
            this.dataGridMateriais.ReadOnly = true;
            this.dataGridMateriais.Size = new System.Drawing.Size(934, 436);
            this.dataGridMateriais.TabIndex = 18;
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
            this.Column2.HeaderText = "Descrição";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Marca";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Modelo";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tipo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tamanho";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // p
            // 
            this.p.HeaderText = "Preço custo (R$)";
            this.p.Name = "p";
            this.p.ReadOnly = true;
            this.p.Width = 120;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Margem lucro (%)";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 120;
            // 
            // Pre
            // 
            this.Pre.HeaderText = "Preço venda (R$)";
            this.Pre.Name = "Pre";
            this.Pre.ReadOnly = true;
            this.Pre.Width = 120;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Insumo";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Para venda";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Estoque";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 50;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Ped. Compra";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // btGravar
            // 
            this.btGravar.BackColor = System.Drawing.Color.Teal;
            this.btGravar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGravar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btGravar.Location = new System.Drawing.Point(868, 120);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(85, 23);
            this.btGravar.TabIndex = 13;
            this.btGravar.Text = "&GRAVAR";
            this.btGravar.UseVisualStyleBackColor = false;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(706, 120);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 14;
            this.btAlterar.Text = "&ALTERAR";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(787, 120);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 15;
            this.btExcluir.Text = "&EXCLUIR";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // txMarca
            // 
            this.txMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txMarca.Location = new System.Drawing.Point(353, 28);
            this.txMarca.Name = "txMarca";
            this.txMarca.Size = new System.Drawing.Size(220, 22);
            this.txMarca.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(534, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Ped. Compra";
            // 
            // txPedCompra
            // 
            // 
            // 
            // 
            this.txPedCompra.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txPedCompra.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txPedCompra.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txPedCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPedCompra.Increment = 1D;
            this.txPedCompra.Location = new System.Drawing.Point(537, 74);
            this.txPedCompra.Name = "txPedCompra";
            this.txPedCompra.Size = new System.Drawing.Size(92, 22);
            this.txPedCompra.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(350, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Marca";
            // 
            // rdInsumo
            // 
            this.rdInsumo.AutoSize = true;
            this.rdInsumo.Checked = true;
            this.rdInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdInsumo.Location = new System.Drawing.Point(652, 74);
            this.rdInsumo.Name = "rdInsumo";
            this.rdInsumo.Size = new System.Drawing.Size(151, 20);
            this.rdInsumo.TabIndex = 26;
            this.rdInsumo.TabStop = true;
            this.rdInsumo.Text = "Material para insumo";
            this.rdInsumo.UseVisualStyleBackColor = true;
            // 
            // rdVenda
            // 
            this.rdVenda.AutoSize = true;
            this.rdVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdVenda.Location = new System.Drawing.Point(809, 74);
            this.rdVenda.Name = "rdVenda";
            this.rdVenda.Size = new System.Drawing.Size(146, 20);
            this.rdVenda.TabIndex = 27;
            this.rdVenda.TabStop = true;
            this.rdVenda.Text = "Material para venda";
            this.rdVenda.UseVisualStyleBackColor = true;
            this.rdVenda.CheckedChanged += new System.EventHandler(this.rdInsumo_CheckedChanged);
            // 
            // txPesquisa
            // 
            this.txPesquisa.Location = new System.Drawing.Point(179, 123);
            this.txPesquisa.Name = "txPesquisa";
            this.txPesquisa.Size = new System.Drawing.Size(378, 20);
            this.txPesquisa.TabIndex = 28;
            this.txPesquisa.TextChanged += new System.EventHandler(this.txPesquisa_TextChanged);
            // 
            // cbFiltro
            // 
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "Descrição",
            "Marca",
            "Modelo",
            "Tipo",
            "Tamanho"});
            this.cbFiltro.Location = new System.Drawing.Point(21, 122);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(152, 21);
            this.cbFiltro.TabIndex = 29;
            this.cbFiltro.Text = "Descrição";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Filtro";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(176, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Pesquisa";
            // 
            // CadastroMateriais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.txPesquisa);
            this.Controls.Add(this.rdVenda);
            this.Controls.Add(this.rdInsumo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txPedCompra);
            this.Controls.Add(this.txMarca);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.dataGridMateriais);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txEstoque);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txPrecoVenda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txMargemLucro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txPrecoCusto);
            this.Controls.Add(this.txTamanho);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txModelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txDescricao);
            this.Controls.Add(this.label1);
            this.Name = "CadastroMateriais";
            this.Size = new System.Drawing.Size(970, 600);
            ((System.ComponentModel.ISupportInitialize)(this.txPrecoCusto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txMargemLucro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txPrecoVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMateriais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txPedCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txDescricao;
        private System.Windows.Forms.TextBox txModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txTamanho;
        private System.Windows.Forms.Label label4;
        private DevComponents.Editors.DoubleInput txPrecoCusto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevComponents.Editors.DoubleInput txMargemLucro;
        private System.Windows.Forms.Label label7;
        private DevComponents.Editors.DoubleInput txPrecoVenda;
        private System.Windows.Forms.Label label8;
        private DevComponents.Editors.DoubleInput txEstoque;
        private System.Windows.Forms.DataGridView dataGridMateriais;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.TextBox txMarca;
        private DevComponents.Editors.DoubleInput txPedCompra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdInsumo;
        private System.Windows.Forms.RadioButton rdVenda;
        private System.Windows.Forms.TextBox txPesquisa;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn p;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Label label12;
    }
}
