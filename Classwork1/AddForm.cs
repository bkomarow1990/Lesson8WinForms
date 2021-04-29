using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Classwork1
{
    public partial class AddForm : Form
    {
        Form1 parentForm = null;
        public AddForm(Form1 form1)
        {
            InitializeComponent();
            if (form1 == null)
            {
                throw new Exception("Fom is null");
            }
            parentForm = form1;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try { 
                Item tmp = new Item(this.nameTxtBox.Text, this.descTxtBox.Text, this.authorTxtBox.Text, (float)this.priceNUP.Value);
                parentForm.shop.items.Add(tmp);
                parentForm.basketListBox.Items.Add(tmp);
                MessageBox.Show("Added");
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
        }
    }
}
