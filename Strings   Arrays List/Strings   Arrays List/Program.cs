using System;
using System.Collections.Generic;

namespace Strings___Arrays_List
{
    class Program
    {
        //String Program
        static void Main(string[] args)
        {
            String Str = "Iam a FullStackDeveloper";
            String Str1 = "Iam a DotNet Develper";
            String str2 = "Iam a Python developer";
            string Str3 = new string("Iam a Python developer");
            Console.WriteLine(Str.Length); //to find length
            Console.WriteLine(Str.ToUpper()); //to Uppercase
            Console.WriteLine(Str.ToLower());  //to lowercase
            Console.WriteLine(Str.Trim());     //to remove the spaces
            Console.WriteLine(Str.TrimStart());
            Console.WriteLine(Str.TrimEnd());
            Console.WriteLine(Str.Substring(0,20)); //to find the count values
            Console.WriteLine(Str.StartsWith("u")); 
            Console.WriteLine(Str.StartsWith("I"));
            Console.WriteLine(Str.EndsWith("r"));
            Console.WriteLine(Str.Equals(Str1));
            Console.WriteLine(str2.Equals(Str3));
            Console.WriteLine(Str==Str1);
            Console.WriteLine(Str == Str3);
            Console.WriteLine(Str.GetHashCode());  // to find the  values
            Console.WriteLine(Str1.GetHashCode());
            Console.WriteLine(Str3.GetHashCode());
            Console.WriteLine(str2.GetHashCode());
            Console.WriteLine(str2.Split("developer"));

            Console.WriteLine(Str.Replace("FullStackDeveloper" ,"HalfStackDeveloper"));
            //Console.WriteLine(Str1.Remove("Iam a DotNet Develper"));

            /* String  S = "Anusha";
            Console.WriteLine("Length==>" +
                               "S.Length," +
                               "S.ToUpper()");*/

            //Math Properties
             Console.WriteLine(Math.Sqrt(4));//2

             Console.WriteLine(Math.Max(20,30));//30

             Console.WriteLine(Math.Min(2, 30));//2

             Console.WriteLine(Math.Round(11.876876));//12

             Console.WriteLine(Math.Floor(0.766));//0

             Console.WriteLine(Math.Floor(-0.2));//increase value  -1

             Console.WriteLine(Math.Floor(0.0)); //0

             Console.WriteLine(Math.Floor(34.67M));//constant value is 34


             //Arrays Concept

             int[] values = { 10, 20, 30, 40 };
             foreach (int i in values)
             {
                 Console.WriteLine(i+10);
             }


             String[] arr = { "Anusha", "Fruity", "Binnu" };

             Console.WriteLine(arr.Length);
             Console.WriteLine(arr[1]);
             foreach (string s in arr)

                 //string is a datatype
                 //s is variable
                 //in is a keyword
                 //arrayof string
             {
                 Console.WriteLine(s);
             }
             

            //ListProgram

            //List allows duplicate values
           List<int> age = new List<int>();
            age.Add(10);
            age.Add(20);
            age.Add(30);
            age.Add(40);
            age.Add(50);

            foreach (int i in age)
            {
                Console.WriteLine(i);
            }


       
            List<string> Names = new List<string>();
            Names.Add("Anusha");
            Names.Add("Sanvi");
            Names.Add("Sree");
            Names.Add("Binnu");
            Names.Add("Binnu"); 
            Names.Add("Binnu");
            Names.Add("varshith");

            Names.Remove("Sree");
            //Hashset doesn't allow duplicate values
           //Hashset is usedfor to delet duplicate values(multiple values)
           HashSet<string> hashNames = new HashSet<string>(Names);

            foreach (string s in hashNames)
            {
                Console.WriteLine(s);
                //Console.WriteLine(s.ToLower());
                //Console.WriteLine(s.ToUpper());
            }
     

        }
    }
}