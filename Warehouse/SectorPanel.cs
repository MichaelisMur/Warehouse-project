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
    // Форма для редактирования информации о разделе.
    public partial class SectorPanel : Form
    {
        // Поля для управления разделом.
        public string command;
        public string addSectorName;
        public string renameSection;
        public int ammountOfSectionsToGenerate = 0;
        public int ammountOfProductsToGenerate = 0;
        public int sortingCode = 0;

        public string productName;
        public string productAmmount;
        public string productPrice;
        public string productCode;
        public string productInfo;
        public SectorPanel(TreeNode node, Node sectionObject)
        {
            InitializeComponent();
            CenterToScreen();
            renameSectionBox.Text = node.Text;
            sortingCode = sectionObject.SortingIndex;

            comboBoxSubsections.Items.AddRange(new object[] { 0, 1, 2, 3, 4, 5 });
            comboBoxSubsections.SelectedIndex = 0;
            comboBoxProducts.Items.AddRange(new object[] { 0, 1, 2, 3, 4, 5 });
            comboBoxProducts.SelectedIndex = 0;
            sortingCodeBox.Text = sortingCode.ToString();
        }

        // Далее идут обработчики событий в форме.
        private void AddSector_Click(object sender, EventArgs e)
        {
            addSectorName = addSectorText.Text;
            command = "addSector";
            Close();
        }

        private void deleteSection_Click(object sender, EventArgs e)
        {
            command = "delete";
            Close();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            ammountOfSectionsToGenerate = (int)comboBoxSubsections.SelectedItem;
            ammountOfProductsToGenerate = (int)comboBoxProducts.SelectedItem;
            command = "generate";
            Close();
        }

        private void renameSection_Click(object sender, EventArgs e)
        {
            renameSection = renameSectionBox.Text;
            command = "renameSection";
            Close();
        }

        private void sortingCodeButton_Click(object sender, EventArgs e)
        {
            int code;
            if(int.TryParse(sortingCodeBox.Text, out code) && code >= 0)
                sortingCode = code;
            else
                sortingCode = -1;
            command = "sortingCode";
            Close();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            productName = productNameText.Text;
            productAmmount = productAmmountText.Text;
            productPrice = productPriceText.Text;
            productCode = productCodeText.Text;
            productInfo = productInfoText.Text;
            command = "addProduct";
            Close();
        }
    }
}
