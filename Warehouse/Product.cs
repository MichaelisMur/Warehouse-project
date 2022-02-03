using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class Product
    { 
        // Параметры товара.
        string name;
        int price;
        string vendorCode;
        int ammount;

        public string Name
        {
            get => name;
            set => name = value;
        }
        public int Price
        {
            get => price;
            set => price = value;
        }
        public string VendorCode
        {
            get => vendorCode;
            set => vendorCode = value;
        }
        public int Ammount
        {
            get => ammount;
            set => ammount = value;
        }
        public Product() { }
        public Product(string name, string vendorCode, int price, int ammount)
        {
            this.name = name;
            this.vendorCode = vendorCode;
            this.price = price;
            this.ammount = ammount;
        }
    }
}
