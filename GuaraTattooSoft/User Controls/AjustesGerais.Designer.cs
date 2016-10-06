namespace GuaraTattooSoft.User_Controls
{
    partial class AjustesGerais
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
            this.txEmail = new System.Windows.Forms.TextBox();
            this.txSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txImagemLogo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btEscolherImagem = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txProvedorEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txPorta = new DevComponents.Editors.IntegerInput();
            this.label5 = new System.Windows.Forms.Label();
            this.txRetorno_cliente = new DevComponents.Editors.IntegerInput();
            this.label9 = new System.Windows.Forms.Label();
            this.txCodTipo_serv = new DevComponents.Editors.IntegerInput();
            this.label10 = new System.Windows.Forms.Label();
            this.txDescricaoTipoServ = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txPorta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txRetorno_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txCodTipo_serv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // txEmail
            // 
            this.txEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txEmail.Location = new System.Drawing.Point(21, 32);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(296, 22);
            this.txEmail.TabIndex = 1;
            // 
            // txSenha
            // 
            this.txSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSenha.Location = new System.Drawing.Point(323, 32);
            this.txSenha.Name = "txSenha";
            this.txSenha.PasswordChar = '●';
            this.txSenha.Size = new System.Drawing.Size(207, 22);
            this.txSenha.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // txImagemLogo
            // 
            this.txImagemLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txImagemLogo.Location = new System.Drawing.Point(21, 76);
            this.txImagemLogo.Name = "txImagemLogo";
            this.txImagemLogo.Size = new System.Drawing.Size(427, 22);
            this.txImagemLogo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Imagem logo";
            // 
            // btEscolherImagem
            // 
            this.btEscolherImagem.Font = new System.Drawing.Font("Segoe Marker", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEscolherImagem.Location = new System.Drawing.Point(454, 76);
            this.btEscolherImagem.Name = "btEscolherImagem";
            this.btEscolherImagem.Size = new System.Drawing.Size(61, 22);
            this.btEscolherImagem.TabIndex = 6;
            this.btEscolherImagem.Text = ". . . ";
            this.btEscolherImagem.UseVisualStyleBackColor = true;
            this.btEscolherImagem.Click += new System.EventHandler(this.btEscolherImagem_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(709, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "&SALVAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txProvedorEmail
            // 
            this.txProvedorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txProvedorEmail.Location = new System.Drawing.Point(536, 32);
            this.txProvedorEmail.Name = "txProvedorEmail";
            this.txProvedorEmail.Size = new System.Drawing.Size(183, 22);
            this.txProvedorEmail.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(533, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Provedor de email";
            // 
            // txPorta
            // 
            // 
            // 
            // 
            this.txPorta.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txPorta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txPorta.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPorta.Location = new System.Drawing.Point(726, 32);
            this.txPorta.Name = "txPorta";
            this.txPorta.Size = new System.Drawing.Size(80, 22);
            this.txPorta.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(723, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Porta";
            // 
            // txRetorno_cliente
            // 
            // 
            // 
            // 
            this.txRetorno_cliente.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txRetorno_cliente.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txRetorno_cliente.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txRetorno_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txRetorno_cliente.Location = new System.Drawing.Point(725, 76);
            this.txRetorno_cliente.Name = "txRetorno_cliente";
            this.txRetorno_cliente.Size = new System.Drawing.Size(81, 22);
            this.txRetorno_cliente.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(521, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Retorno do cliente após o trabalho (dias)";
            // 
            // txCodTipo_serv
            // 
            // 
            // 
            // 
            this.txCodTipo_serv.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txCodTipo_serv.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txCodTipo_serv.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txCodTipo_serv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCodTipo_serv.Location = new System.Drawing.Point(21, 118);
            this.txCodTipo_serv.Name = "txCodTipo_serv";
            this.txCodTipo_serv.Size = new System.Drawing.Size(81, 22);
            this.txCodTipo_serv.TabIndex = 20;
            this.txCodTipo_serv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txCodTipo_serv_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Tipo de servico a agendar";
            // 
            // txDescricaoTipoServ
            // 
            this.txDescricaoTipoServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDescricaoTipoServ.Location = new System.Drawing.Point(108, 118);
            this.txDescricaoTipoServ.Name = "txDescricaoTipoServ";
            this.txDescricaoTipoServ.Size = new System.Drawing.Size(340, 22);
            this.txDescricaoTipoServ.TabIndex = 22;
            // 
            // AjustesGerais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.txDescricaoTipoServ);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txCodTipo_serv);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txRetorno_cliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txPorta);
            this.Controls.Add(this.txProvedorEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btEscolherImagem);
            this.Controls.Add(this.txImagemLogo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txEmail);
            this.Controls.Add(this.label1);
            this.Name = "AjustesGerais";
            this.Size = new System.Drawing.Size(847, 253);
            ((System.ComponentModel.ISupportInitialize)(this.txPorta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txRetorno_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txCodTipo_serv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.TextBox txSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txImagemLogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btEscolherImagem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txProvedorEmail;
        private System.Windows.Forms.Label label4;
        private DevComponents.Editors.IntegerInput txPorta;
        private System.Windows.Forms.Label label5;
        private DevComponents.Editors.IntegerInput txRetorno_cliente;
        private System.Windows.Forms.Label label9;
        private DevComponents.Editors.IntegerInput txCodTipo_serv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txDescricaoTipoServ;
    }
}
