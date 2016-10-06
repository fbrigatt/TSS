namespace GuaraTattooSoft.Forms
{
    partial class Reagendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reagendar));
            this.txNome_profissional = new System.Windows.Forms.TextBox();
            this.txCod_Profissional = new DevComponents.Editors.IntegerInput();
            this.label1 = new System.Windows.Forms.Label();
            this.txNome_cliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txData = new System.Windows.Forms.DateTimePicker();
            this.txHora = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txCodTipo_serv = new DevComponents.Editors.IntegerInput();
            this.txDescricao_serv = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txCod_Profissional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txCodTipo_serv)).BeginInit();
            this.SuspendLayout();
            // 
            // txNome_profissional
            // 
            this.txNome_profissional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome_profissional.Location = new System.Drawing.Point(87, 32);
            this.txNome_profissional.Name = "txNome_profissional";
            this.txNome_profissional.Size = new System.Drawing.Size(353, 22);
            this.txNome_profissional.TabIndex = 2;
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
            this.txCod_Profissional.Location = new System.Drawing.Point(13, 32);
            this.txCod_Profissional.Name = "txCod_Profissional";
            this.txCod_Profissional.Size = new System.Drawing.Size(68, 22);
            this.txCod_Profissional.TabIndex = 1;
            this.txCod_Profissional.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txCod_Profissional_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Profissional";
            // 
            // txNome_cliente
            // 
            this.txNome_cliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txNome_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome_cliente.Location = new System.Drawing.Point(13, 81);
            this.txNome_cliente.Name = "txNome_cliente";
            this.txNome_cliente.ReadOnly = true;
            this.txNome_cliente.Size = new System.Drawing.Size(427, 22);
            this.txNome_cliente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente";
            // 
            // txData
            // 
            this.txData.CustomFormat = "dd/MM/yyyy hh:MM:ss";
            this.txData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txData.Location = new System.Drawing.Point(12, 169);
            this.txData.Name = "txData";
            this.txData.Size = new System.Drawing.Size(110, 22);
            this.txData.TabIndex = 6;
            // 
            // txHora
            // 
            this.txHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txHora.Location = new System.Drawing.Point(129, 169);
            this.txHora.Mask = "##:##";
            this.txHora.Name = "txHora";
            this.txHora.Size = new System.Drawing.Size(76, 22);
            this.txHora.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hora (opcional)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 12;
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
            this.txCodTipo_serv.Location = new System.Drawing.Point(13, 126);
            this.txCodTipo_serv.Name = "txCodTipo_serv";
            this.txCodTipo_serv.Size = new System.Drawing.Size(68, 22);
            this.txCodTipo_serv.TabIndex = 4;
            this.txCodTipo_serv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txCodTipo_serv_KeyDown);
            // 
            // txDescricao_serv
            // 
            this.txDescricao_serv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDescricao_serv.Location = new System.Drawing.Point(87, 126);
            this.txDescricao_serv.Name = "txDescricao_serv";
            this.txDescricao_serv.Size = new System.Drawing.Size(353, 22);
            this.txDescricao_serv.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(365, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "&GRAVAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(283, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "&CANCELAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Reagendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(452, 250);
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
            this.Name = "Reagendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reagendar";
            ((System.ComponentModel.ISupportInitialize)(this.txCod_Profissional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txCodTipo_serv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txNome_profissional;
        private DevComponents.Editors.IntegerInput txCod_Profissional;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txData;
        private System.Windows.Forms.MaskedTextBox txHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevComponents.Editors.IntegerInput txCodTipo_serv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txDescricao_serv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txNome_cliente;
    }
}