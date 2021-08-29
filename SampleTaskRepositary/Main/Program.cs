using SampleTaskRepositary.Model;
using System;

namespace SampleTaskRepositary
{
    class Program
    {
        public static void displayDetails()
        {
            Circle cr = new Circle();
            cr.length = 100;
            cr.height = 100;
            cr.breadth = 500;
            cr.radius = "value";
            cr.size = "large";

            Console.WriteLine("\nLength:" + cr.length + "\nHeight:" + cr.height + "\nBreadth:" + cr.breadth +
                               "\nRadius:" + cr.radius + "\nSize:" + cr.size);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Program.displayDetails();
           
        }
    }
}
