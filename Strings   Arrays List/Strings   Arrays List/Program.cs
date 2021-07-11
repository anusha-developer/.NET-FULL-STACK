using System;

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




        }
    }
}