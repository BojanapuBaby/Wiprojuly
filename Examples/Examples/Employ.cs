using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    public class Employ
    {
        public int? LeaveDays { get; set; }
        public int Empno { get; set; }
        public string Name { get; set; }
        public double Basic { get; set; }

        public Nullable<int> Status { get; set; }

        public override string ToString()
        {
            return "Employ No " + Empno + " Name " + Name + " Basic  " + Basic;
        }
    }
}
