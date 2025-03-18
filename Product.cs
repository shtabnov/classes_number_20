using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_number_20
{
    internal class Product
    {
        int index;
        string name;
        string store;
        decimal price;
        static int counter = 0;

        public Product()
        {
            index = ++counter;
            name = "no_name";
            store = "aliexpress";
            price = 000;
        }
        public Product(string name, string store, decimal price)
        {
            index = ++counter;
            this.name = name;
            this.store = store;
            this.price = price;
        }
        public static int GetCounter
        {
            get { return counter; }
        }
        public string GetName
        {
            get { return name; }
        }

        public string GetStore
        {
            get { return store; }
        }

        public decimal GetPrice
        {
            get { return price; }
        }

        public override string ToString()
        {
            return $"Индекс: {index},\nТовар: {name},\nМагазин: {store},\nЦена: {price} $.";
        }
    }  
}
