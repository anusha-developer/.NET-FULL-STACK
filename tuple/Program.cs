using System;

namespace tuple
{
    class Program
    {
        static void Main(string[] args)
        {
           
                var person = Tuple.Create(1, "Steve", "Jobs");
                DisplayTuple(person);
            }

            static void DisplayTuple(Tuple<int, string, string> person)
            {
                Console.WriteLine($"Id = { person.Item1}");
                Console.WriteLine($"First Name = { person.Item2}");
                Console.WriteLine($"Last Name = { person.Item3}");
            }
            Console.WriteLine("Hello World!");
        }
    }
}
