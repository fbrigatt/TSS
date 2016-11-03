namespace GuaraTattooSoft.User_Controls
{
    partial class CadastroEstilos
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridEstilos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btGravar = new System.Windows.Forms.Button();
            this.txNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstilos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridEstilos
            // 
            this.dataGridEstilos.AllowUserToAddRows = false;
            this.dataGridEstilos.AllowUserToDeleteRows = false;
            this.dataGridEstilos.AllowUserToOrderColumns = true;
            this.dataGridEstilos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridEstilos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEstilos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridEstilos.Location = new System.Drawing.Point(3, 79);
            this.dataGridEstilos.Name = "dataGridEstilos";
            this.dataGridEstilos.ReadOnly = true;
            this.dataGridEstilos.Size = new System.Drawing.Size(473, 415);
            this.dataGridEstilos.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cod";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 350;
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(229, 50);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 9;
            this.btAlterar.Text = "&ALTERAR";
            this.btAlterar.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(310, 50);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 8;
            this.btExcluir.Text = "&EXCLUIR";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btGravar
            // 
            this.btGravar.BackColor = System.Drawing.Color.Teal;
            this.btGravar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btGravar.FlatAppearance.BorderSize = 0;
            this.btGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGravar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btGravar.Location = new System.Drawing.Point(391, 50);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(75, 23);
            this.btGravar.TabIndex = 7;
            this.btGravar.Text = "&GRAVAR";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // txNome
            // 
            this.txNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome.Location = new System.Drawing.Point(8, 22);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(458, 22);
            this.txNome.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // CadastroEstilos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridEstilos);
            this.Name = "CadastroEstilos";
            this.Size = new System.Drawing.Size(479, 497);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstilos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridEstilos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label label1;
    }
}
