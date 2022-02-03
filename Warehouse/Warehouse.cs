using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.IO;

namespace Warehouse
{
    public partial class Warehouse : Form
    {
        // Сериализатор.
        XmlSerializer formatter = new XmlSerializer(typeof(Node));
        // Узел верхнего уровня.
        Node warehouse;
        Node selectedNode;
        string xml = "";
        int endingGoodsLimit = 10;

        // Списки для сохранения данных в CSV.
        List<string> pathsToCSV = new List<string>();
        List<string> codeToCSV = new List<string>();
        List<string> nameToCSV = new List<string>();
        List<string> ammountToCSV = new List<string>();

        public Warehouse(string xml = "")
        {
            InitializeComponent();
            this.xml = xml;
        }

        private void WarehouseLoad(object sender, EventArgs e)
        {
            try
            {
                if (xml.Length == 0)
                {
                    using (FileStream fs = new FileStream("info.xml", FileMode.OpenOrCreate))
                    {
                        try
                        {
                            warehouse = (Node)formatter.Deserialize(fs);
                        }
                        catch (Exception)
                        {
                            warehouse = new Node("root");
                        }
                    }
                }
                // Запуск формы из формы.
                else
                {
                    try
                    {
                        using (TextReader reader = new StringReader(xml))
                        {
                            warehouse = (Node)formatter.Deserialize(reader);
                        }
                    }
                    catch (Exception)
                    {
                        warehouse = new Node("root");
                    }
                }
                UpdateTreeView();
            }
            catch (Exception)
            {
                var message = new Message(false, "Something went wrong!");
                message.ShowDialog();
            }
        }

        // Создание дерева узлов.
        private TreeNode MakeTree(Node root)
        {
            try
            {
                List<TreeNode> childrenNodes = new List<TreeNode>();
                List<Node> childrenNodeObjects = new List<Node>();

                root.Children.ForEach(child =>
                {
                    // Заполняю при помощи рекурсии.
                    childrenNodes.Add(
                        MakeTree(child)
                    );
                    childrenNodeObjects.Add(child);
                });

                return new TreeNode(root.Name, childrenNodes.ToArray());
            }
            catch (Exception)
            {
                warehouse = new Node("root");
                return MakeTree(warehouse);
            }
        }

        // Обновление дерерва после изменений.
        private void UpdateTreeView()
        {
            try
            {
                treeView.Nodes.Clear();
                TreeNode treeNode = MakeTree(warehouse);
                treeView.Nodes.Add(treeNode);
                treeView.ExpandAll();
            }
            catch (Exception)
            {
                var message = new Message(false, "Something went wrong!");
                message.ShowDialog();
            }
        }

        // Поиск класса узла.
        private Node FindNodesObject(TreeNode node, bool findParent = false)
        {
            List<int> indexes = new List<int>();
            while (node.Parent != null)
            {
                indexes.Add(node.Index);
                node = node.Parent;
            }
            indexes.Reverse();

            Node selectedObject = warehouse;

            if (indexes.Count == 0)
                return warehouse;

            int i = 0;
            indexes.ForEach(index =>
            {
                i++;
                if (i == indexes.Count && findParent)
                    return;
                selectedObject = selectedObject.Children[index];
            });
            return selectedObject;
        }

        // Добавление подраздела.
        private void AddSector(Node selectedObject, SectorPanel sectorEdit)
        {
            if (sectorEdit.addSectorName.Length == 0)
            {
                var message = new Message(false, "Invalid subsection name");
                message.ShowDialog();
            }
            else if (selectedObject.HasChildWithName(sectorEdit.addSectorName))
            {
                var message = new Message(false, "Subsection name is already taken");
                message.ShowDialog();
            }
            else
            {
                selectedObject.Children.Add(
                    new Node(sectorEdit.addSectorName)
                );
                UpdateTreeView();
                var message = new Message(true, "New subsection was added");
                message.ShowDialog();
            }
        }

        // Удаление подраздела.
        private void DeleteSector(Node selectedObject, TreeNodeMouseClickEventArgs e)
        {
            if (selectedObject.Children.Count > 0)
            {
                var message = new Message(false, "Section is not empty");
                message.ShowDialog();
            }
            else
            {
                var selectedsParentObject = FindNodesObject(e.Node, true);
                selectedsParentObject.Children.Remove(selectedObject);
                UpdateTreeView();
                var message = new Message(true, "Section was deleted");
                message.ShowDialog();
            }
        }

        // Удаление подраздела.
        private void AddProduct(Node selectedObject, SectorPanel sectorEdit)
        {
            int ammount, price;

            if (sectorEdit.productName.Length == 0 ||
                sectorEdit.productCode.Length == 0 ||
                sectorEdit.productInfo.Length == 0 ||
                !int.TryParse(sectorEdit.productAmmount, out ammount) ||
                !int.TryParse(sectorEdit.productPrice, out price) ||
                ammount < 0 || price < 0)
            {
                var mes = new Message(false, "Invalid parameters");
                mes.ShowDialog();
                return;
            }
            selectedObject.Products.Add(
                new Product(sectorEdit.productName, sectorEdit.productCode, price, ammount)
            );

            updateListView();

            var message = new Message(true, "Product was added");
            message.ShowDialog();
        }

        // Событие двойного клика по разделу.
        private void TreeViewNodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                var selectedObject = FindNodesObject(e.Node);

                var sectorEdit = new SectorPanel(e.Node, selectedObject);
                sectorEdit.ShowDialog();

                if (sectorEdit.command == "addSector")
                {
                    AddSector(selectedObject, sectorEdit);
                }
                else if (sectorEdit.command == "delete")
                {
                    DeleteSector(selectedObject, e);
                }
                else if (sectorEdit.command == "generate")
                {
                    GenerateRandom(selectedObject, sectorEdit.ammountOfSectionsToGenerate, sectorEdit.ammountOfProductsToGenerate);
                    UpdateTreeView();
                    var message = new Message(true, "New subsections were generated");
                    message.ShowDialog();
                }
                else if (sectorEdit.command == "renameSection")
                {
                    if (sectorEdit.renameSection.Length == 0)
                    {
                        var mes = new Message(false, "Invalid name");
                        mes.ShowDialog();
                        return;
                    }
                    selectedObject.Name = sectorEdit.renameSection;
                    UpdateTreeView();
                    var message = new Message(true, "Section was renamed");
                    message.ShowDialog();
                }
                else if (sectorEdit.command == "sortingCode")
                {
                    if (sectorEdit.sortingCode == -1)
                    {
                        var mes = new Message(false, "Invalid sorting code");
                        mes.ShowDialog();
                        return;
                    }
                    selectedObject.SortingIndex = sectorEdit.sortingCode;
                    UpdateTreeView();
                    var message = new Message(true, "Sorting code was updated");
                    message.ShowDialog();
                }
                else if (sectorEdit.command == "addProduct")
                {
                    AddProduct(selectedObject, sectorEdit);
                }
            }
            catch (Exception)
            {
                var message = new Message(false, "Something went wrong!");
                message.ShowDialog();
            }
        }

        // Добавление рандомной инфы.
        private void GenerateRandom(Node node, int sections, int products)
        {
            Random random = new Random();
            for (int i = 0; i < sections; i++)
            {
                node.Children.Add(
                    new Node($"Gen. Section {random.Next(1000, 9999)}")
                );
            }

            for (int i = 0; i < products; i++)
            {
                node.Products.Add(
                    new Product(
                        $"Gen. product {random.Next(1000, 10000)}",
                        $"Gen. Code {random.Next(10, 100)}",
                        random.Next(1000, 5000),
                        random.Next(1, 10)
                    )
                );
            }
        }

        private void TreeViewBeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Cancel = true;
        }

        // Событие выделение раздела в дереве.
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                var selectedObject = FindNodesObject(e.Node);
                listViewProducts.Items.Clear();
                selectedObject.Products.ForEach(product =>
                {
                    string[] row = { product.Name, product.VendorCode, product.Ammount.ToString(), product.Price.ToString() };
                    ListViewItem lvi = new ListViewItem(row);
                    listViewProducts.Items.Add(lvi);
                });
                selectedNode = selectedObject;


                allProducts.Items.Clear();
                FindAllProducts(selectedObject, true);
            }
            catch (Exception)
            {
                var message = new Message(false, "Something went wrong!");
                message.ShowDialog();
            }
        }

        // Поиск товаров в подразделах.
        private void FindAllProducts(Node selectedObject, bool first = false)
        {
            try
            {
                if (!first)
                {
                    selectedObject.Products.ForEach(product =>
                    {
                        string[] row = { product.Name, product.VendorCode, product.Ammount.ToString(), product.Price.ToString() };
                        ListViewItem lvi = new ListViewItem(row);
                        allProducts.Items.Add(lvi);
                    });
                }

                selectedObject.Children.ForEach(child =>
                {
                    FindAllProducts(child);
                });
            }
            catch (Exception)
            {
                var message = new Message(false, "Something went wrong!");
                message.ShowDialog();
            }
        }

        // Событие двойного нажатия на товар в списке.
        private void listViewProducts_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var productEdit = new ProductEdit(listViewProducts.SelectedItems[0].SubItems);
                var productToChange = selectedNode.Products[
                    listViewProducts.Items.IndexOf(listViewProducts.SelectedItems[0])
                ];

                productEdit.ShowDialog();

                // Если команда обновить информацию о товаре.
                if (productEdit.command == "updateParams")
                {
                    int ammount, price;
                    if (productEdit.name.Length == 0 ||
                        productEdit.code.Length == 0 ||
                        !int.TryParse(productEdit.ammount, out ammount) ||
                        !int.TryParse(productEdit.price, out price) ||
                        ammount < 0 || price < 0)
                    {
                        var mes = new Message(false, "Invalid parameters");
                        mes.ShowDialog();
                        return;
                    }
                    productToChange.Name = productEdit.name;
                    productToChange.Ammount = ammount;
                    productToChange.VendorCode = productEdit.code;
                    productToChange.Price = price;

                    updateListView();
                    var message = new Message(true, "Product has been changed");
                    message.ShowDialog();
                }
                // Если команда удалить товар.
                else if (productEdit.command == "delete")
                {
                    selectedNode.Products.Remove(productToChange);
                    updateListView();
                    var message = new Message(true, "Product has been deleted");
                    message.ShowDialog();
                }
            }
            catch (Exception)
            {
                var message = new Message(false, "Something went wrong!");
                message.ShowDialog();
            }
        }

        // Обновление списка товаров.
        private void updateListView()
        {
            listViewProducts.Items.Clear();
            selectedNode.Products.ForEach(product =>
            {
                string[] row = { product.Name, product.VendorCode, product.Ammount.ToString(), product.Price.ToString() };
                ListViewItem lvi = new ListViewItem(row);
                listViewProducts.Items.Add(lvi);
            });
        }

        // Открытие таблицы из xml документа.
        private void LoadStrip()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "";
                openFileDialog.Filter = "xml files (*.xml)|*.xml";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }

                    var form = new Warehouse(fileContent);
                    form.Show();
                }
            }
        }

        // Сохранение таблицы в xml документ.
        private void SaveStrip()
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "xml files (*.xml)|*.xml";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    myStream.Close();
                }

                using (StringWriter textWriter = new StringWriter())
                {
                    formatter.Serialize(textWriter, warehouse);
                    File.WriteAllText(saveFileDialog1.FileName, textWriter.ToString());
                }
                var message = new Message(true, "Data was successfully saved to the xml file");
                message.ShowDialog();
            }
        }

        // Изменение лимита для сохранения в csv.
        private void EndingStrip()
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 120,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Ending goods limit",
                StartPosition = FormStartPosition.CenterScreen
            };
            TextBox textBox = new TextBox() { Left = 10, Top = 20, Width = 200, Text = endingGoodsLimit.ToString() };
            Button confirmation = new Button()
            {
                Text = "Ok",
                Left = 250,
                Width = 100,
                Top = 20,
                Height = 30
                ,
                DialogResult = DialogResult.OK
            };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            if (prompt.ShowDialog() == DialogResult.OK)
            {
                int newLimit;
                if (int.TryParse(textBox.Text, out newLimit) && newLimit >= 0)
                {
                    endingGoodsLimit = newLimit;
                }
            }
        }

        // Событие клика на кнопку в меню.
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                if (e.ClickedItem.Name == "loadStrip")
                {
                    LoadStrip();
                }
                else if (e.ClickedItem.Name == "saveStrip")
                {
                    SaveStrip();
                }
                else if (e.ClickedItem.Name == "defaultSave")
                {
                    using (FileStream fs = new FileStream("info.xml", FileMode.Create))
                    {
                        formatter.Serialize(fs, warehouse);
                    }
                    var message = new Message(true, "Data was saved to the default path");
                    message.ShowDialog();
                }
                else if (e.ClickedItem.Name == "endingStrip")
                {
                    EndingStrip();
                }
                else if (e.ClickedItem.Name == "csv")
                {
                    findThemAll(warehouse, "");
                    var csv = new StringBuilder();
                    for (int i = 0; i < pathsToCSV.Count; i++)
                    {
                        csv.AppendLine(string.Format("{0},{1},{2},{3}",
                            pathsToCSV[i], codeToCSV[i], nameToCSV[i], ammountToCSV[i]));
                    }
                    File.WriteAllText("wtf.csv", csv.ToString());
                    var message = new Message(true, "Data was written to wtf.csv");
                    message.ShowDialog();
                }
            }
            catch (Exception)
            {
                var message = new Message(false, "Something went wrong!");
                message.ShowDialog();
            }
        }

        // Поиск данных для сохранения в csv.
        private void findThemAll(Node node, string path)
        {
            try
            {
                string wholePath = path + "/" + node.Name;
                node.Products.ForEach(product =>
                {
                    if (product.Ammount < endingGoodsLimit)
                    {
                        pathsToCSV.Add(wholePath);
                        codeToCSV.Add(product.VendorCode);
                        nameToCSV.Add(product.Name);
                        ammountToCSV.Add(product.Ammount.ToString());
                    }
                });

                node.Children.ForEach(child =>
                {
                    findThemAll(child, wholePath);
                });
            }
            catch (Exception)
            {
                var message = new Message(false, "Something went wrong!");
                message.ShowDialog();
            }
        }
    }
}
