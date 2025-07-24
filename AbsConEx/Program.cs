using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsConEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employ[] arrEmploy = new Employ[]
            {
                new Uday(101, "Uday", 5000),
                new Anusha(102, "Anusha", 6000),
                new Madhu(103, "Madhu", 7000)
            };
            foreach(Employ employ in arrEmploy)
            {
                Console.WriteLine( employ);
            }
        }
    }
}
