using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatedExamples
{
    internal class DelegatedAnonymous7
    {
        public delegate void MyDelegate(string str);
        static void Main()
        {
            MyDelegate obj = delegate (string str)
            {
                Console.WriteLine("This is Anonymous Method  " + str);
            };

            obj("Baby");
        }
    }
}
