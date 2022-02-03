using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    // Форма для редактирования товара.
    public partial class ProductEdit : Form
    {
        public string name;
        public string code;
        public string ammount;
        public string price;
        public string command;

        public ProductEdit(ListViewItem.ListViewSubItemCollection info)
        {
            InitializeComponent();
            nameProductBox.Text = info[0].Text;
            codeProductBox.Text = info[1].Text;
            ammountProductBox.Text = info[2].Text;
            priceProductBox.Text = info[3].Text;
        }

        private void saveProductChanges_Click(object sender, EventArgs e)
        {
            name = nameProductBox.Text;
            code = codeProductBox.Text;
            ammount = ammountProductBox.Text;
            price = priceProductBox.Text;
            command = "updateParams";
            Close();
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            command = "delete";
            Close();
        }
    }
}
