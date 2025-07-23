using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/// <summary>
/// program to perform Calculation of 2 Numbers
/// Accept 2 Numbers
/// Write methods for business Logic
/// Call them in main method
/// </summary>
namespace DemoApplications
{ 
    #region calculation_class
    internal class Calculation
    {
        #region methods
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Mul(int a, int b)
        {
            return a * b;
        }
        #endregion methods
        #region main_method
        static void Main()
        {
            int a, b;
            Console.WriteLine( "Enter 2 Numbers ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Calculation calculation = new Calculation();
            int result = calculation.Sum(a, b);
            Console.WriteLine("Sum is " +result);
            result = calculation.Sub(a, b);
            Console.WriteLine( "Sub is " +result);
            result = calculation.Mul(a, b);
            Console.WriteLine("Mul is " + result);
        }
    }
    #endregion Main_Method
}
