using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstaractExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Training obj1 = new Baby();
           // Training obj2 = new Chinni();
            //Training obj3 = new Dee();

            int[] a = new int[] { 1, 2, 3, 4, 5 };

            Training[] arrTraining = new Training[]
            {
                new Baby(),
                new Chinni(),
                new Dee()
            };
            foreach (Training t in arrTraining)
            {
                t.Company();
                t.Email();
                t.Name();

                Console.WriteLine( "-----------------------");

            }

        }
    }
}
