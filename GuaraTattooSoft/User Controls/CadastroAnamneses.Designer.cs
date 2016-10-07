namespace GuaraTattooSoft.User_Controls
{
    partial class CadastroAnamneses
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
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.dataGridAnamneses = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btGravar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAnamneses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição da anamnese";
            // 
            // txDescricao
            // 
            this.txDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDescricao.Location = new System.Drawing.Point(6, 20);
            this.txDescricao.Name = "txDescricao";
            this.txDescricao.Size = new System.Drawing.Size(458, 22);
            this.txDescricao.TabIndex = 1;
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(308, 48);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 3;
            this.btExcluir.Text = "&EXCLUIR";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(227, 48);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 4;
            this.btAlterar.Text = "&ALTERAR";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // dataGridAnamneses
            // 
            this.dataGridAnamneses.AllowUserToAddRows = false;
            this.dataGridAnamneses.AllowUserToDeleteRows = false;
            this.dataGridAnamneses.AllowUserToOrderColumns = true;
            this.dataGridAnamneses.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridAnamneses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAnamneses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Descrição});
            this.dataGridAnamneses.Location = new System.Drawing.Point(6, 77);
            this.dataGridAnamneses.Name = "dataGridAnamneses";
            this.dataGridAnamneses.ReadOnly = true;
            this.dataGridAnamneses.Size = new System.Drawing.Size(458, 350);
            this.dataGridAnamneses.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cod";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // Descrição
            // 
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            this.Descrição.ReadOnly = true;
            this.Descrição.Width = 375;
            // 
            // btGravar
            // 
            this.btGravar.BackColor = System.Drawing.Color.Teal;
            this.btGravar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btGravar.FlatAppearance.BorderSize = 0;
            this.btGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGravar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btGravar.Location = new System.Drawing.Point(389, 48);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(75, 23);
            this.btGravar.TabIndex = 2;
            this.btGravar.Text = "&GRAVAR";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            this.btGravar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btGravar_MouseDown);
            // 
            // CadastroAnamneses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.dataGridAnamneses);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.txDescricao);
            this.Controls.Add(this.label1);
            this.Name = "CadastroAnamneses";
            this.Size = new System.Drawing.Size(498, 453);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAnamneses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txDescricao;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.DataGridView dataGridAnamneses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.Button btGravar;
    }
}
