namespace GuaraTattooSoft.Forms
{
    partial class CriarAgendamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriarAgendamento));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txCodTipo_serv = new DevComponents.Editors.IntegerInput();
            this.txDescricao_serv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txHora = new System.Windows.Forms.MaskedTextBox();
            this.txData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txNome_cliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txCod_Profissional = new DevComponents.Editors.IntegerInput();
            this.txNome_profissional = new System.Windows.Forms.TextBox();
            this.txCod_cliente = new DevComponents.Editors.IntegerInput();
            ((System.ComponentModel.ISupportInitialize)(this.txCodTipo_serv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txCod_Profissional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txCod_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(279, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "&CANCELAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(361, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "&GRAVAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tipo serviço";
            // 
            // txCodTipo_serv
            // 
            // 
            // 
            // 
            this.txCodTipo_serv.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txCodTipo_serv.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txCodTipo_serv.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txCodTipo_serv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCodTipo_serv.Location = new System.Drawing.Point(9, 119);
            this.txCodTipo_serv.Name = "txCodTipo_serv";
            this.txCodTipo_serv.Size = new System.Drawing.Size(68, 22);
            this.txCodTipo_serv.TabIndex = 19;
            this.txCodTipo_serv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txCodTipo_serv_KeyDown);
            // 
            // txDescricao_serv
            // 
            this.txDescricao_serv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDescricao_serv.Location = new System.Drawing.Point(83, 119);
            this.txDescricao_serv.Name = "txDescricao_serv";
            this.txDescricao_serv.Size = new System.Drawing.Size(353, 22);
            this.txDescricao_serv.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Hora (opcional)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Data";
            // 
            // txHora
            // 
            this.txHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txHora.Location = new System.Drawing.Point(125, 162);
            this.txHora.Mask = "##:##";
            this.txHora.Name = "txHora";
            this.txHora.Size = new System.Drawing.Size(76, 22);
            this.txHora.TabIndex = 23;
            // 
            // txData
            // 
            this.txData.CustomFormat = "dd/MM/yyyy hh:MM:ss";
            this.txData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txData.Location = new System.Drawing.Point(8, 162);
            this.txData.Name = "txData";
            this.txData.Size = new System.Drawing.Size(110, 22);
            this.txData.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cliente";
            // 
            // txNome_cliente
            // 
            this.txNome_cliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txNome_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome_cliente.Location = new System.Drawing.Point(83, 74);
            this.txNome_cliente.Name = "txNome_cliente";
            this.txNome_cliente.ReadOnly = true;
            this.txNome_cliente.Size = new System.Drawing.Size(353, 22);
            this.txNome_cliente.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Profissional";
            // 
            // txCod_Profissional
            // 
            // 
            // 
            // 
            this.txCod_Profissional.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txCod_Profissional.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txCod_Profissional.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txCod_Profissional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCod_Profissional.Location = new System.Drawing.Point(9, 25);
            this.txCod_Profissional.Name = "txCod_Profissional";
            this.txCod_Profissional.Size = new System.Drawing.Size(68, 22);
            this.txCod_Profissional.TabIndex = 15;
            this.txCod_Profissional.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txCod_Profissional_KeyDown);
            // 
            // txNome_profissional
            // 
            this.txNome_profissional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome_profissional.Location = new System.Drawing.Point(83, 25);
            this.txNome_profissional.Name = "txNome_profissional";
            this.txNome_profissional.Size = new System.Drawing.Size(353, 22);
            this.txNome_profissional.TabIndex = 17;
            // 
            // txCod_cliente
            // 
            // 
            // 
            // 
            this.txCod_cliente.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txCod_cliente.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txCod_cliente.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txCod_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCod_cliente.Location = new System.Drawing.Point(9, 74);
            this.txCod_cliente.Name = "txCod_cliente";
            this.txCod_cliente.Size = new System.Drawing.Size(68, 22);
            this.txCod_cliente.TabIndex = 29;
            this.txCod_cliente.ValueChanged += new System.EventHandler(this.txCod_cliente_ValueChanged);
            this.txCod_cliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txCod_cliente_KeyDown);
            // 
            // CriarAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(447, 248);
            this.Controls.Add(this.txCod_cliente);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txCodTipo_serv);
            this.Controls.Add(this.txDescricao_serv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txHora);
            this.Controls.Add(this.txData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txNome_cliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txCod_Profissional);
            this.Controls.Add(this.txNome_profissional);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CriarAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar agendamento";
            ((System.ComponentModel.ISupportInitialize)(this.txCodTipo_serv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txCod_Profissional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txCod_cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private DevComponents.Editors.IntegerInput txCodTipo_serv;
        private System.Windows.Forms.TextBox txDescricao_serv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txHora;
        private System.Windows.Forms.DateTimePicker txData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txNome_cliente;
        private System.Windows.Forms.Label label1;
        private DevComponents.Editors.IntegerInput txCod_Profissional;
        private System.Windows.Forms.TextBox txNome_profissional;
        private DevComponents.Editors.IntegerInput txCod_cliente;
    }
}