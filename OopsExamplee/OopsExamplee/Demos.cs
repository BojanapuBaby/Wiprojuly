using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExamplee
{
    internal class Demos
    {
       static int count;
        public void Increment()
        {
            count++;
        }
    public void Show()
    {
        Console.WriteLine( "Count " +count);

    }
    static void Main()
        {
            Demos obj1 = new Demos();
            Demos obj2 = new Demos();
            Demos obj3 = new Demos();
            obj1.Increment();
            obj1.Show();
            obj2.Increment();
            obj2.Show();
        }


    }
}
