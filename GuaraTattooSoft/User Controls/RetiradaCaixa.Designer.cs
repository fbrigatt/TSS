namespace GuaraTattooSoft.User_Controls
{
    partial class RetiradaCaixa
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
            this.txNome_usuario = new System.Windows.Forms.TextBox();
            this.txCod_usuario = new DevComponents.Editors.IntegerInput();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCaixas = new System.Windows.Forms.ComboBox();
            this.txData = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txValorDisponivel = new DevComponents.Editors.DoubleInput();
            this.txObs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txValorRetirar = new DevComponents.Editors.DoubleInput();
            this.label6 = new System.Windows.Forms.Label();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdMes = new System.Windows.Forms.RadioButton();
            this.rdApenasHoje = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.txCod_usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txValorDisponivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txValorRetirar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
            // 
            // txNome_usuario
            // 
            this.txNome_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome_usuario.Location = new System.Drawing.Point(316, 28);
            this.txNome_usuario.Name = "txNome_usuario";
            this.txNome_usuario.Size = new System.Drawing.Size(234, 22);
            this.txNome_usuario.TabIndex = 50;
            // 
            // txCod_usuario
            // 
            // 
            // 
            // 
            this.txCod_usuario.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txCod_usuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txCod_usuario.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txCod_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCod_usuario.Location = new System.Drawing.Point(270, 28);
            this.txCod_usuario.Name = "txCod_usuario";
            this.txCod_usuario.Size = new System.Drawing.Size(40, 22);
            this.txCod_usuario.TabIndex = 2;
            this.txCod_usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txCod_usuario_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Caixa";
            // 
            // cbCaixas
            // 
            this.cbCaixas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCaixas.FormattingEnabled = true;
            this.cbCaixas.Location = new System.Drawing.Point(11, 76);
            this.cbCaixas.Name = "cbCaixas";
            this.cbCaixas.Size = new System.Drawing.Size(236, 24);
            this.cbCaixas.TabIndex = 30;
            this.cbCaixas.SelectedIndexChanged += new System.EventHandler(this.cbCaixas_SelectedIndexChanged);
            this.cbCaixas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbCaixas_MouseClick);
            // 
            // txData
            // 
            this.txData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txData.Location = new System.Drawing.Point(11, 28);
            this.txData.Name = "txData";
            this.txData.Size = new System.Drawing.Size(253, 22);
            this.txData.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor disponível (R$)";
            // 
            // txValorDisponivel
            // 
            this.txValorDisponivel.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txValorDisponivel.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txValorDisponivel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txValorDisponivel.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txValorDisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txValorDisponivel.Increment = 1D;
            this.txValorDisponivel.IsInputReadOnly = true;
            this.txValorDisponivel.Location = new System.Drawing.Point(253, 76);
            this.txValorDisponivel.Name = "txValorDisponivel";
            this.txValorDisponivel.Size = new System.Drawing.Size(105, 22);
            this.txValorDisponivel.TabIndex = 8;
            // 
            // txObs
            // 
            this.txObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txObs.Location = new System.Drawing.Point(11, 124);
            this.txObs.Multiline = true;
            this.txObs.Name = "txObs";
            this.txObs.Size = new System.Drawing.Size(539, 174);
            this.txObs.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Motivo";
            // 
            // txValorRetirar
            // 
            // 
            // 
            // 
            this.txValorRetirar.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txValorRetirar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txValorRetirar.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txValorRetirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txValorRetirar.Increment = 1D;
            this.txValorRetirar.Location = new System.Drawing.Point(385, 322);
            this.txValorRetirar.Name = "txValorRetirar";
            this.txValorRetirar.Size = new System.Drawing.Size(165, 38);
            this.txValorRetirar.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(382, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Valor a retirar (R$)";
            // 
            // btConfirmar
            // 
            this.btConfirmar.BackColor = System.Drawing.Color.Teal;
            this.btConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirmar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btConfirmar.Location = new System.Drawing.Point(429, 375);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(121, 31);
            this.btConfirmar.TabIndex = 13;
            this.btConfirmar.Text = "&CONFIRMAR";
            this.btConfirmar.UseVisualStyleBackColor = false;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdMes);
            this.groupBox1.Controls.Add(this.rdApenasHoje);
            this.groupBox1.Location = new System.Drawing.Point(364, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 43);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exibir valores";
            // 
            // rdMes
            // 
            this.rdMes.AutoSize = true;
            this.rdMes.Location = new System.Drawing.Point(104, 19);
            this.rdMes.Name = "rdMes";
            this.rdMes.Size = new System.Drawing.Size(76, 17);
            this.rdMes.TabIndex = 1;
            this.rdMes.Text = "Mês inteiro";
            this.rdMes.UseVisualStyleBackColor = true;
            this.rdMes.CheckedChanged += new System.EventHandler(this.rdMes_CheckedChanged);
            // 
            // rdApenasHoje
            // 
            this.rdApenasHoje.AutoSize = true;
            this.rdApenasHoje.Checked = true;
            this.rdApenasHoje.Location = new System.Drawing.Point(7, 19);
            this.rdApenasHoje.Name = "rdApenasHoje";
            this.rdApenasHoje.Size = new System.Drawing.Size(84, 17);
            this.rdApenasHoje.TabIndex = 0;
            this.rdApenasHoje.TabStop = true;
            this.rdApenasHoje.Text = "Apenas hoje";
            this.rdApenasHoje.UseVisualStyleBackColor = true;
            this.rdApenasHoje.CheckedChanged += new System.EventHandler(this.rdApenasHoje_CheckedChanged);
            // 
            // RetiradaCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txValorRetirar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txObs);
            this.Controls.Add(this.txValorDisponivel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txData);
            this.Controls.Add(this.cbCaixas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txCod_usuario);
            this.Controls.Add(this.txNome_usuario);
            this.Controls.Add(this.label1);
            this.Name = "RetiradaCaixa";
            this.Size = new System.Drawing.Size(557, 438);
            ((System.ComponentModel.ISupportInitialize)(this.txCod_usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txValorDisponivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txValorRetirar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txNome_usuario;
        private DevComponents.Editors.IntegerInput txCod_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCaixas;
        private System.Windows.Forms.DateTimePicker txData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevComponents.Editors.DoubleInput txValorDisponivel;
        private System.Windows.Forms.TextBox txObs;
        private System.Windows.Forms.Label label5;
        private DevComponents.Editors.DoubleInput txValorRetirar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdMes;
        private System.Windows.Forms.RadioButton rdApenasHoje;
        private System.Windows.Forms.Button btConfirmar;
    }
}
