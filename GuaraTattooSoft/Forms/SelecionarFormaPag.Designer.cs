namespace GuaraTattooSoft.Forms
{
    partial class SelecionarFormaPag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelecionarFormaPag));
            this.txPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridFormasPag = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.De = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFormasPag)).BeginInit();
            this.SuspendLayout();
            // 
            // txPesquisa
            // 
            this.txPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPesquisa.Location = new System.Drawing.Point(12, 29);
            this.txPesquisa.Name = "txPesquisa";
            this.txPesquisa.Size = new System.Drawing.Size(480, 22);
            this.txPesquisa.TabIndex = 0;
            this.txPesquisa.TextChanged += new System.EventHandler(this.txPesquisa_TextChanged);
            this.txPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txPesquisa_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisa por descrição";
            // 
            // dataGridFormasPag
            // 
            this.dataGridFormasPag.AllowUserToAddRows = false;
            this.dataGridFormasPag.AllowUserToDeleteRows = false;
            this.dataGridFormasPag.AllowUserToOrderColumns = true;
            this.dataGridFormasPag.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridFormasPag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFormasPag.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.De,
            this.Column2});
            this.dataGridFormasPag.Location = new System.Drawing.Point(12, 57);
            this.dataGridFormasPag.Name = "dataGridFormasPag";
            this.dataGridFormasPag.ReadOnly = true;
            this.dataGridFormasPag.Size = new System.Drawing.Size(480, 381);
            this.dataGridFormasPag.TabIndex = 2;
            this.dataGridFormasPag.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridFormasPag_KeyDown);
            this.dataGridFormasPag.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridFormasPag_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cod";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // De
            // 
            this.De.HeaderText = "Descrição";
            this.De.Name = "De";
            this.De.ReadOnly = true;
            this.De.Width = 350;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Parcelar";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 60;
            // 
            // btConfirmar
            // 
            this.btConfirmar.BackColor = System.Drawing.Color.Teal;
            this.btConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirmar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btConfirmar.Location = new System.Drawing.Point(403, 446);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(89, 23);
            this.btConfirmar.TabIndex = 3;
            this.btConfirmar.Text = "&CONFIRMAR";
            this.btConfirmar.UseVisualStyleBackColor = false;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // SelecionarFormaPag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(504, 481);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.dataGridFormasPag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelecionarFormaPag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleciona Forma de Pagamento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFormasPag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridFormasPag;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn De;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}