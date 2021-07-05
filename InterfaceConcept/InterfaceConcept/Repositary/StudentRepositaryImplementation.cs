using InterfaceConcept.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceConcept.Repositary
{
    class StudentRepositaryImplementation : IStudentRepositary
    {
        public string addstudent()
        {
            return "Student Added Success";
        }

        public string deletestudent()
        {
            return " Student  details deleted ";
        }

        public string getAllStudents()
        {
            return " Retrived all the details";
        }

        public string getStudentById()
        {
            return "retrived all the details";
        }

        public string updateStudent()
        {
            return "Updated Student details";
        }
    }
}
