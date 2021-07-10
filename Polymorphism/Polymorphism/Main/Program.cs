using Polymorphism.Model;
using System;

namespace Polymorphism
{   
    //Poly means Many morphism means forms
    // many methods with different functionality
    //we acheieve  polymorphim overloading
    //RunTime(Overriding)Dynamic
    //Compiletim(Overloading)Static
    class Program
    {
        //Method OverLoading
        //same methods with different parametrs
        //without distrabing the exitsting we  can  implement the new functionality
        //it is a compile time polymorphism
        static void Main(string[] args)
        {
            Addition addi = new Addition();
            addi.Add(10, 20);
            addi.Add(10, 20, 30);
            addi.Add(10, 20.5f);

            Child child = new Child();
            child.add();
            child.Substract();
        }
    }
}
