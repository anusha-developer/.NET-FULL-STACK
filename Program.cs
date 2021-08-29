using System;

namespace task
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string a = "skilliceberg";
            string b = "berg";
            int count = 1;
            for (int i = 1; i < a.Length; i++)
            {
                for (int j = 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine(a[i] + "==" + count);
                count = 0;

            }
            Console.ReadLine();

        }
    }
   

   
}