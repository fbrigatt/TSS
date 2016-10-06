namespace GuaraTattooSoft.User_Controls
{
    partial class CadastroOperadorasCartao
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
            this.ckAtivo = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txDebito = new DevComponents.Editors.IntegerInput();
            this.label2 = new System.Windows.Forms.Label();
            this.txCredito = new DevComponents.Editors.IntegerInput();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridOperadoras = new System.Windows.Forms.DataGridView();
            this.btGravar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txTaxa = new DevComponents.Editors.DoubleInput();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txDebito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txCredito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOperadoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txTaxa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da operadora";
            // 
            // txNome
            // 
            this.txNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome.Location = new System.Drawing.Point(17, 32);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(427, 22);
            this.txNome.TabIndex = 1;
            // 
            // ckAtivo
            // 
            this.ckAtivo.AutoSize = true;
            this.ckAtivo.Checked = true;
            this.ckAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckAtivo.Location = new System.Drawing.Point(450, 32);
            this.ckAtivo.Name = "ckAtivo";
            this.ckAtivo.Size = new System.Drawing.Size(57, 20);
            this.ckAtivo.TabIndex = 2;
            this.ckAtivo.Text = "Ativo";
            this.ckAtivo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txTaxa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txDebito);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txCredito);
            this.groupBox1.Location = new System.Drawing.Point(17, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 82);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prazos para recebimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Débito (horas)";
            // 
            // txDebito
            // 
            // 
            // 
            // 
            this.txDebito.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txDebito.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txDebito.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDebito.Location = new System.Drawing.Point(107, 41);
            this.txDebito.Name = "txDebito";
            this.txDebito.Size = new System.Drawing.Size(65, 22);
            this.txDebito.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Crédito (dias)";
            // 
            // txCredito
            // 
            // 
            // 
            // 
            this.txCredito.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txCredito.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txCredito.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCredito.Location = new System.Drawing.Point(18, 41);
            this.txCredito.Name = "txCredito";
            this.txCredito.Size = new System.Drawing.Size(65, 22);
            this.txCredito.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Taxa (%)";
            // 
            // dataGridOperadoras
            // 
            this.dataGridOperadoras.AllowUserToAddRows = false;
            this.dataGridOperadoras.AllowUserToDeleteRows = false;
            this.dataGridOperadoras.AllowUserToOrderColumns = true;
            this.dataGridOperadoras.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridOperadoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOperadoras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.s,
            this.Cs,
            this.d,
            this.Column3});
            this.dataGridOperadoras.Location = new System.Drawing.Point(17, 179);
            this.dataGridOperadoras.Name = "dataGridOperadoras";
            this.dataGridOperadoras.ReadOnly = true;
            this.dataGridOperadoras.Size = new System.Drawing.Size(490, 303);
            this.dataGridOperadoras.TabIndex = 8;
            // 
            // btGravar
            // 
            this.btGravar.BackColor = System.Drawing.Color.Teal;
            this.btGravar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGravar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btGravar.Location = new System.Drawing.Point(431, 150);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(75, 23);
            this.btGravar.TabIndex = 6;
            this.btGravar.Text = "&GRAVAR";
            this.btGravar.UseVisualStyleBackColor = false;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(350, 150);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 6;
            this.btExcluir.Text = "&EXCLUIR";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(269, 150);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 7;
            this.btAlterar.Text = "&ALTERAR";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
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
            this.Column2.Width = 150;
            // 
            // s
            // 
            this.s.HeaderText = "Ativo";
            this.s.Name = "s";
            this.s.ReadOnly = true;
            this.s.Width = 50;
            // 
            // Cs
            // 
            this.Cs.HeaderText = "Credito (dias)";
            this.Cs.Name = "Cs";
            this.Cs.ReadOnly = true;
            // 
            // d
            // 
            this.d.HeaderText = "Débito (horas)";
            this.d.Name = "d";
            this.d.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Taxa (%)";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // txTaxa
            // 
            // 
            // 
            // 
            this.txTaxa.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txTaxa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txTaxa.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txTaxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTaxa.Increment = 1D;
            this.txTaxa.Location = new System.Drawing.Point(203, 41);
            this.txTaxa.Name = "txTaxa";
            this.txTaxa.Size = new System.Drawing.Size(65, 22);
            this.txTaxa.TabIndex = 5;
            // 
            // CadastroOperadorasCartao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.dataGridOperadoras);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ckAtivo);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.label1);
            this.Name = "CadastroOperadorasCartao";
            this.Size = new System.Drawing.Size(891, 517);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txDebito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txCredito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOperadoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txTaxa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.CheckBox ckAtivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.Editors.IntegerInput txCredito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevComponents.Editors.IntegerInput txDebito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridOperadoras;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn s;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cs;
        private System.Windows.Forms.DataGridViewTextBoxColumn d;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private DevComponents.Editors.DoubleInput txTaxa;
    }
}
