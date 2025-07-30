using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitDemos
{
    public class Demo
    {
        public int Max3(int a, int b, int c)
        {
            int m = a;
            if (m < b)
            {
                m = b;
            }
            if (m < c)
            {
                m = c;
            }
            return m;
        }
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public string SayHello()
        {
            return "Welcome to C# FSD Programming...";
        }

        public object Max3(int v1, int v2, int v3)
        {
            throw new NotImplementedException();
        }
    }
}
