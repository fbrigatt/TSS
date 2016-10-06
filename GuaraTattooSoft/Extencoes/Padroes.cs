using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;
using GuaraTattooSoft.User_Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuaraTattooSoft.Extencoes
{
    public static class Padroes
    {
        private static TabControl mainTabControl;
        private static List<int> mainTextBox = new List<int>();

        private static List<DoubleInput> doubleInputs = new List<DoubleInput>();

        public static void AplicarPadroes(this UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            foreach (Control control in userControl.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    TextBox textBox = (control as TextBox);
                    if (textBox == null) textBox = new TextBox();
                    textBox.CharacterCasing = CharacterCasing.Upper;
                }

                if (control.GetType() == typeof(ComboBox))
                {
                    ComboBox combo = (control as ComboBox);
                    if (combo == null) combo = new ComboBox();
                    combo.DropDownStyle = ComboBoxStyle.DropDownList;
                }

                if (control.GetType() == typeof(DoubleInput))
                {
                    DoubleInput di = (control as DoubleInput);
                    if (di == null) di = new DoubleInput();
                    di.DisplayFormat = "N2";
                }

                if (control.GetType() == typeof(DateTimePicker))
                {
                    DateTimePicker dt_pckr = (control as DateTimePicker);
                    if (dt_pckr == null) dt_pckr = new DateTimePicker();
                    dt_pckr.Format = DateTimePickerFormat.Short;
                }

                if(control.GetType() == typeof(IntegerInput))
                {
                    IntegerInput integerInput = (control as IntegerInput);
                    if (integerInput == null) integerInput = new IntegerInput();

                    integerInput.BackgroundStyle.Border = DevComponents.DotNetBar.eStyleBorderType.Solid;
                    integerInput.BackgroundStyle.BorderColor = System.Drawing.Color.Blue;
                }
            }
        }

        public static void AplicarPadroes(this TabControl tabControl)
        {
            mainTabControl = tabControl;

            mainTabControl.KeyDown += MainTabControl_KeyDown;
        }

        public static void AplicarPadroes(this DataGridView dataGridView)
        {
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;
            dataGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightBlue;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.ReadOnly = true;
            dataGridView.Cursor = Cursors.Hand;
            dataGridView.RowHeadersVisible = false;
        }

        public static int IdAtual(this DataGridView dataGridEmQuestao, int column)
        {
            if (dataGridEmQuestao.Rows.Count == 0) return 0;

            int id = int.Parse(dataGridEmQuestao.CurrentRow.Cells[column].Value.ToString());

            return id;
        }

        public static bool TemLinhas(this DataGridView dataGridEmQuestao)
        {
            if (dataGridEmQuestao.Rows.Count == 0) return false;
            if (dataGridEmQuestao.Rows.Count != 0) return true;

            return false;
        }

        public static void AplicarPadroes(this Form form)
        {
            form.Icon = new System.Drawing.Icon("iconeFinal.ico");

            foreach (Control control in form.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    TextBox textBox = (control as TextBox);
                    if (textBox == null) textBox = new TextBox();
                    textBox.CharacterCasing = CharacterCasing.Upper;
                }

                if (control.GetType() == typeof(ComboBox))
                {
                    ComboBox combo = (control as ComboBox);
                    if (combo == null) combo = new ComboBox();
                    combo.DropDownStyle = ComboBoxStyle.DropDownList;
                }
            }
        }

        public static void LimparCampos(this Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    control.Text = null;
                }
                if (control.GetType() == typeof(IntegerInput))
                {
                    IntegerInput integerInput = (control as IntegerInput);
                    if (integerInput == null) integerInput = new IntegerInput();
                    integerInput.Value = 0;
                }
                if (control.GetType() == typeof(DoubleInput))
                {
                    DoubleInput integerInput = (control as DoubleInput);
                    if (integerInput == null) integerInput = new DoubleInput();
                    integerInput.Value = 0;
                }
            }
        }

        public static void LimparCampos(this UserControl userControl)
        {
            foreach (Control control in userControl.Controls)
            {
                if (control.GetType() == typeof(TextBox)) (control as TextBox).Text = string.Empty;
                if (control.GetType() == typeof(IntegerInput)) (control as IntegerInput).Value = 0;
                if (control.GetType() == typeof(DoubleInput)) (control as DoubleInput).Value = 0;
            }
        }

        public static void Adicionar(this TabControl tabControl, TabPage tabPage)
        {
            if (tabControl.TabPages.Count == 1 && tabControl.SelectedTab.Text == "Página inicial")
            {
                tabControl.TabPages.Remove(tabControl.SelectedTab);
                tabControl.TabPages.Add(tabPage);
                tabControl.SelectedTab = tabPage;
                tabPage.Show();
            }
            else
            {
                
                tabControl.TabPages.Add(tabPage);
            }

           // tabPage.BackColor = System.Drawing.Color.White;
        }

        private static void MainTabControl_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Q) && e.Modifiers == Keys.Control)
            {
                if (mainTabControl.TabPages.Count == 0) return;
                mainTabControl.TabPages.Remove(mainTabControl.SelectedTab);
            }
        }
    }
}
