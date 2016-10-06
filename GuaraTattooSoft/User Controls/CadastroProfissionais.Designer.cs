namespace GuaraTattooSoft.User_Controls
{
    partial class CadastroProfissionais
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
            this.txNome = new System.Windows.Forms.TextBox();
            this.txTel_Cel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txCPF = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txDataEntrada = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txComissao = new DevComponents.Editors.DoubleInput();
            this.label6 = new System.Windows.Forms.Label();
            this.btGravar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.dataGridProfissionais = new System.Windows.Forms.DataGridView();
            this.ckAtivo = new System.Windows.Forms.CheckBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comiss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txComissao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfissionais)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do profissional";
            // 
            // txNome
            // 
            this.txNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome.Location = new System.Drawing.Point(16, 31);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(340, 22);
            this.txNome.TabIndex = 1;
            // 
            // txTel_Cel
            // 
            this.txTel_Cel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTel_Cel.Location = new System.Drawing.Point(362, 31);
            this.txTel_Cel.Name = "txTel_Cel";
            this.txTel_Cel.Size = new System.Drawing.Size(129, 22);
            this.txTel_Cel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone/Celular";
            // 
            // txCPF
            // 
            this.txCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCPF.Location = new System.Drawing.Point(497, 31);
            this.txCPF.Mask = "###.###.###-##";
            this.txCPF.Name = "txCPF";
            this.txCPF.Size = new System.Drawing.Size(100, 22);
            this.txCPF.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPF";
            // 
            // txDataEntrada
            // 
            this.txDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDataEntrada.Location = new System.Drawing.Point(603, 31);
            this.txDataEntrada.Mask = "##/##/####";
            this.txDataEntrada.Name = "txDataEntrada";
            this.txDataEntrada.Size = new System.Drawing.Size(88, 22);
            this.txDataEntrada.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(604, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data entrada";
            // 
            // txComissao
            // 
            // 
            // 
            // 
            this.txComissao.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txComissao.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txComissao.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txComissao.Increment = 1D;
            this.txComissao.Location = new System.Drawing.Point(697, 31);
            this.txComissao.Name = "txComissao";
            this.txComissao.Size = new System.Drawing.Size(80, 22);
            this.txComissao.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(694, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Comissão (%)";
            // 
            // btGravar
            // 
            this.btGravar.BackColor = System.Drawing.Color.Teal;
            this.btGravar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGravar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btGravar.Location = new System.Drawing.Point(702, 92);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(75, 23);
            this.btGravar.TabIndex = 12;
            this.btGravar.Text = "&GRAVAR";
            this.btGravar.UseVisualStyleBackColor = false;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(621, 92);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 13;
            this.btExcluir.Text = "&EXCLUIR";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(540, 92);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 14;
            this.btAlterar.Text = "&ALTERAR";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
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
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Comiss,
            this.Column7});
            this.dataGridProfissionais.Location = new System.Drawing.Point(16, 121);
            this.dataGridProfissionais.Name = "dataGridProfissionais";
            this.dataGridProfissionais.ReadOnly = true;
            this.dataGridProfissionais.Size = new System.Drawing.Size(761, 392);
            this.dataGridProfissionais.TabIndex = 15;
            // 
            // ckAtivo
            // 
            this.ckAtivo.AutoSize = true;
            this.ckAtivo.Checked = true;
            this.ckAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckAtivo.Location = new System.Drawing.Point(727, 65);
            this.ckAtivo.Name = "ckAtivo";
            this.ckAtivo.Size = new System.Drawing.Size(50, 17);
            this.ckAtivo.TabIndex = 16;
            this.ckAtivo.Text = "Ativo";
            this.ckAtivo.UseVisualStyleBackColor = true;
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
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 260;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Telefone/Celular";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "CPF";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Data entrada";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Comiss
            // 
            this.Comiss.HeaderText = "Comissão (%)";
            this.Comiss.Name = "Comiss";
            this.Comiss.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ativo";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 50;
            // 
            // CadastroProfissionais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.ckAtivo);
            this.Controls.Add(this.dataGridProfissionais);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txComissao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txDataEntrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txCPF);
            this.Controls.Add(this.txTel_Cel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.label1);
            this.Name = "CadastroProfissionais";
            this.Size = new System.Drawing.Size(820, 526);
            ((System.ComponentModel.ISupportInitialize)(this.txComissao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfissionais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.TextBox txTel_Cel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txDataEntrada;
        private System.Windows.Forms.Label label4;
        private DevComponents.Editors.DoubleInput txComissao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.DataGridView dataGridProfissionais;
        private System.Windows.Forms.CheckBox ckAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comiss;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}
