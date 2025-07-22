using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class StrMethods
    {
        static void Main()
        {
            string str = "Welcome toDotnet programming...From Wipro ";
            Console.WriteLine("Length of the string: " + str.Length);
            Console.WriteLine("Uppercase: " + str.ToUpper());
            Console.WriteLine("Lower casestring " +str.ToLower() );
            Console.WriteLine("First Occurrence of Char 'o' " +str.IndexOf("o"));
            Console.WriteLine("Replaced string " +str.Replace("Dotnet","Dotnet core"));
            string s1 = "Baby", s2 = "Chinni", s3 = "Deekshi";
            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine(s1.Equals(s3));
            Console.WriteLine(s1.CompareTo(s2));
            Console.WriteLine(s2.CompareTo(s1));
            Console.WriteLine(s1.CompareTo(s3));
        }
    }
}
