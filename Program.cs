﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using classes_number_20;


    class Program
    {
    static void Main(string[] args)
    {
        Product[] products = new Product[]
        {
            new Product(),
            new Product("RAM", "dns", 12),
            new Product("CPU", "oldi", 66.11),
            new Product("Video Card", "citilink", 120.5),
            new Product("HDD", "merlion", 29.99),
            new Product("SSD", "3logic", 20)
        };

        Warehouse warehouse = new Warehouse(products);

        //ищем по индексу по индексу
        warehouse.FindProductByIndex(10);
        warehouse.FindProductByIndex(0);
        //ищем по индексу по имени
        warehouse.FindProductByName("RAM");
        warehouse.FindProductByName("xdd");
        //сортировки
        warehouse.SortByStore();
        warehouse.SortByName();
        warehouse.SortByPrice();


        Console.ReadLine();
        
        }
    }

