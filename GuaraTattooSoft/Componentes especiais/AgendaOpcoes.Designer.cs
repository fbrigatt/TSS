namespace GuaraTattooSoft.Componentes_especiais
{
    partial class AgendaOpcoes
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
            this.btReagendar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.btServico = new System.Windows.Forms.Button();
            this.bt_notificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btReagendar
            // 
            this.btReagendar.BackColor = System.Drawing.Color.White;
            this.btReagendar.FlatAppearance.BorderSize = 0;
            this.btReagendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReagendar.Location = new System.Drawing.Point(9, 86);
            this.btReagendar.Name = "btReagendar";
            this.btReagendar.Size = new System.Drawing.Size(251, 33);
            this.btReagendar.TabIndex = 0;
            this.btReagendar.Text = "REAGENDAR";
            this.btReagendar.UseVisualStyleBackColor = false;
            this.btReagendar.Click += new System.EventHandler(this.btReagendar_Click);
            this.btReagendar.MouseEnter += new System.EventHandler(this.btReagendar_MouseEnter);
            this.btReagendar.MouseLeave += new System.EventHandler(this.btReagendar_MouseLeave);
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.White;
            this.btExcluir.FlatAppearance.BorderSize = 0;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Location = new System.Drawing.Point(9, 125);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(251, 33);
            this.btExcluir.TabIndex = 1;
            this.btExcluir.Text = "EXCLUIR ";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            this.btExcluir.MouseEnter += new System.EventHandler(this.btExcluir_MouseEnter);
            this.btExcluir.MouseLeave += new System.EventHandler(this.btExcluir_MouseLeave);
            // 
            // btFechar
            // 
            this.btFechar.BackColor = System.Drawing.Color.White;
            this.btFechar.FlatAppearance.BorderSize = 0;
            this.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFechar.Location = new System.Drawing.Point(9, 164);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(251, 33);
            this.btFechar.TabIndex = 2;
            this.btFechar.Text = "FECHAR";
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            this.btFechar.MouseEnter += new System.EventHandler(this.btFechar_MouseEnter);
            this.btFechar.MouseLeave += new System.EventHandler(this.btFechar_MouseLeave);
            // 
            // btServico
            // 
            this.btServico.BackColor = System.Drawing.Color.White;
            this.btServico.FlatAppearance.BorderSize = 0;
            this.btServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btServico.Location = new System.Drawing.Point(9, 47);
            this.btServico.Name = "btServico";
            this.btServico.Size = new System.Drawing.Size(251, 33);
            this.btServico.TabIndex = 3;
            this.btServico.Text = "PROCEDIMENTO PARA ESTE CLIENTE";
            this.btServico.UseVisualStyleBackColor = false;
            this.btServico.Click += new System.EventHandler(this.btServico_Click);
            this.btServico.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.btServico.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // bt_notificar
            // 
            this.bt_notificar.BackColor = System.Drawing.Color.White;
            this.bt_notificar.FlatAppearance.BorderSize = 0;
            this.bt_notificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_notificar.Location = new System.Drawing.Point(9, 8);
            this.bt_notificar.Name = "bt_notificar";
            this.bt_notificar.Size = new System.Drawing.Size(251, 33);
            this.bt_notificar.TabIndex = 4;
            this.bt_notificar.Text = "NOTIFICAR O CLIENTE";
            this.bt_notificar.UseVisualStyleBackColor = false;
            this.bt_notificar.Click += new System.EventHandler(this.bt_notificar_Click);
            this.bt_notificar.MouseEnter += new System.EventHandler(this.bt_notificar_MouseEnter);
            this.bt_notificar.MouseLeave += new System.EventHandler(this.bt_notificar_MouseLeave);
            // 
            // AgendaOpcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(272, 206);
            this.Controls.Add(this.bt_notificar);
            this.Controls.Add(this.btServico);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btReagendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgendaOpcoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AgendaOpcoes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btReagendar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btServico;
        private System.Windows.Forms.Button bt_notificar;
    }
}