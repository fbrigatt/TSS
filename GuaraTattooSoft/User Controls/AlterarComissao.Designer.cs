namespace GuaraTattooSoft.User_Controls
{
    partial class AlterarComissao
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
            this.dataGridProfissionais = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sssss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAplicar = new System.Windows.Forms.Button();
            this.txComissao = new DevComponents.Editors.DoubleInput();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdApenasSel = new System.Windows.Forms.RadioButton();
            this.rdTodos = new System.Windows.Forms.RadioButton();
            this.rdApenasProfs = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfissionais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txComissao)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.sssss,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column5});
            this.dataGridProfissionais.Location = new System.Drawing.Point(3, 74);
            this.dataGridProfissionais.Name = "dataGridProfissionais";
            this.dataGridProfissionais.ReadOnly = true;
            this.dataGridProfissionais.Size = new System.Drawing.Size(677, 376);
            this.dataGridProfissionais.TabIndex = 0;
            this.dataGridProfissionais.SelectionChanged += new System.EventHandler(this.dataGridProfissionais_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cod";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // sssss
            // 
            this.sssss.HeaderText = "Nome ";
            this.sssss.Name = "sssss";
            this.sssss.ReadOnly = true;
            this.sssss.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Telefone";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 110;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CPF";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Salário (R$)";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Comissão (%)";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ativo";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 60;
            // 
            // btAplicar
            // 
            this.btAplicar.BackColor = System.Drawing.Color.Teal;
            this.btAplicar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAplicar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAplicar.Location = new System.Drawing.Point(572, 40);
            this.btAplicar.Name = "btAplicar";
            this.btAplicar.Size = new System.Drawing.Size(108, 31);
            this.btAplicar.TabIndex = 1;
            this.btAplicar.Text = "&APLICAR";
            this.btAplicar.UseVisualStyleBackColor = false;
            this.btAplicar.Click += new System.EventHandler(this.btAplicar_Click);
            // 
            // txComissao
            // 
            // 
            // 
            // 
            this.txComissao.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txComissao.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txComissao.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txComissao.Increment = 1D;
            this.txComissao.Location = new System.Drawing.Point(3, 30);
            this.txComissao.Name = "txComissao";
            this.txComissao.Size = new System.Drawing.Size(90, 38);
            this.txComissao.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdApenasSel);
            this.groupBox1.Controls.Add(this.rdTodos);
            this.groupBox1.Controls.Add(this.rdApenasProfs);
            this.groupBox1.Location = new System.Drawing.Point(99, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 50);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alterar";
            // 
            // rdApenasSel
            // 
            this.rdApenasSel.AutoSize = true;
            this.rdApenasSel.Location = new System.Drawing.Point(244, 19);
            this.rdApenasSel.Name = "rdApenasSel";
            this.rdApenasSel.Size = new System.Drawing.Size(121, 17);
            this.rdApenasSel.TabIndex = 7;
            this.rdApenasSel.TabStop = true;
            this.rdApenasSel.Text = "Apenas selecionado";
            this.rdApenasSel.UseVisualStyleBackColor = true;
            // 
            // rdTodos
            // 
            this.rdTodos.AutoSize = true;
            this.rdTodos.Location = new System.Drawing.Point(371, 19);
            this.rdTodos.Name = "rdTodos";
            this.rdTodos.Size = new System.Drawing.Size(55, 17);
            this.rdTodos.TabIndex = 7;
            this.rdTodos.Text = "Todos";
            this.rdTodos.UseVisualStyleBackColor = true;
            // 
            // rdApenasProfs
            // 
            this.rdApenasProfs.AutoSize = true;
            this.rdApenasProfs.Checked = true;
            this.rdApenasProfs.Location = new System.Drawing.Point(6, 19);
            this.rdApenasProfs.Name = "rdApenasProfs";
            this.rdApenasProfs.Size = new System.Drawing.Size(232, 17);
            this.rdApenasProfs.TabIndex = 6;
            this.rdApenasProfs.TabStop = true;
            this.rdApenasProfs.Text = "Apenas profissionais com esta porcentagem";
            this.rdApenasProfs.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Comissão (%)";
            // 
            // AlterarComissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txComissao);
            this.Controls.Add(this.btAplicar);
            this.Controls.Add(this.dataGridProfissionais);
            this.Name = "AlterarComissao";
            this.Size = new System.Drawing.Size(702, 453);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfissionais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txComissao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProfissionais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sssss;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btAplicar;
        private DevComponents.Editors.DoubleInput txComissao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTodos;
        private System.Windows.Forms.RadioButton rdApenasProfs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdApenasSel;
    }
}
