﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplications
{
    internal class MileStone2
    {
        static void Main()
        {
            string str = "Welcome to dotnet programming trainer prasanna";
            string[] names = str.Split(' ');
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
