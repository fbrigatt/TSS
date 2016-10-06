namespace GuaraTattooSoft.Componentes_especiais
{
    partial class CardProfissional
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
            this.lbNomeProdissional = new System.Windows.Forms.Label();
            this.grupoQuant = new DevComponents.DotNetBar.PanelEx();
            this.lbQuant = new System.Windows.Forms.Label();
            this.grupoQuant.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNomeProdissional
            // 
            this.lbNomeProdissional.AutoSize = true;
            this.lbNomeProdissional.BackColor = System.Drawing.Color.Transparent;
            this.lbNomeProdissional.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeProdissional.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNomeProdissional.Location = new System.Drawing.Point(3, 9);
            this.lbNomeProdissional.Name = "lbNomeProdissional";
            this.lbNomeProdissional.Size = new System.Drawing.Size(60, 24);
            this.lbNomeProdissional.TabIndex = 0;
            this.lbNomeProdissional.Text = "label1";
            this.lbNomeProdissional.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbNomeProdissional_MouseDown);
            this.lbNomeProdissional.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbNomeProdissional_MouseUp);
            // 
            // grupoQuant
            // 
            this.grupoQuant.CanvasColor = System.Drawing.Color.Teal;
            this.grupoQuant.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.grupoQuant.Controls.Add(this.lbQuant);
            this.grupoQuant.Location = new System.Drawing.Point(207, 7);
            this.grupoQuant.Name = "grupoQuant";
            this.grupoQuant.Size = new System.Drawing.Size(43, 32);
            this.grupoQuant.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.grupoQuant.Style.BackColor1.Color = System.Drawing.Color.Blue;
            this.grupoQuant.Style.BackColor2.Color = System.Drawing.Color.Blue;
            this.grupoQuant.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.grupoQuant.Style.BorderColor.Color = System.Drawing.Color.Teal;
            this.grupoQuant.Style.BorderWidth = 0;
            this.grupoQuant.Style.CornerDiameter = 15;
            this.grupoQuant.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grupoQuant.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grupoQuant.Style.GradientAngle = 90;
            this.grupoQuant.TabIndex = 1;
            // 
            // lbQuant
            // 
            this.lbQuant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbQuant.AutoSize = true;
            this.lbQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbQuant.Location = new System.Drawing.Point(7, 8);
            this.lbQuant.Name = "lbQuant";
            this.lbQuant.Size = new System.Drawing.Size(20, 16);
            this.lbQuant.TabIndex = 2;
            this.lbQuant.Text = "   ";
            // 
            // CardProfissional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.grupoQuant);
            this.Controls.Add(this.lbNomeProdissional);
            this.Name = "CardProfissional";
            this.Size = new System.Drawing.Size(252, 44);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardProfissional_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CardProfissional_MouseUp);
            this.grupoQuant.ResumeLayout(false);
            this.grupoQuant.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNomeProdissional;
        private DevComponents.DotNetBar.PanelEx grupoQuant;
        private System.Windows.Forms.Label lbQuant;
    }
}
