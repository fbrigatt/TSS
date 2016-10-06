namespace GuaraTattooSoft.Assistente
{
    partial class Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txHost = new System.Windows.Forms.TextBox();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.txSenha = new System.Windows.Forms.TextBox();
            this.txPorta = new DevComponents.Editors.IntegerInput();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btProximo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txPorta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Para que o envio de emails para os clientes funcione, será necessário fornecer as" +
    " credenciais de login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(13, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(535, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOTA: EM NENHUM MOMENTO USAREMOS SUAS CREDENCIAIS PARA QUAISQUER FINS";
            // 
            // txHost
            // 
            this.txHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txHost.Location = new System.Drawing.Point(80, 179);
            this.txHost.Name = "txHost";
            this.txHost.Size = new System.Drawing.Size(176, 22);
            this.txHost.TabIndex = 10;
            this.txHost.Text = "smtp.gmail.com";
            // 
            // txEmail
            // 
            this.txEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txEmail.Location = new System.Drawing.Point(80, 72);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(405, 22);
            this.txEmail.TabIndex = 1;
            // 
            // txSenha
            // 
            this.txSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSenha.Location = new System.Drawing.Point(80, 122);
            this.txSenha.Name = "txSenha";
            this.txSenha.PasswordChar = '●';
            this.txSenha.Size = new System.Drawing.Size(405, 22);
            this.txSenha.TabIndex = 2;
            // 
            // txPorta
            // 
            // 
            // 
            // 
            this.txPorta.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txPorta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txPorta.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPorta.Location = new System.Drawing.Point(262, 179);
            this.txPorta.Name = "txPorta";
            this.txPorta.Size = new System.Drawing.Size(89, 22);
            this.txPorta.TabIndex = 20;
            this.txPorta.Value = 587;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Servidor de email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Porta";
            // 
            // btProximo
            // 
            this.btProximo.BackColor = System.Drawing.Color.Teal;
            this.btProximo.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProximo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btProximo.Location = new System.Drawing.Point(462, 255);
            this.btProximo.Name = "btProximo";
            this.btProximo.Size = new System.Drawing.Size(114, 23);
            this.btProximo.TabIndex = 3;
            this.btProximo.Text = "&PRÓXIMO";
            this.btProximo.UseVisualStyleBackColor = false;
            this.btProximo.Click += new System.EventHandler(this.btProximo_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(588, 290);
            this.Controls.Add(this.btProximo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txPorta);
            this.Controls.Add(this.txSenha);
            this.Controls.Add(this.txEmail);
            this.Controls.Add(this.txHost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajustes";
            ((System.ComponentModel.ISupportInitialize)(this.txPorta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txHost;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.TextBox txSenha;
        private DevComponents.Editors.IntegerInput txPorta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btProximo;
    }
}