using EmployProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployProject.Daoo
{
    public class EmployDaoImpl : IEmployDao
    {
        static List<Employ> employList;
        static EmployDaoImpl()
        {
            employList = new List<Employ>();

        }

        public string AddEmployDao(Employ employ)
        {
            throw new NotImplementedException();
        }

        public string AddEmployDaoo(Employ employ)
        {
            employList.Add(employ);
            return "Employ Record Inserted...";
        }

        public Employ SearchEmploy(int empno)
        {
            Employ employFound = null;
            foreach (Employ employ in employList)
            {
                if (employ.Empno == empno)
                {
                    employFound = employ;
                    break;
                }
            }
            return employFound;
        }

        public Employ SearchEmployDao(int empno)
        {
            throw new NotImplementedException();
        }

        public List<Employ> ShowEmployDao()
        {
            return employList;

        }

        public List<Employ> ShowEmployDaoo()
        {
            throw new NotImplementedException();
        }
    }
}
