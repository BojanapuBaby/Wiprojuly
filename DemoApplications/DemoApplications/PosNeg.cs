using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

///  <summary>
///  Program to check if a number is positive or negative
///  </summary>
namespace DemoApplications
{
    internal class PosNeg
    {
        public void Check(int n)
        {
            if (n >= 0)
            {
                Console.WriteLine("Positive Number...");
            }
            else
            {
                Console.WriteLine("Negative Number...");
            }

        }
        static void Main()
        {
            int n;
            Console.WriteLine("Enter a Number: ");
            n = Convert.ToInt32(Console.ReadLine());
            PosNeg obj = new PosNeg();
            obj.Check(n);
        }
    }
}
