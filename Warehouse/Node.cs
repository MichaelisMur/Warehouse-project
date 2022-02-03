using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    // Класс узла в XML (раздел).
    [Serializable]
    public class Node
    {
        string name;
        // Подразделы.
        List<Node> children = new List<Node>();
        // Товары в разделе.
        List<Product> products = new List<Product>();
        // Индекс для сортировки товаров.
        int sortingIndex;

        public string Name
        {
            get => name;
            set => name = value;
        }
        public List<Node> Children
        {
            get
            {
                // Сортирую товары при помощи индекса сортировки.
                children.Sort((x, y) => {
                    if(x.SortingIndex > y.SortingIndex)
                        return -1;
                    else if(x.SortingIndex < y.SortingIndex)
                        return 1;

                    return x.Name.CompareTo(y.Name);
                });
                return children;
            }
            set => children = value;
        }
        public List<Product> Products
        {
            get => products;
            set => products = value;
        }
        public int SortingIndex
        {
            get => sortingIndex;
            set => sortingIndex = value;
        }

        // Пустой конструктор для сериализации.
        public Node(){ }

        public Node(string name, List<Node> children = null)
        {
            this.name = name;
            this.sortingIndex = 0;
            this.children = children == null ? new List<Node>() : new List<Node>(children);
        }

        // Поиск подраздела по названию.
        public bool HasChildWithName(string childName)
        {
            bool found = false;
            children.ForEach(child =>
            {
                if (child.Name == childName)
                    found = true;
            });
            return found;
        }
    }
}
