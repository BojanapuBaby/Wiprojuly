using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstaractExample
{
    internal class Dee : Training
    {
        public override void Email()
        {
            Console.WriteLine( "Email is dee@gmail.com");
        }

        public override void Name()
        {
            Console.WriteLine( "Hi My Name is Dee...");
        }
    }
}
