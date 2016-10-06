namespace GuaraTattooSoft.User_Controls
{
    partial class ModelosEmail
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
            this.dataGridModelos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visualizar = new System.Windows.Forms.WebBrowser();
            this.btCriar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridModelos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridModelos
            // 
            this.dataGridModelos.AllowUserToAddRows = false;
            this.dataGridModelos.AllowUserToDeleteRows = false;
            this.dataGridModelos.AllowUserToOrderColumns = true;
            this.dataGridModelos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridModelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridModelos.Location = new System.Drawing.Point(4, 25);
            this.dataGridModelos.Name = "dataGridModelos";
            this.dataGridModelos.ReadOnly = true;
            this.dataGridModelos.Size = new System.Drawing.Size(258, 547);
            this.dataGridModelos.TabIndex = 0;
            this.dataGridModelos.SelectionChanged += new System.EventHandler(this.dataGridModelos_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Modelos Disponíveis";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 250;
            // 
            // visualizar
            // 
            this.visualizar.IsWebBrowserContextMenuEnabled = false;
            this.visualizar.Location = new System.Drawing.Point(269, 54);
            this.visualizar.MinimumSize = new System.Drawing.Size(20, 20);
            this.visualizar.Name = "visualizar";
            this.visualizar.Size = new System.Drawing.Size(628, 511);
            this.visualizar.TabIndex = 1;
            // 
            // btCriar
            // 
            this.btCriar.Location = new System.Drawing.Point(656, 25);
            this.btCriar.Name = "btCriar";
            this.btCriar.Size = new System.Drawing.Size(107, 23);
            this.btCriar.TabIndex = 3;
            this.btCriar.Text = "&Criar um modelo";
            this.btCriar.UseVisualStyleBackColor = true;
            this.btCriar.Click += new System.EventHandler(this.btCriar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(543, 25);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(107, 23);
            this.btExcluir.TabIndex = 4;
            this.btExcluir.Text = "&Excluir modelo";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(769, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "&Usar modelo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModelosEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btCriar);
            this.Controls.Add(this.visualizar);
            this.Controls.Add(this.dataGridModelos);
            this.Name = "ModelosEmail";
            this.Size = new System.Drawing.Size(900, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridModelos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridModelos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.WebBrowser visualizar;
        private System.Windows.Forms.Button btCriar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button button1;
    }
}
