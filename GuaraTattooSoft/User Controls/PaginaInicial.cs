using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GuaraTattooSoft.Entidades;

namespace GuaraTattooSoft.User_Controls
{
    public partial class PaginaInicial : UserControl
    {
        public PaginaInicial()
        {
            InitializeComponent();

            Config conf = new Config(true);
            if (!string.IsNullOrWhiteSpace(conf.ImagemLogo))
            {
                imgLogo.BackgroundImage = Image.FromFile(conf.ImagemLogo);
               
            }
        }

        private void imgLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
