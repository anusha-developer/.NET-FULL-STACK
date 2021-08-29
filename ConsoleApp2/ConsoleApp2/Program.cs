using System;

namespace ConsoleApp2
{
    public class user
    {
        public void add(int x, int y)
        {
            Console.WriteLine("addition of number {0} ", x + y);
        }
        public void add(int x, int y, int z)
        {
            Console.WriteLine(" addtion of number {0}", x + y + z);
        }



        class Program
        {
            static void Main(string[] args)
            {
                user s = new user();
                s.add(2, 3);
                s.add(2, 9, 8);
                Console.ReadLine();


            }
        }
    }
}
