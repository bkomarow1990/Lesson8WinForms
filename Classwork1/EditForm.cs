using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Classwork1
{
    public partial class EditForm : Form
    {
        Item item;
        Form1 parentForm = null;
        public EditForm(Form1 form)
        {
            InitializeComponent();
            if (form == null)
            {
                throw new Exception("Form is null");
            }
            if (form.basketListBox.SelectedItem == null)
            {
                MessageBox.Show("Select Item");
                this.DialogResult = DialogResult.Cancel;
                this.Hide();
                return;
            }
            this.parentForm = form;
            item = parentForm.basketListBox.SelectedItem as Item;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Item tmp = new Item(this.nameTxtBox.Text, this.descTxtBox.Text, this.authorTxtBox.Text, (float)this.priceNUP.Value);
                parentForm.shop.items[parentForm.shop.items.IndexOf(item)] = tmp;
                parentForm.basketListBox.Items.Clear();
                parentForm.basketListBox.Items.AddRange((parentForm.shop.items).ToArray());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

            this.nameTxtBox.Text = item.Name;
            this.descTxtBox.Text = item.Description;
            this.authorTxtBox.Text = item.Author;
            this.priceNUP.Value = (decimal)item.Price;
        }
    }
}
