using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_number_20
{
    class Product
    {
        int index;
        string name;
        string store;
        decimal price;

        private static int counter = 0;

        public Product(string name, string storeName, decimal price)
        {
            index = ++counter;
            this.name = name;
            this.store = storeName;
            this.price = price;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string StoreName
        {
            get { return store; }
            set { store = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
    }  
}
