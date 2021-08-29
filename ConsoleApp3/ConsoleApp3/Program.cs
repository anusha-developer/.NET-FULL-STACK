using System;
using System.Collections;
using static ConsoleApp3.partial;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee1Repositary ep;
            Employee1Repositary ep = new Employee1Repositary();

        }
    }
}
        /*  string str, revstring ="";
          Console.WriteLine("enter string : ");
          str = Console.ReadLine();
          str = str.ToUpper();
          for(int i=str.Length-1;i>=0;i--)
          {
              revstring = revstring + str[i];

          }
          Console.WriteLine("Reverse string is :{0}", revstring);

          Console.ReadLine();*/


        /* string name = "ANUSHA";
         char[] ch = name.ToCharArray();
         Array.Reverse(ch);
         Console.WriteLine(ch);
         Console.ReadLine();*/



        /* int num = 1234;
         int rem, revno = 0;

         while (num > 0)
         {
             rem = num % 10;
             num = num / 10;
             revno = (revno * 10) + rem;

         }
         Console.WriteLine("Reverse number is :{0}", revno);*/











      /*  int num;
            bool isprime = true;

            Console.WriteLine("enter a number:");
            num = int.Parse(Console.ReadLine());
            //int s = num / 2;
            for (int i = 2; i <= num/2; i++)
            {
                if (num % i == 0)
                {
                    isprime = false;
                    Console.WriteLine("not prime");
                    break;
                }
            }
            if (isprime)
                Console.WriteLine("prime no");
            Console.ReadLine();







          
                 
            




         
        }
    }
}
*/