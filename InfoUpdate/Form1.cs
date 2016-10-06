using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoUpdate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Exibir();
        }

        private void Exibir()
        {
            try
            {
                recursos.Items.Clear();
                StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + @"\info.txt", Encoding.Default);
                string line = string.Empty;

                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("versao"))
                    {
                        lbVAt.Text = line.Split(':')[1];
                        continue;
                    }

                    recursos.Items.Add(line);
                }

                reader.Close();
            }
            catch(Exception ex)
            {

            }
        }
    }
}
