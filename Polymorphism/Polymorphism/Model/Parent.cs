using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Model
{
    //Method Overriding
    //returntype parameter are same but functionality different
    //if we take two classe like parent and child it automaticllay excute the child class only
    // y because same method name ,same returntypes, in both the classes 
    class Parent
    {
        public void add()
        {
            Console.WriteLine("Am a parent");
        }
        public void Substract()
        {
            Console.WriteLine(" parent");
        }
    }
}
