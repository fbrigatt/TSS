namespace InfoUpdate
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbVIns = new System.Windows.Forms.Label();
            this.lbVAt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.recursos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(216, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tattoo Smart Soft Update";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(27, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Versão instalada:";
            // 
            // lbVIns
            // 
            this.lbVIns.AutoSize = true;
            this.lbVIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbVIns.Location = new System.Drawing.Point(208, 69);
            this.lbVIns.Name = "lbVIns";
            this.lbVIns.Size = new System.Drawing.Size(16, 17);
            this.lbVIns.TabIndex = 2;
            this.lbVIns.Text = "0";
            // 
            // lbVAt
            // 
            this.lbVAt.AutoSize = true;
            this.lbVAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbVAt.Location = new System.Drawing.Point(208, 96);
            this.lbVAt.Name = "lbVAt";
            this.lbVAt.Size = new System.Drawing.Size(16, 17);
            this.lbVAt.TabIndex = 4;
            this.lbVAt.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(27, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Versão da atualização:";
            // 
            // recursos
            // 
            this.recursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.recursos.FormattingEnabled = true;
            this.recursos.ItemHeight = 20;
            this.recursos.Location = new System.Drawing.Point(30, 167);
            this.recursos.Name = "recursos";
            this.recursos.Size = new System.Drawing.Size(646, 324);
            this.recursos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(27, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Melhorias e novos recursos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(701, 513);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.recursos);
            this.Controls.Add(this.lbVAt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbVIns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notas da atualização";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbVIns;
        private System.Windows.Forms.Label lbVAt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox recursos;
        private System.Windows.Forms.Label label3;
    }
}

