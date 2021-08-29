using System;
using System.Collections.Generic;
using System.Text;

namespace task
{
    class program1
    {
        static void main(string[] args)
        {
            int i, j = 0;
            for(i = 1; i <= 5; i++)
            {
                for (j = 1; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.Write("/n");
            }
            Console.ReadLine();
        }

    }

}
