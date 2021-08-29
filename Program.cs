using System;

namespace ConsoleApp1
{
    //Program for Static variable
    /*class Program
        //Class is keyword
        //program is a className
    {
        static void Main(string[] args)
           //static is a keyword--->we don't want to create any object for static class  we can take class name as a object
          //void means empty
        {
             int Id = 101;
             string  Name = "Dotnet";
             long MobileNumber = 8298182822;
             float Weight = 15.22f;
             double Salary = 82928;
             bool Qualified = false;
             byte length = 10;

            //Console is a Class
            //WriteLine is a Method--static method
             Console.WriteLine("Id:"+Id);
             Console.WriteLine("Name:" + Name);
             Console.WriteLine("MobileNumber:" + MobileNumber);
             Console.WriteLine("Weight:" + Weight);
             Console.WriteLine("Salary:" + Salary);
             Console.WriteLine("Qualified:" + Qualified);
             Console.WriteLine("length:" + length);
            Console.ReadLine();


        }*/


    //Program for NonStatic variable
    class Program1
    {
        int Id;
        string firstName;
        long mobileNumber;

        static void Main(string[] args)
        {
            Program1 program = new Program1();
            program.Id = 100;
            program.firstName = "dotNet";
            program.mobileNumber = 90828288282;

            Console.WriteLine("Id:" + program.Id);
            Console.WriteLine("firstName:" + program.firstName);
            Console.WriteLine("mobileNumber:" + program.mobileNumber);
        }
    }
}



