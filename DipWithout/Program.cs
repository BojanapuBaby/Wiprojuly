using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipWithout
{
    public class Program
    {
        static void Main(string[] args)
        {
            JavaTrainingInfo javaTrainingInfo = new JavaTrainingInfo(new JavaTrg());
            DotnetTrgInfo dotnetTrainingInfo = new DotnetTrgInfo(new DotnetTrg());

            javaTrainingInfo.Details();
            dotnetTrainingInfo.Details();
        }
    }
}
