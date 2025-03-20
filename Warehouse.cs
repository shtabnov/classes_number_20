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

        public void DisplayProductByIndex(int index)
        {
            if (index >= 0 && index < products.Length)
            {
                products[index].ToString();
            }
            else
            {
                Console.WriteLine("Error: Введенный индекс отсутсвует");
            }
        }

    }
}
