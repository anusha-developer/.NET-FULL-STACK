using SampleRepositary.Model;
using System;

namespace SampleRepositary
{
    class Program
    {
        public static void displaydetails()
        {
            Employee emp = new Employee();
            emp.Id = 101;
            emp.Name = "Anusha";
            emp.MobileNumber = 93838383822;
            emp.salary = 38000;
            emp.EmployeeId = 233;
            emp.Address = "Knr";

            Console.WriteLine("\nId:" + emp.Id + "\nName:" + emp.Name + "\nMobileNumber:" + emp.MobileNumber +
                               "\nSalary:" + emp.salary + "\nEmployeeId:" + emp.EmployeeId + "\nAddress:" + emp.Address );
        }
        static void Main(string[] args)
        {
            Program.displaydetails();
           

        }
        
    }
}
