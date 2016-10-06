namespace GuaraTattooSoft.User_Controls
{
    partial class Agendamento
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
            this.listaProfissionais = new System.Windows.Forms.FlowLayoutPanel();
            this.painelAgenda = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listaProfissionais
            // 
            this.listaProfissionais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listaProfissionais.AutoScroll = true;
            this.listaProfissionais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listaProfissionais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listaProfissionais.Location = new System.Drawing.Point(3, 29);
            this.listaProfissionais.Name = "listaProfissionais";
            this.listaProfissionais.Size = new System.Drawing.Size(281, 505);
            this.listaProfissionais.TabIndex = 1;
            // 
            // painelAgenda
            // 
            this.painelAgenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painelAgenda.AutoScroll = true;
            this.painelAgenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.painelAgenda.Location = new System.Drawing.Point(291, 29);
            this.painelAgenda.Name = "painelAgenda";
            this.painelAgenda.Size = new System.Drawing.Size(695, 505);
            this.painelAgenda.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(817, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "&CRIAR AGENDAMENTO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(737, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Após selecionar o profissional, escolha um evento ao lado direito, clique e mante" +
    "nha pressionado para obter opções sobre o agendamento";
            // 
            // Agendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.painelAgenda);
            this.Controls.Add(this.listaProfissionais);
            this.Name = "Agendamento";
            this.Size = new System.Drawing.Size(989, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel listaProfissionais;
        private System.Windows.Forms.FlowLayoutPanel painelAgenda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}
