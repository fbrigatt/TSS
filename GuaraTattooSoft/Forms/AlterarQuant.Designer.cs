namespace GuaraTattooSoft.Forms
{
    partial class AlterarQuant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarQuant));
            this.txQuant = new DevComponents.Editors.IntegerInput();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txQuant)).BeginInit();
            this.SuspendLayout();
            // 
            // txQuant
            // 
            // 
            // 
            // 
            this.txQuant.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txQuant.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txQuant.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txQuant.Location = new System.Drawing.Point(12, 45);
            this.txQuant.Name = "txQuant";
            this.txQuant.Size = new System.Drawing.Size(293, 38);
            this.txQuant.TabIndex = 1;
            this.txQuant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txQuant_KeyDown);
            // 
            // btConfirmar
            // 
            this.btConfirmar.BackColor = System.Drawing.Color.Teal;
            this.btConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirmar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btConfirmar.Location = new System.Drawing.Point(209, 115);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(96, 23);
            this.btConfirmar.TabIndex = 1;
            this.btConfirmar.Text = "&CONFIRMAR";
            this.btConfirmar.UseVisualStyleBackColor = false;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inserir quantidade";
            // 
            // AlterarQuant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(317, 150);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.txQuant);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlterarQuant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Quantidade ";
            ((System.ComponentModel.ISupportInitialize)(this.txQuant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.Editors.IntegerInput txQuant;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.Label label1;
    }
}