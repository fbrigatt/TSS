namespace GuaraTattooSoft.User_Controls
{
    partial class AberturaFechamentoCaixa
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
            this.txNomeUsuario = new System.Windows.Forms.TextBox();
            this.txCodUsuario = new DevComponents.Editors.IntegerInput();
            this.label2 = new System.Windows.Forms.Label();
            this.btAcao = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.cbCaixa = new System.Windows.Forms.ComboBox();
            this.txValor = new DevComponents.Editors.DoubleInput();
            this.lbValor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txCodUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txValor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caixa";
            // 
            // txNomeUsuario
            // 
            this.txNomeUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txNomeUsuario.Enabled = false;
            this.txNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNomeUsuario.Location = new System.Drawing.Point(77, 49);
            this.txNomeUsuario.Name = "txNomeUsuario";
            this.txNomeUsuario.Size = new System.Drawing.Size(298, 22);
            this.txNomeUsuario.TabIndex = 5;
            // 
            // txCodUsuario
            // 
            this.txCodUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // 
            // 
            this.txCodUsuario.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txCodUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txCodUsuario.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txCodUsuario.Enabled = false;
            this.txCodUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCodUsuario.Location = new System.Drawing.Point(19, 49);
            this.txCodUsuario.Name = "txCodUsuario";
            this.txCodUsuario.Size = new System.Drawing.Size(51, 22);
            this.txCodUsuario.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuário";
            // 
            // btAcao
            // 
            this.btAcao.BackColor = System.Drawing.Color.Teal;
            this.btAcao.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btAcao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAcao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAcao.Location = new System.Drawing.Point(242, 140);
            this.btAcao.Name = "btAcao";
            this.btAcao.Size = new System.Drawing.Size(132, 38);
            this.btAcao.TabIndex = 6;
            this.btAcao.Text = "&ABRIR CAIXA";
            this.btAcao.UseVisualStyleBackColor = false;
            this.btAcao.Click += new System.EventHandler(this.btAcao_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(264, 13);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(80, 16);
            this.lbStatus.TabIndex = 11;
            this.lbStatus.Text = "Status caixa";
            // 
            // cbCaixa
            // 
            this.cbCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCaixa.FormattingEnabled = true;
            this.cbCaixa.Location = new System.Drawing.Point(19, 93);
            this.cbCaixa.Name = "cbCaixa";
            this.cbCaixa.Size = new System.Drawing.Size(355, 24);
            this.cbCaixa.TabIndex = 12;
            this.cbCaixa.SelectedIndexChanged += new System.EventHandler(this.cbCaixa_SelectedIndexChanged);
            // 
            // txValor
            // 
            // 
            // 
            // 
            this.txValor.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txValor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txValor.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txValor.Increment = 1D;
            this.txValor.Location = new System.Drawing.Point(89, 140);
            this.txValor.Name = "txValor";
            this.txValor.Size = new System.Drawing.Size(149, 38);
            this.txValor.TabIndex = 13;
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(86, 124);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(54, 13);
            this.lbValor.TabIndex = 14;
            this.lbValor.Text = "Valor (R$)";
            // 
            // AberturaFechamentoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.txValor);
            this.Controls.Add(this.cbCaixa);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btAcao);
            this.Controls.Add(this.txNomeUsuario);
            this.Controls.Add(this.txCodUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AberturaFechamentoCaixa";
            this.Size = new System.Drawing.Size(428, 232);
            ((System.ComponentModel.ISupportInitialize)(this.txCodUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txNomeUsuario;
        private DevComponents.Editors.IntegerInput txCodUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAcao;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.ComboBox cbCaixa;
        private DevComponents.Editors.DoubleInput txValor;
        private System.Windows.Forms.Label lbValor;
    }
}
