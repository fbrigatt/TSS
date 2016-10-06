namespace GuaraTattooSoft.Assistente
{
    partial class CadastroCaixas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCaixas));
            this.dataGridCaixas = new System.Windows.Forms.DataGridView();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.txNomeComputador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ckNotificarFechamento = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btGravar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txHoraAviso = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCaixas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCaixas
            // 
            this.dataGridCaixas.AllowUserToAddRows = false;
            this.dataGridCaixas.AllowUserToDeleteRows = false;
            this.dataGridCaixas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridCaixas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridCaixas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCaixas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod,
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3});
            this.dataGridCaixas.Location = new System.Drawing.Point(13, 139);
            this.dataGridCaixas.Name = "dataGridCaixas";
            this.dataGridCaixas.ReadOnly = true;
            this.dataGridCaixas.Size = new System.Drawing.Size(449, 152);
            this.dataGridCaixas.TabIndex = 1;
            // 
            // Cod
            // 
            this.Cod.HeaderText = "Cod";
            this.Cod.Name = "Cod";
            this.Cod.ReadOnly = true;
            this.Cod.Width = 40;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nome";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nome Computador";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Aviso";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Horário Aviso";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escolha um nome para o caixa";
            // 
            // txNome
            // 
            this.txNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome.Location = new System.Drawing.Point(16, 30);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(226, 22);
            this.txNome.TabIndex = 3;
            // 
            // txNomeComputador
            // 
            this.txNomeComputador.Enabled = false;
            this.txNomeComputador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNomeComputador.Location = new System.Drawing.Point(248, 30);
            this.txNomeComputador.Name = "txNomeComputador";
            this.txNomeComputador.Size = new System.Drawing.Size(214, 22);
            this.txNomeComputador.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome do computador";
            // 
            // ckNotificarFechamento
            // 
            this.ckNotificarFechamento.AutoSize = true;
            this.ckNotificarFechamento.Location = new System.Drawing.Point(17, 83);
            this.ckNotificarFechamento.Name = "ckNotificarFechamento";
            this.ckNotificarFechamento.Size = new System.Drawing.Size(347, 17);
            this.ckNotificarFechamento.TabIndex = 6;
            this.ckNotificarFechamento.Text = "Avisar o respectivo usuário a realizar a contagem e fechar seu caixa";
            this.ckNotificarFechamento.UseVisualStyleBackColor = true;
            this.ckNotificarFechamento.CheckedChanged += new System.EventHandler(this.ckNotificarFechamento_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Horário do aviso";
            // 
            // btGravar
            // 
            this.btGravar.Location = new System.Drawing.Point(367, 110);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(95, 23);
            this.btGravar.TabIndex = 8;
            this.btGravar.Text = "&GRAVAR";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(198, 110);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(74, 23);
            this.btAlterar.TabIndex = 9;
            this.btAlterar.Text = "&ALTERAR";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(278, 110);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(86, 23);
            this.btExcluir.TabIndex = 10;
            this.btExcluir.Text = "&EXCLUIR";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Teal;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(388, 329);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "&PRÓXIMO";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(13, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(421, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "NOTA: É IMPORTANTE QUE OS CAIXAS SIGAM UM BOM PADRÃO DE CADASTRO";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(13, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(418, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "POSTERIORMENTE, PODE SER QUE NÃO SEJA POSSÍVEL \"EXCLUIR\" UM CAIXA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Location = new System.Drawing.Point(89, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ex.: Caixa Manhã, Caixa Tarde";
            // 
            // txHoraAviso
            // 
            this.txHoraAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txHoraAviso.Location = new System.Drawing.Point(367, 78);
            this.txHoraAviso.Mask = "##:##:##";
            this.txHoraAviso.Name = "txHoraAviso";
            this.txHoraAviso.Size = new System.Drawing.Size(95, 22);
            this.txHoraAviso.TabIndex = 15;
            // 
            // CadastroCaixas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(474, 364);
            this.Controls.Add(this.txHoraAviso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ckNotificarFechamento);
            this.Controls.Add(this.txNomeComputador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridCaixas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroCaixas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro e configuração dos caixas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCaixas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridCaixas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.TextBox txNomeComputador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckNotificarFechamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.MaskedTextBox txHoraAviso;
    }
}