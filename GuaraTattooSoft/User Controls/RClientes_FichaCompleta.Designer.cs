namespace GuaraTattooSoft.User_Controls
{
    partial class RClientes_FichaCompleta
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
            this.label5 = new System.Windows.Forms.Label();
            this.txCod_Cliente = new DevComponents.Editors.IntegerInput();
            this.btVisualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txCod_Cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ficha completa do cliente";
            // 
            // txNome
            // 
            this.txNome.Enabled = false;
            this.txNome.Location = new System.Drawing.Point(79, 66);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(232, 20);
            this.txNome.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cliente";
            // 
            // txCod_Cliente
            // 
            // 
            // 
            // 
            this.txCod_Cliente.BackgroundStyle.BorderColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveText;
            this.txCod_Cliente.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveText;
            this.txCod_Cliente.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txCod_Cliente.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txCod_Cliente.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txCod_Cliente.Location = new System.Drawing.Point(10, 66);
            this.txCod_Cliente.Name = "txCod_Cliente";
            this.txCod_Cliente.Size = new System.Drawing.Size(62, 20);
            this.txCod_Cliente.TabIndex = 11;
            this.txCod_Cliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txCod_Cliente_KeyDown);
            // 
            // btVisualizar
            // 
            this.btVisualizar.BackColor = System.Drawing.Color.Teal;
            this.btVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVisualizar.ForeColor = System.Drawing.Color.White;
            this.btVisualizar.Location = new System.Drawing.Point(224, 255);
            this.btVisualizar.Name = "btVisualizar";
            this.btVisualizar.Size = new System.Drawing.Size(87, 28);
            this.btVisualizar.TabIndex = 14;
            this.btVisualizar.Text = "&Visualizar";
            this.btVisualizar.UseVisualStyleBackColor = false;
            this.btVisualizar.Click += new System.EventHandler(this.btVisualizar_Click);
            // 
            // RClientes_FichaCompleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btVisualizar);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txCod_Cliente);
            this.Controls.Add(this.label1);
            this.Name = "RClientes_FichaCompleta";
            this.Size = new System.Drawing.Size(326, 303);
            ((System.ComponentModel.ISupportInitialize)(this.txCod_Cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label label5;
        private DevComponents.Editors.IntegerInput txCod_Cliente;
        private System.Windows.Forms.Button btVisualizar;
    }
}
