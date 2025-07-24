using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstaractExample
{
    internal class Baby : Training
    {
        public override void Email()
        {
            Console.WriteLine( "Hi My Emailis baby@gmail.com");
        }

        public override void Name()
        {
            Console.WriteLine( "Hi I am Baby...");
        }
    }
}
