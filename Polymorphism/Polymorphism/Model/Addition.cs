using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Model
{
    class Addition
    {
        //Method OverLoading
       
       
         public int Add( int Number1, int Number2)
        {
            Console.WriteLine(Number1+Number2);
            return Number1 + Number2;
        }
        public int Add(int Number1, int Number2, int Number3)
        {
            Console.WriteLine(Number1+Number2+Number3);
            return Number1 + Number2 + Number3;
        }
        public int Add(int Number1,float Number2)
        {
            Console.WriteLine((int)((float)(Number1 + Number2)));
            //Type is Conerting only int to int
           //Type is Converting only string to string
           //it can't convert int to string
           //in this below we can type caste the float and after that it can convert to int
            return (int)((float)(Number1 + Number2));//Explit Typecasting
        }
    }

}
