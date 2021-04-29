using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson8WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {

            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Color[] colors = { Color.Violet, Color.Black ,Color.Red, Color.Blue, Color.Yellow, Color.Magenta, Color.Aquamarine};
            this.colorComboBox.DataSource =  colors;
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            string caption = String.IsNullOrWhiteSpace(titleTxtBox.Text) ? "Child Form" : titleTxtBox.Text; 
            ChildrenForm child = new ChildrenForm(caption);
            child.ParentForm = this;
            child.BackColor = (Color)colorComboBox.SelectedItem;
            child.FoundWord += (string s) => this.Text = $"IT HELLO FROM {child.Text} : {s}";
            child.ShowDialog(); // AS MODAL (LOCKS PARENT FORM)
            MessageBox.Show($"Result of Dialog : {child.DialogResult}");
        }

        private void showOverloadBtn_Click(object sender, EventArgs e)
        {
            ChildrenForm child = new ChildrenForm();
            
            child.BackColor = (Color)colorComboBox.SelectedItem;
            child.ParentForm = this;
            child.Show(titleTxtBox.Text);
        }

        private void titleTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void showDialogBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
