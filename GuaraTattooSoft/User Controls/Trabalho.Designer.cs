namespace GuaraTattooSoft.User_Controls
{
    partial class Trabalho
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
            this.txDataServico = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txNome_usuario = new System.Windows.Forms.TextBox();
            this.txCod_usuario = new DevComponents.Editors.IntegerInput();
            this.txCodtipo_servico = new DevComponents.Editors.IntegerInput();
            this.label2 = new System.Windows.Forms.Label();
            this.txDescricaoTipo_servico = new System.Windows.Forms.TextBox();
            this.txCod_cliente = new DevComponents.Editors.IntegerInput();
            this.label3 = new System.Windows.Forms.Label();
            this.txNome_cliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txNome_caixa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txCod_caixa = new DevComponents.Editors.IntegerInput();
            this.txNome_profissional = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txCod_profissional = new DevComponents.Editors.IntegerInput();
            this.txDescricaoForma_pag = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txCodforma_pag = new DevComponents.Editors.IntegerInput();
            this.txObs = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btIncluir = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.txTotal_materiais = new DevComponents.Editors.DoubleInput();
            this.label10 = new System.Windows.Forms.Label();
            this.txValor_total = new DevComponents.Editors.DoubleInput();
            this.txValor_trabalho = new DevComponents.Editors.DoubleInput();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txDesconto = new DevComponents.Editors.DoubleInput();
            this.label13 = new System.Windows.Forms.Label();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.dataGridMateriais = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Q = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txCod_usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txCodtipo_servico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txCod_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txCod_caixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txCod_profissional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txCodforma_pag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txTotal_materiais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txValor_total)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txValor_trabalho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txDesconto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMateriais)).BeginInit();
            this.SuspendLayout();
            // 
            // txDataServico
            // 
            this.txDataServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDataServico.Location = new System.Drawing.Point(12, 29);
            this.txDataServico.Name = "txDataServico";
            this.txDataServico.Size = new System.Drawing.Size(238, 22);
            this.txDataServico.TabIndex = 1;
            this.txDataServico.Value = new System.DateTime(2016, 3, 19, 7, 22, 51, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data do serviço";
            // 
            // txNome_usuario
            // 
            this.txNome_usuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txNome_usuario.Enabled = false;
            this.txNome_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome_usuario.Location = new System.Drawing.Point(353, 29);
            this.txNome_usuario.Name = "txNome_usuario";
            this.txNome_usuario.Size = new System.Drawing.Size(252, 22);
            this.txNome_usuario.TabIndex = 0;
            // 
            // txCod_usuario
            // 
            this.txCod_usuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // 
            // 
            this.txCod_usuario.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txCod_usuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txCod_usuario.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txCod_usuario.Enabled = false;
            this.txCod_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCod_usuario.Location = new System.Drawing.Point(256, 29);
            this.txCod_usuario.Name = "txCod_usuario";
            this.txCod_usuario.Size = new System.Drawing.Size(90, 22);
            this.txCod_usuario.TabIndex = 2;
            // 
            // txCodtipo_servico
            // 
            // 
            // 
            // 
            this.txCodtipo_servico.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txCodtipo_servico.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txCodtipo_servico.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txCodtipo_servico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCodtipo_servico.Location = new System.Drawing.Point(12, 80);
            this.txCodtipo_servico.Name = "txCodtipo_servico";
            this.txCodtipo_servico.Size = new System.Drawing.Size(90, 22);
            this.txCodtipo_servico.TabIndex = 4;
            this.txCodtipo_servico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txCodtipo_servico_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de serviço";
            // 
            // txDescricaoTipo_servico
            // 
            this.txDescricaoTipo_servico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDescricaoTipo_servico.Location = new System.Drawing.Point(109, 80);
            this.txDescricaoTipo_servico.Name = "txDescricaoTipo_servico";
            this.txDescricaoTipo_servico.Size = new System.Drawing.Size(216, 22);
            this.txDescricaoTipo_servico.TabIndex = 0;
            // 
            // txCod_cliente
            // 
            // 
            // 
            // 
            this.txCod_cliente.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txCod_cliente.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txCod_cliente.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txCod_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCod_cliente.Location = new System.Drawing.Point(331, 80);
            this.txCod_cliente.Name = "txCod_cliente";
            this.txCod_cliente.Size = new System.Drawing.Size(90, 22);
            this.txCod_cliente.TabIndex = 5;
            this.txCod_cliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txCod_cliente_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cliente";
            // 
            // txNome_cliente
            // 
            this.txNome_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome_cliente.Location = new System.Drawing.Point(427, 80);
            this.txNome_cliente.Name = "txNome_cliente";
            this.txNome_cliente.Size = new System.Drawing.Size(212, 22);
            this.txNome_cliente.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Usuário";
            // 
            // txNome_caixa
            // 
            this.txNome_caixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome_caixa.Location = new System.Drawing.Point(707, 29);
            this.txNome_caixa.Name = "txNome_caixa";
            this.txNome_caixa.Size = new System.Drawing.Size(252, 22);
            this.txNome_caixa.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(608, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Caixa";
            // 
            // txCod_caixa
            // 
            // 
            // 
            // 
            this.txCod_caixa.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txCod_caixa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txCod_caixa.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txCod_caixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCod_caixa.Location = new System.Drawing.Point(611, 29);
            this.txCod_caixa.Name = "txCod_caixa";
            this.txCod_caixa.Size = new System.Drawing.Size(90, 22);
            this.txCod_caixa.TabIndex = 3;
            this.txCod_caixa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.integerInput4_KeyDown);
            // 
            // txNome_profissional
            // 
            this.txNome_profissional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome_profissional.Location = new System.Drawing.Point(743, 80);
            this.txNome_profissional.Name = "txNome_profissional";
            this.txNome_profissional.Size = new System.Drawing.Size(216, 22);
            this.txNome_profissional.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(644, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Profissional";
            // 
            // txCod_profissional
            // 
            // 
            // 
            // 
            this.txCod_profissional.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txCod_profissional.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txCod_profissional.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txCod_profissional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCod_profissional.Location = new System.Drawing.Point(647, 80);
            this.txCod_profissional.Name = "txCod_profissional";
            this.txCod_profissional.Size = new System.Drawing.Size(90, 22);
            this.txCod_profissional.TabIndex = 6;
            this.txCod_profissional.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txCod_profissional_KeyDown);
            // 
            // txDescricaoForma_pag
            // 
            this.txDescricaoForma_pag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDescricaoForma_pag.Location = new System.Drawing.Point(109, 125);
            this.txDescricaoForma_pag.Name = "txDescricaoForma_pag";
            this.txDescricaoForma_pag.Size = new System.Drawing.Size(216, 22);
            this.txDescricaoForma_pag.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Forma pag.";
            // 
            // txCodforma_pag
            // 
            // 
            // 
            // 
            this.txCodforma_pag.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txCodforma_pag.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txCodforma_pag.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txCodforma_pag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCodforma_pag.Location = new System.Drawing.Point(13, 125);
            this.txCodforma_pag.Name = "txCodforma_pag";
            this.txCodforma_pag.Size = new System.Drawing.Size(90, 22);
            this.txCodforma_pag.TabIndex = 7;
            this.txCodforma_pag.ValueChanged += new System.EventHandler(this.txCodforma_pag_ValueChanged);
            this.txCodforma_pag.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txCodforma_pag_KeyDown);
            // 
            // txObs
            // 
            this.txObs.Location = new System.Drawing.Point(13, 169);
            this.txObs.Multiline = true;
            this.txObs.Name = "txObs";
            this.txObs.Size = new System.Drawing.Size(946, 98);
            this.txObs.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Detalhes e observações sobre o serviço";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Materiais";
            // 
            // btIncluir
            // 
            this.btIncluir.Location = new System.Drawing.Point(575, 280);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(113, 23);
            this.btIncluir.TabIndex = 24;
            this.btIncluir.Text = "&INCLUIR";
            this.btIncluir.UseVisualStyleBackColor = true;
            this.btIncluir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(694, 279);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(113, 23);
            this.btRemover.TabIndex = 26;
            this.btRemover.Text = "&REMOVER";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.button3_Click);
            // 
            // txTotal_materiais
            // 
            // 
            // 
            // 
            this.txTotal_materiais.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txTotal_materiais.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txTotal_materiais.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txTotal_materiais.DisplayFormat = "N2";
            this.txTotal_materiais.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTotal_materiais.Increment = 1D;
            this.txTotal_materiais.Location = new System.Drawing.Point(814, 296);
            this.txTotal_materiais.Name = "txTotal_materiais";
            this.txTotal_materiais.Size = new System.Drawing.Size(145, 38);
            this.txTotal_materiais.TabIndex = 9;
            this.txTotal_materiais.Leave += new System.EventHandler(this.txTotal_materiais_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(811, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "VALOR EM MATERIAIS (R$)";
            // 
            // txValor_total
            // 
            // 
            // 
            // 
            this.txValor_total.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txValor_total.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txValor_total.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txValor_total.DisplayFormat = "N2";
            this.txValor_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txValor_total.Increment = 1D;
            this.txValor_total.Location = new System.Drawing.Point(816, 475);
            this.txValor_total.Name = "txValor_total";
            this.txValor_total.Size = new System.Drawing.Size(143, 38);
            this.txValor_total.TabIndex = 12;
            // 
            // txValor_trabalho
            // 
            // 
            // 
            // 
            this.txValor_trabalho.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txValor_trabalho.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txValor_trabalho.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txValor_trabalho.DisplayFormat = "N2";
            this.txValor_trabalho.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txValor_trabalho.Increment = 1D;
            this.txValor_trabalho.Location = new System.Drawing.Point(814, 356);
            this.txValor_trabalho.Name = "txValor_trabalho";
            this.txValor_trabalho.Size = new System.Drawing.Size(145, 38);
            this.txValor_trabalho.TabIndex = 10;
            this.txValor_trabalho.Leave += new System.EventHandler(this.txValor_trabalho_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(813, 340);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "VALOR DO TRABALHO (R$)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(816, 459);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "VALOR TOTAL (R$)";
            // 
            // txDesconto
            // 
            // 
            // 
            // 
            this.txDesconto.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txDesconto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txDesconto.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txDesconto.DisplayFormat = "N2";
            this.txDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDesconto.Increment = 1D;
            this.txDesconto.Location = new System.Drawing.Point(816, 417);
            this.txDesconto.Name = "txDesconto";
            this.txDesconto.Size = new System.Drawing.Size(143, 38);
            this.txDesconto.TabIndex = 11;
            this.txDesconto.ValueChanged += new System.EventHandler(this.txDesconto_ValueChanged);
            this.txDesconto.Enter += new System.EventHandler(this.txDesconto_Enter);
            this.txDesconto.Leave += new System.EventHandler(this.txDesconto_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(813, 401);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "DESCONTO (%)";
            // 
            // btFinalizar
            // 
            this.btFinalizar.BackColor = System.Drawing.Color.Teal;
            this.btFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinalizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btFinalizar.Location = new System.Drawing.Point(816, 550);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(143, 36);
            this.btFinalizar.TabIndex = 35;
            this.btFinalizar.Text = "&FINALIZAR";
            this.btFinalizar.UseVisualStyleBackColor = false;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // dataGridMateriais
            // 
            this.dataGridMateriais.AllowUserToAddRows = false;
            this.dataGridMateriais.AllowUserToDeleteRows = false;
            this.dataGridMateriais.AllowUserToOrderColumns = true;
            this.dataGridMateriais.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridMateriais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMateriais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column1,
            this.Column4,
            this.Column5,
            this.s,
            this.Q,
            this.Column6});
            this.dataGridMateriais.Location = new System.Drawing.Point(12, 308);
            this.dataGridMateriais.Name = "dataGridMateriais";
            this.dataGridMateriais.ReadOnly = true;
            this.dataGridMateriais.Size = new System.Drawing.Size(795, 278);
            this.dataGridMateriais.TabIndex = 36;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cod. ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 40;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Descrição";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Marca";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Modelo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tamanho";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // s
            // 
            this.s.HeaderText = "Valor UN (R$)";
            this.s.Name = "s";
            this.s.ReadOnly = true;
            // 
            // Q
            // 
            this.Q.HeaderText = "Quant.";
            this.Q.Name = "Q";
            this.Q.ReadOnly = true;
            this.Q.Width = 45;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Sub Total (R$)";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Trabalho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.dataGridMateriais);
            this.Controls.Add(this.btFinalizar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txDesconto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txValor_trabalho);
            this.Controls.Add(this.txValor_total);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txTotal_materiais);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btIncluir);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txObs);
            this.Controls.Add(this.txDescricaoForma_pag);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txCodforma_pag);
            this.Controls.Add(this.txNome_profissional);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txCod_profissional);
            this.Controls.Add(this.txNome_caixa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txCod_caixa);
            this.Controls.Add(this.txNome_usuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txCod_usuario);
            this.Controls.Add(this.txNome_cliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txCod_cliente);
            this.Controls.Add(this.txDescricaoTipo_servico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txCodtipo_servico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txDataServico);
            this.Name = "Trabalho";
            this.Size = new System.Drawing.Size(980, 600);
            ((System.ComponentModel.ISupportInitialize)(this.txCod_usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txCodtipo_servico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txCod_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txCod_caixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txCod_profissional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txCodforma_pag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txTotal_materiais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txValor_total)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txValor_trabalho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txDesconto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMateriais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker txDataServico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txNome_usuario;
        private DevComponents.Editors.IntegerInput txCod_usuario;
        private DevComponents.Editors.IntegerInput txCodtipo_servico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txDescricaoTipo_servico;
        private DevComponents.Editors.IntegerInput txCod_cliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txNome_cliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txNome_caixa;
        private System.Windows.Forms.Label label5;
        private DevComponents.Editors.IntegerInput txCod_caixa;
        private System.Windows.Forms.TextBox txNome_profissional;
        private System.Windows.Forms.Label label6;
        private DevComponents.Editors.IntegerInput txCod_profissional;
        private System.Windows.Forms.TextBox txDescricaoForma_pag;
        private System.Windows.Forms.Label label7;
        private DevComponents.Editors.IntegerInput txCodforma_pag;
        private System.Windows.Forms.TextBox txObs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Label label10;
        private DevComponents.Editors.DoubleInput txValor_trabalho;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private DevComponents.Editors.DoubleInput txDesconto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btFinalizar;
        public System.Windows.Forms.DataGridView dataGridMateriais;
        public DevComponents.Editors.DoubleInput txTotal_materiais;
        public DevComponents.Editors.DoubleInput txValor_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn s;
        private System.Windows.Forms.DataGridViewTextBoxColumn Q;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
