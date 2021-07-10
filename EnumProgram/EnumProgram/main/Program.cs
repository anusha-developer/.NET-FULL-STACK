using EnumProgram.Model;
using System;

namespace EnumProgram
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Enum Creation
            Colors colors = Colors.BLUE;
            Console.WriteLine(colors);

            Roles roles = Roles.Admin;
            Console.WriteLine(roles);
            //we can convert string into string
            //we can convert the object to object
            //we can can't obj to string
            if (roles.ToString()=="Admin")
                // roles is a object it can covert to string
            {
                Console.WriteLine("Welcome to  adminpage");
            }
            else
            {
                Console.WriteLine("You are navigated to Home");
            }
        }
    }
}
