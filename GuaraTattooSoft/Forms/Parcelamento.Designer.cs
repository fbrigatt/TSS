namespace GuaraTattooSoft.Forms
{
    partial class Parcelamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parcelamento));
            this.label1 = new System.Windows.Forms.Label();
            this.txValor = new DevComponents.Editors.DoubleInput();
            this.label2 = new System.Windows.Forms.Label();
            this.txParcelas = new DevComponents.Editors.IntegerInput();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridParcelas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.cbOperadoras = new System.Windows.Forms.ComboBox();
            this.cbOperacao = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txJuros = new DevComponents.Editors.DoubleInput();
            ((System.ComponentModel.ISupportInitialize)(this.txValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txJuros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operadora de cartão";
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
            this.txValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txValor.Increment = 1D;
            this.txValor.Location = new System.Drawing.Point(16, 80);
            this.txValor.Name = "txValor";
            this.txValor.Size = new System.Drawing.Size(120, 38);
            this.txValor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor do movimento (R$)";
            // 
            // txParcelas
            // 
            // 
            // 
            // 
            this.txParcelas.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txParcelas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txParcelas.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txParcelas.Location = new System.Drawing.Point(244, 80);
            this.txParcelas.MinValue = 0;
            this.txParcelas.Name = "txParcelas";
            this.txParcelas.ShowUpDown = true;
            this.txParcelas.Size = new System.Drawing.Size(72, 38);
            this.txParcelas.TabIndex = 5;
            this.txParcelas.ValueChanged += new System.EventHandler(this.txParcelas_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parcelas";
            // 
            // dataGridParcelas
            // 
            this.dataGridParcelas.AllowUserToAddRows = false;
            this.dataGridParcelas.AllowUserToDeleteRows = false;
            this.dataGridParcelas.AllowUserToOrderColumns = true;
            this.dataGridParcelas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3});
            this.dataGridParcelas.Location = new System.Drawing.Point(16, 125);
            this.dataGridParcelas.Name = "dataGridParcelas";
            this.dataGridParcelas.ReadOnly = true;
            this.dataGridParcelas.Size = new System.Drawing.Size(451, 320);
            this.dataGridParcelas.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Vencimento";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Valor (R$)";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 120;
            // 
            // btConfirmar
            // 
            this.btConfirmar.BackColor = System.Drawing.Color.Teal;
            this.btConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirmar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btConfirmar.Location = new System.Drawing.Point(371, 451);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(93, 23);
            this.btConfirmar.TabIndex = 8;
            this.btConfirmar.Text = "&CONFIRMAR";
            this.btConfirmar.UseVisualStyleBackColor = false;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // cbOperadoras
            // 
            this.cbOperadoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOperadoras.FormattingEnabled = true;
            this.cbOperadoras.Location = new System.Drawing.Point(17, 29);
            this.cbOperadoras.Name = "cbOperadoras";
            this.cbOperadoras.Size = new System.Drawing.Size(217, 24);
            this.cbOperadoras.TabIndex = 11;
            // 
            // cbOperacao
            // 
            this.cbOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOperacao.FormattingEnabled = true;
            this.cbOperacao.Items.AddRange(new object[] {
            "DÉBITO",
            "CRÉDITO"});
            this.cbOperacao.Location = new System.Drawing.Point(240, 29);
            this.cbOperacao.Name = "cbOperacao";
            this.cbOperacao.Size = new System.Drawing.Size(224, 24);
            this.cbOperacao.TabIndex = 12;
            this.cbOperacao.Text = "DÉBITO";
            this.cbOperacao.SelectedIndexChanged += new System.EventHandler(this.cbOperacao_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Modalidade de operação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Juros (%)";
            // 
            // txJuros
            // 
            // 
            // 
            // 
            this.txJuros.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txJuros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txJuros.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txJuros.DisplayFormat = "N2";
            this.txJuros.Enabled = false;
            this.txJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txJuros.Increment = 1D;
            this.txJuros.Location = new System.Drawing.Point(143, 81);
            this.txJuros.Name = "txJuros";
            this.txJuros.ShowUpDown = true;
            this.txJuros.Size = new System.Drawing.Size(91, 38);
            this.txJuros.TabIndex = 18;
            // 
            // Parcelamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(476, 483);
            this.Controls.Add(this.txJuros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbOperacao);
            this.Controls.Add(this.cbOperadoras);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.dataGridParcelas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txParcelas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txValor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Parcelamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parcelamento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Parcelamento_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.txValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txJuros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        public System.Windows.Forms.Label label1;
        public DevComponents.Editors.DoubleInput txValor;
        public System.Windows.Forms.Label label2;
        public DevComponents.Editors.IntegerInput txParcelas;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dataGridParcelas;
        public System.Windows.Forms.ComboBox cbOperadoras;
        public System.Windows.Forms.ComboBox cbOperacao;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public DevComponents.Editors.DoubleInput txJuros;
    }
}