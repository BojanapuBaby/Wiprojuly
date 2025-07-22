using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class EmpData
    {
        static void Main()
        {
            Employ employ1 = new Employ();
            employ1.empno = 1;
            employ1.name = "Baby";
            employ1.basic = 200000;

            Employ employ2 = new Employ();
            employ2.empno = 2;
            employ2.name = "Chinni";
            employ2.basic = 300000;

            Console.WriteLine( "First Employ Data ");
            Console.WriteLine( "Employ No " +employ1.empno);
            Console.WriteLine( "Employ Name " +employ1.name );
            Console.WriteLine( "Employ Basic " +employ1.basic);

            Console.WriteLine("Second Employ Data ");
            Console.WriteLine("Employ No " + employ2.empno);
            Console.WriteLine("Employ Name " + employ2.name);
            Console.WriteLine("Employ Basic " + employ2.basic);



        }

    }
}
