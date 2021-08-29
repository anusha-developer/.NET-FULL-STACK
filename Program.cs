using System;

namespace method_override
{
    class Program
    {
        public virtual void display()
        {
            System.Console.WriteLine(" program display");

        }
    }
    class program2:Program
    {
        public override void display()
        {
            System.Console.WriteLine("program2 display");
        }
    }

       class Demo { 
        static void Main(string[] args)
        {
            Program pgr;
            pgr = new Program();
            pgr.display();

            pgr = new program2();
            pgr.display();

            
           
    }
}
}