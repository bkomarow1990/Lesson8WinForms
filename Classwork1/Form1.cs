using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classwork1
{
    public partial class Form1 : Form
    {
        internal protected Shop shop = new Shop();
        private void FillShop()
        {
            shop.Add(new Item("Mouse","Gaming Mouse","Rambo",60.2f));
        }
        public Form1()
        {
            InitializeComponent();
            FillShop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in shop.items)
            {
                this.basketListBox.Items.Add(item);
            }
            
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddForm addform = new AddForm(this);
            addform.ShowDialog();
            if (addform.DialogResult == DialogResult.OK)
            {
                basketListBox.DataSource = shop.items;
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            EditForm editform = new EditForm(this);
            editform.ShowDialog();
        }
    }
}
