namespace GuaraTattooSoft.User_Controls
{
    partial class RClientes_ListagemSimples
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
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btVisualizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txData_inicio = new System.Windows.Forms.DateTimePicker();
            this.txData_fim = new System.Windows.Forms.DateTimePicker();
            this.txCod_profissional = new DevComponents.Editors.IntegerInput();
            this.label5 = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txCod_profissional)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listagem simples";
            // 
            // cbFiltro
            // 
            this.cbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "Trazer todos",
            "Aniversariantes do mês",
            "Por data de cadastro",
            "Atendidos por profissional"});
            this.cbFiltro.Location = new System.Drawing.Point(12, 60);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(301, 26);
            this.cbFiltro.TabIndex = 1;
            this.cbFiltro.SelectedIndexChanged += new System.EventHandler(this.cbFiltro_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de filtro";
            // 
            // btVisualizar
            // 
            this.btVisualizar.BackColor = System.Drawing.Color.Teal;
            this.btVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVisualizar.ForeColor = System.Drawing.Color.White;
            this.btVisualizar.Location = new System.Drawing.Point(238, 262);
            this.btVisualizar.Name = "btVisualizar";
            this.btVisualizar.Size = new System.Drawing.Size(75, 23);
            this.btVisualizar.TabIndex = 3;
            this.btVisualizar.Text = "&Visualizar";
            this.btVisualizar.UseVisualStyleBackColor = false;
            this.btVisualizar.Click += new System.EventHandler(this.btVisualizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data inicial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data final";
            // 
            // txData_inicio
            // 
            this.txData_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txData_inicio.Location = new System.Drawing.Point(12, 112);
            this.txData_inicio.Name = "txData_inicio";
            this.txData_inicio.Size = new System.Drawing.Size(102, 20);
            this.txData_inicio.TabIndex = 6;
            // 
            // txData_fim
            // 
            this.txData_fim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txData_fim.Location = new System.Drawing.Point(153, 112);
            this.txData_fim.Name = "txData_fim";
            this.txData_fim.Size = new System.Drawing.Size(96, 20);
            this.txData_fim.TabIndex = 7;
            // 
            // txCod_profissional
            // 
            // 
            // 
            // 
            this.txCod_profissional.BackgroundStyle.BorderColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveText;
            this.txCod_profissional.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveText;
            this.txCod_profissional.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txCod_profissional.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txCod_profissional.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txCod_profissional.Location = new System.Drawing.Point(12, 162);
            this.txCod_profissional.Name = "txCod_profissional";
            this.txCod_profissional.Size = new System.Drawing.Size(62, 20);
            this.txCod_profissional.TabIndex = 8;
            this.txCod_profissional.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txCod_profissional_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Profissional";
            // 
            // txNome
            // 
            this.txNome.Enabled = false;
            this.txNome.Location = new System.Drawing.Point(81, 162);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(232, 20);
            this.txNome.TabIndex = 10;
            // 
            // RClientes_ListagemSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txCod_profissional);
            this.Controls.Add(this.txData_fim);
            this.Controls.Add(this.txData_inicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btVisualizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.label1);
            this.Name = "RClientes_ListagemSimples";
            this.Size = new System.Drawing.Size(326, 303);
            ((System.ComponentModel.ISupportInitialize)(this.txCod_profissional)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btVisualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txData_inicio;
        private System.Windows.Forms.DateTimePicker txData_fim;
        private DevComponents.Editors.IntegerInput txCod_profissional;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txNome;
    }
}
