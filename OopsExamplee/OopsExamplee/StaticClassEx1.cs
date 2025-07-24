using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExamplee
{
    static class Demo
    {
        public static void Show()
        {
            Console.WriteLine("Static class Demo Class...");
        }
        public static string Trainer()
        {
            return "Trainer is Prasanna";

        }
    }

    internal class StaticClassEx1
    {
        static void Main()
        {
            Demo.Show();
            Console.WriteLine( Demo.Trainer());


        }
    }
}
