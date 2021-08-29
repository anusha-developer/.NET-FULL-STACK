using System;

namespace Duplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int Array, temp,i,n;
            int j = 0;
            for (i = 0; i <= n - 1; i++) ;
            {
                if (Array[i] != Array[i + 1]) ;
                {
                    temp[j] = Array[n - 1];
                    j++;
                }
            }
            temp[j] = Array[n - 1];
        }

           /* int[] array = { 10, 5, 10, 2, 2, 3, 5, 5, 6, 8, 11, 12, 12 };
            int count = 1;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length - 1; j++)
                {

                    if (array[j] == array[j + 1])
                        count = count + 1;
                }
                Console.WriteLine("\n" + array[i] + "values" + count);
                Console.ReadLine();*/
            }
        }
    

