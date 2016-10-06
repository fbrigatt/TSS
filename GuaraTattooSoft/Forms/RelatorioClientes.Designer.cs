namespace GuaraTattooSoft.Forms
{
    partial class RelatorioClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridModelos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.painelVis = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridModelos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modelo";
            // 
            // dataGridModelos
            // 
            this.dataGridModelos.AllowUserToAddRows = false;
            this.dataGridModelos.AllowUserToDeleteRows = false;
            this.dataGridModelos.AllowUserToOrderColumns = true;
            this.dataGridModelos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridModelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridModelos.Location = new System.Drawing.Point(8, 29);
            this.dataGridModelos.Name = "dataGridModelos";
            this.dataGridModelos.ReadOnly = true;
            this.dataGridModelos.RowHeadersVisible = false;
            this.dataGridModelos.Size = new System.Drawing.Size(214, 304);
            this.dataGridModelos.TabIndex = 2;
            this.dataGridModelos.SelectionChanged += new System.EventHandler(this.dataGridModelos_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cod";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // painelVis
            // 
            this.painelVis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painelVis.Location = new System.Drawing.Point(228, 30);
            this.painelVis.Name = "painelVis";
            this.painelVis.Size = new System.Drawing.Size(326, 303);
            this.painelVis.TabIndex = 3;
            // 
            // RelatorioClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 347);
            this.Controls.Add(this.painelVis);
            this.Controls.Add(this.dataGridModelos);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "RelatorioClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parâmetros iniciais";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridModelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridModelos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Panel painelVis;
    }
}