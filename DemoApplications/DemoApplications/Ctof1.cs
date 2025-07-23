using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Program to Convert Celsius into Fahrenheit
/// </summary>
namespace DemoApplications
{
    internal class Ctof1
    {
        public double ConvertToFahrenehit(double celcius)
            {
            double f = ((9 * celcius) / 5) + 32;
            return f;    
        }
        static void Main()
        {
            double celsius;
            Console.WriteLine( "Enter Celsius Value ");
            celsius = Convert.ToDouble(Console.ReadLine());
            Ctof1 obj = new Ctof1();
            Console.WriteLine( "Fahrenheit Value is " +obj.ConvertToFahrenehit(celsius));
        }

    }
}
