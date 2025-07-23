using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// program to convert Celsius to Fahrenheit
/// </summary>
namespace DemoApplications
{
    internal class CtoF
    {
        public double ConvertToFahrenheit(double celsius)
        {
          double f = ((9 * celsius) / 5) + 32;
          return f;

        }
        static void Main()
        {
            double celsius;
            Console.WriteLine( "Enter Celsius Value ");
            celsius = Convert.ToDouble(Console.ReadLine());
            CtoF obj = new CtoF();
            Console.WriteLine( "Fahrenheit Value is " +obj.ConvertToFahrenehit(celsius));
        }
    }
}
