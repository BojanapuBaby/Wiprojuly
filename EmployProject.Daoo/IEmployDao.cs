using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployProject.Models;

namespace EmployProject.Daoo
{
    internal interface IEmployDao
    { 
        string AddEmployDaoo(Employ employ);
       List<Employ> ShowEmployDaoo();
        Employ SearchEmploy(int empno);


    }
}
