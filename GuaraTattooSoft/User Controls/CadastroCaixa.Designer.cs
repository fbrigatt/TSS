namespace GuaraTattooSoft.User_Controls
{
    partial class CadastroCaixa
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
            this.txNomeCaixa = new System.Windows.Forms.TextBox();
            this.txNomeComputador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ckAlertaUsuario = new System.Windows.Forms.CheckBox();
            this.txHorario = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btGravar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.dataGridCaixas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCaixas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha um nome para o caixa";
            // 
            // txNomeCaixa
            // 
            this.txNomeCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNomeCaixa.Location = new System.Drawing.Point(18, 31);
            this.txNomeCaixa.Name = "txNomeCaixa";
            this.txNomeCaixa.Size = new System.Drawing.Size(292, 22);
            this.txNomeCaixa.TabIndex = 1;
            // 
            // txNomeComputador
            // 
            this.txNomeComputador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNomeComputador.Location = new System.Drawing.Point(316, 31);
            this.txNomeComputador.Name = "txNomeComputador";
            this.txNomeComputador.ReadOnly = true;
            this.txNomeComputador.Size = new System.Drawing.Size(264, 22);
            this.txNomeComputador.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do computador";
            // 
            // ckAlertaUsuario
            // 
            this.ckAlertaUsuario.AutoSize = true;
            this.ckAlertaUsuario.Location = new System.Drawing.Point(258, 84);
            this.ckAlertaUsuario.Name = "ckAlertaUsuario";
            this.ckAlertaUsuario.Size = new System.Drawing.Size(244, 17);
            this.ckAlertaUsuario.TabIndex = 4;
            this.ckAlertaUsuario.Text = "Alertar o usuário a fechar seu respectivo caixa";
            this.ckAlertaUsuario.UseVisualStyleBackColor = true;
            // 
            // txHorario
            // 
            this.txHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txHorario.Location = new System.Drawing.Point(508, 80);
            this.txHorario.Mask = "##:##:##";
            this.txHorario.Name = "txHorario";
            this.txHorario.Size = new System.Drawing.Size(72, 22);
            this.txHorario.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Horário";
            // 
            // btGravar
            // 
            this.btGravar.BackColor = System.Drawing.Color.Teal;
            this.btGravar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGravar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btGravar.Location = new System.Drawing.Point(491, 109);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(89, 23);
            this.btGravar.TabIndex = 7;
            this.btGravar.Text = "&GRAVAR";
            this.btGravar.UseVisualStyleBackColor = false;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(410, 109);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 8;
            this.btExcluir.Text = "&EXCLUIR";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(329, 109);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 9;
            this.btAlterar.Text = "&ALTERAR";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // dataGridCaixas
            // 
            this.dataGridCaixas.AllowUserToAddRows = false;
            this.dataGridCaixas.AllowUserToDeleteRows = false;
            this.dataGridCaixas.AllowUserToOrderColumns = true;
            this.dataGridCaixas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridCaixas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCaixas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridCaixas.Location = new System.Drawing.Point(18, 138);
            this.dataGridCaixas.Name = "dataGridCaixas";
            this.dataGridCaixas.ReadOnly = true;
            this.dataGridCaixas.Size = new System.Drawing.Size(562, 273);
            this.dataGridCaixas.TabIndex = 10;
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
            this.Column2.HeaderText = "Nome Caixa";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nome Micro";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Alertar usuário";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Horário";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 60;
            // 
            // CadastroCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.dataGridCaixas);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txHorario);
            this.Controls.Add(this.ckAlertaUsuario);
            this.Controls.Add(this.txNomeComputador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txNomeCaixa);
            this.Controls.Add(this.label1);
            this.Name = "CadastroCaixa";
            this.Size = new System.Drawing.Size(654, 432);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCaixas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txNomeCaixa;
        private System.Windows.Forms.TextBox txNomeComputador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckAlertaUsuario;
        private System.Windows.Forms.MaskedTextBox txHorario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.DataGridView dataGridCaixas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
