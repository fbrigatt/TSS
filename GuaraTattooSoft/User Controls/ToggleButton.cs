using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuaraTattooSoft.User_Controls
{
    public partial class ToggleButton : UserControl
    {
        private bool isTrue;

        public ToggleButton()
        {
            InitializeComponent();
            this.Visible = true;

            this.BackColor = Color.LightGray;
            enabled.Visible = false;
            disabled.Visible = true;
            isTrue = false;

            this.Cursor = Cursors.Hand;
            panel1.Cursor = Cursors.Hand;
            return;
        }

        public bool IsTrue
        {
            get
            {
                return isTrue;
            }

            set
            {
                isTrue = value;
            }
        }

        private void ToggleButton_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Acionar();
        }

        private void Acionar()
        {
            if (isTrue)
            {
                this.BackColor = Color.LightGray;
                enabled.Visible = false;
                disabled.Visible = true;
                isTrue = false;
                return;
            }

            if (!isTrue)
            {
                this.BackColor = Color.Teal;
                enabled.Visible = true;
                disabled.Visible = false;
                isTrue = true;
                return;
            }
        }

        private void enabled_MouseClick(object sender, MouseEventArgs e)
        {
            Acionar();
        }

        private void disabled_MouseClick(object sender, MouseEventArgs e)
        {
            Acionar();
        }
    }
}
