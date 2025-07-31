using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LspWith
{
    internal class Details
    {
        public virtual void ShowInfo()
        {
            // Optionally provide a base implementation
        }
    }
    internal class Mounika : Details
    {
        public override void ShowInfo()
        {
            Console.WriteLine("Hi I am Mounika...");
        }
    }
}
