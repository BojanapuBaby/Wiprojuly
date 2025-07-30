using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitDemos
{
    internal class EmployDAO
    {
        static List<Employ> employList;
        static EmployDAO()
        {
            employList = new List<Employ>
            {
                new Employ { Employ = 1, Name = "Baby", Age = 23, Basic = 23456},
                new Employ { Employ = 2, Name = "Chinni", Age = 25, Basic =34567},
                new Employ { Employ = 3, Name = "Dee", Age = 22, Basic = 12345 }
            };
        }

        public static List<Employ> GetAllEmploys()
        {
            return employList;
        }

        public Employ SearchEmploy(int empno)
        {
            Employ employFound = null;
            foreach (Employ employ in employList)
            {
                if (employ.Empno == empno)
                {
                    employFound = employ;
                }
            }
            return employFound;

        }

    }
}
