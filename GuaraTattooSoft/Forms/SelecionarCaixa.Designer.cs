namespace GuaraTattooSoft.Forms
{
    partial class SelecionarCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelecionarCaixa));
            this.txPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridCaixas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCaixas)).BeginInit();
            this.SuspendLayout();
            // 
            // txPesquisa
            // 
            this.txPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPesquisa.Location = new System.Drawing.Point(12, 32);
            this.txPesquisa.Name = "txPesquisa";
            this.txPesquisa.Size = new System.Drawing.Size(460, 22);
            this.txPesquisa.TabIndex = 0;
            this.txPesquisa.TextChanged += new System.EventHandler(this.txPesquisa_TextChanged);
            this.txPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txPesquisa_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisa por nome do caixa";
            // 
            // dataGridCaixas
            // 
            this.dataGridCaixas.AllowUserToAddRows = false;
            this.dataGridCaixas.AllowUserToDeleteRows = false;
            this.dataGridCaixas.AllowUserToOrderColumns = true;
            this.dataGridCaixas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridCaixas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCaixas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.N,
            this.Column2});
            this.dataGridCaixas.Location = new System.Drawing.Point(12, 61);
            this.dataGridCaixas.Name = "dataGridCaixas";
            this.dataGridCaixas.ReadOnly = true;
            this.dataGridCaixas.Size = new System.Drawing.Size(460, 379);
            this.dataGridCaixas.TabIndex = 2;
            this.dataGridCaixas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridCaixas_KeyDown);
            this.dataGridCaixas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridCaixas_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cod";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // N
            // 
            this.N.HeaderText = "Nome";
            this.N.Name = "N";
            this.N.ReadOnly = true;
            this.N.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nome do micro";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // btConfirmar
            // 
            this.btConfirmar.BackColor = System.Drawing.Color.Teal;
            this.btConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirmar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btConfirmar.Location = new System.Drawing.Point(379, 447);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(92, 23);
            this.btConfirmar.TabIndex = 3;
            this.btConfirmar.Text = "&CONFIRMAR";
            this.btConfirmar.UseVisualStyleBackColor = false;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // SelecionarCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(484, 481);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.dataGridCaixas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelecionarCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Caixa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCaixas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridCaixas;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}