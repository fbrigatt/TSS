namespace GuaraTattooSoft.Componentes_especiais
{
    partial class CardCompromisso
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTipoServ = new System.Windows.Forms.Label();
            this.onLongPress = new System.Windows.Forms.Timer(this.components);
            this.lbNomeP = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbData.Location = new System.Drawing.Point(136, 11);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(44, 20);
            this.lbData.TabIndex = 1;
            this.lbData.Text = "Data";
            this.lbData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbData_MouseDown);
            this.lbData.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbData_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(16, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label2_MouseUp);
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCliente.Location = new System.Drawing.Point(136, 38);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(58, 20);
            this.lbCliente.TabIndex = 3;
            this.lbCliente.Text = "Cliente";
            this.lbCliente.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbCliente_MouseDown);
            this.lbCliente.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label2_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(16, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label3_MouseDown);
            this.label3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label2_MouseUp);
            // 
            // lbTipoServ
            // 
            this.lbTipoServ.AutoSize = true;
            this.lbTipoServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoServ.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTipoServ.Location = new System.Drawing.Point(136, 64);
            this.lbTipoServ.Name = "lbTipoServ";
            this.lbTipoServ.Size = new System.Drawing.Size(91, 20);
            this.lbTipoServ.TabIndex = 5;
            this.lbTipoServ.Text = "TipoServico";
            this.lbTipoServ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbTipoServ_MouseDown);
            this.lbTipoServ.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label2_MouseUp);
            // 
            // onLongPress
            // 
            this.onLongPress.Enabled = true;
            this.onLongPress.Interval = 1000;
            this.onLongPress.Tick += new System.EventHandler(this.onLongPress_Tick);
            // 
            // lbNomeP
            // 
            this.lbNomeP.AutoSize = true;
            this.lbNomeP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNomeP.Location = new System.Drawing.Point(136, 93);
            this.lbNomeP.Name = "lbNomeP";
            this.lbNomeP.Size = new System.Drawing.Size(91, 20);
            this.lbNomeP.TabIndex = 7;
            this.lbNomeP.Text = "TipoServico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(16, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Profissional";
            // 
            // CardCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.lbNomeP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTipoServ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.label1);
            this.Name = "CardCompromisso";
            this.Size = new System.Drawing.Size(686, 122);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardCompromisso_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CardCompromisso_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer onLongPress;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Label lbTipoServ;
        private System.Windows.Forms.Label lbNomeP;
        private System.Windows.Forms.Label label5;
    }
}
