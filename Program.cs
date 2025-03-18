using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using classes_number_20;


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Всего товаров {Product.GetCounter}");
            Product mainBoard = new Product();
            Product ram = new Product("ram", "dns", 12);
            Console.WriteLine($"Всего товаров {Product.GetCounter}");
            Console.WriteLine(mainBoard);
            Console.ReadLine();
        
        }
    }

