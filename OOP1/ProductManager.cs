using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {
        public void Add(Product product) // Void komutuyla birlikte git ekle ,güncelle,sil diyoruz.
        {
            Console.WriteLine( product.ProductName + " eklendi");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi");
        }

        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;   
        //}

        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1 + sayi2);
        //}
    }
}
