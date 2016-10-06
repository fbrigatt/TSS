namespace GuaraTattooSoft.Assistente
{
    partial class CadastroLoja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroLoja));
            this.label1 = new System.Windows.Forms.Label();
            this.txRazao_social = new System.Windows.Forms.TextBox();
            this.txNome_fantasia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txCEP = new System.Windows.Forms.MaskedTextBox();
            this.txCidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txBairro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txLogradouro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txNumero = new DevComponents.Editors.IntegerInput();
            this.txUF = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txResponsavel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txCelular = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btProximo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Razão Social";
            // 
            // txRazao_social
            // 
            this.txRazao_social.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txRazao_social.Location = new System.Drawing.Point(12, 65);
            this.txRazao_social.Name = "txRazao_social";
            this.txRazao_social.Size = new System.Drawing.Size(345, 22);
            this.txRazao_social.TabIndex = 1;
            // 
            // txNome_fantasia
            // 
            this.txNome_fantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome_fantasia.Location = new System.Drawing.Point(363, 65);
            this.txNome_fantasia.Name = "txNome_fantasia";
            this.txNome_fantasia.Size = new System.Drawing.Size(341, 22);
            this.txNome_fantasia.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome Fantasia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CNPJ";
            // 
            // txCNPJ
            // 
            this.txCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCNPJ.Location = new System.Drawing.Point(12, 111);
            this.txCNPJ.Mask = "##.###.###/####-##";
            this.txCNPJ.Name = "txCNPJ";
            this.txCNPJ.Size = new System.Drawing.Size(122, 22);
            this.txCNPJ.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "CEP";
            // 
            // txCEP
            // 
            this.txCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCEP.Location = new System.Drawing.Point(140, 111);
            this.txCEP.Mask = "##.###-###";
            this.txCEP.Name = "txCEP";
            this.txCEP.Size = new System.Drawing.Size(86, 22);
            this.txCEP.TabIndex = 4;
            this.txCEP.Leave += new System.EventHandler(this.txCEP_Leave);
            // 
            // txCidade
            // 
            this.txCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCidade.Location = new System.Drawing.Point(270, 111);
            this.txCidade.Name = "txCidade";
            this.txCidade.Size = new System.Drawing.Size(222, 22);
            this.txCidade.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cidade";
            // 
            // txBairro
            // 
            this.txBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBairro.Location = new System.Drawing.Point(498, 111);
            this.txBairro.Name = "txBairro";
            this.txBairro.Size = new System.Drawing.Size(206, 22);
            this.txBairro.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bairro";
            // 
            // txLogradouro
            // 
            this.txLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txLogradouro.Location = new System.Drawing.Point(12, 156);
            this.txLogradouro.Name = "txLogradouro";
            this.txLogradouro.Size = new System.Drawing.Size(345, 22);
            this.txLogradouro.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Logradouro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(403, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Número";
            // 
            // txNumero
            // 
            // 
            // 
            // 
            this.txNumero.BackgroundStyle.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.txNumero.BackgroundStyle.BorderColor2 = System.Drawing.SystemColors.AppWorkspace;
            this.txNumero.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txNumero.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNumero.Location = new System.Drawing.Point(406, 156);
            this.txNumero.Name = "txNumero";
            this.txNumero.Size = new System.Drawing.Size(79, 22);
            this.txNumero.TabIndex = 9;
            // 
            // txUF
            // 
            this.txUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txUF.Location = new System.Drawing.Point(363, 156);
            this.txUF.Name = "txUF";
            this.txUF.Size = new System.Drawing.Size(37, 22);
            this.txUF.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(360, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "UF";
            // 
            // txResponsavel
            // 
            this.txResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txResponsavel.Location = new System.Drawing.Point(12, 198);
            this.txResponsavel.Name = "txResponsavel";
            this.txResponsavel.Size = new System.Drawing.Size(329, 22);
            this.txResponsavel.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Responsável";
            // 
            // txTelefone
            // 
            this.txTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTelefone.Location = new System.Drawing.Point(491, 156);
            this.txTelefone.Mask = "(##)####-####";
            this.txTelefone.Name = "txTelefone";
            this.txTelefone.Size = new System.Drawing.Size(105, 22);
            this.txTelefone.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(495, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Telefone";
            // 
            // txCelular
            // 
            this.txCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCelular.Location = new System.Drawing.Point(602, 156);
            this.txCelular.Mask = "(##)#####-####";
            this.txCelular.Name = "txCelular";
            this.txCelular.Size = new System.Drawing.Size(102, 22);
            this.txCelular.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(602, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Celular";
            // 
            // btProximo
            // 
            this.btProximo.BackColor = System.Drawing.Color.Teal;
            this.btProximo.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProximo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btProximo.Location = new System.Drawing.Point(573, 283);
            this.btProximo.Name = "btProximo";
            this.btProximo.Size = new System.Drawing.Size(130, 23);
            this.btProximo.TabIndex = 25;
            this.btProximo.Text = "&PRÓXIMO";
            this.btProximo.UseVisualStyleBackColor = false;
            this.btProximo.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::GuaraTattooSoft.Properties.Resources.procurar;
            this.button2.Location = new System.Drawing.Point(232, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 26);
            this.button2.TabIndex = 26;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CadastroLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(720, 318);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btProximo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txCelular);
            this.Controls.Add(this.txTelefone);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txResponsavel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txUF);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txNumero);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txLogradouro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txBairro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txCidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txCEP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txCNPJ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txNome_fantasia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txRazao_social);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroLoja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Loja";
            ((System.ComponentModel.ISupportInitialize)(this.txNumero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txRazao_social;
        private System.Windows.Forms.TextBox txNome_fantasia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txCNPJ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txCEP;
        private System.Windows.Forms.TextBox txCidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txBairro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txLogradouro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private DevComponents.Editors.IntegerInput txNumero;
        private System.Windows.Forms.TextBox txUF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txResponsavel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txTelefone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox txCelular;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btProximo;
        private System.Windows.Forms.Button button2;
    }
}