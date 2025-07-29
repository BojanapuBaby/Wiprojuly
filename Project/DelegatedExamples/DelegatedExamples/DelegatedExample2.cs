using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatedExamples
{
    internal class DelegatedExample2
    {
        public delegate void MyDelegate(string s);

        public static void Show(string s)
        {
            Console.WriteLine("Welcome to Delegates from " + s);
        }

        static void Main()
        {
            MyDelegate obj = new MyDelegate(Show);
            obj("Baby");
        }
    }
}
