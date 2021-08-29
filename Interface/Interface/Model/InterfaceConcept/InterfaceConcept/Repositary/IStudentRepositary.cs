using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceConcept.Interface
{
    public  interface IStudentRepositary
    {
        public string addstudent();

        public string getAllStudents();

        public string deletestudent();

        public string getStudentById();

        public string updateStudent();
    }
}
