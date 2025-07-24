using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class ConOver
    {
        int a, b;

        public ConOver()
        {
            a = 5;
            b = 7;
        }
        public ConOver(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void Show()
        {
            Console.WriteLine("A value is " + a + " B value is " + b);
        }
        static void Main()
        {
            ConOver obj1 = new ConOver();
            obj1.Show();
            ConOver obj2 = new ConOver(66, 12);
            obj2.Show();
        }
    }
}
