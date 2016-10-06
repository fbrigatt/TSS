namespace GuaraTattooSoft.Forms
{
    partial class AdicionarItensMov
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarItensMov));
            this.dataGridItens = new System.Windows.Forms.DataGridView();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.dataGridMateriais = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txPesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btRemover = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txQNTD = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMateriais)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridItens
            // 
            this.dataGridItens.AllowUserToAddRows = false;
            this.dataGridItens.AllowUserToDeleteRows = false;
            this.dataGridItens.AllowUserToOrderColumns = true;
            this.dataGridItens.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItens.Location = new System.Drawing.Point(609, 79);
            this.dataGridItens.Name = "dataGridItens";
            this.dataGridItens.ReadOnly = true;
            this.dataGridItens.Size = new System.Drawing.Size(382, 443);
            this.dataGridItens.TabIndex = 0;
            // 
            // btConfirmar
            // 
            this.btConfirmar.BackColor = System.Drawing.Color.Teal;
            this.btConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirmar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btConfirmar.Location = new System.Drawing.Point(902, 528);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(89, 23);
            this.btConfirmar.TabIndex = 1;
            this.btConfirmar.Text = "&CONFIRMAR";
            this.btConfirmar.UseVisualStyleBackColor = false;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // dataGridMateriais
            // 
            this.dataGridMateriais.AllowUserToAddRows = false;
            this.dataGridMateriais.AllowUserToDeleteRows = false;
            this.dataGridMateriais.AllowUserToOrderColumns = true;
            this.dataGridMateriais.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridMateriais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMateriais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column2,
            this.Mod,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridMateriais.Location = new System.Drawing.Point(12, 79);
            this.dataGridMateriais.Name = "dataGridMateriais";
            this.dataGridMateriais.ReadOnly = true;
            this.dataGridMateriais.Size = new System.Drawing.Size(511, 472);
            this.dataGridMateriais.TabIndex = 2;
            this.dataGridMateriais.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridMateriais_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cod";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Descrição";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 250;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Marca";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Mod
            // 
            this.Mod.HeaderText = "Modelo";
            this.Mod.Name = "Mod";
            this.Mod.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tipo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tamanho";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Valor UN. (R$)";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // txPesquisa
            // 
            this.txPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPesquisa.Location = new System.Drawing.Point(12, 26);
            this.txPesquisa.Name = "txPesquisa";
            this.txPesquisa.Size = new System.Drawing.Size(381, 24);
            this.txPesquisa.TabIndex = 5;
            this.txPesquisa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pesquisa por descrição";
            // 
            // btRemover
            // 
            this.btRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemover.Location = new System.Drawing.Point(529, 209);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(74, 36);
            this.btRemover.TabIndex = 7;
            this.btRemover.Text = "<";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(525, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quant";
            // 
            // txQNTD
            // 
            this.txQNTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txQNTD.Location = new System.Drawing.Point(529, 156);
            this.txQNTD.Name = "txQNTD";
            this.txQNTD.Size = new System.Drawing.Size(74, 31);
            this.txQNTD.TabIndex = 11;
            this.txQNTD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txQNTD_KeyDown_1);
            this.txQNTD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txQNTD_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(529, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Materiais em estoque:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(606, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Materiais a serem adicionados:";
            // 
            // AdicionarItensMov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1003, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txQNTD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txPesquisa);
            this.Controls.Add(this.dataGridMateriais);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.dataGridItens);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdicionarItensMov";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Itens do movimento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMateriais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.DataGridView dataGridMateriais;
        private System.Windows.Forms.TextBox txPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dataGridItens;
        private System.Windows.Forms.TextBox txQNTD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}