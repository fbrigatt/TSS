namespace GuaraTattooSoft.Assistente
{
    partial class CadastroUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroUsuarios));
            this.txUsuario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckCadCli = new System.Windows.Forms.CheckBox();
            this.ckCadProf = new System.Windows.Forms.CheckBox();
            this.ckLancServ = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txUsuario
            // 
            this.txUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txUsuario.Location = new System.Drawing.Point(22, 30);
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.Size = new System.Drawing.Size(240, 22);
            this.txUsuario.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Nome do administrador";
            // 
            // txSenha
            // 
            this.txSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSenha.Location = new System.Drawing.Point(268, 30);
            this.txSenha.Name = "txSenha";
            this.txSenha.PasswordChar = '*';
            this.txSenha.Size = new System.Drawing.Size(240, 22);
            this.txSenha.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Senha";
            // 
            // ckCadCli
            // 
            this.ckCadCli.AutoSize = true;
            this.ckCadCli.Checked = true;
            this.ckCadCli.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckCadCli.Location = new System.Drawing.Point(22, 59);
            this.ckCadCli.Name = "ckCadCli";
            this.ckCadCli.Size = new System.Drawing.Size(123, 17);
            this.ckCadCli.TabIndex = 3;
            this.ckCadCli.Text = "Cadastro de Clientes";
            this.ckCadCli.UseVisualStyleBackColor = true;
            // 
            // ckCadProf
            // 
            this.ckCadProf.AutoSize = true;
            this.ckCadProf.Checked = true;
            this.ckCadProf.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckCadProf.Location = new System.Drawing.Point(180, 59);
            this.ckCadProf.Name = "ckCadProf";
            this.ckCadProf.Size = new System.Drawing.Size(144, 17);
            this.ckCadProf.TabIndex = 4;
            this.ckCadProf.Text = "Cadastro de Profissionais";
            this.ckCadProf.UseVisualStyleBackColor = true;
            // 
            // ckLancServ
            // 
            this.ckLancServ.AutoSize = true;
            this.ckLancServ.Checked = true;
            this.ckLancServ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckLancServ.Location = new System.Drawing.Point(364, 58);
            this.ckLancServ.Name = "ckLancServ";
            this.ckLancServ.Size = new System.Drawing.Size(142, 17);
            this.ckLancServ.TabIndex = 5;
            this.ckLancServ.Text = "Lancamento de serviços";
            this.ckLancServ.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(427, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "&PRÓXIMO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(19, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(490, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "NOTA: PARA MAIS CONFIGURAÇÕES DE USUÁRIOS, LOGO APÓS ESTE ASSISTENTE, ACESSE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(19, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "MENU > ATUALIZAÇÕES > CADASTROS > CADASTRO DE USUÁRIOS";
            // 
            // CadastroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(538, 227);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ckLancServ);
            this.Controls.Add(this.ckCadProf);
            this.Controls.Add(this.ckCadCli);
            this.Controls.Add(this.txSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txUsuario);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro e configuração de usuário administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txUsuario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckCadCli;
        private System.Windows.Forms.CheckBox ckCadProf;
        private System.Windows.Forms.CheckBox ckLancServ;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}