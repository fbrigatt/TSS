namespace GuaraTattooSoft.Assistente
{
    partial class CadastroProfissionais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProfissionais));
            this.label1 = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.txTel_Cel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txCPF = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txComissao = new DevComponents.Editors.DoubleInput();
            this.btGravar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.dataGridProfissionais = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btProximo = new System.Windows.Forms.Button();
            this.txDataEntrada = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txComissao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfissionais)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do profissional";
            // 
            // txNome
            // 
            this.txNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome.Location = new System.Drawing.Point(12, 30);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(205, 22);
            this.txNome.TabIndex = 1;
            // 
            // txTel_Cel
            // 
            this.txTel_Cel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTel_Cel.Location = new System.Drawing.Point(223, 30);
            this.txTel_Cel.Name = "txTel_Cel";
            this.txTel_Cel.Size = new System.Drawing.Size(115, 22);
            this.txTel_Cel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefone / Celular";
            // 
            // txCPF
            // 
            this.txCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCPF.Location = new System.Drawing.Point(344, 30);
            this.txCPF.Mask = "###.###.###-##";
            this.txCPF.Name = "txCPF";
            this.txCPF.Size = new System.Drawing.Size(100, 22);
            this.txCPF.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data entrada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Comissão (%)";
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
            this.txComissao.Location = new System.Drawing.Point(119, 72);
            this.txComissao.Name = "txComissao";
            this.txComissao.Size = new System.Drawing.Size(92, 22);
            this.txComissao.TabIndex = 6;
            // 
            // btGravar
            // 
            this.btGravar.Location = new System.Drawing.Point(366, 106);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(75, 23);
            this.btGravar.TabIndex = 12;
            this.btGravar.Text = "&GRAVAR";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(285, 106);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 13;
            this.btExcluir.Text = "&EXCLUIR";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(204, 106);
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
            this.d,
            this.Column3,
            this.Column4,
            this.C});
            this.dataGridProfissionais.Location = new System.Drawing.Point(12, 135);
            this.dataGridProfissionais.Name = "dataGridProfissionais";
            this.dataGridProfissionais.ReadOnly = true;
            this.dataGridProfissionais.Size = new System.Drawing.Size(429, 215);
            this.dataGridProfissionais.TabIndex = 15;
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
            // d
            // 
            this.d.HeaderText = "Telefone";
            this.d.Name = "d";
            this.d.ReadOnly = true;
            this.d.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CPF";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Data entrada";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // C
            // 
            this.C.HeaderText = "Comissão";
            this.C.Name = "C";
            this.C.ReadOnly = true;
            this.C.Width = 80;
            // 
            // btProximo
            // 
            this.btProximo.BackColor = System.Drawing.Color.Teal;
            this.btProximo.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProximo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btProximo.Location = new System.Drawing.Point(344, 356);
            this.btProximo.Name = "btProximo";
            this.btProximo.Size = new System.Drawing.Size(97, 23);
            this.btProximo.TabIndex = 16;
            this.btProximo.Text = "&PRÓXIMO";
            this.btProximo.UseVisualStyleBackColor = false;
            this.btProximo.Click += new System.EventHandler(this.btProximo_Click);
            // 
            // txDataEntrada
            // 
            this.txDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDataEntrada.Location = new System.Drawing.Point(13, 72);
            this.txDataEntrada.Mask = "##/##/####";
            this.txDataEntrada.Name = "txDataEntrada";
            this.txDataEntrada.Size = new System.Drawing.Size(100, 22);
            this.txDataEntrada.TabIndex = 4;
            // 
            // CadastroProfissionais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(453, 384);
            this.Controls.Add(this.txDataEntrada);
            this.Controls.Add(this.btProximo);
            this.Controls.Add(this.dataGridProfissionais);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txComissao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txCPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txTel_Cel);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroProfissionais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Profissionais";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private DevComponents.Editors.DoubleInput txComissao;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.DataGridView dataGridProfissionais;
        private System.Windows.Forms.Button btProximo;
        private System.Windows.Forms.MaskedTextBox txDataEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn d;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
    }
}