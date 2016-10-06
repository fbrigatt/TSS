namespace GuaraTattooSoft.Relatorios.UserControls
{
    partial class RelatorioClientes
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
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txCod_Cliente = new DevComponents.Editors.IntegerInput();
            this.txNome_cliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txCod_Cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // cbModelo
            // 
            this.cbModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Items.AddRange(new object[] {
            "Modelo 01 - Listagem Simples",
            "Modelo 02 - Ficha completa de Cliente (Cadastro, Anamneses e Trabalhos)",
            "Modelo 03 - Agrupado por Data de Trabalho",
            "Modelo 04 - Agrupado por Mês de Aniversário",
            "Modelo 05 - Agrupado por Data de Cadastro",
            "Modelo 06 - Gráfico de Clientes Mais Rentáveis"});
            this.cbModelo.Location = new System.Drawing.Point(8, 31);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(663, 24);
            this.cbModelo.TabIndex = 0;
            this.cbModelo.Text = "Modelo 01 - Listagem Simples";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione o modelo de relatório";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selecionar o cliente";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(562, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "&VISUALIZAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txCod_Cliente
            // 
            // 
            // 
            // 
            this.txCod_Cliente.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txCod_Cliente.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txCod_Cliente.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txCod_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCod_Cliente.Location = new System.Drawing.Point(8, 86);
            this.txCod_Cliente.Name = "txCod_Cliente";
            this.txCod_Cliente.Size = new System.Drawing.Size(60, 22);
            this.txCod_Cliente.TabIndex = 4;
            this.txCod_Cliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txCod_Cliente_KeyDown);
            // 
            // txNome_cliente
            // 
            this.txNome_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome_cliente.Location = new System.Drawing.Point(75, 86);
            this.txNome_cliente.Name = "txNome_cliente";
            this.txNome_cliente.Size = new System.Drawing.Size(335, 22);
            this.txNome_cliente.TabIndex = 5;
            // 
            // RelatorioClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.txNome_cliente);
            this.Controls.Add(this.txCod_Cliente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbModelo);
            this.Name = "RelatorioClientes";
            this.Size = new System.Drawing.Size(682, 453);
            ((System.ComponentModel.ISupportInitialize)(this.txCod_Cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private DevComponents.Editors.IntegerInput txCod_Cliente;
        private System.Windows.Forms.TextBox txNome_cliente;
    }
}
