﻿using System;
namespace OOP1
{
    class Program
    {
        static void Main(string[] args) 
        {
           Product product1 = new Product();
            product1.Id = 1;    
            product1.ProductName = "Test";
            product1.CategoryId = 2;
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 1, ProductName = "Test2" , CategoryId=5,UnitsInStock=5,UnitPrice=35};    //Şeklinde de ifade edebiliriz.

            //Pascal Case    //Camel Case    //Case Sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            //productManager.Topla2(3, 6);
            //int toplamaSonucu = productManager.Topla(3, 6);
            //Console.WriteLine(toplamaSonucu*2);


            // int,double,bool...değer tip
            //diziler,class,abstract class, interface...referans tip
            //ref out 


        }
    }
}