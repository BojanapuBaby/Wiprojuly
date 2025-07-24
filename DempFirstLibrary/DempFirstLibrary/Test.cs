using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DempFirstLibrary
{
    internal class Test
    {
        public void Display()
        {
            Demp demp = new Demp();
            Console.WriteLine( demp.PublicStr);
            Console.WriteLine( demp.InternalStr);
            Console.WriteLine( demp);.ipStr);
        }
    }
}
