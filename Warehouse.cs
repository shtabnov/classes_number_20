using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_number_20
{
    class Warehouse
    {
        private Product[] products;
        public Warehouse(Product[] products)
        {
            this.products = products;
        }

        public void FindProductByIndex(int index)
        {
            if (index >= 0 && index < products.Length)
            {
                Console.WriteLine(products[index]);
            }
            else
            {
                Console.WriteLine("Error: Введенный индекс отсутсвует");
            }
        }
        public void FindProductByName(string name)
        {
            bool found = false;
            foreach (var product in products)
            {
                if (product.GetName == name)
                {
                    Console.WriteLine(product);
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine($"Error: Товар с именем {name} не найден");
            }
        }
        public void SortByStore()
        {
            Array.Sort(products, (x, y) => string.Compare(x.GetStore, y.GetStore));
            Console.WriteLine("Сортировака по магазинам");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
        public void SortByName()
        {
            Array.Sort(products, (x, y) => string.Compare(x.GetName, y.GetName));
            Console.WriteLine("сортировка по имени");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
        public void SortByPrice()
        {
            Array.Sort(products, (x, y) => x.GetPrice.CompareTo(y.GetPrice));
            Console.WriteLine("сортировка по цене");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }

    }
}
