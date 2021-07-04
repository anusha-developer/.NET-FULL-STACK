
using Interface.Model;
using System;

namespace Interface
{
    class Program
    {
        public  static void Displayproduct1Details()
        {
            Product1 product1 = new Product1();
            product1.ProductId = 100;
            product1.Name = "VIVO";
            product1.Quantity = "Super";
            product1.Description = "VIVOY55";
            product1.Price = 10000;
            product1.Size = 5.6f;
            product1.weight=150;

            Console.WriteLine("p1:"+product1);
        }
        public static void Displayproduct2Details()
        {
            Product2 product2 = new Product2();
            product2.ProductId = 101;
            product2.Name = "Samsung";
            product2.Quantity = "Super";
            product2.Description = "SamsungJ12";
            product2.Price = 20000;
            product2.Size = 10.6f;
            product2.weight = 350;
            product2.Importedform = "Hyderabad";

            Console.WriteLine("p2:"+product2);
        }
        static void Main(string[] args)
        {
            Program.Displayproduct1Details();
            Program.Displayproduct2Details();
            
        }
    }
}
