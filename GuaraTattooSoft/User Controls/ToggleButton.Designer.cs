namespace GuaraTattooSoft.User_Controls
{
    partial class ToggleButton
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.enabled = new System.Windows.Forms.Panel();
            this.disabled = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.disabled);
            this.panel1.Controls.Add(this.enabled);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(57, 25);
            this.panel1.TabIndex = 0;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // enabled
            // 
            this.enabled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enabled.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enabled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enabled.Location = new System.Drawing.Point(42, -1);
            this.enabled.Name = "enabled";
            this.enabled.Size = new System.Drawing.Size(14, 25);
            this.enabled.TabIndex = 1;
            this.enabled.MouseClick += new System.Windows.Forms.MouseEventHandler(this.enabled_MouseClick);
            // 
            // disabled
            // 
            this.disabled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.disabled.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.disabled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.disabled.Location = new System.Drawing.Point(-1, -1);
            this.disabled.Name = "disabled";
            this.disabled.Size = new System.Drawing.Size(15, 25);
            this.disabled.TabIndex = 2;
            this.disabled.MouseClick += new System.Windows.Forms.MouseEventHandler(this.disabled_MouseClick);
            // 
            // ToggleButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Name = "ToggleButton";
            this.Size = new System.Drawing.Size(55, 23);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ToggleButton_MouseClick);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel enabled;
        private System.Windows.Forms.Panel disabled;
    }
}
