namespace GuaraTattooSoft.Forms
{
    partial class PagConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagConta));
            this.label1 = new System.Windows.Forms.Label();
            this.txCod_conta = new DevComponents.Editors.IntegerInput();
            this.txVencimento = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txValor = new DevComponents.Editors.DoubleInput();
            this.label3 = new System.Windows.Forms.Label();
            this.txCod_mov = new DevComponents.Editors.IntegerInput();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCaixas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txObs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txValorPago = new DevComponents.Editors.DoubleInput();
            this.label7 = new System.Windows.Forms.Label();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txDestinatario = new System.Windows.Forms.TextBox();
            this.txEmitente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txCod_conta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txCod_mov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txValorPago)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código da conta";
            // 
            // txCod_conta
            // 
            // 
            // 
            // 
            this.txCod_conta.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txCod_conta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txCod_conta.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txCod_conta.DisabledBackColor = System.Drawing.Color.White;
            this.txCod_conta.Enabled = false;
            this.txCod_conta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCod_conta.IsInputReadOnly = true;
            this.txCod_conta.Location = new System.Drawing.Point(100, 67);
            this.txCod_conta.Name = "txCod_conta";
            this.txCod_conta.Size = new System.Drawing.Size(82, 22);
            this.txCod_conta.TabIndex = 1;
            // 
            // txVencimento
            // 
            this.txVencimento.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txVencimento.Location = new System.Drawing.Point(189, 67);
            this.txVencimento.Mask = "##/##/####";
            this.txVencimento.Name = "txVencimento";
            this.txVencimento.ReadOnly = true;
            this.txVencimento.Size = new System.Drawing.Size(100, 22);
            this.txVencimento.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vencimento";
            // 
            // txValor
            // 
            // 
            // 
            // 
            this.txValor.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txValor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txValor.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txValor.DisplayFormat = "N2";
            this.txValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txValor.Increment = 1D;
            this.txValor.IsInputReadOnly = true;
            this.txValor.Location = new System.Drawing.Point(296, 67);
            this.txValor.Name = "txValor";
            this.txValor.Size = new System.Drawing.Size(118, 22);
            this.txValor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor (R$)";
            // 
            // txCod_mov
            // 
            // 
            // 
            // 
            this.txCod_mov.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txCod_mov.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txCod_mov.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txCod_mov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCod_mov.IsInputReadOnly = true;
            this.txCod_mov.Location = new System.Drawing.Point(12, 67);
            this.txCod_mov.Name = "txCod_mov";
            this.txCod_mov.Size = new System.Drawing.Size(82, 22);
            this.txCod_mov.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cod. Movimento";
            // 
            // cbCaixas
            // 
            this.cbCaixas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCaixas.FormattingEnabled = true;
            this.cbCaixas.Location = new System.Drawing.Point(12, 111);
            this.cbCaixas.Name = "cbCaixas";
            this.cbCaixas.Size = new System.Drawing.Size(402, 24);
            this.cbCaixas.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Caixa";
            // 
            // txObs
            // 
            this.txObs.Location = new System.Drawing.Point(12, 156);
            this.txObs.Multiline = true;
            this.txObs.Name = "txObs";
            this.txObs.Size = new System.Drawing.Size(402, 74);
            this.txObs.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Observações";
            // 
            // txValorPago
            // 
            // 
            // 
            // 
            this.txValorPago.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txValorPago.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txValorPago.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txValorPago.DisplayFormat = "N2";
            this.txValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txValorPago.Increment = 1D;
            this.txValorPago.Location = new System.Drawing.Point(248, 248);
            this.txValorPago.MaxValue = 999999999D;
            this.txValorPago.MinValue = -999999999D;
            this.txValorPago.Name = "txValorPago";
            this.txValorPago.Size = new System.Drawing.Size(166, 38);
            this.txValorPago.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Valor pago (R$)";
            // 
            // btConfirmar
            // 
            this.btConfirmar.BackColor = System.Drawing.Color.Teal;
            this.btConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirmar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btConfirmar.Location = new System.Drawing.Point(319, 292);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(95, 23);
            this.btConfirmar.TabIndex = 14;
            this.btConfirmar.Text = "&CONFIRMAR";
            this.btConfirmar.UseVisualStyleBackColor = false;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Pagador";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Beneficiado";
            // 
            // txDestinatario
            // 
            this.txDestinatario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txDestinatario.Location = new System.Drawing.Point(219, 25);
            this.txDestinatario.Name = "txDestinatario";
            this.txDestinatario.ReadOnly = true;
            this.txDestinatario.Size = new System.Drawing.Size(195, 20);
            this.txDestinatario.TabIndex = 1;
            // 
            // txEmitente
            // 
            this.txEmitente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txEmitente.Location = new System.Drawing.Point(12, 25);
            this.txEmitente.Name = "txEmitente";
            this.txEmitente.ReadOnly = true;
            this.txEmitente.Size = new System.Drawing.Size(201, 20);
            this.txEmitente.TabIndex = 2;
            // 
            // PagConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(423, 322);
            this.Controls.Add(this.txEmitente);
            this.Controls.Add(this.txDestinatario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txValorPago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txObs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbCaixas);
            this.Controls.Add(this.txCod_mov);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txVencimento);
            this.Controls.Add(this.txCod_conta);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PagConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento / Recebimento de Conta";
            ((System.ComponentModel.ISupportInitialize)(this.txCod_conta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txCod_mov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txValorPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevComponents.Editors.IntegerInput txCod_conta;
        private System.Windows.Forms.MaskedTextBox txVencimento;
        private System.Windows.Forms.Label label2;
        private DevComponents.Editors.DoubleInput txValor;
        private System.Windows.Forms.Label label3;
        private DevComponents.Editors.IntegerInput txCod_mov;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCaixas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txObs;
        private System.Windows.Forms.Label label6;
        private DevComponents.Editors.DoubleInput txValorPago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txDestinatario;
        private System.Windows.Forms.TextBox txEmitente;
    }
}