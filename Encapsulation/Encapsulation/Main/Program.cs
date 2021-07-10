using Encapsulation.Model;
using System;

namespace Encapsulation
{   
    //Eccapsulation is mainly used for hiding the data
    // it contain methods & variables by using single class
    //it is used for security purpose
    //we are making feilds as a private
    // in private class we use getters & setters we can access the data
    //in setters &getters mathods we used as public method to access the data
    class Program
    {
        static void Main(string[] args)
        {
            //without mouse over we can throw an error to type the Alt&Enter
            Actor actor = new Actor();
            actor.actorId = 10;
            actor.name = "Anusha";
            actor.nooffilmsacted = 5;
            actor.experience = 3;
            actor.favoritefood = "Chicken";
            Console.WriteLine(actor);
        }
    }
}
