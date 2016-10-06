namespace GuaraTattooSoft.User_Controls
{
    partial class CadastroUsuarios
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
            this.txSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ckCadCli = new System.Windows.Forms.CheckBox();
            this.ckCadProf = new System.Windows.Forms.CheckBox();
            this.ckLancaServ = new System.Windows.Forms.CheckBox();
            this.btGravar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.dataGridUsuarios = new System.Windows.Forms.DataGridView();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cadastrs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridTiposMov = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.descri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTiposMov)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txNome
            // 
            this.txNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome.Location = new System.Drawing.Point(13, 30);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(229, 22);
            this.txNome.TabIndex = 1;
            // 
            // txSenha
            // 
            this.txSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSenha.Location = new System.Drawing.Point(248, 30);
            this.txSenha.Name = "txSenha";
            this.txSenha.PasswordChar = '*';
            this.txSenha.Size = new System.Drawing.Size(185, 22);
            this.txSenha.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // ckCadCli
            // 
            this.ckCadCli.AutoSize = true;
            this.ckCadCli.Location = new System.Drawing.Point(13, 57);
            this.ckCadCli.Name = "ckCadCli";
            this.ckCadCli.Size = new System.Drawing.Size(122, 17);
            this.ckCadCli.TabIndex = 3;
            this.ckCadCli.Text = "Cadastro de clientes";
            this.ckCadCli.UseVisualStyleBackColor = true;
            // 
            // ckCadProf
            // 
            this.ckCadProf.AutoSize = true;
            this.ckCadProf.Location = new System.Drawing.Point(163, 56);
            this.ckCadProf.Name = "ckCadProf";
            this.ckCadProf.Size = new System.Drawing.Size(143, 17);
            this.ckCadProf.TabIndex = 4;
            this.ckCadProf.Text = "Cadastro de profissionais";
            this.ckCadProf.UseVisualStyleBackColor = true;
            // 
            // ckLancaServ
            // 
            this.ckLancaServ.AutoSize = true;
            this.ckLancaServ.Location = new System.Drawing.Point(334, 57);
            this.ckLancaServ.Name = "ckLancaServ";
            this.ckLancaServ.Size = new System.Drawing.Size(142, 17);
            this.ckLancaServ.TabIndex = 5;
            this.ckLancaServ.Text = "Lançamento de serviços";
            this.ckLancaServ.UseVisualStyleBackColor = true;
            // 
            // btGravar
            // 
            this.btGravar.BackColor = System.Drawing.Color.Teal;
            this.btGravar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGravar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btGravar.Location = new System.Drawing.Point(402, 93);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(74, 23);
            this.btGravar.TabIndex = 7;
            this.btGravar.Text = "&GRAVAR";
            this.btGravar.UseVisualStyleBackColor = false;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(321, 93);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 8;
            this.btExcluir.Text = "&EXCLUIR";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(240, 93);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 9;
            this.btAlterar.Text = "&ALTERAR";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // dataGridUsuarios
            // 
            this.dataGridUsuarios.AllowUserToAddRows = false;
            this.dataGridUsuarios.AllowUserToDeleteRows = false;
            this.dataGridUsuarios.AllowUserToOrderColumns = true;
            this.dataGridUsuarios.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Cadastrs,
            this.Column4});
            this.dataGridUsuarios.Location = new System.Drawing.Point(13, 122);
            this.dataGridUsuarios.Name = "dataGridUsuarios";
            this.dataGridUsuarios.ReadOnly = true;
            this.dataGridUsuarios.Size = new System.Drawing.Size(463, 348);
            this.dataGridUsuarios.TabIndex = 10;
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
            // Column2
            // 
            this.Column2.HeaderText = "Senha";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cadastro clientes";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 120;
            // 
            // Cadastrs
            // 
            this.Cadastrs.HeaderText = "Cadastro profissionais";
            this.Cadastrs.Name = "Cadastrs";
            this.Cadastrs.ReadOnly = true;
            this.Cadastrs.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Lancar serviços";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 130;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tipos de movimento para este usuário";
            this.label3.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(439, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 22);
            this.button1.TabIndex = 13;
            this.button1.Text = ". . .";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridTiposMov
            // 
            this.dataGridTiposMov.AllowUserToAddRows = false;
            this.dataGridTiposMov.AllowUserToDeleteRows = false;
            this.dataGridTiposMov.AllowUserToOrderColumns = true;
            this.dataGridTiposMov.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridTiposMov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTiposMov.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.descri});
            this.dataGridTiposMov.Location = new System.Drawing.Point(485, 30);
            this.dataGridTiposMov.Name = "dataGridTiposMov";
            this.dataGridTiposMov.ReadOnly = true;
            this.dataGridTiposMov.Size = new System.Drawing.Size(403, 440);
            this.dataGridTiposMov.TabIndex = 14;
            this.dataGridTiposMov.Visible = false;
            this.dataGridTiposMov.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTiposMov_CellContentClick);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cod";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 40;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Permitir";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 50;
            // 
            // descri
            // 
            this.descri.HeaderText = "Descrição";
            this.descri.Name = "descri";
            this.descri.ReadOnly = true;
            this.descri.Width = 270;
            // 
            // CadastroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.dataGridTiposMov);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridUsuarios);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.ckLancaServ);
            this.Controls.Add(this.ckCadProf);
            this.Controls.Add(this.ckCadCli);
            this.Controls.Add(this.txSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.label1);
            this.Name = "CadastroUsuarios";
            this.Size = new System.Drawing.Size(902, 492);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTiposMov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.TextBox txSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckCadCli;
        private System.Windows.Forms.CheckBox ckCadProf;
        private System.Windows.Forms.CheckBox ckLancaServ;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.DataGridView dataGridUsuarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cadastrs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridTiposMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn descri;
    }
}
