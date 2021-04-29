using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lesson8WinForms
{
    public partial class ChildrenForm : Form
    {
        internal MainForm ParentForm { get; set; }
        public ChildrenForm()
        {
            InitializeComponent();
        }
        internal event Action<string> FoundWord;  
        public ChildrenForm(string title="Hello World")
        :this(){
            
            this.Text = title;
        }
        string word = "C++";
        internal void Show(string richText) {
            richTextBox1.Text = richText;
            this.Show();
        }
        private void ChildrenForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            ParentForm.infoLbl.Text = $"Form info: {richTextBox1.Text}";
            if (richTextBox1.Text.Contains(word))
            {
                FoundWord?.Invoke($"Was found word: {word}");
            }
        }
    }
}
