using InterfaceConcept.Repositary;
using System;

namespace InterfaceConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //cw Tab(double) to print Console.writeline()
            StudentRepositaryImplementation studentRepositary = new StudentRepositaryImplementation();
            Console.WriteLine(studentRepositary.addstudent());
            Console.WriteLine(studentRepositary.deletestudent());
            Console.WriteLine(studentRepositary.getAllStudents());
            Console.WriteLine(studentRepositary.getStudentById());
            Console.WriteLine(studentRepositary.updateStudent());
           
            /*studentRepositary.addstudent();
            studentRepositary.deletestudent();
            studentRepositary.getAllStudents();
            studentRepositary.getStudentById();
            studentRepositary.updateStudent();*/
        }
    }
}
