namespace GuaraTattooSoft.User_Controls
{
    partial class CadastroCampanhas
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
            this.dataGridCampanhas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btGravar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCampanhas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCampanhas
            // 
            this.dataGridCampanhas.AllowUserToAddRows = false;
            this.dataGridCampanhas.AllowUserToDeleteRows = false;
            this.dataGridCampanhas.AllowUserToOrderColumns = true;
            this.dataGridCampanhas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridCampanhas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridCampanhas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCampanhas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridCampanhas.Location = new System.Drawing.Point(6, 82);
            this.dataGridCampanhas.Name = "dataGridCampanhas";
            this.dataGridCampanhas.ReadOnly = true;
            this.dataGridCampanhas.Size = new System.Drawing.Size(407, 327);
            this.dataGridCampanhas.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cod";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descrição";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 350;
            // 
            // txDescricao
            // 
            this.txDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDescricao.Location = new System.Drawing.Point(6, 25);
            this.txDescricao.Name = "txDescricao";
            this.txDescricao.Size = new System.Drawing.Size(407, 22);
            this.txDescricao.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descrição";
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(163, 53);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 12;
            this.btAlterar.Text = "&ALTERAR";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(244, 53);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 11;
            this.btExcluir.Text = "&EXCLUIR";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btGravar
            // 
            this.btGravar.BackColor = System.Drawing.Color.Teal;
            this.btGravar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGravar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btGravar.Location = new System.Drawing.Point(325, 53);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(89, 23);
            this.btGravar.TabIndex = 10;
            this.btGravar.Text = "&GRAVAR";
            this.btGravar.UseVisualStyleBackColor = false;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // CadastroCampanhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.txDescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridCampanhas);
            this.Name = "CadastroCampanhas";
            this.Size = new System.Drawing.Size(419, 437);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCampanhas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCampanhas;
        private System.Windows.Forms.TextBox txDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
